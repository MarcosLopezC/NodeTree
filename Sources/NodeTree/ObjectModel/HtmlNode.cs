using System;
using System.Collections.Generic;
using NodeTree.Serialization;

namespace NodeTree.ObjectModel
{
	public abstract class HtmlNode : IHtmlRenderable, IEnumerable<HtmlNode>
	{
		public HtmlNodeType NoteType { get; protected set; }

		public abstract HtmlNodeList ChildNodes { get; set; }

		public abstract HtmlAttributeCollection Attributes { get; set; }

		public virtual HtmlNode AddChild(HtmlNode node)
		{
			if (this.ChildNodes != null)
			{
				this.ChildNodes.Add(node);
			}
			return this;
		}

		public virtual HtmlNode AddChild(HtmlNode node, int index)
		{
			if (this.ChildNodes != null)
			{
				this.ChildNodes.Add(node, index);
			}
			return this;
		}

		public abstract void Render(IHtmlWriter writer);

		public IEnumerator<HtmlNode> GetEnumerator()
		{
			return (this.ChildNodes == null)
				? System.Linq.Enumerable.Empty<HtmlNode>().GetEnumerator()
				: this.ChildNodes.GetEnumerator();
		}

		System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}
	}
}
