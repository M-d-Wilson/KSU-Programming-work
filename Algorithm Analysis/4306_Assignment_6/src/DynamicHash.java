import java.io.Console;
import java.util.ArrayList;

//Name: Milo Wilson
//Class: CS 4306/1
//Term: Spring 2022
//Instructor: Dr. Haddad
//Assignment: 6

public class DynamicHash<K, V>{
	
    private HashClass<K, V>[] WordList;
    int size, comparisons;
    
    DynamicHash()
    {
    	WordList = new HashClass[26];
    	for(int i =0; i < WordList.length; i++) 
    	{
    		WordList[i] = null;
    	}
    	size = 0;
    }
    
    public int GetSize() {return size;}
    
    public boolean IsEmpty() {return GetSize() == 0;}
    
    public final int GetKey(K key) 
    {
    	
    	//Gets array index
    	int i = ((int) key.toString().toLowerCase().charAt(0)) - 97;
    	return i;
    }
    
    public V Get(K key) 
    {
    	//gets value of the word given
    	//starts at the index
    	HashClass HC = WordList[GetKey(key)];
    	comparisons++;
    	//adds if the index is empty
    	if(HC == null) 
    	{
    		return null;
    	}

    	//counts the first
    	comparisons++;
    	//moves through the chain until it hits a similar input or the end
    	while(HC != null) 
    	{
    		//System.out.println(HC.key + ", " + key);
    		//returns value if at point on chain
    		if(HC.key.equals(key)) 
    		{
        		//System.out.println("Find Similar");
    			return (V) HC.val;
    		}
        	comparisons++;
    		//moves forward
    		HC = HC.next;
    	}

    	//skip comparisons increase because the loop would double count the first
    	//(math works out where it will increase correctly but is one ahead after the loop is done)
    	//returns zero if not found
    	if(HC == null) 
    	{
    		return null;
    	}
    	return (V) HC.val;
    }
    
    public boolean Remove(K key) 
    {
    	HashClass HC = WordList[GetKey(key)];
    	while( HC.next != null && HC.next.key != key) 
    	{
    		HC = HC.next;
    	}
    	
    	if(HC.key != key || HC.next == null) 
    	{
    		return false;
    	}else 
    	{
    		HC.next = HC.next.next;	
    		size--;
        	return true;
    	}
	}
    
    public boolean Add(K key, V val) 
    {
    	int x = GetKey(key);
    	HashClass HC = WordList[x];
    	comparisons++;
    	if(HC == null) 
    	{
    		size++;
    		System.out.println("Added new: " + key + ", " + val);
    		HC = new HashClass(key, val);
    		WordList[x] = HC;
    		return true;
    	}
    	
    	if(HC.key.equals(key)) 
    	{
    		System.out.println("Added to node: " + key + ", " + val);
    		HC.val =  val;
    		WordList[x] = HC;
    		return true;
    	}
    	
    	comparisons++;
    	while( HC.next != null) 
    	{
    		if(HC.key.equals(key)) 
        	{
        		System.out.println("Added to node: " + key + ", " + val);
        		HC.val =  val;
        		WordList[x] = HC;
        		return true;
        	}
        	comparisons++;
    		HC = HC.next;
    	}
    	//same logic as in the get function
    	comparisons--;
    	
		size++;
		System.out.println("Added to chain: " + key + ", " + val);
		HC.next = new HashClass(key, val);
		WordList[x] = HC;
		return true;
	}
    
    public String GetAll() 
    {
    	String str = "Key Word\tWord Count\n" + 
    			"--------------------------\n";
    	HashClass HC  = null;
    	for(int i = 0; i < WordList.length; i++) 
    	{
        	HC = WordList[i];
    		if(HC != null) 
    		{
        		//System.out.println(i);
    			while(HC != null) 
    			{
    	    		//System.out.println(HC.key.toString() + "\n");
    				str += HC.ToString() + "\n";
    				HC = HC.next;
    			}
    		}
    	}
    	return str;
    }
    
}
