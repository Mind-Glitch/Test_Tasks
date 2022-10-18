#pragma once

#ifndef Function
#define Function

#include <vector>

void FindElementsForSum( std::vector<int> list, unsigned long sum, long& start, long& end) {

	unsigned long localsum = 0;
	unsigned int listLength = list.size();

	for (int i = 0; i < listLength; i++) {
		localsum = 0;
		for (int j = i; j < listLength; j++) {
			localsum += list[j];
			if (localsum == sum) {
				start = i;
				end = j + 1;
				return;
			}
		}
	}

	start = 0;
	end = 0;
	return;
}

#endif