// Name: Milo Wilson
// Class: CS 4306/1
// Term: Spring 2022
// Instructor: Dr. Haddad
// Assignment: 5
public class Mergesort {
	int comparisons;
	int[] sortedArr;
	
	Mergesort()
	{
		comparisons = 0;
		sortedArr = new int[0];
	}
	
	Mergesort(int[] arr)
	{
		comparisons = 0;
		sortedArr = arr;
		Sort(sortedArr, 0, sortedArr.length - 1);
	}
	
	public int[] getSortedArr() 
	{
		return sortedArr;
	}
	
	public int getComparisons()
	{
		return comparisons;
	}
	
	public void sortNewArr(int[] arr) 
	{
		comparisons = 0;
		sortedArr = arr;
		Sort(sortedArr, 0, sortedArr.length - 1);
	}
	void Merge(int[] arr, int left, int middle, int right)
	{
		int leftLength = middle - left + 1;
		int rightLength = right - middle;
		int[] leftArr = new int[leftLength];
		int[] rightArr = new int[rightLength];
		
		for (int i = 0; i < leftLength; i++) 
		{
			leftArr[i] = arr[left + i];
		}
		
		for (int i = 0; i < rightLength; i++) 
		{
			rightArr[i] = arr[middle + 1 + i];
		}
		int indexLeft = 0, indexRight = 0;
		int sortedIndex = left;
		
		while(indexLeft < leftLength && indexRight < rightLength) 
		{
			comparisons++;
			if(leftArr[indexLeft] <= rightArr[indexRight]) 
			{
				arr[sortedIndex] = leftArr[indexLeft];
				indexLeft++;
			}else 
			{
				arr[sortedIndex] = rightArr[indexRight];
				indexRight++;
			}
			sortedIndex++;
		}
		
		while (indexLeft < leftLength) 
		{
			arr[sortedIndex] = leftArr[indexLeft];
			indexLeft++;
			sortedIndex++;
		}
		
		while (indexRight < rightLength) 
		{
			arr[sortedIndex] = rightArr[indexRight];
			indexRight++;
			sortedIndex++;
		}
	}
	
	void Sort(int[] arr, int left, int right) 
	{
		if(left < right) 
		{
	        int middle = (left + ((right - left) >> 1));
			Sort(arr, left, middle);
			Sort(arr, middle + 1, right);
			Merge(arr, left, middle, right);
		}
	}
}
