using System;
using System.Collections.Generic;
using System.Text;

namespace NodeTree.Serialization
{
	public class HtmlWriter
	{
		protected StringBuilder stringBuilder;

		public HtmlWriter()
			: this(new StringBuilder()) { }

		public HtmlWriter(StringBuilder stringBuilder)
		{
			if (stringBuilder == null)
			{
				throw new ArgumentNullException("stringBuilder");
			}

			this.stringBuilder = stringBuilder;
		}

		public void Write(char character)
		{
			this.stringBuilder.Append(character);
		}

		public void Write(string text)
		{
			if (text != null)
			{
				this.stringBuilder.Append(text);
			}
		}

		public void WriteEncoded(char character)
		{
			switch (character)
			{
				case '&':  Write("&amp;");   break;
				case '<':  Write("&lt;");    break;
				case '>':  Write("&gt;");    break;
				case '"':  Write("&quot;");  break;
				case '\'': Write("&#x27;");  break;

				default:   Write(character); break;
			}
		}

		public void WriteEncoded(string text)
		{
			for (var i = 0; i < text.Length; i += 1)
			{
				WriteEncoded(text[i]);
			}
		}

		public void WriteEncodedTrimSpaces(string text)
		{
			var start = 0;

			// Skip any leading spaces.
			while (start < text.Length && text[start] == ' ')
			{
				start += 1;
			}

			var end = text.Length - 1;

			// Skip any trailing spaces.
			while (end > start && text[end] == ' ')
			{
				end -= 1;
			}

			for (var i = start; i <= end; i += 1)
			{
				if (text[i] == ' ')
				{
					while (i < end && text[i + 1] == ' ')
					{
						i += 1;
					}

					Write(' ');
				}
				else
				{
					Write(text[i]);
				}
			}
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
			WriteEncoded(text);
			WriteLine();
		}

		public void WriteLineEncodedTrimSpaces(string text)
		{
			WriteEncodedTrimSpaces(text);
			WriteLine();
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
			WriteEncodedTrimSpaces(value);
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
	}
}
