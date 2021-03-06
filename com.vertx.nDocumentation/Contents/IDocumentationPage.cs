﻿using UnityEngine;

namespace Vertx
{
    internal interface IDocumentationPage<in T> : IDocumentation<T> where T : DocumentationWindow
    {
        /// <summary>
        /// The colour of link buttons that reference this page.
        /// </summary>
        Color Color { get; }
        
        /// <summary>
        /// The label of link buttons that reference this page.
        /// </summary>
        string Title { get; }
        
        /// <summary>
        /// Similar to DrawDocumentation, but is drawn after all DocumentationPageAdditions.
        /// </summary>
        /// <param name="window">Parent EditorWindow (contains helper functions)</param>
        void DrawDocumentationAfterAdditions (T window);
    }
}