﻿using Xamarin.Forms;

using Microsoft.Azure.Mobile;
using Microsoft.Azure.Mobile.Analytics;
using Microsoft.Azure.Mobile.Crashes;

namespace mctest
{
	public partial class App : Application
	{
		public App()
		{
			MobileCenter.Start(typeof(Analytics), typeof(Crashes));

			InitializeComponent();

			MainPage = new mctestPage();
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
