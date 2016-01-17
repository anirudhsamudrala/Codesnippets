using System;

//Delegate Definition
public delegate void PrintDelegate(string str);

public class DelegateExample
 {
     //Method that will be invoked by the delegate
     public static void PrintString(string str)
     {     
		 Console.WriteLine(str); 
	   }
     public static void Main()
     {
        //Instantiating the Delegate by passing PrintString function
        PrintDelegate del = new PrintDelegate(PrintString);
        //PrintDelegate.Invoke is called here
        del("PrintDelegate Invoked");
     }
}