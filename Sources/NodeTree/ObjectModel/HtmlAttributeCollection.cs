using System;
using System.Collections.Generic;
using NodeTree.Serialization;

namespace NodeTree.ObjectModel
{
	public class HtmlAttributeCollection : IHtmlRenderable, IEnumerable<KeyValuePair<string, string>>
	{
		private Dictionary<string, string> attributes;

		public int Count
		{
			get
			{
				return this.attributes.Count;
			}
		}

		public string this[string name]
		{
			get
			{
				string value;
				return (this.attributes.TryGetValue(name, out value))
					? value
					: null;
			}
		}

		public HtmlAttributeCollection()
		{
			this.attributes = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
		}

		public HtmlAttributeCollection Set(string name)
		{
			return Set(name, null);
		}

		public HtmlAttributeCollection Set(string name, string value)
		{
			this.attributes.Add(name, value);
			return this;
		}

		public bool Contains(string name)
		{
			return this.attributes.ContainsKey(name);
		}

		public HtmlAttributeCollection Remove(string name)
		{
			this.attributes.Remove(name);
			return this;
		}

		public HtmlAttributeCollection Clear()
		{
			this.attributes.Clear();
			return this;
		}

		public void Render(IHtmlWriter writer)
		{
			throw new NotImplementedException();
		}

		public IEnumerator<KeyValuePair<string,string>> GetEnumerator()
		{
			throw new NotImplementedException();
		}

		System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			throw new NotImplementedException();
		}
	}
}
