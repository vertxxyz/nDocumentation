﻿using System;
using UnityEngine.UIElements;

namespace Vertx
{
	/// <summary>
	/// Additional documentation injected into a Documentation Page.
	/// </summary>
	public abstract class DocumentationPageAddition<T> : IDocumentation<T> where T : DocumentationWindow
	{
		/// <summary>
		/// The documentation to inject below.
		/// </summary>
		public abstract Type PageToAddToType { get; }
		
		/// <summary>
		/// The priority that sorts the position of the additional documentation (lower numbers are above)
		/// </summary>
		public abstract float Order { get; }
		
		public abstract void DrawDocumentation(T window);
		
		
		public virtual void Initialise(T window) { }
	}
}