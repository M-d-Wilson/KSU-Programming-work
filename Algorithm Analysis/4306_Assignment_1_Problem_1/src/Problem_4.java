import java.util.Scanner;

// Name: Milo Wilson
// Class: CS 4306/1
// Term: Spring 2022
// Instructor: Dr. Haddad
// Assignment: 1

/*
String AnagramCheck(string Str1, string Str2)
//Checks if two strings are anagrams of each other
//Input: two stings
//Output: A string saying if the strings are anagrams or not and how many comparisons 
//	the program made to find out
	String ToReturn ← “Output:”
	Bool Match ← true
	Int Comparisons ← 0
	Str1.Remove spaces
	Str2.Remove spaces
	Int x ← Str1.length
	for i ← 0 to x do
		if Match = true
			Match ← false
			for j ← 0 to Str2.length do 
				if Match = false
					Comparisons ← Comparisons + 1
					if Str1[ 0 ] = Str2[ j ]
						Str2 ← ‘ ‘
						if j <= 0
							Str2 ← Str2[1, Str2.length - 1]
							Match ← true;
							Break;
						else if j = Str2.length() - 1
							Str2 ← Str2[0, j]
							Match ← true
							Break
						else
							Str2 ← Str2[0, j] + Str2[j + 1, Str2.length - 1]
							Match ← true
							Break
	if Str2.length > 0 do
		Match = false
	if Match = true
		ToReturn ← ToReturn + “Strings are Anagrams”
	else do
		ToReturn ← ToReturn + “Strings are not Anagrams”
	ToReturn ← ToReturn + “Comparisons:” + Comparisons
return ToReturn

*/
public class Problem_4 {
	public static void main(String[] args) 
	{
		Scanner Scan = new Scanner (System.in);
		//Test Code
		String str1 = "";
		String str2 = "";
		
		try 
		{
			System.out.println("Exampel:\"Done With it\" and \"ti htiW enoD\"\nString 1:\t");
			str1 = Scan.nextLine();
			System.out.println("String 2:\t");
			str2 = Scan.nextLine();
			System.out.println(AnagramCheck(str1, str2));
		}
		catch(Exception e)
		{
			System.out.println("Incorrect input");
		}
	}
	
	public static String AnagramCheck(String str1, String str2) 
	{
		//Input: Two strings
		//Makes a string with the result if the strings match or not and 
		//how may comparisons are made to find the result 
		String toReturn = "Output:\t\t";
		boolean match = true;
		int comparisons = 0;
		str1 = str1.replaceAll("\\s", "");
		str2 = str2.replaceAll("\\s", "");
		int x = str1.length();
		//System.out.println(str1 + "|" + str2);

		for(int i = 0; i < x; i++) 
		{
			if(match) 
			{
				match = false;
				
				for(int j = 0; j < str2.length(); j++) 
				{
					if(!match) 
					{
						comparisons++;
						
						if(str1.charAt(0) == str2.charAt(j)) 
						{
							str1 = str1.substring(1);
							
							if(j <= 0) 
							{
								str2 = str2.substring(1);
								match = true;
								break;
							}
							else if(j == str2.length() - 1) 
							{
								str2 = str2.substring(0, j);
								match = true;
								break;
							}
							else 
							{
								str2 = str2.substring(0, j) + str2.substring(j + 1);
								match = true;
								break;
							}
						}
					}
				}
				//System.out.println(str1 + "|" + str2);
			}
		}
		
		if(str2.length() > 0) 
		{
			match = false;
		}
		
		if(match) 
		{
			toReturn += "Strings are Anagrams";
		}
		else
		{
			toReturn += "Strings are not Anagrams";
		}
		toReturn += "\nComparisons:\t" + comparisons;
		return toReturn;
	}

}
