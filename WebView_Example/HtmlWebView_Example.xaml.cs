using System;
using System.Collections.Generic;
using System.Reflection;
using Xamarin.Forms;

namespace WebView_Example
{
	public partial class HtmlWebView_Example : ContentPage
	{
		public HtmlWebView_Example()
		{
			InitializeComponent();

			string xHtml = "<Div><H1>Xamarin</H1><H2>Xamarin</H2><H3>Xamarin</H3></Div>";
			var source = new HtmlWebViewSource();
			source.Html = xHtml;
			xWebView.Source = source;
		}
	}
}
