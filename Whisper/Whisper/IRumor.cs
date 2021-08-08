using System.Collections.Generic;

namespace Whisper
{
	public interface IRumor
	{
		public int Id { get; }

		public List<IPerson> People { get; }

		public List<ITag> Tags { get; }

		public string Content { get; }
	}
}
