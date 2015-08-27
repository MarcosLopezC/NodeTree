using System;
using System.Collections.Generic;
using NodeTree.Serialization;

namespace NodeTree.ObjectModel
{
	public class HtmlTag : IHtmlRenderable
	{
		public string TagName { get; set; }

		public bool IsSelfClosing { get; set; }

		public HtmlAttributeCollection Attributes { get; protected set; }

		public HtmlNodeList ChildNodes { get; protected set; }

		public HtmlTag()
		{
			this.Attributes = new HtmlAttributeCollection();
			this.ChildNodes = new HtmlNodeList();
		}

		public void Render(HtmlWriter writer)
		{
			writer.WriteOpeningTag(this.TagName);

			this.Attributes.Render(writer);

			if (this.IsSelfClosing)
			{
				writer.WriteSelfClosingTagEnd();
			}
			else
			{
				writer.WriteOpeningTagEnd();
				writer.WriteLine();

				this.ChildNodes.Render(writer);

				writer.WriteClosingTag(this.TagName);
				writer.WriteLine();
			}
		}
	}
}
