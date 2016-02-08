using System;

using Xamarin.Forms;
using Newtonsoft.Json.Linq;
using System.Threading.Tasks;
using System.Net;
using System.IO;


namespace BotBoardApp
{
	public class LoginPage : ContentPage
	{
		protected Entry userEntry = new Entry { Placeholder = "Username" };
		protected Entry passEntry = new Entry { Placeholder = "Password", IsPassword = true };

		protected Button submit = new Button { };

		public LoginPage ()
		{
			this.passEntry.TextColor = Color.Black;
			submit.Text = "Login";
			submit.BackgroundColor = Color.FromRgb (255d, 255d, 20d);
			submit.Clicked += async (sender, e) => {
				string authCred = await DoUserAuthentication (userEntry.Text, passEntry.Text);

				// Fetch login information asynchronously, 
				// parse the results, then proceed based on result:
				string json = await DoLoginRestCall (userEntry.Text, passEntry.Text, authCred);

				bool success = ParseLoginResults (json);
				ActOnLoginResults(success);
			};

			Content = new StackLayout
			{
				Padding = 20,
				VerticalOptions = LayoutOptions.Center,
				Children = { userEntry, passEntry, submit }
			};
		}

		private void ActOnLoginResults(bool isSuccessful){
		}

		// Parse the login results.
		private bool ParseLoginResults (string json)
		{
			bool success = false;
//			try{
				JObject result = JObject.Parse (json);

				JToken token = result.GetValue ("email");

				if (token != null) {
					success = true;
				}
//			}
//			catch{//(Newtonsoft.Json.JsonReaderException){
//				success = false;
//			}

			return success;
		}	

		private async Task<string> DoUserAuthentication(string user, string password){
			string authorizationCredential = await Task.Run (() => ("".ToString()));

			return authorizationCredential;
		}

		// Gets login result from the passed URL and user data.
		private async Task<string> DoLoginRestCall (string user, string password, string authCred)
		{
			//this is the Oauth client id for iOS to the 'Tims Test' project on Google Dev
			//714175265402-qb28vuu5vc0vn5jb2iuskh0umv1aj5m8.apps.googleusercontent.com
			//this is the Oauth client id for Android to the 'Tims Test' project on Google Dev
			//714175265402-vt356v6ljuvjs5kopedgu8jroua551h2.apps.googleusercontent.com


			// Get the login result with supplied user input.
			//string url = "https://boiling-heat-9947.firebaseio.com/users.json?auth=AUTH_CRECENTIAL"; 
			string secret = "BBwlPFTEMISGXNTvQz5nheil1SC3PgyPqIWxEvIV";
			//string url = "https://boiling-heat-9947.firebaseio.com/users.json?orderBy=\"email\"&equalTo=\"" + user + "\"&auth=" + secret + "&print=pretty"; 
			//string url = "https://boiling-heat-9947.firebaseio.com/users.json?orderBy=\"email\"&auth=" + secret + "&print=pretty"; 
			string url = "https://boiling-heat-9947.firebaseio.com/users.json?&auth=" + secret + "&print=pretty"; 
			// Create an HTTP web request using the URL:
			System.Net.HttpWebRequest request = (System.Net.HttpWebRequest)System.Net.HttpWebRequest.Create (new Uri (url));
			request.ContentType = "application/json";
			request.Method = "GET";

//			try{
				// Send the request to the server and wait for the response:
				using (WebResponse response = await request.GetResponseAsync ())
				{
					// Get a stream representation of the HTTP web response:
					using (System.IO.Stream stream = response.GetResponseStream ())
					{
						// Use this stream to build a JSON document object:
						//Newtonsoft.Json.JsonTextReader reader  = new Newtonsoft.Json.JsonTextReader((new StreamReader(stream)).ReadToEnd().ToString());
						string jsonDoc = await Task.Run (() => (new StreamReader(stream)).ReadToEnd().ToString());

						// Return the JSON document:
						return jsonDoc;
					}
				}
//			}
			//catch{//(Newtonsoft.Json.JsonReaderException){  //System.Net.WebException
//				this.passEntry.Text = "Query Failed";
//				this.passEntry.TextColor = Color.Red;
//
//				return "";
//			}
		}
	}
}


