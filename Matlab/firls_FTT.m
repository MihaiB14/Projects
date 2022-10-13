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

function h = firls_FTT(M,w_p,w_s,K)

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
	if (nargin < 3)
	   war_err(E1) ;
	   return ; ; 
	end ; 
	M = round(abs(M(1))) ; 
	if ~M
	   war_err(E1) ;
	   return ; ; 
	end ; 
    
	w_p = abs(w_p(1)) ; 
	w_s = abs(w_s(1)) ; 
    
	if (w_p > w_s)
	   FN = w_p ; 
	   w_p = w_s ; 
	   w_s = FN ; 
	end ; 
	if (nargin < 4)
	   K = 0 ;
	end ; 
	K = round(abs(K(1))) ; 
%
% Filter design
% ~~~~~~~~~~~~~
	M = (0:M)';			% This is the filter support.
	R = sinc(M);
	R = toeplitz(R);		% This is the matrix to invert.
	r = sinc(K - M);	% This is the free vector.
	h = R\r;
%
% END
%
