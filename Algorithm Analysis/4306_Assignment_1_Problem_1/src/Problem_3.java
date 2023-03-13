import java.util.Scanner;

// Name: Milo Wilson
// Class: CS 4306/1
// Term: Spring 2022
// Instructor: Dr. Haddad
// Assignment: 1
/*
String StringMatching(string Str1, string Str2)
//Checks if two strings match
//Input: Two strings
//Output: A string saying if the strings match or not and how many comparisons the
//	program made to find out
	Comparisons ← 0
	ToReturn ← “Output:”
	Same ← true
	if Str1.Length ≠ Str2.Length
		ToReturn ← ToReturn + “Strings are of different Lengths”
		Same ← false
	else
		for i ← 0 to Str1.Length do
			Comparisons ← Comparisons + 1
			if Str1[ i ] ≠ Str2 [ i ]
				Same ← false
				Break
		if Same = true
			ToReturn ← ToReturn + “Strings match”
		else
			ToReturn ← ToReturn + “Strings do not match”			
		ToReturn ← ToReturn + “Comparisons:” + Comparisons
return ToReturn
 
*/
public class Problem_3 {
	public static void main(String[] args) 
	{
		Scanner Scan = new Scanner (System.in);
		//Test Code
		String str1 = "";
		String str2 = "";
		
		try 
		{
			System.out.println("Exampel:\"Hello\" \nString 1:\t");
			str1 = Scan.next();
			System.out.println("\nString 2:\t");
			str2 = Scan.next();
			System.out.println(StringMatching(str1, str2));
		}
		catch(Exception e)
		{
			System.out.println("Incorrect input");
		}
	}
	
	public static String StringMatching(String str1, String str2) 
	{
		//Input: Two strings
		//Makes a string with the results of if the strings match or not 
		//and how may comparisons are made to detect the result 
		String toReturn = "Output:\t\t";
		boolean same = true;
		int comparisons = 0;
		
		if (str1.length() != str2.length())
		{
			toReturn += "Strings do not match";
			same = false;
		} 
		else
		{
			for(int i = 0; i < str1.length(); i++) 
			{
				comparisons++;
				
				if(str1.charAt(i) != str2.charAt(i)) 
				{
					same = false;
					break;
				}
			}
			
			if(same) 
			{
				toReturn += "Strings match";
			}
			else 
			{
				toReturn += "Strings do not match";
			}
			toReturn += "\nComparisons:\t" + comparisons;
		}
		return toReturn;
	}
}
