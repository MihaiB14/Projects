function [h, pr] = firls_FTJ1_c(M,w_p,w_s,K, poz)

    hj = firls_FTJ_c(M - 1, w_p, w_s, K);
    
    if mod(M, 2) == 1
       ht = firls(M, [0 1], [1 1]);
    else
       ht = firls(M - 1, [0 1], [1 1]);
    end
    ht = ht(1:M);
    
    figure(12);
    subplot(3,2,poz);
        [Ht, wt] = freqz(ht, 1, 1500);
        plot(wt, abs(Ht));
        title('Filtrul trece tot');
        xlabel('[0 \pi]');
        ylabel('Amplitudine');
    
    subplot(3,2,2 + poz);
        [Hj, wj] = freqz(hj, 1, 1500);
        plot(wj, abs(Hj));
        if poz == 1
            title('Filtrul trece jos obtinut cu \omega_p si \omega_s');
            xlabel('[0 \pi]');
            ylabel('Amplitudine');
            hold on;
                a = axis;
                o_p = plot([w_p*pi w_p*pi], [a(3), a(4)]);
                o_s = plot([w_s*pi w_s*pi], [a(3), a(4)]);
            hold off;
            legend([o_p, o_s],{'\omega_p', '\omega_s'});
        else
            title('Filtrul trece jos obtinut cu \pi - \omega_p si \pi - \omega_s');
            xlabel('[0 \pi]');
            ylabel('Amplitudine');
            hold on;
                a = axis;
                o_p = plot([w_p*pi w_p*pi], [a(3), a(4)]);
                o_s = plot([w_s*pi w_s*pi], [a(3), a(4)]);
            hold off;
            legend([o_p, o_s],{'\pi - \omega_p', '\pi - \omega_s'});
        end
        
    h = ht' - hj;
end