#include <Arduino_FreeRTOS.h>
#include <semphr.h>

//Variabile globale
int scaune[8];
int pozitieInserare;
bool clientOk = true;
bool tunde = true;
unsigned long timpClient = 0;

//Definitiile 3 celor funtii ce vor fi executate
void TaskClienti( void *pvParameters );
void TaskBarber( void *pvParameters );
void TaskCoada( void *pvParameters);

SemaphoreHandle_t MutexBarber;
SemaphoreHandle_t MutexClient;

void setup() {
  Serial.begin(9600); // Este initializata comunicatia seriala
    //LED Barbier
    pinMode(2, OUTPUT);
    //Leduri locuri in coada
    pinMode(3, OUTPUT);
    pinMode(4, OUTPUT);
    pinMode(5, OUTPUT);
    pinMode(6, OUTPUT);
    pinMode(7, OUTPUT);
    pinMode(8, OUTPUT);
    pinMode(9, OUTPUT);
    pinMode(10, OUTPUT);
    //Led intrare libera in coada
    pinMode(11, OUTPUT);
    //Led coada este plina
    pinMode(12, OUTPUT);
    
  //Initializare coada
  for(int i = 0; i < 8; i++) {
    scaune[i] = 0;
  }

  //Initializare mutexuri
  MutexBarber = xSemaphoreCreateMutex();
  MutexClient = xSemaphoreCreateMutex();

  // Sunt create cele 3 taskuri, fiecare cu 128 de cuvinte de memorie rezervate si prioritate egala cu 1
  xTaskCreate(TaskBarber, "TaskBarber", 128, NULL, 1, NULL);
  xTaskCreate(TaskClienti, "TaskClienti", 128, NULL, 1, NULL);
  xTaskCreate(TaskCoada, "TaskCoada", 128, NULL, 1, NULL);
  vTaskStartScheduler(); // Este pornit algoritmul de planificare
}

void loop() {}

void TaskBarber(void *pvParameters) {
  while(1) {
    if(scaune[0] and xSemaphoreTake(MutexBarber, portMAX_DELAY) == pdTRUE) {
      //Extragere din coada
      for(int i = 0; i < 7; i++) {
        scaune[i] = scaune[i + 1];
      }
      scaune[7] = 0;
      vTaskDelay(200 / portTICK_PERIOD_MS);
      digitalWrite(2, HIGH);
      Serial.println("Barbierul tunde o persoana.");
      //Barbierul tunde 2.5 secunde
      vTaskDelay(2500 / portTICK_PERIOD_MS);
      digitalWrite(2, LOW);
      Serial.println("Barbierul a tuns o persoana.");
      xSemaphoreGive(MutexBarber);
    }
    else if(!scaune[0]){
      //Oprire task
      if(!tunde) {
        Serial.println("Salonul s-a inchis, o zi buna!");
        vTaskDelete(NULL);
      }
      Serial.println("Nu e nimeni in coada!");
      vTaskDelay(500 / portTICK_PERIOD_MS);
    }
  }
}

void TaskCoada(void *pvParameters) {
  while(1) {
    //Calculare pozitie inserare
    int i;
    for(i = 0; i < 8; i++) {
      if(!scaune[i]) {
         break;
      }
    }
    if(i != 8) {
      pozitieInserare = i; 
    }
    else {
      pozitieInserare = -1;
    }     

    //Setare leduri
    for(int j = 0; j < 8; j++) {
      if(scaune[j]) {
        digitalWrite(j + 3, HIGH);   
      }
      else {
        digitalWrite(j + 3, LOW); 
      }
    }

    //Oprite task
    if(pozitieInserare == 0 and !tunde and xSemaphoreTake(MutexBarber, portMAX_DELAY) == pdTRUE) {
      vTaskDelete(NULL);
    }
  }
}

void TaskClienti(void *pvParameters) {
  int timpRandom;
  unsigned long timpClienti;
  while(1) {
    vTaskDelay(200 / portTICK_PERIOD_MS);
    //Calculare timp ramas pentru a mai primii clienti
    timpClienti = millis();
    if(timpClienti >= 60000) {
      tunde = false;
      Serial.println("Salonul se inchide, nu mai primim clienti!");
      vTaskDelete(NULL);
    }

    //Alegere aleatoare intre 2 clienti in intervalul 0.75 si 2.5 secunde 
    if(clientOk) {
      clientOk = false;
      timpRandom = random(750, 2500);
    }
    
    unsigned long timp = millis();
    if(timp - timpClient >= timpRandom) {
      //Mesaj pentru ca nu se poate adauga in coada un client
      if(pozitieInserare == -1) {
        Serial.println("Coada este plina!");
        digitalWrite(11, HIGH);
        vTaskDelay(1000 / portTICK_PERIOD_MS);
        digitalWrite(11, LOW);
        timpClient = timp;
        clientOk = true;
      }
      else if(pozitieInserare != -1 and xSemaphoreTake(MutexClient, portMAX_DELAY) == pdTRUE){
        //Ocupare scaun un salon de catre client, 1 secunda
        digitalWrite(12, HIGH);
        vTaskDelay(1000 / portTICK_PERIOD_MS);
        digitalWrite(12, LOW);
        scaune[pozitieInserare] = 1;
        Serial.println("A intrat o noua persoana!");
        timpClient = timp;
        clientOk = true;
        xSemaphoreGive(MutexClient);
      }
    }
  }
}
