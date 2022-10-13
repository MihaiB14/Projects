function h = FTS(M, w_p, w_s, K, N)

    omega = linspace(0,pi, N + 1);
    pass_band = (omega <= w_p);
    stop_band = (omega >= w_s);
    np = sum(pass_band) - 1;
    ns = N - sum(stop_band) + 1;
    omega_pass_band = omega(pass_band);
    omega_stop_band = omega(stop_band);
    
    M = (0:M)';	
    
    R1 = zeros(size(M));
    for i = 1:length(omega_pass_band)
       R1 = R1 + cos(M*omega_pass_band(i));
    end
    
    R2 = zeros(size(M));
    for i = 1:length(omega_stop_band)
       R2 = R2 + cos(M*omega_stop_band(i));
    end
    
    R = R1 + R2;
    R = toeplitz(R);
    R1 = zeros(size(M));
    for i = 1:length(omega_pass_band)
        R1 = R1 + cos((K - M)*omega_pass_band(i));
    end
    r = R1;
    
    
    h = R\r;
end

