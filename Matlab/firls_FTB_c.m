%
%	File FIRLS_FTJ_C.M
%
%	Function: FIRLS_FTJ_C
%
%	Synopsis: h = firls_FTJ_c(M,w_p,w_s,K) ; 
%
%	Designs a low-pass FIR filter of length M+1, namely h, by solving  
%	the optimization problem based on Euclidean norm. The optimization 
%	method is of Least Squares type, just like in case of MATLAB 
%	function FIRLS. By difference from FIRLS, here, the ideal filter 
%	can have a complex valued frequency response in the passing band.
%	Moreover, the problem is solved by considering continuous variation 
%	of frequency. (The resulted integrals were derived in closed form. 
%	See the theory on this matter.)
%
%	Inputs: M   = the filter order (positive integer); 
%	        w_p = the relative pass band upper limit (a number between 0 and 1); 
%	        w_s = the relative stop band lower limit (a number between 0 and 1, 
%                     at least equal to wp); 
%	        K   = the group delay of ideal filter (non negative integer, 
%	              null by default). 
%
%	Missing, empty or inconsistent inputs return empty or wrong output. 
%
%	Uses:	 WAR_ERR 
%
%	Authors: Bogdan DUMITRESCU & Dan STEFANOIU
%	Created: March    15, 2010 
%	Revised: November 22, 2018
%	         December 10, 2018
%	         July     09, 2019
%

function [h, pr] = firls_FTJ_c(M, w_s1, w_p1, w_p2, w_s2, K)

%
% BEGIN
%
% Constants & Messages 
% ~~~~~~~~~~~~~~~~~~~~
	FN = '<FIRLS_FTJ_C>: ' ;
	E1 = [FN 'Missing, empty or inconsistent input data => empty output. Exit.'] ; 
%
% Faults preventing
% ~~~~~~~~~~~~~~~~~
	h = [] ; 
	if (nargin < 5)
	   war_err(E1) ;
	   return ; ; 
	end ; 
    
	M = round(abs(M(1))) ; 
	if ~M
	   war_err(E1) ;
	   return ; ; 
	end ; 
    
	w_p1 = abs(w_p1(1)) ; 
	if (w_p1 < eps) || (w_p1 >= (1-eps))
	   war_err(E1) ;
	   return ; ; 
	end ; 
	w_s1 = abs(w_s1(1)) ; 
	if (w_s1 < eps) || (w_s1 >= (1-eps))
	   war_err(E1) ;
	   return ; ; 
	end ; 
    
    w_p2 = abs(w_p2(1)) ; 
	if (w_p2 < eps) || (w_p2 >= (1-eps))
	   war_err(E1) ;
	   return ; ; 
	end ; 
	w_s2 = abs(w_s2(1)) ; 
	if (w_s2 < eps) || (w_s2 >= (1-eps))
	   war_err(E1) ;
	   return ; ; 
	end ; 
    
	if (w_s1 > w_p1)
	   FN = w_p1 ; 
	   w_p1 = w_s1 ; 
	   w_s1 = FN ; 
	end ; 
    
    if (w_p2 > w_s2)
	   FN = w_p2 ; 
	   w_p2 = w_s2 ; 
	   w_s2 = FN ; 
	end ; 
    
	if (nargin < 6)
	   K = 0 ;
	end ; 
	K = round(abs(K(1))) ; 
%
% Filter design
% ~~~~~~~~~~~~~
	M = (0:M)';			% This is the filter support.
	R = w_s1*sinc(M*w_s1) + w_p2*sinc(M*w_p2) - w_p1*sinc(M*w_p1) - w_s2*sinc(M*w_s2) + eye(size(M));
	R = toeplitz(R);		% This is the matrix to invert.
	r = w_p2*sinc((K-M)*w_p2) - w_p1*sinc((K-M)*w_p1);	% This is the free vector.
	h = R\r;
    pr = 100*((w_p2 - w_p1 - r'*h)/(w_p2 - w_p1));
%
% END
%
