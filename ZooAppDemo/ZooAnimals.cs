using System;
using System.Collections.Generic;
using System.Text;
using ZooLib.NewFolder;

namespace ZooAppDemo
{
	public class ZooAnimals
	{
		private List<Animal> _animals;

		public ZooAnimals()
		{ 
		_animals = new List<Animal>();
		}

		public ZooAnimals(List<Animal> animals)
		{
			_animals = animals;
		}

		public List<Animal> Animals
		{
			get { return _animals; }
			set { _animals = value; }
		}

		public override string ToString()
		{
			string animals = "[";
			foreach (Animal animal in _animals) 
			{
				animals = animals + "\n" + animal;
			}

			animals = animals + "]";

			return animals;
		}

		public void Add(Animal a)
		{
			_animals.Add(a);
		}

		public List<Animal> ListAll()
		{
			return new List<Animal>(_animals);
		}

	}
}
