using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Whisper
{
	public class Rumor : IRumor
	{
		public static int LastId;

		private int id;

		private List<IPerson> people;

		private List<ITag> tags;

		private string content;

		public int Id => id;

		public List<IPerson> People => people;

		public List<ITag> Tags => tags;

		public string Content => content;

		public Rumor(string content)
		{
			this.content = content;
			id = ++LastId;
		}
	}
}
