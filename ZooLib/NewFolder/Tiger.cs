using System;
using System.Collections.Generic;
using System.Text;

namespace ZooLib.NewFolder
{
	public class Tiger : Animal
	{
		//instance felter


		public Tiger() { }

		public Tiger(string name, string gender) : base (name, gender)
		{ }

		public override string ToString()
		{
			return base.ToString();
		}

		public override string Eat()
		{
			return "Tigeren spiser kun Pandaer";
		}

	}
}
