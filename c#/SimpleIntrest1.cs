using System;
public delegate int sidelegate(int x,int y,int z);
 class program1{


	public int si(int a,int b,int c){
		int  result =(a*b*c)/100;
		return result;	

		}
		public static void Main(String[] args){
			program1 obj = new program1();
			sidelegate del =new sidelegate(obj.si);
	 		int intrest = del.Invoke(1000,5,3);
			Console.WriteLine($"intrests is {intrest}");
	}

}