﻿using UnityEngine;
using Vertx.Example;

namespace Vertx
{
	public sealed class StylingPage : DocumentationPage<ExampleWindow>
	{
		public override ButtonInjection[] InjectedButtonLinks => new[] {new ButtonInjection(typeof(LandingPage), 4)};
		public override Color Color => StylingColor;
		public override string Title => "Styling Pages";

		public override void DrawDocumentation(ExampleWindow window)
		{
			window.AddHeader(Title, 18, FontStyle.Normal);
			window.AddRichText("Styling pages can be achieved with: <b>buttons</b>, <b>colours</b>, <b>sizes</b>, <b>images</b>, <b>code</b>, and <b>styles</b>.");
		}
		
		public override void DrawDocumentationAfterAdditions(ExampleWindow window) => LandingPage.AddNextButton(window, typeof(ButtonRegistryPage));


		public static readonly Color StylingColor = new Color(0.1f, 1, 0.25f);
		
		public static readonly string StylingPageButton = RichTextUtility.GetColoredString(RichTextUtility.GetButtonString(typeof(StylingPage), "Styling Pages"), StylingColor);
	}
}