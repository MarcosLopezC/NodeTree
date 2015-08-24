using System;
using NodeTree.Serialization;

namespace NodeTree.ObjectModel
{
	public interface IHtmlNode : IHtmlRenderable
	{
		HtmlNodeType NodeType { get; }

		HtmlNodeList ChildNodes { get; }

		HtmlAttributeCollection Attributes { get; }
	}
}
