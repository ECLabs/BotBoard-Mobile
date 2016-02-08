using System;

using Xamarin.Forms;

namespace BotBoardApp
{
	public class App : Application
	{
		public App ()
		{
			MainPage = new LoginPage();

//			// The root page of your application
//			MainPage = new ContentPage {
//				Content = new StackLayout {
//					VerticalOptions = LayoutOptions.Center,
//					Children = {
//						new Label {
//							//XAlign = TextAlignment.Center,
//							HorizontalTextAlignment = TextAlignment.Center,
//							Text = "Welcome to the Bot Board App!"
//						}
//					}
//				}
//			};
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}

