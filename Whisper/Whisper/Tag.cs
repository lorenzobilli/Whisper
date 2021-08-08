namespace Whisper
{
	public class Tag : ITag
	{
		private string _tag;

		public string Content { get => _tag; private set => _tag = value; }

		public Tag(string content)
		{
			Content = content;
		}
	}
}
