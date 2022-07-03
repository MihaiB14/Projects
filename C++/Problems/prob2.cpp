#include <iostream>

int main() {
    char word[] = "keti";
    int length = sizeof(word)/sizeof(char) - 1;

    for(int i = 0; i < length/2; i++) {
        word[i] = word[i] ^ word[length - i - 1];
        word[length - i - 1] = word[i] ^ word[length - i - 1];
        word[i] = word[i] ^ word[length - i - 1];
    }

    std::cout << word << std::endl;
    return 0;
}