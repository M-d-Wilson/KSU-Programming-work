// Name: Milo Wilson
// Class: CS 4306/1
// Term: Spring 2022
// Instructor: Dr. Haddad
// Assignment: 2
import java.util.Scanner;
/*
String Substrings(string input)
//Finds how many substrings start with ‘A’ and end in ‘B’ are in the submitted string
//Big O: O(n^2)
//Input: A string
//Output: Makes a string telling you how many substrings can be made with the given string that starts with ‘A’ and ends in ‘B’ and displays the comparisons made to find those strings.

int counter ← 0
int comparisons ← 0
for i ← 0 to input.length do
	if input [i] = ‘A’
		for j ← i to input.length do
			comparisons ← comparisons + 1
			if input[j] = ’B’ 
				counter ← counter + 1
string output ← "Input string:" + input + "# of substrings:" + counter + "# of comparisons:" + comparisons
return output
 */
public class Substrings {
	public static void main(String[] args) 
	{
		Scanner Scan = new Scanner (System.in);
		String input = "";
		System.out.println("Exampel: \nInput:\"ABBAABBA\"" + "\nInput:\"Quit\" to quit");
		System.out.println();

		while(!input.equals("Quit")) 
		{
			try 
			{
				System.out.println("Input: ");
				input = Scan.next();
				
				if(!input.equals("Quit")) 
				{
					System.out.println();
					System.out.println(Substrings(input));
				}
				else 
				{
					System.out.println();
					System.out.println("Have a nice day");
				}
			}
			catch (Exception e)
			{
				Scan.nextLine();
				System.out.println();
				System.out.println(e + "Try again");
			}
			System.out.println();
		}
		Scan.close();
	}
	
	
	static String Substrings(String input) 
	{
		int counter = 0;
		int comparisons = 0;
		for (int i = 0; i < input.length();i++) 
		{
			if (input.charAt(i) == 'A') 
			{
				for(int j = i; j < input.length(); j++) 
				{
					comparisons++;
					if (input.charAt(j) == 'B')
					{ 
						counter++;
					}
				}
			}
		}
		String output = "Input string:\t\t" + input + "\n# of substrings:\t" + counter + "\n# of comparisons:\t" + comparisons;
		return output;
	}

}
