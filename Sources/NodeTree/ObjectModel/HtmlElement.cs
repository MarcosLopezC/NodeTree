using System;
using NodeTree.Serialization;

namespace NodeTree.ObjectModel
{
	public sealed class HtmlElement : IHtmlNode
	{
		public string TagName { get; set; }

		public HtmlNodeType NodeType
		{
			get
			{
				return HtmlNodeType.Element;
			}
		}

		public HtmlAttributeCollection Attributes { get; private set; }

		public HtmlNodeList ChildNodes { get; private set; }

		public HtmlElement()
		{
			this.Attributes = new HtmlAttributeCollection();
			this.ChildNodes = new HtmlNodeList();
		}

		public void Render(IHtmlWriter writer)
		{

		}
	}
}
