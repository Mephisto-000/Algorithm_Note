#include <iostream>
#include "sequential_search.h"

void testSequentialSearch()
{
	std::vector<int> data = { 1, 2, 3, 4, 5 };

	int nIndex = SequentialSearch::search(data, 3);
    std::cout << "Test 1 - Searching for 3: ";
    if (nIndex == 2) {
        std::cout << "Passed" << std::endl;
    }
    else {
        std::cout << "Failed" << std::endl;
    }

    nIndex = SequentialSearch::search(data, 6);
    std::cout << "Test 2 - Searching for 6: ";
    if (nIndex == -1) {
        std::cout << "Passed" << std::endl;
    }
    else {
        std::cout << "Failed" << std::endl;
    }
}


int main()
{
    testSequentialSearch();

    return 0;
}