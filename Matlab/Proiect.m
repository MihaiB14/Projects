%   File Proiect.m
%
%   Uses: war_err.m, PS_Prj_2_Faza_1ab.mlx, PS_Prj_2_Faza_1c.mlx, PS_Prj_2_Faza_1d.mlx
%
%   Author: Mihai Bălan
%   Created: January 3, 2022
%   Updated: January 12, 2022
%
clc;
clear;
close all;
load('date.mat');
%% Faza 1a si b
%     %[omega_p,omega_s,M] = PS_Prj_2_Faza_1ab(5,1) ;
%     % Matricea 3x7 pentru omega_p si omega_s date
%     A = [1 1 0 0];   
%     W = [0 omega_p/pi omega_s/pi 1];
%     figure(1);
%     for i = 1:7
%         h_ls = firls(M(i) - 1, W, A);
%         h_pm = firpm(M(i) - 1, W, A);
%         [H_ls, omega] = freqz(h_ls, 1, 1500);
%         [H_pm, omega] = freqz(h_pm, 1, 1500);
%         % Grafic coordonate liniare
%         subplot(3, 7, i);
%             plot(omega, abs(H_ls));
%             title("Spectrul filtrului în coord. liniare");
%             xlabel("Intervalul [0, \pi]");
%             ylabel("Amplitudine");
%             a = axis;
%             hold on;
%                plot(omega, abs(H_pm));
%                omg_p = plot([omega_p, omega_p], [a(3), a(4)]);
%                omg_s = plot([omega_s, omega_s], [a(3), a(4)]); 
%             hold off;
%             legend('firls', 'firpm', '\omega_p', '\omega_s');
%         % Grafic in dB  
%         subplot(3, 7, i + 7);
%             plot(omega, db(abs(H_ls)));
%             title(sprintf('Spectrul filtrului în dB M = %d', M(i)));
%             xlabel("Intervalul [0, \pi]");
%             ylabel("Amplitudine");
%             a = axis;
%             hold on;
%                 plot(omega, db(abs(H_pm)));
%                 omg_p = plot([omega_p, omega_p], [a(3), a(4)]);
%                 omg_s = plot([omega_s, omega_s], [a(3), a(4)]);  
%             hold off;
%             legend('firls', 'firpm', '\omega_p', '\omega_s');
%         % Faza
%         subplot(3, 7, i + 14);
%             plot(omega, unwrap(angle(H_ls)));
%             hold on;
%                 plot(omega, unwrap(angle(H_pm)));
%             hold off;
%             title("Faza");
%             xlabel("Intervalul [0, \pi]");
%             ylabel("Amplitudine");
%             legend('firls', 'firpm');
%     end
%     
%     % Matricea 3x7 pentru pi-omega_p si pi-omega_s
%     Wc = [0 (pi-omega_s)/pi (pi-omega_p)/pi 1];
%     figure(2);
%     for i = 1:7
%         h_ls = firls(M(i) - 1, Wc, A);
%         h_pm = firpm(M(i) - 1, Wc, A);
%         [H_ls, omega] = freqz(h_ls, 1, 1500);
%         [H_pm, omega] = freqz(h_pm, 1, 1500);
%         % Grafic coordonate liniare
%         subplot(3, 7, i);
%             plot(omega, abs(H_ls));
%             title("Spectrul filtrului în coord. liniare");
%             xlabel("Intervalul [0, \pi]");
%             ylabel("Amplitudine");
%             a = axis;
%             hold on;
%                 plot(omega, abs(H_pm));
%                 omg_p = plot([pi - omega_p, pi - omega_p], [a(3), a(4)]);
%                 omg_s = plot([pi - omega_s, pi - omega_s], [a(3), a(4)]);
%             hold off;
%             legend('firls', 'firpm', '\pi - \omega_p', '\pi - \omega_s');
%         % Grafic in dB  
%         subplot(3, 7, i + 7);
%             plot(omega, db(abs(H_ls)));
%             title(sprintf('Spectrul filtrului în dB M = %d', M(i)));
%             xlabel("Intervalul [0, \pi]");
%             ylabel("Amplitudine");
%             a = axis;
%             hold on;
%                 plot(omega, db(abs(H_pm)));
%                 omg_p = plot([pi - omega_p, pi - omega_p], [a(3), a(4)]);
%                 omg_s = plot([pi - omega_s, pi - omega_s], [a(3), a(4)]);
%             hold off;
%             legend('firls', 'firpm', '\pi - \omega_p', '\pi - \omega_s');
%         % Faza
%         subplot(3, 7, i + 14);
%             plot(omega, unwrap(angle(H_ls)));
%             hold on;
%                 plot(omega, unwrap(angle(H_pm)));
%             hold off;
%             title("Faza");
%             xlabel("Intervalul [0, \pi]");
%             ylabel("Amplitudine");
%             legend('firls', 'firpm');
%     end
%     
%     % Matricea 7x2 pentru functiile pondere calculate anterior
%     figure(3);
%     for i = 1:7
%         h_ls = firls(M(i) - 1, W, A);
%         h_ls_c = firls(M(i) - 1, Wc, A);
%         h_pm = firpm(M(i) - 1, W, A);
%         h_pm_c = firpm(M(i) - 1, Wc, A);
%         % Grafice omega_p si omega_s
%         subplot(7, 2, 2*i - 1);
%             stem(0:M(i) - 1, h_ls);
%             hold on;
%                 stem(0:M(i) - 1, h_pm);
%             hold off;
%             title(sprintf('Secevența pondere a filtrului de ordin %d',M(i))); 
%             xlabel('Timp normalizat');
%             ylabel('Amplitudine');
%             legend('LS', 'PM');
%         % Grafice pi - omega_p si pi - omega_s
%         subplot(7, 2, 2*i);
%             stem(0:M(i) - 1, h_ls_c);
%             hold on;
%                 stem(0:M(i) - 1, h_pm_c);
%             hold off;
%             title(sprintf('Secevența pondere a filtrului de ordin %d',M(i))); 
%             xlabel('Timp normalizat');
%             ylabel('Amplitudine');
%             legend('LS', 'PM');
%     end

%% Faza 1c
%     Mc = PS_Prj_2_Faza_1c(5,1) ; 
%     W = [0 omega_p/pi omega_s/pi 1];
%     Wc = [0 (pi - omega_s)/pi (pi - omega_p)/pi 1];
%      A = [1 1 0 0];
% %--------------------------------Pentru perechea omega_p si omega_s-----------------------------%
%     h_ls_p = firls(Mc - 1, Wc, A);  
%     h_ls = firls(Mc - 1, W, A);
%     h_pm = firpm(Mc - 1, W, A);
%     
%     [H_ls, omega_ls] = freqz(h_ls, 1, 1500);
%     [H_pm, omega_pm] = freqz(h_pm, 1, 1500);
%     % Grafice pentru cele 2 metode
%     figure(4);
%     subplot(3,2,1);
%         plot(omega_ls, abs(H_ls));
%         hold on;
%             plot(omega_pm, abs(H_pm));
%             title(sprintf("Spectrul filtrului în coord. liniare M = %d", Mc));
%             xlabel("Intervalul [0, \pi]");
%             ylabel("Amplitudine");
%             a = axis;
%             o_p = plot([omega_p omega_p], [a(3) a(4)]);
%             o_s = plot([omega_s omega_s], [a(3) a(4)]);
%         hold off;
%         legend('LS', 'PM', '\omega_p', '\omega_s');
%     subplot(3,2,3);
%         plot(omega_ls, db(abs(H_ls)));
%         hold on;
%             plot(omega_pm, db(abs(H_pm)));
%             xlabel("Intervalul [0, \pi]");
%             ylabel("Amplitudine");
%             a = axis;
%             o_p = plot([omega_p omega_p], [a(3) a(4)]);
%             o_s = plot([omega_s omega_s], [a(3) a(4)]);
%        hold off;  
%        legend('LS', 'PM', '\omega_p', '\omega_s');
%     subplot(3,2,5);
%         plot(omega_ls, unwrap(angle(H_ls)));
%         hold on;
%         plot(omega_pm, unwrap(angle(H_pm)));
%         hold off;
%         title("Faza");
%         xlabel("Intervalul [0, \pi]");
%         ylabel("Amplitudine");
%         legend('LS', 'PM');
%         
%     % Masti logice pentru fiecare filtru 
%     stop_band_ls = (omega_ls >= omega_s); 
%     stop_band_pm = (omega_pm >= omega_s); 
%     % Extragerea H doar pe banda de stop
%     H_stop_ls = H_ls(stop_band_ls);
%     H_stop_pm = H_pm(stop_band_pm);
%     % Extragere pulsatii doar din banda de stop
%     omega_stop_ls = omega_ls(stop_band_ls);
%     omega_stop_pm = omega_pm(stop_band_pm);
%     % Aflarea atenuarii minime pentru fiecare filtru
%     [H_min_ls, poz_ls] = max(db(abs(H_stop_ls)));
%     [H_min_pm, poz_pm] = max(db(abs(H_stop_pm)));
%     % Pulsatiile corespunzatoare
%     omega_min_ls = omega_stop_ls(poz_ls); % 0.5739 ~= omega_s (0.5724)
%     omega_min_pm = omega_stop_pm(poz_pm); % 0.8566 :(
%     
%     subplot(3,2,3);
%         title(sprintf('Spectrul filtrului în dB,    ALS = %f,    APM = %f', omega_min_ls, omega_min_pm));
%     
% %----------------------------Pentru perechea pi - omega_p si pi - omega_s-------------------------%
%     h_ls_p = firls(Mc - 1, Wc, A);
%     h_pm_p = firpm(Mc - 1, Wc, A);
%     
%     [H_ls_p, omega_ls_p] = freqz(h_ls_p, 1, 1500);
%     [H_pm_p, omega_pm_p] = freqz(h_pm_p, 1, 1500);
%     % Grafice pentru cele 2 metode
%     subplot(3,2,2);
%         plot(omega_ls_p, abs(H_ls_p));
%         hold on;
%             plot(omega_pm, abs(H_pm_p));
%             title(sprintf("Spectrul filtrului în coord. liniare M = %d", Mc));
%             xlabel("Intervalul [0, \pi]");
%             ylabel("Amplitudine");
%             a = axis;
%             o_p = plot([pi - omega_p pi - omega_p], [a(3) a(4)]);
%             o_s = plot([pi - omega_s pi - omega_s], [a(3) a(4)]);
%         hold off;
%         legend('LS', 'PM', '\pi - \omega_p', '\pi - \omega_s');
%     subplot(3,2,4);
%         plot(omega_ls_p, db(abs(H_ls_p)));
%         hold on;
%             plot(omega_pm, db(abs(H_pm_p)));
%             xlabel("Intervalul [0, \pi]");
%             ylabel("Amplitudine");
%             a = axis;
%             o_p = plot([pi - omega_p pi - omega_p], [a(3) a(4)]);
%             o_s = plot([pi - omega_s pi - omega_s], [a(3) a(4)]);
%        hold off;  
%        legend('LS', 'PM', '\pi - \omega_p', '\pi - \omega_s');
%     subplot(3,2,6);
%         plot(omega_ls_p, unwrap(angle(H_ls_p)));
%         hold on;
%         plot(omega_pm_p, unwrap(angle(H_pm_p)));
%         hold off;
%         title("Faza");
%         xlabel("Intervalul [0, \pi]");
%         ylabel("Amplitudine");
%         legend('LS', 'PM');
%         
%     % Masti logice pentru fiecare filtru 
%     stop_band_ls_p = (omega_ls_p >= pi - omega_p); 
%     stop_band_pm_p = (omega_pm_p >= pi - omega_p); 
%     % Extragerea H doar pe banda de stop
%     H_stop_ls_p = H_ls_p(stop_band_ls_p);
%     H_stop_pm_p = H_pm_p(stop_band_pm_p);
%     % Extragere pulsatii doar din banda de stop
%     omega_stop_ls_p = omega_ls_p(stop_band_ls_p);
%     omega_stop_pm_p = omega_pm_p(stop_band_pm_p);
%     % Aflarea atenuarii minime pentru fiecare filtru
%     [H_min_ls_p, poz_ls_p] = max(db(abs(H_stop_ls_p)));
%     [H_min_pm_p, poz_pm_p] = max(db(abs(H_stop_pm_p)));
%     % Pulsatiile corespunzatoare
%     omega_min_ls_p = omega_stop_ls_p(poz_ls_p); % 3.1018 ~= pi - omega_p (3.0998)
%     omega_min_pm_p = omega_stop_pm_p(poz_pm_p); % 3.1395 :(
%     
%     subplot(3,2,4);
%         title(sprintf('Spectrul filtrului în dB,    ALS = %f,    APM = %f', omega_min_ls_p, omega_min_pm_p));
%         
% %% Faza 1d
%     ws = PS_Prj_2_Faza_1d(5,1) ; 
%     w = [1 ws];
%     Mc = PS_Prj_2_Faza_1c(5,1) ;
%     W = [0 omega_p/pi omega_s/pi 1];
%     Wc = [0 (pi - omega_s)/pi (pi - omega_p)/pi 1];
%     A = [1 1 0 0];
%     j = sqrt(-1);
%     
%     % Filtre pentru perechea omega_p si omega_s prin cele 2 metode (LS si PM)
%     h_ls = firls(Mc - 1, W, A);
%     h_pm = firpm(Mc - 1, W, A);
%     [H_ls, omega_ls] = freqz(h_ls, 1, 1500);
%     [H_pm, omega_pm] = freqz(h_pm, 1, 1500);
%     
%     % Filtre pentru perechea pi - omega_p si pi - omega_s prin cele 2 metode (LS si PM)
%     h_ls_p = firls(Mc - 1, Wc, A);
%     h_pm_p = firpm(Mc - 1, Wc, A);
%     [H_ls_p, omega_ls_p] = freqz(h_ls_p, 1, 1500);
%     [H_pm_p, omega_pm_p] = freqz(h_pm_p, 1, 1500);
%     
%     % Filtre pentru perechea omega_p si omega_s cu ponderi prin cele 2 metode (LS si PM)
%     h_ls_pon = firls(Mc - 1, W, A, w);
%     h_pm_pon = firpm(Mc - 1, W, A, w);
%     [H_ls_pon, omega_ls_pon] = freqz(h_ls_pon, 1, 1500);
%     [H_pm_pon, omega_pm_pon] = freqz(h_pm_pon, 1, 1500);
%     
%     % Filtre pentru perechea pi - omega_p si pi - omega_s cu ponderi prin cele 2 metode (LS si PM)
%     h_ls_pon_p = firls(Mc - 1, Wc, A, w);
%     h_pm_pon_p = firpm(Mc - 1, Wc, A, w);
%     [H_ls_pon_p, omega_ls_pon_p] = freqz(h_ls_pon_p, 1, 1500);
%     [H_pm_pon_p, omega_pm_pon_p] = freqz(h_pm_pon_p, 1, 1500);
%     
%     % Calculul erorii in banda de trecere si banda de stopare
%     % e^(-j*omega*M/2) - H(e^(j*omega)), omega este in intervalul [0, omega_p]
%     % -H(e^(j*omega)), omega este in intervalul [omega_s, pi]
%     %---------------------------------------------------------------------%
%     % Pentru perechea omega_p si omega_s prin LS 
%         pass_band_ls = (omega_ls <= omega_p);
%         omega_pass_ls = omega_ls(pass_band_ls);
%         exp_ls = exp(-j*omega_pass_ls*Mc/2);
%         H_pass_ls = H_ls(pass_band_ls);
%         error_pass_ls = exp_ls - H_pass_ls;
%         
%         stop_band_ls = (omega_ls >= omega_s);
%         error_stop_ls = - H_ls(stop_band_ls);
%         
%         RLS = var(error_stop_ls)/var(error_pass_ls);
%         
%     % Pentru perechea omega_p si omega_s cu ponderi prin LS 
%         pass_band_ls_pon = (omega_ls_pon <= omega_p);
%         omega_pass_ls_pon = omega_ls_pon(pass_band_ls_pon);
%         exp_ls_pon = exp(-j*omega_pass_ls_pon*Mc/2);
%         H_pass_ls_pon = H_ls_pon(pass_band_ls_pon);
%         error_pass_ls_pon = exp_ls_pon - H_pass_ls_pon;
%         
%         stop_band_ls_pon = (omega_ls_pon >= omega_s);
%         error_stop_ls_pon = - H_ls_pon(stop_band_ls_pon);
%         
%         RLS_pon = var(error_stop_ls_pon)/var(error_pass_ls_pon);
%         
%     % Pentru perechea omega_p si omega_s prin PM 
%         pass_band_pm = (omega_pm <= omega_p);
%         omega_pass_pm = omega_pm(pass_band_pm);
%         exp_pm = exp(-j*omega_pass_pm*Mc/2);
%         H_pass_pm = H_pm(pass_band_pm);
%         error_pass_pm = exp_pm - H_pass_pm;
%         
%         stop_band_pm = (omega_pm >= omega_s);
%         error_stop_pm = - H_pm(stop_band_pm);
%         
%         RPM = var(error_stop_pm)/var(error_pass_pm);
%     
%     % Pentru perechea omega_p si omega_s cu ponderi prin PM 
%         pass_band_pm_pon = (omega_pm_pon <= omega_p);
%         omega_pass_pm_pon = omega_pm_pon(pass_band_pm_pon);
%         exp_pm_pon = exp(-j*omega_pass_pm_pon*Mc/2);
%         H_pass_pm_pon = H_pm_pon(pass_band_pm_pon);
%         error_pass_pm_pon = exp_pm_pon - H_pass_pm_pon;
%         
%         stop_band_pm_pon = (omega_pm_pon >= omega_s);
%         error_stop_pm_pon = - H_pm_pon(stop_band_pm_pon);
%         
%         RPM_pon = var(error_stop_pm_pon)/var(error_pass_pm_pon);
%     
%     %-----------------------------------pi--------------------------------%
%     % Pentru perechea pi - omega_p si pi - omega_s prin LS
%         pass_band_ls_p = (omega_ls_p <= pi - omega_s);
%         omega_pass_ls_p = omega_ls_p(pass_band_ls_p);
%         exp_ls_p = exp(-j*omega_pass_ls_p*Mc/2);
%         H_pass_ls_p = H_ls_p(pass_band_ls_p);
%         error_pass_ls_p = exp_ls_p - H_pass_ls_p;
%         
%         stop_band_ls_p = (omega_ls_p >= pi - omega_p);
%         error_stop_ls_p = - H_ls_p(stop_band_ls_p);
%         
%         RLS_p = var(error_stop_ls_p)/var(error_pass_ls_p);
%         
%     % Pentru perechea pi - omega_p si pi - omega_s cu poneri prin LS
%         pass_band_ls_pon_p = (omega_ls_pon_p <= pi - omega_s);
%         omega_pass_ls_pon_p = omega_ls_pon_p(pass_band_ls_pon_p);
%         exp_ls_pon_p = exp(-j*omega_pass_ls_pon_p*Mc/2);
%         H_pass_ls_pon_p = H_ls_pon_p(pass_band_ls_pon_p);
%         error_pass_ls_pon_p = exp_ls_pon_p - H_pass_ls_pon_p;
%         
%         stop_band_ls_pon_p = (omega_ls_pon_p >= pi - omega_p);
%         error_stop_ls_pon_p = - H_ls_pon_p(stop_band_ls_pon_p);
%         
%         RLS_pon_p = var(error_stop_ls_pon_p)/var(error_pass_ls_pon_p);
%         
%     % Pentru perechea pi - omega_p si pi - omega_s prin PM
%         pass_band_pm_p = (omega_pm_p <= pi - omega_s);
%         omega_pass_pm_p = omega_pm_p(pass_band_pm_p);
%         exp_pm_p = exp(-j*omega_pass_pm_p*Mc/2);
%         H_pass_pm_p = H_pm_p(pass_band_pm_p);
%         error_pass_pm_p = exp_pm_p - H_pass_pm_p;
%         
%         stop_band_pm_p = (omega_pm_p >= pi - omega_p);
%         error_stop_pm_p = - H_pm_p(stop_band_pm_p);
%         
%         RPM_p = var(error_stop_pm_p)/var(error_pass_pm_p);
%         
%     % Pentru perechea pi - omega_p si pi - omega_s cu ponderi prin PM
%         pass_band_pm_pon_p = (omega_pm_pon_p <= pi - omega_s);
%         omega_pass_pm_pon_p = omega_pm_pon_p(pass_band_pm_pon_p);
%         exp_pm_pon_p = exp(-j*omega_pass_pm_pon_p*Mc/2);
%         H_pass_pm_pon_p = H_pm_pon_p(pass_band_pm_pon_p);
%         error_pass_pm_pon_p = exp_pm_pon_p - H_pass_pm_pon_p;
%         
%         stop_band_pm_pon_p = (omega_pm_pon_p >= pi - omega_p);
%         error_stop_pm_pon_p = - H_pm_pon_p(stop_band_pm_pon_p);
%         
%         RPM_pon_p = var(error_stop_pm_pon_p)/var(error_pass_pm_pon_p);
%      
%     % Grafice
%     figure(5);
%     %---------------------------------------------------------------------%
%     subplot(4,2,1);
%         plot(omega_ls, abs(H_ls));
%         title(sprintf('Perechea w_p si w_s fara ponderi RLS = %f    RPM = %f', RLS, RPM));
%         xlabel('[0, \pi]');
%         ylabel('Amplitudinea');
%         hold on;
%             plot(omega_pm, abs(H_pm));
%             a = axis;
%             o_p = plot([omega_p omega_p], [a(3), a(4)]);
%             o_s = plot([omega_s omega_s], [a(3), a(4)]);
%         hold off;
%         legend('LS', 'PM', '\omega_p', '\omega_s');
%         
%     subplot(4,2,3);
%         plot(omega_ls, db(abs(H_ls)));
%         title('Perechea w_p si w_s in dB');
%         xlabel('[0, \pi]');
%         ylabel('Amplitudinea');
%         hold on;
%             plot(omega_pm, db(abs(H_pm)));
%             a = axis;
%             o_p = plot([omega_p omega_p], [a(3), a(4)]);
%             o_s = plot([omega_s omega_s], [a(3), a(4)]);
%         hold off;
%         legend('LS', 'PM', '\omega_p', '\omega_s');
%         
%     subplot(4,2,5);
%         plot(omega_ls_pon, abs(H_ls_pon));
%         title(sprintf('Perechea w_p si w_s cu ponderi  RLS = %f    RPM = %f', RLS_pon, RPM_pon));
%         xlabel('[0, \pi]');
%         ylabel('Amplitudinea');
%         hold on;
%             plot(omega_pm_pon, abs(H_pm_pon));
%             a = axis;
%             o_p = plot([omega_p omega_p], [a(3), a(4)]);
%             o_s = plot([omega_s omega_s], [a(3), a(4)]);
%         hold off;
%         legend('LS', 'PM', '\omega_p', '\omega_s');
%         
%     subplot(4,2,7);
%         plot(omega_ls_pon, db(abs(H_ls_pon)));
%         title('Perechea w_p si w_s cu ponderi in dB');
%         xlabel('[0, \pi]');
%         ylabel('Amplitudinea');
%         hold on;
%             plot(omega_pm_pon, db(abs(H_pm_pon)));
%             a = axis;
%             o_p = plot([omega_p omega_p], [a(3), a(4)]);
%             o_s = plot([omega_s omega_s], [a(3), a(4)]);
%         hold off;
%         legend('LS', 'PM', '\omega_p', '\omega_s');
%     %---------------------------------pi----------------------------------%
%     subplot(4,2,2);
%         plot(omega_ls_p, abs(H_ls_p));
%         title(sprintf('Perechea π - w_p si π - w_s fara ponderi RLS = %f    RPM = %f', RLS_p, RPM_p));
%         xlabel('[0, \pi]');
%         ylabel('Amplitudinea');
%         hold on;
%             plot(omega_pm_p, abs(H_pm_p));
%             a = axis;
%             o_p = plot([pi - omega_p pi - omega_p], [a(3), a(4)]);
%             o_s = plot([pi - omega_s pi - omega_s], [a(3), a(4)]);
%         hold off;
%         legend('LS', 'PM', '\pi - \omega_p', '\pi - \omega_s');
%         
%     subplot(4,2,4);
%         plot(omega_ls_p, db(abs(H_ls_p)));
%         title('Perechea π - w_p si π - w_s in dB');
%         xlabel('[0, \pi]');
%         ylabel('Amplitudinea');
%         hold on;
%             plot(omega_pm_p, db(abs(H_pm_p)));
%             a = axis;
%             o_p = plot([pi - omega_p pi - omega_p], [a(3), a(4)]);
%             o_s = plot([pi - omega_s pi - omega_s], [a(3), a(4)]);
%         hold off;
%         legend('LS', 'PM', '\pi - \omega_p', '\pi - \omega_s');
%      
%     subplot(4,2,6);
%         plot(omega_ls_pon_p, abs(H_ls_pon_p));
%         title(sprintf('Perechea π - w_p si π - w_s cu ponderi     RLS = %f    RPM = %f', RLS_pon_p, RPM_pon_p));
%         xlabel('[0, \pi]');
%         ylabel('Amplitudinea');
%         hold on;
%             plot(omega_pm_pon_p, abs(H_pm_pon_p));
%             a = axis;
%             o_p = plot([pi - omega_p pi - omega_p], [a(3), a(4)]);
%             o_s = plot([pi - omega_s pi - omega_s], [a(3), a(4)]);
%         hold off;
%         legend('LS', 'PM', '\pi - \omega_p', '\pi - \omega_s');
%         
%     subplot(4,2,8);
%         plot(omega_ls_p, db(abs(H_ls_pon_p)));
%         title('Perechea π - w_p si π - w_s cu ponderi in dB');
%         xlabel('[0, \pi]');
%         ylabel('Amplitudinea');
%         hold on;
%             plot(omega_pm_p, db(abs(H_pm_pon_p)));
%             a = axis;
%             o_p = plot([pi - omega_p pi - omega_p], [a(3), a(4)]);
%             o_s = plot([pi - omega_s pi - omega_s], [a(3), a(4)]);
%         hold off;
%         legend('LS', 'PM', '\pi - \omega_p', '\pi - \omega_s');  

%% Faza 1 e
%--------------------------------Metoda 1---------------------------------%
%     % Filtru trece sus
%     
%     Me = 20;
%     Ws = [0 omega_p/pi omega_s/pi 1];
%     Ws_p = [0 (pi - omega_s)/pi (pi - omega_p)/pi 1];
%     As = [0 0 1 1];
%     
%     % Filtre
%     hs_ls = firls(Me, Ws, As);
%     hs_pm = firpm(Me, Ws, As);
%     hs_ls_p = firls(Me, Ws_p, As);
%     hs_pm_p = firpm(Me, Ws_p, As);
%     
%     % Raspuns in frecventa
%     [Hs_ls, omega_ls] = freqz(hs_ls, 1, 1500);
%     [Hs_pm, omega_pm] = freqz(hs_pm, 1, 1500);
%     [Hs_ls_p, omega_ls_p] = freqz(hs_ls_p, 1, 1500);
%     [Hs_pm_p, omega_pm_p] = freqz(hs_pm_p, 1, 1500);
%     % Grafice
%     figure(6);
%     subplot(4,2,1);
%         plot(omega_ls, abs(Hs_ls));
%         hold on;    
%             plot(omega_pm, abs(Hs_pm));
%             title('Filtru trece sus in coordonate liniare');
%             xlabel('[0 \pi]');
%             ylabel('Amplitudine');
%             a = axis;
%             % Axe omega
%                 plot([omega_s, omega_s], [a(3) a(4)]);
%                 plot([omega_p, omega_p], [a(3) a(4)]);
%         hold off;
%         legend('LS', 'PM', '\omega_p', '\omega_s');
%         
%     subplot(4,2,3);
%         plot(omega_ls, db(abs(Hs_ls)));
%         hold on;    
%         plot(omega_pm, db(abs(Hs_pm)));
%         title('Filtru trece sus in dB');
%         xlabel('[0 \pi]');
%         ylabel('Amplitudine');
%         a = axis;
%         % Axe omega
%             plot([omega_s, omega_s], [a(3) a(4)]);
%             plot([omega_p, omega_p], [a(3) a(4)]);
%         hold off;
%         legend('LS', 'PM', '\omega_p', '\omega_s');
%         
%      subplot(4,2,5);
%         plot(omega_ls, unwrap(angle(Hs_ls)));
%         hold on;
%             plot(omega_pm, unwrap(angle(Hs_pm)));
%         hold off;
%         title("Faza");
%         xlabel("Intervalul [0, \pi]");
%         ylabel("Amplitudine");
%         legend('LS', 'PM'); 
% 
%     subplot(4,2,7);
%        stem(0:Me, hs_ls);
%         hold on;
%             stem(0:Me, hs_pm);
%         hold off;
%         title(sprintf('Secevența pondere a filtrului trece sus de ordin %d',Me)); 
%         xlabel('Timp normalizat');
%         ylabel('Amplitudine');
%         legend('LS', 'PM'); 
%         
%     subplot(4,2,2);
%         plot(omega_ls_p, abs(Hs_ls_p));
%         hold on;    
%             plot(omega_pm_p, abs(Hs_pm_p));
%             title('Filtru trece sus in coordonate liniare');
%             xlabel('[0 \pi]');
%             ylabel('Amplitudine');
%             a = axis;
%             % Axe omega
%                 plot([pi - omega_s, pi - omega_s], [a(3) a(4)]);
%                 plot([pi - omega_p, pi - omega_p], [a(3) a(4)]);
%         hold off;
%         legend('LS', 'PM', '\pi - \omega_p', '\pi - \omega_s');
%         
%     subplot(4,2,4);
%         plot(omega_ls_p, db(abs(Hs_ls_p)));
%         hold on;    
%         plot(omega_pm_p, db(abs(Hs_pm_p)));
%         title('Filtru trece sus in dB');
%         xlabel('[0 \pi]');
%         ylabel('Amplitudine');
%         a = axis;
%         % Axe omega
%             plot([pi - omega_s, pi - omega_s], [a(3) a(4)]);
%             plot([pi - omega_p, pi - omega_p], [a(3) a(4)]);
%         hold off;
%         legend('LS', 'PM', '\pi - \omega_p', '\pi - \omega_s');
%         
%      subplot(4,2,6);
%         plot(omega_ls_p, unwrap(angle(Hs_ls_p)));
%         hold on;
%             plot(omega_pm_p, unwrap(angle(Hs_pm_p)));
%         hold off;
%         title("Faza");
%         xlabel("Intervalul [0, \pi]");
%         ylabel("Amplitudine");
%         legend('LS', 'PM'); 
% 
%     subplot(4,2,8);
%        stem(0:Me, hs_ls_p);
%         hold on;
%             stem(0:Me, hs_pm_p);
%         hold off;
%         title(sprintf('Secevența pondere a filtrului trece sus de ordin %d',Me)); 
%         xlabel('Timp normalizat');
%         ylabel('Amplitudine');
%         legend('LS', 'PM'); 
%     
%    % Filtru trece banda
% 
%     omega_s1 = omega_p;
%     omega_p1 = omega_s;
%     omega_p2 = pi - omega_s;
%     omega_s2 = pi - omega_p;
%     Wb = [0 omega_s1/pi omega_p1/pi omega_p2/pi omega_s2/pi 1];
%     Ab = [0 0 1 1 0 0];
%     
%     % Filtre
%     hb_ls = firls(Me, Wb, Ab);
%     hb_pm = firpm(Me, Wb, Ab);
% 
%     % Raspuns in frecventa
%     [Hb_ls, omega_b_ls] = freqz(hb_ls, 1, 1500);
%     [Hb_pm, omega_b_pm] = freqz(hb_pm, 1, 1500);
%     % Grafice
%     figure(7);
%     subplot(4,1,1);
%         plot(omega_b_ls, abs(Hb_ls));
%         hold on;    
%             plot(omega_b_pm, abs(Hb_pm));
%             title('Filtru trece banda in coordonate liniare');
%             xlabel('[0 \pi]');
%             ylabel('Amplitudine');
%             a = axis;
%             % Axe omega
%                 plot([omega_s1, omega_s1], [a(3) a(4)]);
%                 plot([omega_p1, omega_p1], [a(3) a(4)]);
%                 plot([omega_p2, omega_p2], [a(3) a(4)]);
%                 plot([omega_s2, omega_s2], [a(3) a(4)]);
%         hold off;
%         legend('LS', 'PM', '\omega_s1', '\omega_p1', '\omega_p2', '\omega_s2');
%         
%     subplot(4,1,2);
%         plot(omega_b_ls, db(abs(Hb_ls)));
%         hold on;    
%             plot(omega_b_pm, db(abs(Hb_pm)));
%             title('Filtru trece banda in dB');
%             xlabel('[0 \pi]');
%             ylabel('Amplitudine');
%             a = axis;
%             % Axe omega
%                 plot([omega_s1, omega_s1], [a(3) a(4)]);
%                 plot([omega_p1, omega_p1], [a(3) a(4)]);
%                 plot([omega_p2, omega_p2], [a(3) a(4)]);
%                 plot([omega_s2, omega_s2], [a(3) a(4)]);
%         hold off;
%         legend('LS', 'PM', '\omega_s1', '\omega_p1', '\omega_p2', '\omega_s2');
%         
%     subplot(4,1,3);
%         plot(omega_b_ls, unwrap(angle(Hb_ls)));
%             hold on;
%                 plot(omega_b_pm, unwrap(angle(Hb_pm)));
%             hold off;
%             title("Faza");
%             xlabel("Intervalul [0, \pi]");
%             ylabel("Amplitudine");
%     
%     subplot(4,1,4);
%        stem(0:Me, abs(hb_ls));
%             hold on;
%                 stem(0:Me, abs(hb_pm));
%             hold off;
%             title(sprintf('Secevența pondere a filtrului trece banda de ordin %d',Me)); 
%             xlabel('Timp normalizat');
%             ylabel('Amplitudine');
%             legend('LS', 'PM'); 
% %    
% % %-------------------------------Metoda 2----------------------------------%
%     
%     % Filtru trece tot
% 
%     ftt_ls = firls(Me, [0 1], [1 1]);
%     ftt_pm = firpm(Me, [0 1], [1 1]);
%     
%     [FTT_ls, omega_ls] = freqz(ftt_ls, 1, 1500);
%     [FTT_pm, omega_pm] = freqz(ftt_pm, 1, 1500);
%     
%     figure(8);
%     subplot(3,2,1);
%         plot(omega_ls, abs(FTT_ls));
%         hold on;
%             plot(omega_pm, abs(FTT_pm));
%         hold off;
%         title('Filtru trece tot in coordonate liniare 0 si \pi');
%         xlabel('[0 \pi]');
%         ylabel('Amplitudine');
%         legend('LS','PM');
%     
%     subplot(3,2,2);
%         plot(omega_ls, abs(FTT_ls));
%         hold on;
%             plot(omega_pm, abs(FTT_pm));
%         hold off;
%         title('Filtru trece tot in coordonate liniare 0 si \pi');
%         xlabel('[0 \pi]');
%         ylabel('Amplitudine');
%         legend('LS','PM'); 
%         
%    % Filtru trece jos w_p si w_s
%     
%     W = [0 omega_p/pi omega_s/pi 1];
%     A = [1 1 0 0];
%     
%     hj_ls = firls(Me, W, A); 
%     hj_pm = firpm(Me, W, A);
%    
%     [Hj_ls, o_ls] = freqz(hj_ls, 1, 1500);
%     [Hj_pm, o_pm] = freqz(hj_pm, 1, 1500);
%     
%     subplot(3,2,3);
%         plot(o_ls, abs(Hj_ls));
%         hold on;
%             plot(o_pm, abs(Hj_pm));
%             a = axis;
%             o_p = plot([omega_p omega_p], [a(3) a(4)]);
%             o_s = plot([omega_s omega_s], [a(3) a(4)]);
%         hold off;
%         title(sprintf('Filtru trece jos in coordonate liniare w_p si w_s M = %d', Me));
%         xlabel('[0 \pi]');
%         ylabel('Amplitudine');
%         legend('LS','PM', '\omega_p', '\omega_s');
%     
%     % Filtru trece jos cu pulsatiile opuse
%    
%     Wp = [0 (pi - omega_s)/pi (pi - omega_p)/pi 1];
%     A = [1 1 0 0];
%     
%     hj_ls_p = firls(Me, Wp, A); 
%     hj_pm_p = firpm(Me, Wp, A);
%     
%     [Hj_ls_p, o_ls_p] = freqz(hj_ls_p, 1, 1500);
%     [Hj_pm_p, o_pm_p] = freqz(hj_pm_p, 1, 1500);
%     
%     subplot(3,2,4);
%         plot(o_ls_p, abs(Hj_ls_p));
%         hold on;
%             plot(o_pm_p, abs(Hj_pm_p));
%             a = axis;
%             o_p = plot([pi - omega_p pi - omega_p], [a(3) a(4)]);
%             o_s = plot([pi - omega_s pi - omega_s], [a(3) a(4)]);
%         hold off;
%         title(sprintf('Filtru trece jos in coordonate liniare π - w_p si π - w_s  M = %d', Me));
%         xlabel('[0 \pi]');
%         ylabel('Amplitudine');
%         legend('LS','PM', '\pi - \omega_p', '\pi - \omega_s');
%  
%     % Filtre trece sus w_p si w_s
%     h_s_ls = ftt_ls - hj_ls;
%     h_s_pm = ftt_pm - hj_pm;
%     H_s_ls = FTT_ls - Hj_ls;
%     H_s_pm = FTT_pm - Hj_pm;
%     
%     subplot(3,2,5);
%         plot(omega_ls, abs(H_s_ls));
%         hold on;
%             plot(omega_pm, abs(H_s_pm));
%             a = axis;
%             o_p = plot([omega_p omega_p], [a(3) a(4)]);
%             o_s = plot([omega_s omega_s], [a(3) a(4)]);
%         hold off;
%         title('Filtru trece sus obtinut in coordonate liniare');
%         xlabel('[0 \pi]');
%         ylabel('Amplitudine');
%         legend('LS','PM', '\omega_p', '\omega_s');
%         
%     % Filtre trece sus pi - w_p si pi - w_s
%     h_s_ls_p = ftt_ls - hj_ls_p;
%     h_s_pm_p = ftt_pm - hj_pm_p;
%     H_s_ls_p = FTT_ls - Hj_ls_p;
%     H_s_pm_p = FTT_pm - Hj_pm_p;
%     
%     subplot(3,2,6);
%         plot(omega_ls, abs(H_s_ls_p));
%         hold on;
%             plot(omega_pm, abs(H_s_pm_p));
%             o_p = plot([pi - omega_p pi - omega_p], [a(3) a(4)]);
%             o_s = plot([pi - omega_s pi - omega_s], [a(3) a(4)]);
%         hold off;
%         title('Filtru trece sus obtinut in coordonate liniare');
%         xlabel('[0 \pi]');
%         ylabel('Amplitudine');
%         legend('LS','PM', '\pi - \omega_p', '\pi - \omega_s'); 
%         
%     % Filtru trece banda
%     figure(9);
%     h_b_ls = hj_ls_p - hj_ls;
%     h_b_pm = hj_pm_p - hj_pm;
%     H_b_ls = Hj_ls_p - Hj_ls;
%     H_b_pm = Hj_pm_p - Hj_pm;
%    
%     subplot(3,1,1);
%         plot(o_ls_p, abs(Hj_ls_p));
%             hold on;
%                 plot(o_pm_p, abs(Hj_pm_p));
%                 a = axis;
%                 o_p = plot([pi - omega_p pi - omega_p], [a(3) a(4)]);
%                 o_s = plot([pi - omega_s pi - omega_s], [a(3) a(4)]);
%             hold off;
%             title(sprintf('Filtru trece jos in coordonate liniare π - w_p si π - w_s  M = %d', Me));
%             xlabel('[0 \pi]');
%             ylabel('Amplitudine');
%             legend('LS','PM', '\pi - \omega_p', '\pi - \omega_s');
%             
%     subplot(3,1,2);
%         plot(o_ls, abs(Hj_ls));
%             hold on;
%                 plot(o_pm, abs(Hj_pm));
%                 a = axis;
%                 o_p = plot([omega_p omega_p], [a(3) a(4)]);
%                 o_s = plot([omega_s omega_s], [a(3) a(4)]);
%             hold off;
%             title('Filtru trece jos in coordonate liniare \omega_p si \omega_s');
%             xlabel('[0 \pi]');
%             ylabel('Amplitudine');
%             legend('LS','PM', '\omega_p', '\omega_s');
%             
%     subplot(3,1,3);
%         plot(o_ls_p, abs(H_b_ls));
%         hold on;
%             plot(o_pm_p, abs(H_b_pm));
%             a = axis;
%             o_s1 = plot([omega_p omega_p], [a(3) a(4)]);
%             o_p1 = plot([omega_s omega_s], [a(3) a(4)]);
%             o_p2 = plot([pi - omega_s pi - omega_s], [a(3) a(4)]);
%             o_s2 = plot([pi - omega_p pi - omega_p], [a(3) a(4)]);
%         hold off;
%         title('Filtru trece banda obtinut in coordonate liniare');
%         xlabel('[0 \pi]');
%         ylabel('Amplitudine');
%         legend('LS','PM', '\omega_p', '\omega_s', '\pi - \omega_s', '\pi - \omega_p');
%     
%     % Calculul normelor
%         norm_s_ls = norm(Hs_ls - H_s_ls);
%         norm_s_pm = norm(Hs_pm - H_s_pm);
%         norm_s_ls_pon = norm(hs_ls - h_s_ls);
%         norm_s_pm_pon = norm(hs_pm - h_s_pm);
%         
%         norm_b_ls = norm(Hb_ls - H_b_ls);
%         norm_b_pm = norm(Hb_pm - H_b_pm);
%         norm_b_ls_pon = norm(hb_ls - h_b_ls);
%         norm_b_pm_pon = norm(hb_pm - h_b_pm);
%        
%% Faza 2a
%     Ma = 20;
%     k = [5 7 10 13 15];
%     w = linspace(-pi, pi, 1500);
%     figure(9);
%     grid on;
%     for i = 1:5
%         h = firls_FTJ_c(Ma, omega_p/pi, omega_s/pi, k(i));
%         [gd, wg] = grpdelay(h, 1, 1500, 'whole');
%         [H, ~] = freqz(h, 1, w); 
%         subplot(4,5,i);
%             plot(w, abs(H));
%             a = axis;
%             hold on;
%                 o_p = plot([omega_p omega_p], [a(3) a(4)]);
%                 o_s = plot([omega_s omega_s], [a(3) a(4)]);
%             hold off;
%             title(sprintf('Carac. de frecventa a filtrului K = %d', k(i)));
%             xlabel('[-\pi \pi]');
%             ylabel('Amplitudine');
%             legend([o_p, o_s],{'\omega_p', '\omega_s'});
%             
%         subplot(4,5,5+i);
%             plot(wg/pi, gd);
%             title('Intarzierea de grup a filtrului');
%             xlabel('[-\pi \pi]');
%             ylabel('Amplitudine');  
%             
%        subplot(4,5,10+i);
%             plot(w, unwrap(angle(H)));
%             title('Faza');
%             xlabel('[-\pi \pi]');
%             ylabel('Amplitudine');
%             
%        subplot(4,5,15+i);
%             stem(0:Ma, h);
%             title('Secventa pondere a filtrului');
%             xlabel('Timp normalizat');
%             ylabel('Amplitudine');     
%     end
%     
%     figure(10);
%     for i = 1:5
%         h = firls_FTJ_c(Ma, (pi - omega_p)/pi, (pi - omega_s)/pi, k(i));
%         [gd, wg] = grpdelay(h, 1, 1500, 'whole');
%         [H, ~] = freqz(h, 1, w); 
%         subplot(4,5,i);
%             plot(w, abs(H));
%             a = axis;
%             hold on;
%                 o_p = plot([pi - omega_p pi - omega_p], [a(3) a(4)]);
%                 o_s = plot([pi - omega_s pi - omega_s], [a(3) a(4)]);
%             hold off;
%             title(sprintf('Carac. de frecventa a filtrului K = %d', k(i)));
%             xlabel('[-\pi \pi]');
%             ylabel('Amplitudine');
%             legend([o_p o_s],{'\pi - \omega_p', '\pi - \omega_s'});
%             
%         subplot(4,5,5+i);
%             plot(wg/pi, gd);
%             title('Intarzierea de grup a filtrului');
%             xlabel('[-\pi \pi]');
%             ylabel('Amplitudine');
% 
%         subplot(4,5,10+i);
%             plot(w, unwrap(angle(H)));
%             title('Faza');
%             xlabel('[-\pi \pi]');
%             ylabel('Amplitudine');
%             
%         subplot(4,5,15+i);
%             stem(0:Ma, h);
%             title('Secventa pondere a filtrului');
%             xlabel('Timp normalizat');
%             ylabel('Amplitudine');
%     end
%     grid off;

%% Faza 2b
%     figure(11);
%     for i = 1:7
%         [h, pr] = Modify_firls_FTJ_c(M(i), omega_p/pi, omega_s/pi, M(i)/2);
%         [H, w] = freqz(h, 1, 1500);
%         subplot(3,7,i);
%             plot(w, abs(H));
%             hold on;
%                 a = axis;
%                 o_p = plot([omega_p omega_p], [a(3) a(4)]);
%                 o_s = plot([omega_s omega_s], [a(3) a(4)]);
%             hold off;
%             title(sprintf('Spc FTJ în crd. ln. PR = %0.6f', abs(pr)));
%             xlabel("Intervalul [0, \pi]");
%             ylabel("Amplitudine");
%             legend([o_p, o_s],{'\omega_p', '\omega_s'});
%         subplot(3,7,7+i);
%             plot(w, unwrap(angle(H)));
%             title(sprintf("Faza M = %d", M(i)));
%             xlabel("Intervalul [0, \pi]");
%             ylabel("Radiani");
%         subplot(3,7,14+i);
%             stem(h);
%             title('Secventa pondere');
%             xlabel('Timp normalizat');
%             ylabel('Amplitudinea');
%     end
%     
%     figure(12);
%     for i = 1:7
%         [h, pr] = Modify_firls_FTJ_c(M(i), (pi - omega_s)/pi, (pi - omega_p)/pi, M(i)/2);
%         [H, w] = freqz(h, 1, 1500);
%         subplot(3,7,i);
%             plot(w, abs(H));
%             hold on;
%                 a = axis;
%                 o_p = plot([pi - omega_p pi - omega_p], [a(3) a(4)]);
%                 o_s = plot([pi - omega_s pi - omega_s], [a(3) a(4)]);
%             hold off;
%             title(sprintf('Spc FTJ în crd. ln. PR = %0.6f', abs(pr)));
%             xlabel("Intervalul [0, \pi]");
%             ylabel("Amplitudine");
%             legend([o_p, o_s],{'\pi - \omega_p', '\pi - \omega_s'});
%         subplot(3,7,7+i);
%             plot(w, unwrap(angle(H)));
%              title(sprintf("Faza M = %d", M(i)));
%             xlabel("Intervalul [0, \pi]");
%             ylabel("Radiani");
%         subplot(3,7,14+i);
%             stem(h);
%             title('Secventa pondere');
%             xlabel('Timp normalizat');
%             ylabel('Amplitudinea');
%     end
% 
%% Faza 2c
%---------------------------------Metoda 1--------------------------------%
%     % Filtru trece sus
%     Mc = PS_Prj_2_Faza_1c(5,1) ;
%     h = firls_FTS1_c(Mc, omega_p/pi, omega_s/pi, Mc/2, 1);
%     [H, w] = freqz(h, 1, 1500);
%     
%     figure(12);
%     subplot(3,2,5);
%         plot(w, abs(H));
%         title(sprintf('Filtrul trece sus obtinut de ordin %d', Mc));
%         xlabel('[0 \pi]');
%         ylabel('Amplitudine');
%         hold on;
%             a = axis;
%             o_p = plot([omega_p omega_p], [a(3), a(4)]);
%             o_s = plot([omega_s omega_s], [a(3), a(4)]);
%         hold off;
%         legend([o_p, o_s],{'\omega_s', '\omega_p'})
%    
%     h = firls_FTS1_c(Mc, (pi - omega_p)/pi, (pi - omega_s)/pi, Mc/2, 2);
%     [H, w] = freqz(h, 1, 1500);
%     
%     subplot(3,2,6);
%         plot(w, abs(H));
%         title(sprintf('Filtrul trece sus obtinut de ordin %d', Mc));
%         xlabel('[0 \pi]');
%         ylabel('Amplitudine');
%         hold on;
%             a = axis;
%             o_p = plot([pi - omega_p pi - omega_p], [a(3), a(4)]);
%             o_s = plot([pi - omega_s pi - omega_s], [a(3), a(4)]);
%         hold off;
%         legend([o_p, o_s],{'\pi - \omega_p', '\pi - \omega_s'})
%         
%     %Filtru trece banda
%     figure(13);
%     h = firls_FTB1_c(Mc, omega_s/pi, omega_p/pi, (pi - omega_s)/pi, (pi - omega_p)/pi, Mc/2);
%     [H, w] = freqz(h, 1, 1500);
%     subplot(3,1,3);
%         plot(w, abs(H));
%         title(sprintf('Filtrul trece banda obtinut de ordin %d', Mc));
%         xlabel('[0 \pi]');
%         ylabel('Amplitudine');
%         hold on;
%             a = axis;
%             o_s1 = plot([omega_p omega_p], [a(3), a(4)]);
%             o_p1 = plot([omega_s omega_s], [a(3), a(4)]);
%             o_p2 = plot([pi - omega_s pi - omega_s], [a(3), a(4)]);
%             o_s2 = plot([pi - omega_p pi - omega_p], [a(3), a(4)]);
%         hold off;
%         legend([o_s1, o_p1, o_p2, o_s2],{'\omega_s', '\omega_p', '\pi - \omega_s', '\pi - \omega_p'})
% 
% %------------------------------------Metoda 2-----------------------------%
%      %Filtru trece sus cu omega_p si omega_s
%      figure(14);
%      for i = 1:7
%          [h, pr] = firls_FTS_c(M(i), omega_s/pi, omega_p/pi, M(i)/2);
%          [H, w] = freqz(h, 1, 1500);
%          subplot(7,1,i);
%          plot(w, abs(H));
%             title(sprintf('Filtru trece sus obtinut de ordin %d si PR = %f', M(i), pr));
%             xlabel('[0 \pi]');
%             ylabel('Amplitudine');
%             hold on;
%                 a = axis;
%                 o_p = plot([omega_s omega_s], [a(3) a(4)]);
%                 o_s = plot([omega_p omega_p], [a(3) a(4)]);
%             hold off;
%             legend([o_p, o_s], {'\omega_p', '\omega_s'});
%      end
%      
%      % Filtru trece sus cu pi - omega_p si pi - omega_s
%      figure(15);
%      for i = 1:7
%          [h, pr] = firls_FTS_c(M(i), (pi - omega_s)/pi, (pi - omega_p)/pi, M(i)/2);
%          [H, w] = freqz(h, 1, 1500);
%          subplot(7,1,i);
%          plot(w, abs(H));
%             title(sprintf('Filtru trece sus obtinut de ordin %d si PR = %f', M(i), pr));
%             xlabel('[0 \pi]');
%             ylabel('Amplitudine');
%             hold on;
%                 a = axis;
%                 o_p = plot([pi - omega_s pi - omega_s], [a(3) a(4)]);
%                 o_s = plot([pi - omega_p pi - omega_p], [a(3) a(4)]);
%             hold off;
%             legend([o_s, o_p], {'\pi - \omega_p', '\pi - \omega_s'});
%      end
%       
%      % Filtru trece banda
%      figure(16);
%      for i = 1:7
%          [h, pr] = firls_FTB_c(M(i), omega_p/pi, omega_s/pi, (pi - omega_p)/pi, (pi - omega_s)/pi, M(i)/2);
%          [H, w] = freqz(h, 1, 1500);
%          subplot(7,1,i);
%          plot(w, abs(H));
%             title(sprintf('Filtru trece tot obtinut de ordin %d si PR = %f', M(i), pr));
%             xlabel('[0 \pi]');
%             ylabel('Amplitudine');
%             hold on;
%                 a = axis;
%                 o_s1 = plot([omega_p omega_p], [a(3) a(4)]);
%                 o_p1 = plot([omega_s omega_s], [a(3) a(4)]);
%                 o_p2 = plot([pi - omega_s pi - omega_s], [a(3) a(4)]);
%                 o_s2 = plot([pi - omega_p pi - omega_p], [a(3) a(4)]);
%             hold off;
%             legend([o_s1, o_p1, o_p2, o_s2], {'\omega_p', '\omega_s', '\pi - \omega_s', '\pi - \omega_p'});
%      end
%         
%% Faza 3
    N = [250 500 1000];
    % O matrice de 3x7 care contin pe linii ordinele de marime astefel:
        % 1. M/4
        % 2. M/2
        % 3. 3*M/4
    for i = 1:3
       for j = 1:7
            switch(i)
                case 1
                    K(i,j) = M(j)/4;
                case 2
                    K(i,j) = M(j)/2;
                case 3
                    K(i,j) = 3*M(j)/4;
            end
       end
    end

    % Se creaza cele 9 matrici de tip 3x7 pt ficare N si K  pt wp si ws
    for i = 1:3
        for j = 1:3
            figure();
            for x = 1:7
                h = FTS(M(x) - 1, omega_p, omega_s, K(j,x), N(i));
                [H, w] = freqz(h, 1, 1500);
                
                subplot(3,7,x);
                    plot(w, abs(H));
                    title(sprintf('FTS M = %d, K = %0.2f', M(x), K(j,x)));
                    xlabel('[0 \pi]');
                    ylabel('Amplitudine');
                    hold on;
                        a = axis;
                        w_p = plot([omega_p omega_p], [a(3) a(4)]);
                        w_s = plot([omega_s omega_s], [a(3) a(4)]);
                    hold off;
                    legend([w_p, w_s], {'\omega_p', '\omega_s'});
                    
                subplot(3,7,7+x);
                    plot(w, db(abs(H)));
                    title('FTS \omega_p si \omega_s in dB');
                    xlabel('[0 \pi]');
                    ylabel('Amplitudine');
                    hold on;
                        a = axis;
                        w_p = plot([omega_p omega_p], [a(3) a(4)]);
                        w_s = plot([omega_s omega_s], [a(3) a(4)]);
                    hold off;
                    legend([w_p, w_s], {'\omega_p', '\omega_s'});
                    
                subplot(3,7,14+x);
                    plot(w, unwrap(angle(H)));
                    title(sprintf('Faza N = %d', N(i)));
                    xlabel('[0 \pi]');
                    ylabel('Amplitudine');

            end
        end
        
    end
   
    % 9 grafice pentru functia pondere de tip 7x1 pentru wp si ws
     for i = 1:3
        for j = 1:3
            figure();
            for x = 1:7
                h = FTS(M(x) - 1, omega_p, omega_s, K(j,x), N(i));
                subplot(7,1,x);
                    stem(0:M(x) -1 , h);
                    title(sprintf('Funcția pondere pentru w_p si w_s M = %d, K = %0.2f, N = %d', M(x), K(j,x), N(i)));
                    xlabel('Timp normalizat');
                    ylabel('Amplitudine');
            end
        end
     end
  
%~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~% 
     
%     Se creaza cele 9 matrici de tip 3x7 pt ficare N si K  pt pi - wp si pi - ws
    for i = 1:3
        for j = 1:3
            figure();
            for x = 1:7
                h = FTS(M(x) - 1, (pi - omega_s), (pi - omega_p), K(j,x), N(i));
                [H, w] = freqz(h, 1, 1500);
                
                subplot(3,7,x);
                    plot(w, abs(H));
                    title(sprintf('FTS M = %d, K = %0.2f', M(x), K(j,x)));
                    xlabel('[0 \pi]');
                    ylabel('Amplitudine');
                    hold on;
                        a = axis;
                        w_p = plot([pi - omega_p pi - omega_p], [a(3) a(4)]);
                        w_s = plot([pi - omega_s pi - omega_s], [a(3) a(4)]);
                    hold off;
                    legend([w_p, w_s], {'\pi - \omega_p', '\pi - \omega_s'});
                    
                subplot(3,7,7+x);
                    plot(w, db(abs(H)));
                    title('FTS \omega_p si \omega_s in dB');
                    xlabel('[0 \pi]');
                    ylabel('Amplitudine');
                    hold on;
                        a = axis;
                        w_p = plot([pi - omega_p pi - omega_p], [a(3) a(4)]);
                        w_s = plot([pi - omega_s pi - omega_s], [a(3) a(4)]);
                    hold off;
                    legend([w_p, w_s], {'\pi - \omega_p', '\pi - \omega_s'});
                    
                subplot(3,7,14+x);
                    plot(w, unwrap(angle(H)));
                    title(sprintf('Faza N = %d', N(i)));
                    xlabel('[0 \pi]');
                    ylabel('Amplitudine');

            end
        end
        
    end
   
    % 9 grafice pentru functia pondere de tip 7x1 pentru pi - wp si pi - ws
     for i = 1:3
        for j = 1:3
            figure();
            for x = 1:7
                h = FTS(M(x) - 1, (pi - omega_s), (pi - omega_p), K(j,x), N(i));
                subplot(7,1,x);
                    stem(0:M(x) -1 , h);
                    title(sprintf('Funcția pondere pentru w_p si w_s M = %d, K = %0.2f, N = %d', M(x), K(j,x), N(i)));
                    xlabel('Timp normalizat');
                    ylabel('Amplitudine');
            end
        end
     end