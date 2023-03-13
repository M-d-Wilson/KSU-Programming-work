// Name: Milo Wilson
// Class: CS 4306/1
// Term: Spring 2022
// Instructor: Dr. Haddad
// Assignment: 4
import java.util.Arrays;
import java.util.Random;
import java.util.Scanner;

public class TestIS {
	public int tableSize;
	public int[] Values;
	
	public TestIS()
	{
		Values = new int [1024];
		int dataLength = 1;
	    for(int i = 0; i < Values.length; i++) 
	    {
	    	Values[i] = 1;
	    }
	}
	
	
	public void RandomDistinct()
	{
		//Fills Values with new random integers that are unique
		//Input: none
		//Output: fill Values with distinct random integers
	    Random rand = new Random();
	    int[] randNumbs = new int[9999];
	    
	    for(int i = 0; i < randNumbs.length; i++) 
	    {
	    	randNumbs[i] = i + 1;
	    }
	    
		for(int i = 0; i < 1024; i++) 
		{
			int j = rand.nextInt(9999);
			
			while(randNumbs[j] == 0) 
			{
				j = rand.nextInt(9999);
			}
			Values[i] = randNumbs[j];
			randNumbs[j] = 0;
		}
		Arrays.sort(Values);
		String ster = "";
		
		for(int j = 0; j < 1024; j++) 
		{
			ster +=  "" + Values[j] + " ";
			if((j + 1) % 30 == 0) 
			{
				ster += "\n";
			}
		}
		System.out.println(ster);
		
	}
	
	public void RunIS()
	{
		//Runs interpolation search on Values x time (x = tableSize)
		//Input: none
		//Output: The key, if the integer was found, the index of the integer (if not found -1), 
		//			and how many divisions it took to find or not find the value
		int[] toAvg = new int[tableSize];
		double avrage = 0;
	    Random rand = new Random();
		System.out.println("Key\tFound\tIndex\tDivisions\n" + 
				"-------------------------------------------");
		for(int i = 0; i < tableSize; i++) 
		{
			InterpolationSearch IS = new InterpolationSearch(Values, rand.nextInt(9999) + 1);
			System.out.println(IS.ToString());
			toAvg[i] = IS.divisions;
		}
		
		for(int i = 0; i < tableSize; i++) avrage += toAvg[i];
		
		avrage /= tableSize;
		
		System.out.println("Divisions average: \t" + avrage +"\n" 
		+ "Difference:\t" + ( 3.322 - avrage) );
	}
	
	public static void main(String[] args) 
	{
		Scanner Scan = new Scanner (System.in);
		TestIS TIS = new TestIS();
		int action = 0;
		while( action!= 4) 
		{
			try 
			{
				System.out.println(" ---------------MAIN MENU---------------\n" + 
						"1. Create and display array Values[]\n" + 
						"2. Read output table size\n" + 
						"3. Run algorithm and display outputs\n" + 
						"4. Exit program");
				action = Scan.nextInt();
	
				if(action == 1) 
				{
					System.out.println("New Array:");
					TIS.RandomDistinct();
				}
				else if(action == 2) 
				{
					System.out.println("Enter Table Size:");
					TIS.tableSize = Scan.nextInt();
					
				}
				else if(action == 3) 
				{
					TIS.RunIS();
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

}
