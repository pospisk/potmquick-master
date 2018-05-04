﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PlayeroftheGame.Helpers;
using PlayeroftheGame.ViewModels;
using Xamarin.Forms;

namespace PlayeroftheGame
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

           // SetMainPage();

            //MainPage = new NavigationPage(new LoginPage())
            //{

            //  //  BarBackgroundColor = Color.IndianRed,
            //  //  BarTextColor = Color.Blue
            //};
           
            
            MainPage = new LoginPage();
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
