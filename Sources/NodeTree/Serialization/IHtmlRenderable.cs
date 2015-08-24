using System;

namespace NodeTree.Serialization
{
	public interface IHtmlRenderable
	{
		void Render(IHtmlWriter writer);
	}
}
