using System;
using System.Collections.Generic;
using NodeTree.Serialization;

namespace NodeTree.ObjectModel
{
	public class HtmlAttributeCollection : IHtmlRenderable, IEnumerable<KeyValuePair<string, string>>
	{
		private Dictionary<string, string> attributes;

		public string this[string name]
		{
			get
			{
				string value;
				return (this.attributes.TryGetValue(name, out value))
					? value
					: null;
			}
			set
			{
				this.attributes[name] = value;
			}
		}

		public int Count
		{
			get
			{
				return this.attributes.Count;
			}
		}

		public HtmlAttributeCollection()
		{
			this.attributes = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
		}

		public bool Contains(string name)
		{
			return this.attributes.ContainsKey(name);
		}

		public bool Remove(string name)
		{
			return this.attributes.Remove(name);
		}

		public void Clear()
		{
			this.attributes.Clear();
		}

		public void Render(IHtmlWriter writer)
		{
			throw new NotImplementedException();
		}

		public IEnumerator<KeyValuePair<string, string>> GetEnumerator()
		{
			return this.attributes.GetEnumerator();
		}

		System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}
	}
}
