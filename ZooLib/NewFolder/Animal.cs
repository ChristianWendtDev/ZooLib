using System;
using System.Collections.Generic;
using System.Text;

namespace ZooLib.NewFolder
{
	public class Animal
	{
		
		private string _name;
		private string _gender;
			

		public Animal(string name, string gender)
		{
			_name = name;
			_gender = gender;
		}

		public Animal ()
		{
			_name = " ";
			_gender = " ";
		}
		
		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}
		public string Gender
		{
			get{ return _gender; }
			set { _gender = value; }
		}

		public override string ToString()
		{
			return "name= " + Name + " " + "gender= " + Gender;
		}

		public virtual string Eat()
		{
			return "dyret spiser alt muligt";
		}


	}
}
