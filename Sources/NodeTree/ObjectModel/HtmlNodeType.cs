using System;
using NodeTree.Serialization;

namespace NodeTree.ObjectModel
{
	public enum HtmlNodeType
	{
		RenderableObject = 0,
		Element,
		Text,
		Comment,
		Document,
		DocumentType,
		DocumentFragment,
	}
}
