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
			if (!this.Text.StartsWith(">") &&
				!this.Text.StartsWith("->") &&
				!this.Text.Contains("--"))
			{
				writer.Write("<!-- ");
				writer.Write(this.Text);
				writer.Write(" -->");
			}
		}

		public override string ToString()
		{
			return this.Text;
		}
	}
}
