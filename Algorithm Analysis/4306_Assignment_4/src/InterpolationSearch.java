// Name: Milo Wilson
// Class: CS 4306/1
// Term: Spring 2022
// Instructor: Dr. Haddad
// Assignment: 4

public class InterpolationSearch 
{
	public boolean found;
	public int index, divisions, key;
	
	InterpolationSearch()
	{
		found = false;
		index = -1;
		divisions = -1;
	}
	
	InterpolationSearch(int[] list, int targetValue)
	{
		index = RunInterpolationSearch(list, targetValue);
	}

	
	public int RunInterpolationSearch(int[] list, int targetValue)
	{
		//Runs interpolation search to find the target value in the given sorted array
		//Input: An array A[0..n − 1] with n unique elements and a target integer to find
		//Output: The index of the target integer
		found = false;
		index = -1;
		divisions = 0;
		key = targetValue;
		int n = list.length, startPos = 0, endPos =  n - 1, pos = 0;
		
		if(n <= 0) 
		{
			System.out.print("No elements in list");
			found = false;
			return -1;
		}
		
		while(list[endPos] != list[startPos] && targetValue >= list[startPos] && targetValue <= list[endPos])
		{
			pos = startPos + ((targetValue - list[startPos]) * (endPos - startPos) / (list[endPos] - list[startPos]));
			
			if(list[pos] == targetValue) 
			{
				found = true;
				return pos;
			}
			else if (list[pos] > targetValue) 
			{
				endPos = pos - 1;
				divisions++;
			}else 
			{
				startPos = pos + 1;
				divisions++;
			}	
		}
		
		if(targetValue == list[startPos]) 
		{
			found = true;
			return startPos;
		}
		found = false;
		return -1;
	}
	
	public String ToString() 
	{
		return key + "\t" + found + "\t" + index + "\t" + divisions;
	}
}
