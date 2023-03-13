import java.util.Scanner;
import javax.swing.Spring;

// Name: Milo Wilson
// Class: CS 4306/1
// Term: Spring 2022
// Instructor: Dr. Haddad
// Assignment: 3

/* (A)
 * int FakeCoin2(int arr[0… n-1])	
 * 	if n = 1
 * 		Return 0
 * 	arr1 ← int[n/3]
 * 	arr2 ← int[n/3]
 * 	arr3 ← int[n/3]
 * 	if n % 3 = 2
 * 		arr1 ← int[n/3 + 1]
 * 		arr2 ← int[n/3 + 1]
 * 	else if n % 1
 * 		arr3 ← int[n/3 + 1]
 * 	sum1 ← 0
 * 	sum2 ← 0
 * 	for i ← 0 to n − 1 do 
 * 		if i < n/3
 * 			arr1[i] ← arr[i]
 * 			sum1 ← sum1 + arr[i]
 * 		else if i < ((n / 3) + (n / 3))
 * 			arr2[i - n/3] ← arr[i]
 * 			sum1 ← sum1 + arr[i]
 * 		else
 * 			Arr3[i - (n/3 + n/3)] ← arr[i]
 * 	if sum1 = sum 2 
 * 		dev ← dev + 1
 * 		return FakeCoin2(Arr3) + (Arr2.length + Arr1.length)
 * 	else if sum1 > sum2 
 * 		dev ← dev + 1
 * 		return FakeCoin2(Arr2) + (Arr1.length)
 * 	else 
 * 		dev ← dev + 1
 * 		return FakeCoin2(Arr1)
 */

/* (B)		
 * F(n)		|	
 * n > 1 	|	(lengths of sections before divided section)  + F(divided section)
 * n = 1	|	0
 */

/* (C)
 * It is about 1/6th times faster, because of the devisions by 3. 
 */

public class FakeCoin2 {
	static int devisions = 0, numb = 0;
	static int[] arr = {5, 5, 5, 5, 5, 5, 2, 5, 5, 5};
	
	public static void main(String[] args) 
	{
		Scanner Scan = new Scanner (System.in);
		int action = 0;
		while( action!= 4) 
		{
			try 
			{
				System.out.println();
				System.out.println("-----------------MAIN MENU---------------------------\n" + 
						"1. Read number of coins (array size)\n" + 
						"2. Read array values (all values are 5 except one value 2)\n" + 
						"3. Run algorithm and display results\n" + 
						"4. Exit program");
				action = Scan.nextInt();
				
				if(action == 1) 
				{
					System.out.println("Enter array size"); 
					ChangeArraySize(Scan.nextInt());
					
				}
				else if(action == 2) 
				{
					System.out.println("Enter array values"); 
					ChangeArrayElements();
				}
				else if(action == 3) 
				{
					System.out.println(RunFakeCoin(arr));
				}
				else if(action == 4) 
				{
					
				}
				else
				{
					System.out.println("Try Again"); 

				}
			}
			catch (Exception e) 
			{
				Scan.nextLine();
				System.out.println();
				System.out.println(e + "Try again");
			}
		}
	}
	
	public static void ChangeArraySize(int x) 
	{
		arr = new int[x];
	}
	
	public static void ChangeArrayElements() 
	{
		Scanner Scan = new Scanner (System.in);
		int[] newArr = arr;
		for(int i = 0; i < newArr.length; i++) 
		{
			newArr[i] = Scan.nextInt();
		}
	}

	public static String RunFakeCoin(int[] newArr) 
	{
		devisions = 0;
		String output = "Array size:\t\t" + newArr.length + " \n" + 
				"Array values:\t\t";
		for(int i = 0; i < arr.length; i ++) 
		{
			output += arr[i] + " ";
		}
		int x = FakeCoin2(newArr);
		output += "\n# of divisions:\t\t" + devisions + "\n" + 
				"Fake coin index:\t" + x;
		
		return output;
	}
	
	public static int FakeCoin2(int[] newArr) 
	{
		int n = newArr.length;
		if(n == 1) 
		{
			return 0;
		}
		int[] arr1 = new int[n/3];
		int[] arr2 = new int[n/3];
		int[] arr3 = new int[n/3];
		
		if((n % 3 == 1)) {
			arr1 = new int[n/3];
			arr2 = new int[n/3];
			arr3 = new int[n/3 + 1];
		}
        if ((n % 3 == 2))
        {
			arr1 = new int[n/3 + 1];
			arr2 = new int[n/3 + 1];
			arr3 = new int[n/3];
        }
        int sum1 = 0;
        int sum2 = 0;
        for(int i = 0; i < n; i++) 
        {
        	if (i < arr1.length) 
        	{
        		arr1[i] = newArr[i];
        		sum1 += newArr[i];
        	}
        	else if( i < (arr1.length + arr2.length)) 
        	{
        		arr2[i - arr1.length] = newArr[i];
        		sum2 += newArr[i];
        	}
        	else 
        	{
        		arr3[i - arr1.length - arr2.length] = newArr[i];
        	}
        }
        if(sum1 == sum2) 
        {
        	devisions++;
        	return FakeCoin2(arr3) + (arr1.length + arr2.length);
        }
        else if (sum1 > sum2) 
        {
        	devisions++;
        	return FakeCoin2(arr2) + (arr1.length);
        }
        else if (sum1 < sum2)
        {
        	devisions++;
        	return FakeCoin2(arr1);
        }
        return 0;
	}
}
