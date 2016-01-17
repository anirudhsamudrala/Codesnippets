using System;
//This snippet is an example to reverse the string using string reverse inbuilt funtion					
public class Program
{
	public static void Main()
	{
		
		string i= "I am Anirudh Samudrala";
    string[] tokens = i.Split(' ');
		foreach(string s in tokens)
		{
			char[] arr=s.ToCharArray();
			Array.Reverse(arr);
			String output=new String(arr);
		  Console.WriteLine(output);
		}
			
	}
}