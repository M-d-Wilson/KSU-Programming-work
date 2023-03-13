// Name: Milo Wilson
// Class: CS 4306/1
// Term: Spring 2022
// Instructor: Dr. Haddad
// Assignment: 5
public class Quicksort {
	int comparisons;
	int[] sortedArr;
	
	Quicksort()
	{
		comparisons = 0;
		sortedArr = new int[0];
	}
	
	public Quicksort(int[] arr)
	{
		comparisons = 0;
		sortedArr = arr;
		RunQuicksort(sortedArr, 0, sortedArr.length - 1);
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
		RunQuicksort(sortedArr, 0, sortedArr.length - 1);
		int[]lowArray, higharray;
	}
	
	public void RunQuicksort(int[] arr, int start, int end) 
	{
//		This way (the way in the book gave me) stack overflows everytime it gets to 
//		100000 random nodes or more

//		if(start < end) 
//		{
//	        int pivot = FindPivot(arr, start, end);
//	        RunQuicksort(arr, start, pivot);
//	        RunQuicksort(arr, pivot + 1, end);
//		}
		
		//this seems to work but there might be issues
	    if(start < end)
	    {
	        int pivot = FindPivot(arr, start, end);
	        if (pivot - start <= end - (pivot + 1))
	        {
	        	RunQuicksort(arr, start, pivot);
	            start = pivot + 1;
	        }
	        else
	        {
	        	RunQuicksort(arr, pivot + 1, end);
	            end = pivot;
	        }
	    }
	}

	private int FindPivot(int[] arr, int start, int end) 
	{
		int pivot = arr[end];
	    int i = start - 1;

	    for (int j = start; j < end; j++) 
	    {
        	comparisons++;
	        if (arr[j] < pivot) 
	        {
	        	i++;

	            int temp = arr[i];
	            arr[i] = arr[j];
	            arr[j] = temp;
	        }
	    }
	    int temp = arr[i + 1];
	    arr[i + 1] = arr[end];
	    arr[end] = temp;
	    return i + 1;
	}
}
