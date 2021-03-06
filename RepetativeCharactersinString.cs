//Find the repetative characters in a string in C# , without using hashmap
using System;
using System.Collections.Generic;
					
public class Program
{
	public static void Main()
	{
		//Read the string from the console
	       	string str = Console.ReadLine();
		//Create a dictionary object to hold the name value pairs
            Dictionary<Char, int> dict = new Dictionary<Char, int>();
            for (int i = 0; i < str.Length; i++)
            {
                char c = str[i];
				//Check if the key is present , if true incremant the key value , if not go to else and add the key 
                if (dict.ContainsKey(c))
                {
                    int val = 0;
                    dict.TryGetValue(c, out val);
                    int cnt = ++val;
                    dict[c] = cnt;
                }
                else
                {
                    dict.Add(c, 1);
                }
            }
          //iterate through the key value pairs and read it 
            foreach (KeyValuePair<Char, int> b in dict)
            {
                Console.WriteLine("{0}, {1}", b.Key, b.Value);
            }
	}
}