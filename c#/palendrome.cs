using System;
public class fibonacci{

	public static void Main(){
		int sum = 0;
		int b = 1;
		int a = 0;
		for(int i = 0;i<=10;++i)
		{
		  sum = a + b;
		 
		 Console.WriteLine(sum+" ");
		  a = b;
		  b = sum;
		  
			
		}
		  
		}
}



	