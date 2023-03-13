// Name: Milo Wilson
// Class: CS 4306/1
// Term: Spring 2022
// Instructor: Dr. Haddad
// Assignment: 1

/*
DecimalToBinary (Numb)
//Make the binary of a given number
//Input: An integer
//Output: A string with the the binary of the number and the number of comparisons the
//	program made
	ToReturn ← “Output Binary Value:\t”
	Binary ← “”
	Divisions ← 0
	if Numb < 0
		ToReturn ← ToReturn + “Unable to binary”
		return ToReturn
	else
		x ← 1
		
		while Numb >= x do x ← x * 2
		while x >= 2 do
			if Numb >= x
				Numb ← Numb - x
				Binary ← Binary + "1"
			else
				Binary ← Binary + "0"
			Divisions ← Divisions + 1
			x ← x / 2
		if Numb = 0 
			Divisions ← Divisions + 1
			Binary ← Binary + "0"
		else
			Divisions ← Divisions + 1
			Binary ← Binary + "1"			
		ToReturn ← ToReturn + Binary + “\nDivisions:\t” + Divisions
return ToReturn
*/
import java.io.Console;
import java.util.Scanner;

public class Problem_2 
{
	public static void main(String[] args) 
	{
		Scanner Scan = new Scanner (System.in);
		//Test Code
		int numb = 0;
		try 
		{
			System.out.println("Exampel:\"14\" \nDecimal value:\t");
			numb = Scan.nextInt();
			System.out.println(DecimalToBinary(numb));
		}
		catch(Exception e)
		{
			System.out.println("Incorrect input");
		}
	}
	
	public static String DecimalToBinary(int numb) 
	{
		//Input: number to be turned into binary
		//Makes a string with the binary values and how may comparisons are made 
		String toReturn = "Binary Value:\t";
		String binary = "";
		int divisions = 0;
		
		if (numb < 0) 
		{
			toReturn += "Unable to binary";
			return toReturn;
		} 
		else
		{
			int x = 1;
			
			while(numb >= x) 
			{
				x *= 2;
			}
			
			while(x >= 2) 
			{
				if(numb >= x) 
				{
					numb -= x;
					binary += "1";
				}
				else 
				{
					binary += "0";
				}
				divisions++;	
				x /= 2;
			}
			
			if(numb == 0) 
			{
				divisions++;
				binary += "0";	
			}else if (numb == 1)
			{
				divisions++;
				binary += "1";				
			
			}
			toReturn += binary + "\nDivisions:\t" + divisions;
		}
		return toReturn;
	}
}