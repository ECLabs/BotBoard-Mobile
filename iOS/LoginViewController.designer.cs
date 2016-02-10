// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace BotBoardApp.iOS
{
	[Register ("LoginViewController")]
	partial class LoginViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField login { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIStackView loginStackView { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIView LoginView { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (login != null) {
				login.Dispose ();
				login = null;
			}
			if (loginStackView != null) {
				loginStackView.Dispose ();
				loginStackView = null;
			}
			if (LoginView != null) {
				LoginView.Dispose ();
				LoginView = null;
			}
		}
	}
}
