using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace StudentEnroll
{
    public partial class VerificationPage : ContentPage
    {
        public VerificationPage()
        {
            InitializeComponent();
            NavigationPage.SetHasBackButton(this, false);
        }

        bool IsVerified = true;
        void ChangeCode_Clicked(object sender, System.EventArgs e)
        {
          
        }


        /// <summary>
        /// Ons the back button pressed.
        /// </summary>
        /// <returns><c>true</c>, if you want page not terminating, <c>false</c> otherwise.</returns>
        protected override bool OnBackButtonPressed()
        {
            return false;
        }
        /// <summary>
        /// Ons the back button pressed.
        /// </summary>
        /// <returns><c>true</c>, if you want page not terminating, <c>false</c> otherwise.</returns>
        public bool AskUser(){


            //DisplayAlert("","","","")

            return true;


        }
    }
}
