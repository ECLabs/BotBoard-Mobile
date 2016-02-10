using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;

namespace BotBoardApp.iOS
{
	[Register ("AppDelegate")]
	public partial class AppDelegate : UIApplicationDelegate
	{
		private AppDelegate ad = (AppDelegate)UIApplication.SharedApplication.Delegate;
		//private UINavigationController NavigationController = ad.NavigationController;
		public UINavigationController NavigationController;

		public override bool FinishedLaunching (UIApplication app, NSDictionary options)
		{
//			LoadApplication (new App ());
			UIStoryboard board = UIStoryboard.FromName ("MainStoryboard", null);
			LoginViewController ctrl = (LoginViewController)board.InstantiateViewController ("LoginViewController");
			ctrl.ModalTransitionStyle = UIModalTransitionStyle.CrossDissolve;
			ad.NavigationController.PushViewController (ctrl, true);

			return base.FinishedLaunching (app, options);
		}
	
/*
		public override bool FinishedLaunching (UIApplication app, NSDictionary options)
		{
			globalCache.EvictsObjectsWithDiscardedContent = false;

			// check for a notification
			if(options != null) {

				// check for a local notification
				if(options.ContainsKey(UIApplication.LaunchOptionsLocalNotificationKey)) {

					UILocalNotification localNotification = options[UIApplication.LaunchOptionsLocalNotificationKey] as UILocalNotification;
					if(localNotification != null) {

						new UIAlertView(localNotification.AlertAction, localNotification.AlertBody, null, "OK", null).Show();
						// reset our badge
						UIApplication.SharedApplication.ApplicationIconBadgeNumber = 0;
					}
				}

				// check for a remote notification
				if(options.ContainsKey(UIApplication.LaunchOptionsRemoteNotificationKey)) {

					NSDictionary remoteNotification = options[UIApplication.LaunchOptionsRemoteNotificationKey] as NSDictionary;
					if(remoteNotification != null) {
						//new UIAlertView(remoteNotification.AlertAction, remoteNotification.AlertBody, null, "OK", null).Show();
					}
				}
			}

			//==== register for remote notifications and get the device token

			if (getSystemVersion() >= 8) {
				// It's iOS 8
				UIUserNotificationType types = UIUserNotificationType.Badge | UIUserNotificationType.Sound | UIUserNotificationType.Alert;
				UIUserNotificationSettings settings = UIUserNotificationSettings.GetSettingsForTypes (types, null);
				UIApplication.SharedApplication.RegisterUserNotificationSettings (settings);
			}

			/ * this causes a runtime error - RJE 1/30/2016
			// set what kind of notification types we want
			UIRemoteNotificationType notificationTypes = UIRemoteNotificationType.Alert | UIRemoteNotificationType.Badge;
			// register for remote notifications
			UIApplication.SharedApplication.RegisterForRemoteNotificationTypes(notificationTypes);

			//The NSDictionary options variable would contain our notification data if the user clicked the 'view' button on the notification
			// to launch the application.  So you could process it here.  I find it nice to have one method to process these options from the
			// FinishedLaunching, as well as the ReceivedRemoteNotification methods.
			processNotification(options, true);
			* /
			return true;
		}
*/
//		//MOVE TO A UTILITY CLASS OR AREA
//		public int getSystemVersion(){
//			int systemVersion = Convert.ToInt16(UIKit.UIDevice.CurrentDevice.SystemVersion.Split('.')[0]);
//			return systemVersion; 
//		}
//		//MOVE TO A UTILITY CLASS OR AREA
//		public string getLibraryCachesPathFor7To8VersionShift(string endPointUri){
//			// iOS 8.0+ compliant
//			int systemVersion = getSystemVersion();
//			string filename = "";
//			string documents;
//			if (systemVersion >= 8)
//			{
//				documents = NSFileManager.DefaultManager.GetUrls(NSSearchPathDirectory.CachesDirectory, NSSearchPathDomain.User)[0].Path;
//			}
//			else
//			{
//				documents = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments); // iOS 7 and earlier
//			}
//			filename = Path.Combine(documents, endPointUri);
//
//			return filename;
//		}
	}
}
