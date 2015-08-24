using System;
using NodeTree.Serialization;

namespace NodeTree.ObjectModel
{
	public abstract class HtmlNode : IHtmlRenderable
	{
		public HtmlNodeType NodeType { get; private set; }

		public void Render(IHtmlWriter writer);
	}
}
