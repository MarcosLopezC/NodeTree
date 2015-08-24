using System;
using System.Collections.Generic;
using NodeTree.Serialization;

namespace NodeTree.ObjectModel
{
	public class HtmlAttributeCollection :
		IHtmlRenderable,
		IEnumerable<KeyValuePair<string, string>>
	{
		private Dictionary<string, string> dictionary;

		public int Count
		{
			get
			{
				return this.dictionary.Count;
			}
		}

		public string this[string name]
		{
			get
			{
				return this.dictionary[name];
			}
			set
			{
				this.dictionary[name] = value;
			}
		}

		public HtmlAttributeCollection()
		{
			this.dictionary = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
		}

		public HtmlAttributeCollection Set(string name)
		{
			return Set(name, null);
		}

		public HtmlAttributeCollection Set(string name, string value)
		{
			this[name] = value;
			return this;
		}

		public HtmlAttributeCollection Remove(string name)
		{
			this.dictionary.Remove(name);
			return this;
		}

		public HtmlAttributeCollection Clear()
		{
			this.dictionary.Clear();
			return this;
		}

		public bool Contains(string name)
		{
			return this.dictionary.ContainsKey(name);
		}

		public void Render(IHtmlWriter writer)
		{
			throw new NotImplementedException();
		}

		public IEnumerator<KeyValuePair<string, string>> GetEnumerator()
		{
			throw new NotImplementedException();
		}

		System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			throw new NotImplementedException();
		}
	}
}
