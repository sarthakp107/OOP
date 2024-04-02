using System;
//id : 104817068
namespace HelloWorld
{
	public class Message
	{
		// instance variable  _text: declar4ed outside of the constructor
		private string _text; //why private? //other class cannot use it directly

		//constructor
		 public Message(string text)
		{
			_text = text;
		}

		//addidng print method

		public void Print()
		{
			Console.WriteLine(_text);
		}
	}
}

