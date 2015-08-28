using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
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

		public void AppendClassName(string className)
		{
			if (string.IsNullOrEmpty(this["class"]))
			{
				this["class"] = className;
			}
			else
			{
				this["class"] += " " + className;
			}
		}

		public void AppendStyle(string propertyName, string value)
		{
			this["style"] += string.Format("{0}:{1};", propertyName, value);
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

		public void Render(HtmlWriter writer)
		{
			foreach (var attribute in this.attributes)
			{
				writer.WriteAttribute(attribute.Key, attribute.Value);
			}
		}

		public IEnumerator<KeyValuePair<string, string>> GetEnumerator()
		{
			return this.attributes.GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}
	}
}
