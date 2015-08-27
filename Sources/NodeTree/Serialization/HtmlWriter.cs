using System;
using System.Collections.Generic;
using System.Text;

namespace NodeTree.Serialization
{
	public class HtmlWriter
	{
		protected StringBuilder stringBuilder;

		public HtmlWriter()
			: this(new StringBuilder(8192)) { }

		public HtmlWriter(StringBuilder stringBuilder)
		{
			if (stringBuilder == null)
			{
				throw new ArgumentNullException("stringBuilder");
			}

			this.stringBuilder = stringBuilder;
		}

		public void Write(string text)
		{
			if (text != null)
			{
				this.stringBuilder.Append(text);
			}
		}

		public void WriteEncoded(string text)
		{
			Write(EncodeText(text));
		}

		public void WriteLine()
		{
			WriteLine(null);
		}

		public void WriteLine(string text)
		{
			Write(text);
			Write("\n");
		}

		public void WriteLineEncoded(string text)
		{
			WriteLine(EncodeText(text));
		}

		public void WriteOpeningTag(string tagName)
		{
			Write("<");
			Write(tagName);
		}

		public void WriteOpeningTagEnd()
		{
			Write(">");
		}

		public void WriteSelfClosingTagEnd()
		{
			Write("/>");
		}

		public void WriteClosingTag(string tagName)
		{
			Write("</");
			Write(tagName);
			Write(">");
		}

		public void WriteAttribute(string name, string value)
		{
			Write(" ");
			Write(name);
			Write("=\"");
			Write(EncodeText(value));
			Write("\"");
		}

		public void Clear()
		{
			this.stringBuilder.Length = 0;
		}

		public override string ToString()
		{
			return this.stringBuilder.ToString();
		}

		public static string EncodeText(string text)
		{
			return new StringBuilder(text)
				.Replace("&",  "&amp;")
				.Replace("<",  "&lt;")
				.Replace(">",  "&gt;")
				.Replace("\"", "&quot;")
				.Replace("'",  "&#x27;")
				.Replace("/",  "&#x2F")
				.ToString();
		}

		protected struct TagData
		{
			public string tagName;
			public int indent;
		}

		protected struct HtmlAttribute
		{
			public string Name { get; private set; }
			public string Value { get; private set; }

			public HtmlAttribute(string name, string value) : this()
			{
				this.Name = name;
				this.Value = value;
			}
		}
	}
}
