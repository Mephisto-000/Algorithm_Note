#include "sequential_search.h"

int SequentialSearch::search(const std::vector<int>& data, int target)
{
	for (size_t i = 0; i < data.size(); i++)
	{
		if (data[i] == target)
		{
			return static_cast<int>(i);
		}
	}
	return -1;  // Target not found
}