using Xamarin.Forms;

namespace WebView_Example
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			MainPage = new WebView_ExamplePage();
			//MainPage = new HtmlWebView_Example();
		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}
