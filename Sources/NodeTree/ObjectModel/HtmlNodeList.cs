using System;
using System.Collections;
using System.Collections.Generic;
using NodeTree.Serialization;

namespace NodeTree.ObjectModel
{
	public class HtmlNodeList : IHtmlRenderable, IEnumerable<IHtmlRenderable>
	{
		private List<IHtmlRenderable> nodes;

		public IHtmlRenderable this[int index]
		{
			get
			{
				return nodes[index];
			}
			set
			{
				nodes[index] = value;
			}
		}

		public int Count
		{
			get
			{
				return this.nodes.Count;
			}
		}

		public HtmlNodeList()
		{
			this.nodes = new List<IHtmlRenderable>();
		}

		public void Add(IHtmlRenderable node)
		{
			if (node == null)
			{
				throw new ArgumentNullException("node");
			}

			this.nodes.Add(node);
		}

		public void Clear()
		{
			this.nodes.Clear();
		}

		public bool Remove(int index)
		{
			if ((index >= 0) && (index < this.Count))
			{
				this.nodes.RemoveAt(index);
				return true;
			}
			else
			{
				return false;
			}
		}

		public bool Remove(IHtmlRenderable node)
		{
			return this.nodes.Remove(node);
		}

		public void Render(HtmlWriter writer)
		{
			foreach (var node in this.nodes)
			{
				node.Render(writer);
			}
		}

		public IEnumerator<IHtmlRenderable> GetEnumerator()
		{
			return this.nodes.GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}
	}
}
