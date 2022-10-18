#include "Function.h"
#include <iostream>
#include <vector>

using namespace std;

int main()
{
	vector<int> ar = { 1, 5, 3, 7, 11, 16, 26 };
	unsigned long sum = 42;
	long start = 0;
	long end = 0;

	/*
	При условии что вектор ar содержит{1, 5, 3, 7, 11, 16, 26}, в результате выполнения
	FindElementsForSum по адресу start будет 1, а по адресу end - 6.
	*/

	FindElementsForSum(ar, sum, start, end);

	std::cout << std::endl << "Start = " << start << std::endl << "End = " << end << std::endl;
}