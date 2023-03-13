import java.util.Scanner;

//Name: Milo Wilson
//Class: CS 4306/1
//Term: Spring 2022
//Instructor: Dr. Haddad
//Assignment: 6

/*
 * Sample 1 is the ideal scenario where each input is assigned to it's specific 
 * index instantly and is placed in those indexes. This results in in the lowest speeds
 * 
 * Sample 2 is another that is less ideal but not worst case. This one takes more comparisons 
 * because it has to do comparisons to see if the number is able to be put in the same 
 * place 
 * 
 * Sample 3 is about the worst case with the most comparisons because it has to go down 
 * the line whenever it needs to add a new element.
 * 
 * Sample 4 is theoretically the average case between the last three. Because it would 
 * most likely be somewhere between 2 and 3. It would not be as many comparisons as 3
 * because as long as two words started with a different letter it would, in most cases,
 * be less comparisons because you would use the key value to find a spot in the array 
 * to put one of those elements saving you one iteration down the chain.
 * 
 * Sample 5 seems closer to an actual case where it stores the data of many different 
 * words ant it would have the most comparisons probably because the sheer amount of 
 * values you have to deal with
 */
public class TestProgram {
	
	public static void main(String[] args) 
	{
		Scanner Scan = new Scanner (System.in);
		int action = 0;
		String str = "";
		DynamicHash<String, Integer> DH = new DynamicHash();
		while( action!= 5) 
		{
			try 
			{
				System.out.println("---------------MAIN MENU---------------\n" + 
						"1. Read input text\n" + 
						"2. Hash Input Text to Hash Table\n" + 
						"3. Display Words and Occurrences\n" + 
						"4. Display Efficiency Outputs\n" + 
						"5. Exit program\n" + 
						"\n" +
						"Enter option number:");
				action = Scan.nextInt();
				Scan.nextLine();
				if(action == 1) 
				{
					System.out.println("Input Text:");
					str = Scan.nextLine();
				}
				else if(action == 2) 
				{
					System.out.println("Inputiing to hash");
					//won't work with space for some reason
					String[] Inputs =  str.split(" ");
					//System.out.println(Inputs.length);					
					for (int i = 0; i < Inputs.length; i++) 
					{
						Integer x = DH.Get(Inputs[i]);
						if(x == null) { x = 0; }
						DH.Add(Inputs[i], (x + 1));
					}
					System.out.println("Done");					
				}
				else if(action == 3) 
				{
					System.out.println(DH.GetAll());
				}
				else if(action == 4) 
				{
					System.out.println("Sample test 1:\n" + 
							"Input values: " + str + "\n" + 
							"Inputs size: " + DH.size + " words\n" + 
							"Number of comparisons: " + DH.comparisons);
				}
				else if(action == 5) 
				{
					System.out.println("Thank You"); 
				}
				else
				{
					System.out.println("Try Again"); 
				}
			}catch(Exception e)
			{
				System.out.println("Error Try Again");
				System.out.println(e.toString());
			}
		}
	}
}
