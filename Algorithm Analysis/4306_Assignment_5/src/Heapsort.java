// Name: Milo Wilson
// Class: CS 4306/1
// Term: Spring 2022
// Instructor: Dr. Haddad
// Assignment: 5
public class Heapsort {
	int comparisons;
	int[] sortedArr;
	
	Heapsort()
	{
		comparisons = 0;
		sortedArr = new int[0];
	}
	
	public Heapsort(int[] arr)
	{
		comparisons = 0;
		sortedArr = arr;
		int length = sortedArr.length;
		
		for (int i = sortedArr.length / 2 - 1; i >= 0; i--)
            heapify(sortedArr, length, i);
		
		for(int i = sortedArr.length - 1; i > 0; i--) 
		{
		    int temp = sortedArr[0];
		    sortedArr[0] = sortedArr[i];
		    sortedArr[i] = temp;
            heapify(sortedArr, i, 0);
		}
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
		int length = sortedArr.length;
		
		for (int i = length / 2 - 1; i >= 0; i--)
            heapify(sortedArr, length, i);
		
		for(int i = length - 1; i > 0; i--) 
		{
		    int temp = sortedArr[0];
		    sortedArr[0] = sortedArr[i];
		    sortedArr[i] = temp;
            heapify(sortedArr, i, 0);
		}
	}
	
	public void heapify(int[] arr, int length, int biggestSofar) 
	{
		int largest = biggestSofar;
		int left = 2 * biggestSofar + 1;
		int right = 2 * biggestSofar + 2;
		//compare left node
		comparisons++;
		if (left < length && arr[left] > arr[largest]) 
		{
            largest = left;
		}
		//compare right node
		comparisons++;
		if (right < length && arr[right] > arr[largest]) 
		{
            largest = right;
		}
		if(largest != biggestSofar) 
		{
		    int temp = arr[biggestSofar];
		    arr[biggestSofar] = arr[largest];
		    arr[largest] = temp;
		    
		    heapify(arr, length, largest);
		}
		
		
		
	}
}
