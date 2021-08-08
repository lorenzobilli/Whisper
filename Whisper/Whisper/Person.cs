using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Whisper
{
	public class Person : IPerson
	{
		public string? Name { get; set; }

		public string? Surname { get; set; }

		public int? Age { get; }

		public Person(string? name, string? surname)
		{
			Name = name;
			Surname = surname;
		}
	}
}
