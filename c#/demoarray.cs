using System;
	public class array{
		public bool search(int [] a,int key){
			for(int i= 0;i<a.Length;i++)
			{
			 if(a[i] == key)
			 return true;
			 else
			 return false;
			}



			}
	public static void Main(String[] args){
		int[] b = {1,2,3,4,5};
		int value = 4;
		array obj = new array();
		 bool a = obj.search(b,value);
		
			if(a == true)
			Console.WriteLine("key found");
			


		}

}
	