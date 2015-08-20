using System;
using System.Collections.Generic;

namespace NodeTree.ObjectModel
{
	public class HtmlAttributes :
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

		public HtmlAttributes ()
		{
			this.dictionary = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
		}

		public HtmlAttributes Set(string name)
		{
			return Set(name, null);
		}

		public HtmlAttributes Set(string name, string value)
		{
			this[name] = value;
			return this;
		}

		public HtmlAttributes Remove(string name)
		{
			this.dictionary.Remove(name);
			return this;
		}

		public HtmlAttributes Clear()
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
