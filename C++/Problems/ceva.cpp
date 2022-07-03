#include <iostream>
#include <math.h>
#include <string.h>

using namespace std;

template<int stage>
struct FF
{
	static const int value =
		FF<stage - 1>::value + FF<stage - 2>::value;
	static inline int getValue(int i)
	{
		if (i == stage)
		{
			return value;
		}
		else
		{
			return FF<stage - 1>::getValue(i);
		}
	}
};

template<>
struct FF <0>
{
	static const int value = 1;
	
	static inline int getValue(int i)
	{
		assert(i == 0);
		return 1;
	}
};

template<>
struct FF <1>
{
	static const int value = 1;
	
	static inline int getValue(int i)
	{
		if (i == 1)
		{
			return value;
		}
		else
		{
			return FF<0>::getValue(i);
		}
	}
};


int main() {
    

    return 0;
}