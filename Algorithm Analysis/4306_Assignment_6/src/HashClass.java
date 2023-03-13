
//Name: Milo Wilson
//Class: CS 4306/1
//Term: Spring 2022
//Instructor: Dr. Haddad
//Assignment: 6

public class HashClass<K, V>  {
	K key;
	V val;
	
	HashClass<K, V> next;
	
	public HashClass(K k, V v) 
	{
		key = k;
		val = v;
		next = null;
	}
	
	public HashClass(K k, V v, HashClass HC) 
	{
		key = k;
		val = v;
		next = HC;
	}
	
	public V getValue() {
		return val;
	}
	
	public String ToString() 
	{
		String str = key + "\t\t" + val;
		return str;
		
	}
}
