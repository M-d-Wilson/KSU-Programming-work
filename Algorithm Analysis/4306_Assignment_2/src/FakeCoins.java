// Name: Milo Wilson
// Class: CS 4306/1
// Term: Spring 2022
// Instructor: Dr. Haddad
// Assignment: 2

/*
String FakeCoins(int bags, int[] weights)
//Finds the first sack, that weighs 11, is sets of coins that weigh 10
//Big O: O(n)
//minimum runs is 1 for when the Fake coins are in the first element of the array
//Input: An integer with the number of bags and an integer array for all the sack’s weights
//Output: Returns the number of sacks, the index (base 1) of the first counterfeit sack (if any), and how many comparisons where made to find it.

int comparisons ← 0
int fakes ← -1
string output ← “”
for i ← 0 to weights.length do
	comparisons ← comparisons + 1
	if (weights[i] = 11)
			fakes ← i + 1
			output ← “Total number of stacks is:” + bags + “Fake coins stack is stack #: ” + fakes + “# of weighings required:“ + comparisons
			return output
	if fake != -1
			output += "Total number of stacks is:" + weights.length + "Fake coins stack is stack #:none found" + "# of weighings required:" + comparisons;
	return output
 */
import java.io.Console;
import java.util.Scanner;

public class FakeCoins 
{
	
	public static void main(String[] args) 
	{
		Scanner Scan = new Scanner (System.in);
		int size = 0;
		int[] weights;
		System.out.println("Exampel: \"size: 5\numbers:\n10\n10\n11\n10\n10\"\ninput \"size :-1\" to quit");
		
		while(size > -1) 
		{
			try 
			{
				System.out.println("Input Size: ");
				size = Scan.nextInt();
				
				if(size > -1) 
				{
					System.out.println("Input Weights: ");
					weights = new int[size];
					for(int i = 0; i < size; i++) 
					{
						weights[i] = Scan.nextInt();
					}
					System.out.println();
					System.out.println(CommonElements(weights));
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
	
	static String CommonElements (int[]weights) 
	{
		String output = "";
		int comparisons = 0, fake = -1;
		for(int i = 0; i < weights.length; i++) 
		{
			comparisons++;
			if(weights[i] == 11) 
			{
				fake = i + 1;
				output += "Total number of stacks is:\t" + weights.length + "\nFake coins stack is stack #:\t" + fake + "\n# of weighings required:\t" + comparisons;
				return output;
			}
		}
		if (fake != -1)
			output += "Total number of stacks is:\t" + weights.length + "\nFake coins stack is stack #:\tnone found" + "\n# of weighings required:\t" + comparisons;
		return output;
		
	}


}
