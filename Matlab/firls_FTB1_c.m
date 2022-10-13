function [h, pr] = firls_FTB1_c(M, w_s1, w_p1, w_p2, w_s2, K)

     hj = firls_FTJ_c(M - 1, w_p1, w_s1, K);
     hj_p = firls_FTJ_c(M - 1, w_p2, w_s2, K);
     
     [Hj_p, w_p] = freqz(hj_p, 1, 1500);
     [Hj, w] = freqz(hj, 1, 1500);
     
     figure(13);
     subplot(3, 1, 1);
        plot(w_p, abs(Hj_p));
        title('Filtrul trece jos obtinut cu \pi - \omega_p si \pi - \omega_s');
        xlabel('[0 \pi]');
        ylabel('Amplitudine');
        hold on;
            a = axis;
            o_p = plot([w_s2*pi w_s2*pi], [a(3), a(4)]);
            o_s = plot([w_p2*pi w_p2*pi], [a(3), a(4)]);
        hold off;
        legend([o_p, o_s],{'\pi - \omega_p', '\pi - \omega_s'});
     
     subplot(3, 1, 2);
        plot(w, abs(Hj));
        title('Filtrul trece jos obtinut cu \omega_p si \omega_s');
        xlabel('[0 \pi]');
        ylabel('Amplitudine');
        hold on;
            a = axis;
            o_p = plot([w_p1*pi w_p1*pi], [a(3), a(4)]);
            o_s = plot([w_s1*pi w_s1*pi], [a(3), a(4)]);
        hold off;
        legend([o_p, o_s],{'\omega_p', '\omega_s'});
        
     h = hj_p - hj;  
end
