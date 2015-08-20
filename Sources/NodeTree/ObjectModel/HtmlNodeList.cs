using System;
using System.Collections.Generic;

namespace NodeTree.ObjectModel
{
	public class HtmlNodeList : IHtmlRenderable, IEnumerable<HtmlNode>
	{
		private List<HtmlNode> nodes;

		public int Count
		{
			get
			{
				return this.nodes.Count;
			}
		}

		public HtmlNode this[int index]
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
			this.nodes = new List<HtmlNode>();
		}

		public HtmlNodeList Add(HtmlNode node)
		{
			this.nodes.Add(node);
			return this;
		}

		public HtmlNodeList Add(HtmlNode node, int index)
		{
			this.nodes.Insert(index, node);
			return this;
		}

		public HtmlNodeList Clear()
		{
			this.nodes.Clear();
			return this;
		}

		public bool Contains(HtmlNode node)
		{
			return this.nodes.Contains(node);
		}

		public int IndexOf(HtmlNode node)
		{
			return this.nodes.IndexOf(node);
		}

		public HtmlNodeList Remove(HtmlNode node)
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

		public IEnumerator<HtmlNode> GetEnumerator()
		{
			throw new NotImplementedException();
		}

		System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			throw new NotImplementedException();
		}
	}
}
