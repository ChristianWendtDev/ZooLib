using System;
using System.Collections.Generic;
using System.Text;

namespace ZooLib.NewFolder
{
	public class Panda : Animal
	{
		//instance felter?


		public Panda() : base () 
		{
			
		}

		public Panda(string name, string gender) : base(name, gender)
		{

		}

		public override string ToString()
		{
			return base.ToString();
		}

		public override string Eat()
		{
			return "Pandaer spiser kun bambus";
		}
			
		

	}
}
