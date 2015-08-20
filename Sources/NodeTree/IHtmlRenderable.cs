using System;

namespace NodeTree
{
	public interface IHtmlRenderable
	{
		void Render(IHtmlWriter writer);
	}
}
