// Name: Milo Wilson
// Class: CS 4306/1
// Term: Spring 2022
// Instructor: Dr. Haddad
// Assignment: 2
import java.util.Scanner;
/*
String Partition(int [] fullSet)
//Divides a set of numbers into two equal disjoint subsets with an equal total value in each of its subsets if able
//Input: An integer array
//Output: a string showing the two posible disjoint pairs that have the same sum of their elements 
int [] set 2 ← new int []
int [] set 1 ← new int []
int sum1 ← 0
int sum2 ← 0
string output ← "Set size:" + fullSet.length + "integers Integer values:"
for i ← 0 to fullSet.length do
	output ← output + fullSet[i] + “ “
output ← output + “Disjoint subsets with same sum:”
if sum % 2 = 0 
	for i ← 0 to fullSet.length do
		set1[i] ← ∞
		set2[i] ← ∞
	for i ← 0 to fullSet.length do
		for j ← 0 to fullSet.length do
				int addMore ← j
				for k ← 0 to fullSet.length do
					if k ← i
						set1[k] ← fullSet[k]
					else if addMore > 0
						set1[k] ← fullSet[k]
						addMore ← addMore - 1
					else
						set2[k] ← fullSet[k]
				for k ← 0 to fullSet.length do
					if Set1[k] < ∞
						sum1 ← sum1 + fullSet[k]
					else
						sum2 ← sum2 + fullSet[k]
				if sum1 = sum2
					output ← output + "{ "
					for k ← 0 to fullSet.length do
						if set1[k] < ∞
							output ← output + set1[k] + " "
					output ← output + "} { "
					for k ← 0 to fullSet.length do
						if set2[k] < ∞
							output ← output + set2[k] + " "
					output ← output + "}"
					return output
				sum1 ← 0
				sum2 ← 0
				for k ← 0 to fullSet.length do
				set1[k] ← ∞
				set2[k] ← ∞
output ← output + “none found”
return output
 */
public class Partition {
	public static void main(String[] args) 
	{
		Scanner Scan = new Scanner (System.in);
		int size = 0;
		int[] numbs;
		String input = "";
		System.out.println("Exampel:\nSize: 5\nNumbers\n2\n4\n6\n2\n10 \nSize: \"-1\" to quit");

		while(size > -1) 
		{
			try 
			{
				System.out.println();
				System.out.println("Input Size: ");
				size = Scan.nextInt();
				
				if(size > -1) 
				{
					System.out.println("Input Numbers: ");
					numbs = new int[size];
					for(int i = 0; i < size; i++) 
					{
						numbs[i] = Scan.nextInt();
					}
					System.out.println();
					System.out.println(Partition(numbs));
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
				System.out.println(e);
				
			}
			System.out.println();
		}
		Scan.close();
	}
	
	
	static String Partition(int [] fullSet)
	{
		int [] Set2 = new int[fullSet.length];
		int [] Set1 = new int[fullSet.length];
		int sum1 = 0;
		int sum2 = 0;
		String output = "Set size:\t\t\t" + fullSet.length + "\nintegers Integer values:\t";
		
		
		for (int i = 0;  i < fullSet.length;i++)
		{
			sum1 += fullSet[i];
		}

		
		for (int i = 0;  i < fullSet.length;i++)
		{
			output += fullSet[i] + " ";
		}
		output += "\nDisjoint subsets with same sum:\t";
		if(sum1 % 2 == 0) 
		{
			for (int k = 0; k < fullSet.length; k++) 
			{
				Set1[k] = Integer.MIN_VALUE;
				Set2[k] = Integer.MIN_VALUE;
			}
			
			
			for(int i = 0; i < fullSet.length; i++) 
			{		
				for(int j = 0; j < fullSet.length; j++) 
				{
					int addMore = j;
					for(int k = 0; k < fullSet.length; k++) 
					{
						if (k == i) 
						{
							Set1[k] = fullSet[k];
						}
						else if (addMore > 0) 
						{
							Set1[k] = fullSet[k];
							addMore--;
						}
						else 
						{
							Set2[k] = fullSet[k];
						}
					}
					
					for (int k = 0; k < fullSet.length; k++)
					{
						if (Set1[k] > Integer.MIN_VALUE) 
						{
							//System.out.println("1: " + Set1[k]);
							sum1 += fullSet[k];
						}
						else
						{
							//System.out.println("2: " + Set2[k]);
							sum2 += fullSet[k];
						}
					}
					//System.out.println(sum1 + ", " + sum2);			
					if (sum1 == sum2) 
					{
						output += "{ ";
						for (int k = 0; k < fullSet.length; k++) 
						{						
							if (Set1[k] > Integer.MIN_VALUE) 
							{
								output += Set1[k] + " ";
							}
						}
						output += "\b}\n\t\t\t\t{ ";		
						for (int k = 0; k < fullSet.length; k++) 
						{						
							if (Set2[k] > Integer.MIN_VALUE)
							{
								output += Set2[k] + " ";
							}
						}
						output += "\b}";
						return output;
					}
					sum1 = 0;
					sum2 = 0;
					for (int k = 0; k < fullSet.length; k++) 
					{
						Set1[k] = Integer.MIN_VALUE;
						Set2[k] = Integer.MIN_VALUE;
					}
				}
			}
		}
		output += "none found";
		return output;
	}

}
