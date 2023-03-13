// Name: Milo Wilson
// Class: CS 4306/1
// Term: Spring 2022
// Instructor: Dr. Haddad
// Assignment: 1

/*
CommonElements (Ar1[0..n-1], Ar2[0,,n-1])
//Finds common elements in two arrays
//Input: Two integer arrays
//Output: A string with the the common numbers and the number of comparisons the
//	program made
	ToReturn = “Common Values:\t “
	Compareisons = 0
	for i ← 0 to Ar1.Length do
		for j ← 0 to j < Ar2.Length do
			Compareisons ← Compareisons + 1
			if Ar1[ i ] = Ar2 [ j ]
				ToReturn ← ToReturn + Ar1[ i ] + “ “
				Ar2 [ j ] ← ∞
return ToReturn
*/
import java.io.Console;
import java.util.Scanner;

public class Problem_1 
{
	public static void main(String[] args) 
	{
		Scanner Scan = new Scanner (System.in);
		int[] Ar1 = new int[] {3,4,5,6,7};
		int[] Ar2 = new int[] {4,3,2,1};
		System.out.println("Exampel: \"1,2,3,4,5\"\nList 1:\t");
		String[] toBeAr = new String[1];
		toBeAr[0] = Scan.next();
		toBeAr = toBeAr[0].split(",");
		try 
		{
			Ar1 = new int[toBeAr.length];
			for(int i = 0; i < toBeAr.length; i++) 
			{
				Ar1[i] = Integer.parseInt(toBeAr[i]);
			}
			
			System.out.println("\nList 2:\t");
			toBeAr[0] = Scan.next();
			toBeAr = toBeAr[0].split(",");
			Ar2 = new int[toBeAr.length];
			for(int i = 0; i < toBeAr.length; i++) 
			{
				Ar2[i] = Integer.parseInt(toBeAr[i]);
			}		
			System.out.println(CommonElements(Ar1, Ar2));
		}
		catch(Exception e)
		{
			System.out.println("Incorrect input");				
		}
	}
	
	public static String CommonElements(int[] Ar1, int[] Ar2) 
	{
		//Input: Two integer arrays
		//Makes a string with all common values and how may comparisons are made. 
		String toReturn = "Common values:\t";
		int comparisons = 0;
		for(int i = 0; i < Ar1.length; i++) 
		{
			for(int j = 0; j < Ar2.length; j++) 
			{
				comparisons++;
				if(Ar1[i] == Ar2[j]) 
				{
					toReturn += Ar1[i] +  " ";
					Ar2[j] = Integer.MAX_VALUE;
					break;
				}
			}
		}
		if(toReturn == "Common values:\t") 
		{
			toReturn += "No common values";
		}
		toReturn += "\nComparisons:\t" + comparisons;
		return toReturn;
	}
}