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

		public HtmlTag(string tagName) : this()
		{
			this.TagName = tagName;
		}

		public HtmlTag SetAttribute(string name, string value)
		{
			this.Attributes[name] = value;
			return this;
		}

		public HtmlTag RemoveAttribute(string name)
		{
			this.Attributes.Remove(name);
			return this;
		}

		public HtmlTag SetSelfClosing(bool isSelfClosing)
		{
			this.IsSelfClosing = isSelfClosing;
			return this;
		}

		public HtmlTag Prepend(IHtmlRenderable node)
		{
			throw new NotImplementedException();
		}

		public HtmlTag Append(IHtmlRenderable node)
		{
			this.ChildNodes.Add(node);
			return this;
		}

		public HtmlTag SetText(string text)
		{
			throw new NotImplementedException();
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

		public override string ToString()
		{
			var writer = new HtmlWriter();

			this.Render(writer);

			return writer.ToString();
		}
	}
}
