using System;
using System.Collections.Generic;
using NodeTree.Serialization;

namespace NodeTree.ObjectModel
{
	public class HtmlText : IHtmlRenderable
	{
		public string Text { get; private set; }

		public HtmlText(string text)
		{
			this.Text = text;
		}

		public void Render(HtmlWriter writer)
		{
			writer.WriteLineEncodedTrimSpaces(this.Text);
		}

		public override string ToString()
		{
			return this.Text;
		}
	}
}
