using System;

namespace First
{
	public class FirstClass
	{
		private string _name;
		public string Name 
		{ 
			get 
			{
				return _name;
			}	
			set
			{
				_name = value.Replace("1", "2");
			}
		}
		
		private bool _secretKey = false;
	
		public FirstClass()
		{
			// TODO
		}
		
		private bool IsGoodClass()
		{
			return true;
		}
		
		public string 
	}
	
	public class SecondClass
	{
		public SecondClass()
		{
			var test = new FirstClass();
			test.Name = "Name1";
		}
	}
}