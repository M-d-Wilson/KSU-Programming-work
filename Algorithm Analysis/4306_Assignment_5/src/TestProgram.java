import java.util.Arrays;
import java.util.Random;
import java.util.Scanner;
//Name: Milo Wilson
//Class: CS 4306/1
//Term: Spring 2022
//Instructor: Dr. Haddad
//Assignment: 5

/*				QS			HS			MS
 * Best case: 	n*log(n)	n*log(n)	n*log(n)
 * Worst case:	n*log(n)	n*log(n)	n*log(n)
 * Avg case:	n^2			n*log(n)	n*log(n)
 * 
 * What I found when examining the results of the algorithms was that quicksort seems to compare
 * all but one index every time you run it because it has to  check all the indexes before it is
 * considered sorted. Heapsort seems to have checked a constant amount of time which makes seams
 * because the algorithm has to check log2(n) nodes overtime it puts a value on top of the tree
 * which is why it seems to have a mostly consistent amount of comparisons. The mergesort seems
 * to have given insertion results because it makes more comparisons in the random case than it
 * dose in the worst case. I think this has to do with my implementation just adding in all the 
 * variables after one side of the merge has finished.
 * 
 * Hope this make sense, have a nice day
*/
public class TestProgram {

	public static void main(String[] args) 
	{
		int[][] thousands, tenThousand, hundredThousand, million, random, increasing, decreasing;
		
		thousands = new int[3][1000];
		tenThousand = new int[3][10000];
		hundredThousand = new int[3][100000];
		million = new int[3][1000000];
		random = new int[3][4];
		increasing = new int[3][4];
		decreasing = new int[3][4];		
		
		Scanner Scan = new Scanner (System.in);
		int action = 0;
		while( action!= 4) 
		{
			try 
			{
				System.out.println("---------------MAIN MENU---------------\n" + 
						"1. Populate Arrays\n" + 
						"2. Run Algorithms\n" + 
						"3. Display outputs\n" + 
						"4. Exit program\n\n" +
						"Enter option number:");
				action = Scan.nextInt();
	
				if(action == 1) 
				{
					System.out.println("Populating Arrays");
					// Random
					thousands[0] = RandomIntegers(thousands[0]);
					tenThousand[0] = RandomIntegers(tenThousand[0]);
					hundredThousand[0] = RandomIntegers(hundredThousand[0]);
					million[0] = RandomIntegers(million[0]);
					// Increasing
					thousands[1] = IncreasingIntegers(thousands[1]);
					tenThousand[1] = IncreasingIntegers(tenThousand[1]);
					hundredThousand[1] = IncreasingIntegers(hundredThousand[1]);
					million[1] = IncreasingIntegers(million[1]);
					// Decreasing
					thousands[2] = DecreasingIntegers(thousands[2]);
					tenThousand[2] = DecreasingIntegers(tenThousand[2]);
					hundredThousand[2] = DecreasingIntegers(hundredThousand[2]);
					million[2] = DecreasingIntegers(million[2]);
				}
				else if(action == 2) 
				{
					System.out.println("Running Algorithems");
					Mergesort MS = new Mergesort(); 
					Heapsort HS = new Heapsort(); 
					Quicksort QS = new Quicksort();
					// Random
					MS.sortNewArr(thousands[0]);
					random[0][0] = MS.getComparisons();
					MS.sortNewArr(tenThousand[0]);
					random[0][1] = MS.getComparisons();
					MS.sortNewArr(hundredThousand[0]);
					random[0][2] = MS.getComparisons();
					MS.sortNewArr(million[0]);
					random[0][3] = MS.getComparisons();
					
					//shows array and tells if sorted
//					System.out.println(DisplayArray(QS.getSortedArr()));
//					System.out.println(InOrder(QS.getSortedArr()));
					QS.sortNewArr(thousands[0]);
					random[1][0] = QS.getComparisons();
					//shows array and tells if sorted
//					System.out.println(DisplayArray(QS.getSortedArr()));
//					System.out.println(InOrder(QS.getSortedArr()));
					QS.sortNewArr(tenThousand[0]);
					random[1][1] = QS.getComparisons();
					//shows array and tells if sorted
//					System.out.println(DisplayArray(QS.getSortedArr()));
//					System.out.println(InOrder(QS.getSortedArr()));
					QS.sortNewArr(hundredThousand[0]);
					random[1][2] = QS.getComparisons();
					//shows array and tells if sorted
//					System.out.println(DisplayArray(QS.getSortedArr()));
//					System.out.println(InOrder(QS.getSortedArr()));
					QS.sortNewArr(million[0]);
					random[1][3] = QS.getComparisons();
					
					HS.sortNewArr(thousands[0]);
					random[2][0] = HS.getComparisons();
					HS.sortNewArr(tenThousand[0]);
					random[2][1] = HS.getComparisons();
					HS.sortNewArr(hundredThousand[0]);
					random[2][2] = HS.getComparisons();
					HS.sortNewArr(million[0]);
					random[2][3] = HS.getComparisons();
					
					// Increasing
					MS.sortNewArr(thousands[1]);
					increasing[0][0] = MS.getComparisons();
					MS.sortNewArr(tenThousand[1]);
					increasing[0][1] = MS.getComparisons();
					MS.sortNewArr(hundredThousand[1]);
					increasing[0][2] = MS.getComparisons();
					MS.sortNewArr(million[1]);
					increasing[0][3] = MS.getComparisons();
					
					QS.sortNewArr(thousands[1]);
					increasing[1][0] = QS.getComparisons();
					QS.sortNewArr(tenThousand[1]);
					increasing[1][1] = QS.getComparisons();
					QS.sortNewArr(hundredThousand[1]);
					increasing[1][2] = QS.getComparisons();
					QS.sortNewArr(million[1]);
					increasing[1][3] = QS.getComparisons();
					
					HS.sortNewArr(thousands[1]);
					increasing[2][0] = HS.getComparisons();
					HS.sortNewArr(tenThousand[1]);
					increasing[2][1] = HS.getComparisons();
					HS.sortNewArr(hundredThousand[1]);
					increasing[2][2] = HS.getComparisons();
					HS.sortNewArr(million[1]);
					increasing[2][3] = HS.getComparisons();
					
					// Decreasing
					MS.sortNewArr(thousands[2]);
					decreasing[0][0] = MS.getComparisons();
					MS.sortNewArr(tenThousand[2]);
					decreasing[0][1] = MS.getComparisons();
					MS.sortNewArr(hundredThousand[2]);
					decreasing[0][2] = MS.getComparisons();
					MS.sortNewArr(million[2]);
					decreasing[0][3] = MS.getComparisons();
					
					QS.sortNewArr(thousands[2]);
					decreasing[1][0] = QS.getComparisons();
					QS.sortNewArr(tenThousand[2]);
					decreasing[1][1] = QS.getComparisons();
					QS.sortNewArr(hundredThousand[2]);
					decreasing[1][2] = QS.getComparisons();
					QS.sortNewArr(million[2]);
					decreasing[1][3] = QS.getComparisons();
					
					HS.sortNewArr(thousands[2]);
					decreasing[2][0] = HS.getComparisons();
					HS.sortNewArr(tenThousand[2]);
					decreasing[2][1] = HS.getComparisons();
					HS.sortNewArr(hundredThousand[2]);
					decreasing[2][2] = HS.getComparisons();
					HS.sortNewArr(million[2]);
					decreasing[2][3] = HS.getComparisons();
				}
				else if(action == 3) 
				{
					System.out.println("Output:\n");
					System.out.println("Array Type: Random\n" + 
							"Algorithm\tn=1000\tn=10000\tn=100000n=1000000\n" + 
							"----------------------------------------------------------\n" + 
							"Mergesort \t" + random[0][0] + "\t" + random[0][1] + "\t" + random[0][2] + "\t" + random[0][3] + "\n" +
							"Quicksort \t" + random[1][0] + "\t" + random[1][1] + "\t" + random[1][2] + "\t" + random[1][3] + "\n" +
							"Heapsort \t"  + random[2][0] + "\t" + random[2][1] + "\t" + random[2][2] + "\t" + random[2][3] + "\n\n" +
							"Array Type: Increasing\n" + 
							"Algorithm\tn=1000\tn=10000\tn=100000n=1000000\n" + 
							"----------------------------------------------------------\n" + 
							"Mergesort \t" + increasing[0][0] + "\t" + increasing[0][1] + "\t" + increasing[0][2] + "\t" + increasing[0][3] + "\n" +
							"Quicksort \t" + increasing[1][0] + "\t" + increasing[1][1] + "\t" + increasing[1][2] + "\t" + increasing[1][3] + "\n" +
							"Heapsort \t"  + increasing[2][0] + "\t" + increasing[2][1] + "\t" + increasing[2][2] + "\t" + increasing[2][3] + "\n\n" +
							"Array Type: Decreasing\n" + 
							"Algorithm\tn=1000\tn=10000\tn=100000n=1000000\n" + 
							"----------------------------------------------------------\n" + 
							"Mergesort \t" + decreasing[0][0] + "\t" + decreasing[0][1] + "\t" + decreasing[0][2] + "\t" + decreasing[0][3] + "\n" +
							"Quicksort \t" + decreasing[1][0] + "\t" + decreasing[1][1] + "\t" + decreasing[1][2] + "\t" + decreasing[1][3] + "\n" +
							"Heapsort \t"  + decreasing[2][0] + "\t" + decreasing[2][1] + "\t" + decreasing[2][2] + "\t" + decreasing[2][3] + "\n");
					
				}
				else if(action == 4) 
				{
					System.out.println("Thank You"); 
				}
				else
				{
					System.out.println("Try Again"); 
	
				}
			}catch(Exception e)
			{
				System.out.println("Try Again");
			}
		}
	}

	public static int[] RandomIntegers(int[] arr)
	{
		//Fills given array with new random integers
		//Input: integer array
		//Output: fill array with random integers
		
	    Random rand = new Random();
		for(int j = 0; j< arr.length; j++) 
		{
			arr[j] = rand.nextInt();
		}
		return arr;
	}
	
	public static int[] IncreasingIntegers(int[] arr)
	{
		//Fills given array with new increasing integers
		//Input: integer array
		//Output: fill array with increasing integers
		
		for( int j = 0; j < arr.length; j++) 
		{
			arr[j] = j;
		}
		return arr;
	}
	
	public static int[] DecreasingIntegers(int[] arr)
	{
		//Fills given array with new decreasing integers
		//Input: integer array
		//Output: fill array with decreasing integers
		
		for(int j = 0; j < arr.length; j++) 
		{
			arr[j] = arr.length - j - 1;
		}
		return arr;
	}
	
	public static String Display2DArray(int[][] arr) 
	{
		//Makes string with all integer values
		//Input: 2D array
		//Output: fill array with increasing integers

		String output = "";
		for(int i = 0; i < arr.length; i++) 
		{
			for(int j = 0; j < arr[i].length; j++) 
			{
				if (j % 100 == 0) 
				{
					output += "\n";
				}
				output += arr[i][j] + ", ";
			}
			output += "\n";
		}
		return output;
	}
	public static String DisplayArray(int[] arr) 
	{
		//Makes string with all integer values
		//Input: 2D array
		//Output: fill array with increasing integers

		String output = "";
		for(int i = 0; i < arr.length; i++) 
		{
			if (i % 100 == 0) 
			{
				output += "\n";
			}
			output += arr[i] + ", ";
		}
		output += "\n";
		return output;
	}
	
	public static boolean InOrder(int[] arr) 
	{
		for(int i = 1; i < arr.length; i++) 
		{
			if(arr[i] < arr[i-1]) 
			{
				System.out.println(i); 
				return false;
			}
		}
		return true;
	}
}
