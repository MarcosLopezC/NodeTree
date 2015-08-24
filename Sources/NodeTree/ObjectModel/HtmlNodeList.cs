using System;
using System.Collections.Generic;
using NodeTree.Serialization;

namespace NodeTree.ObjectModel
{
	public class HtmlNodeList : IHtmlRenderable, IEnumerable<IHtmlNode>
	{
		private List<IHtmlNode> nodes;

		public int Count
		{
			get
			{
				return this.nodes.Count;
			}
		}

		public IHtmlNode this[int index]
		{
			get
			{
				return this.nodes[index];
			}
			set
			{
				this.nodes[index] = value;
			}
		}

		public HtmlNodeList()
		{
			this.nodes = new List<IHtmlNode>();
		}

		public HtmlNodeList Add(IHtmlNode node)
		{
			this.nodes.Add(node);
			return this;
		}

		public HtmlNodeList Add(IHtmlNode node, int index)
		{
			this.nodes.Insert(index, node);
			return this;
		}

		public HtmlNodeList Clear()
		{
			this.nodes.Clear();
			return this;
		}

		public bool Contains(IHtmlNode node)
		{
			return this.nodes.Contains(node);
		}

		public int IndexOf(IHtmlNode node)
		{
			return this.nodes.IndexOf(node);
		}

		public HtmlNodeList Remove(IHtmlNode node)
		{
			this.nodes.Remove(node);
			return this;
		}

		public HtmlNodeList Remove(int index)
		{
			this.nodes.RemoveAt(index);
			return this;
		}

		public void Render(IHtmlWriter writer)
		{
			throw new NotImplementedException();
		}

		public IEnumerator<IHtmlNode> GetEnumerator()
		{
			throw new NotImplementedException();
		}

		System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			throw new NotImplementedException();
		}
	}
}
