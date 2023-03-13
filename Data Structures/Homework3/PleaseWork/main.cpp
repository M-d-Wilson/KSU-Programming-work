#include <stdio.h>
#include "LinkedList.h"
#include <iostream>

int main(int argc, char **argv)
{
	bool isPlendrome = true;
	std::string input = "";
	LinkedList MyList;
	std::cout << "Enter a word:" << std::endl;
	std::cin >> input;
	
	for(int i = 0; i < input.length(); i++)
	{
		MyList.addNode_End(input[i]);
	}
	int mesureLength = MyList.length();
	mesureLength -= 1;
	
	while(isPlendrome && mesureLength >= 0)
	{
		if(MyList.getDataFromNode(mesureLength) != MyList.getDataFromNode(MyList.length() - mesureLength - 1))
		{
			isPlendrome = false;
		}
		mesureLength--;
	}
	
	if (isPlendrome)
	{
		std::cout << "The word is palindrome" << std::endl;
	}
	else
	{
		std::cout << "The word is not palindrome" << std::endl;
	}
	return 0;
}
