using System;
using System.Collections.Generic;
using NodeTree.Serialization;

namespace NodeTree.ObjectModel
{
	public class HtmlNodeList : IHtmlRenderable, IEnumerable<HtmlNode>
	{
		private List<HtmlNode> nodeList;

		public int Count
		{
			get
			{
				return this.nodeList.Count;
			}
		}

		public HtmlNode this[int index]
		{
			get
			{
				return ((index >= 0) && (index < this.nodeList.Count))
					? this.nodeList[index]
					: null;
			}
		}

		public HtmlNodeList()
		{
			this.nodeList = new List<HtmlNode>();
		}

		public HtmlNodeList Add(HtmlNode node)
		{
			this.nodeList.Add(node);
			return this;
		}

		public HtmlNodeList Add(HtmlNodeList list)
		{
			this.nodeList.AddRange(list);
			return this;
		}

		public HtmlNodeList Add(HtmlNode node, int index)
		{
			this.nodeList.Insert(ContrainIndex(index), node);
			return this;
		}

		public HtmlNodeList Add(HtmlNodeList list, int index)
		{
			this.nodeList.InsertRange(ContrainIndex(index), list);
			return this;
		}

		public bool Contains(HtmlNode node)
		{
			return this.nodeList.Contains(node);
		}

		public HtmlNodeList Remove(int index)
		{
			this.nodeList.RemoveAt(index);
			return this;
		}

		public HtmlNodeList Remove(HtmlNode node)
		{
			this.nodeList.Remove(node);
			return this;
		}

		public HtmlNodeList Remove(HtmlNodeList list)
		{
			foreach (var node in list)
			{
				Remove(node);
			}

			return this;
		}

		public IEnumerator<HtmlNode> GetEnumerator()
		{
			throw new NotImplementedException();
		}

		System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			throw new NotImplementedException();
		}

		protected int ContrainIndex(int index)
		{
			return Math.Min(Math.Max(0, index), this.Count);
		}
	}
}
