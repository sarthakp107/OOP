using System;
namespace CounterTask
{
	public class Counter
	{
		//instance variable to know its count
		private int _count;
		//instance v to know the name
		private string _name;

		//constructor 
		public Counter(string name)
		{
			_count = 0;
			_name = name;
		}
		public void Increment()
		{
			_count++;
		}
		public void Reset()
		{
			_count = 0;
		}

		//property
		public string Name
		{
			get
			{
				return _name; 
			}
			set
			{
				_name = value;
			}
		}
		public int Ticks
		{
			get
			{
				return _count;
			}
		}
	}
}

