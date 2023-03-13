import java.io.Console;
import java.util.Scanner;

// Name: Milo Wilson
// Class: CS 4306/1
// Term: Spring 2022
// Instructor: Dr. Haddad
// Assignment: 3

/*
 * The two insertion sorts work at the same speed. Taking at minimum O(n),
 * at most O(n^2), and on average O(n^2). The swap method dose nothing 
 * to improve the speed of the algorithm it just changes the way the 
 * values get sorted.
 */

public class InsertionCompare {	
	static int[] arr = {};
	static int IS1Check = 0, IS1Swap = 0, IS2Check = 0, IS2Swap = 0;
	
	public static void main(String[] args) 
	{
		Scanner Scan = new Scanner (System.in);
		int action = 0;
		while( action!= 4) 
		{
			try 
			{
				System.out.println();
				System.out.println("-------------MAIN MENU--------------\n" + 
						"1. Read array size\n" + 
						"2. Read array values (integer type)\n" + 
						"3. Run algorithm comparison and display results\n" + 
						"4. Exit program");
				action = Scan.nextInt();
				
				if(action == 1) 
				{
					System.out.println("Enter array size"); 
					ChangeArraySize(Scan.nextInt());
				}
				else if(action == 2) 
				{
					System.out.println("Enter array values"); 
					ChangeArrayElements();
				}
				else if(action == 3) 
				{
					int[] arr2 = arr.clone();
					InsertionSort2(arr);
					InsertionSort(arr2);
					System.out.print("Array size:\t\t" +arr.length+"\n" + 
							"Array values:\t\t");
					for(int i = 0; i < arr.length; i ++) 
					{
						System.out.print(arr[i] + " ");
					}
					System.out.println();
					System.out.println("InsertionSort Stats:\n" + 
							"\tj >= 0:\t\t" + IS1Check + "\n" + 
							"\tA[j] > v:\t" + IS1Check + "\n" + 
							"\tA[j+1] = a[j]:\t" + IS1Swap +"\n" + 
							"\tj = j-1:\t" + IS1Swap + "\n" + 
							"InsertionSort2 Stats:\n" + 
							"\tj >= 0:\t\t" + IS2Check + "\n" + 
							"\tA[j] > A[j+1]:\t" + IS2Check + "\n" + 
							"\tSwap:\t\t" + IS2Swap + "\n" + 
							"\tj = j-1:\t" + IS2Swap);
				}
				else if(action == 4) 
				{
					System.out.println("Good Bye"); 
				}
				else
				{
					System.out.println("Try Again"); 
				}


			}
			catch (Exception e) 
			{
				Scan.nextLine();
				System.out.println();
				System.out.println(e + "Try again");
			}
		}
	}
	
	public static void ChangeArraySize(int x) 
	{
		arr = new int[x];
	}
	
	public static void ChangeArrayElements() 
	{
		Scanner Scan = new Scanner (System.in);
		int[] newArr = arr;
		for(int i = 0; i < newArr.length; i++) 
		{
			newArr[i] = Scan.nextInt();
		}
	}	
	
	public static int[] InsertionSort(int[] newArr) 
	{
		//Sorts a given array by insertion sort
		//Input: An array A[0..n − 1] of n orderable elements
		//Output: Array A[0..n − 1] sorted in nondecreasing order
		
		IS1Check = 0; 
		IS1Swap = 0;
		int n = newArr.length;
		for(int i = 1; i < n - 1; i++) 
		{
			int v = newArr[i];
			int j = i - 1;
			IS1Check++;
			while(j >= 0 && newArr[j] > v) 
			{
				newArr[j + 1] = newArr[j];
				j = j - 1;
				IS1Swap++;
			}
			newArr[j + 1] = v;
		}
		return newArr;
	}
	
	public static int[] InsertionSort2(int[] newArr) 
	{
		//Sorts a given array by insertion sort
		//Input: An array A[0..n − 1] of n orderable elements
		//Output: Array A[0..n − 1] sorted in nondecreasing order
		IS2Check = 0; 
		IS2Swap = 0;
		int n = newArr.length;
		for(int i = 1; i < n - 1; i++) 
		{
			int j = i - 1;
			IS2Check++;
			while(j >= 0 && newArr[j] > newArr[j + 1]) 
			{
				Swap(newArr, j, j + 1);
				j--;
				IS2Swap++;
			}
		}
		return newArr;
	}
	
	public static void Swap(int[] newArr, int x, int y) 
	{
		int temp = newArr[x];
		newArr[x] = newArr[y];
		newArr[y] = temp;
	}
}
