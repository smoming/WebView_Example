using Xamarin.Forms;

namespace WebView_Example
{
	public partial class WebView_ExamplePage : ContentPage
	{
		public WebView_ExamplePage()
		{
			InitializeComponent();
		}

		void Handle_Navigating(object sender, Xamarin.Forms.WebNavigatingEventArgs e)
		{
			//throw new NotImplementedException();
			xActivityIndicator.IsRunning = true;
		}

		void Handle_Navigated(object sender, Xamarin.Forms.WebNavigatedEventArgs e)
		{
			//throw new NotImplementedException();
			xActivityIndicator.IsRunning = false;
		}
	}
}
