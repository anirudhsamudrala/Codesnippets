using System;
//This program is an example to reverse a string without using inbuilt string reverse funtion
class stringfunction
{
	public string ReverseString(string sz)
	{
    string result = string.Empty;
    for(int i = sz.Length-1; i>=0; i--)
    {
      result += sz[i];
    }
    return result;
	}
}
					
public class Program
{
	public static void Main()
	{
		stringfunction obj = new stringfunction();
		string str=obj.ReverseString("Anirudh");
		Console.WriteLine(str);
	}
}