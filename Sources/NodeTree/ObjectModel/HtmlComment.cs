using System;
using System.Collections.Generic;
using NodeTree.Serialization;

namespace NodeTree.ObjectModel
{
	public class HtmlComment : IHtmlRenderable
	{
		public string Text { get; set; }

		public HtmlComment(string text)
		{
			this.Text = text;
		}

		public void Render(HtmlWriter writer)
		{
			writer.Write("<!-- ");

			var start = 0;

			if (this.Text.StartsWith(">"))
			{
				start = 1;
			}
			else if (this.Text.StartsWith("->"))
			{
				start = 2;
			}

			if (this.Text[start] != '-')
			{
				writer.Write(this.Text[start]);
			}

			for (var i = start + 1; i < this.Text.Length; i += 1)
			{
				if (this.Text[i] != '-' || this.Text[i - 1] != '-')
				{
					writer.Write(this.Text[i]);
				}
			}

			writer.WriteLine(" -->");
		}

		public override string ToString()
		{
			return this.Text;
		}
	}
}
