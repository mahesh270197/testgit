using System; 

public class program
     {
	
      static int si(int a,int b,int c){
	int intrest=(a*b*c)/100;
	return intrest;

	} 


     public static void Main(String[]args){
	int a = Int32.Parse(args[0]);
	int b = Int32.Parse(args[1]);
	int c = Int32.Parse(args[2]);
	program obj = new program();
	int calintrest = program.si(a,b,c);
	Console.WriteLine("intrest is {0}",calintrest);
	
	





     }
}  