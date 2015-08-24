using System;
using System.Collections.Generic;
using NodeTree.Serialization;

namespace NodeTree.ObjectModel
{
	public abstract class HtmlNode : IHtmlRenderable, IEnumerable<HtmlNode>
	{
		HtmlNode Parent { get; private set; }

		HtmlNodeType NoteType { get; protected set; }

		HtmlNode this[int index] { get; }

		bool HasChildNodes { get; }

		bool IsVoidElement { get; }

		string GetTagName();

		HtmlNode SetTagName(string tag);

		string GetText();

		HtmlNode SetText(string text);

		string GetAttribute(string name);

		bool HasAttribute(string name);

		HtmlNode SetAttribute(string name, string value);

		HtmlNode AddClassName(string className);

		HtmlNode HasClassName(string className);

		HtmlNode RemoveClassName(string className);

		HtmlNode AddCssStyle(string propertyName, string value);

		HtmlNode HasCssStyle(string propertyName);

		HtmlNode RemoveCssStyle(string propertyName);

		HtmlNode Prepend(HtmlNode node);

		HtmlNode PrependTo(HtmlNode node);

		HtmlNode Append(HtmlNode node);

		HtmlNode AppendTo(HtmlNode node);

		HtmlNode ReplaceWith(HtmlNode node);

		HtmlNode Detach();

		HtmlNode Clone();

		HtmlNode Normalize();
	}
}
