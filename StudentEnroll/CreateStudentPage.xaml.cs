using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace StudentEnroll
{
    public partial class CreateStudentPage : ContentPage
    {
        public CreateStudentPage()
        {
            InitializeComponent();
        }

        void Save_Clicked(object sender, System.EventArgs e)
        {

            if(!Uri.IsWellFormedUriString(ImageEntry.Text, UriKind.Absolute)){
                DisplayAlert("Invalid Image", "Student image url is invalid", "Okay");
                return;
            }


            StudentModel student = new StudentModel() { Name = NameEntry.Text, Address = AddressEntry.Text, Age = AgeEntry.Text, Bio = BioEntry.Text, ImageUrl = ImageEntry.Text };
            DisplayAlert("Saved", "New Student added", "Okay");

            Constants.StudentCollections.Add(student);


            ///Clean up form
            NameEntry.Text = "";
            AgeEntry.Text = "";
            AddressEntry.Text = "";
            BioEntry.Text = "";
            ImageEntry.Text = "";

            Navigation.PopAsync();
        }
    }
}
