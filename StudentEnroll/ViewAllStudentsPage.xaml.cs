using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace StudentEnroll
{
    public partial class ViewAllStudentsPage : ContentPage
    {
        public ViewAllStudentsPage()
        {
            InitializeComponent();
            StudentsListView.ItemsSource = Constants.StudentCollections;

        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            StudentsListView.ItemsSource = null;
            StudentsListView.ItemsSource = Constants.StudentCollections;
        }

        //void Students_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        //{
        //    if (StudentsListView.SelectedItem != null)
        //    {
        //        Navigation.PushAsync(new StudentProfilePage());
        //        StudentsListView.SelectedItem = null;
        //    }
        //}

        void Students_ItemTapped(object sender, Xamarin.Forms.ItemTappedEventArgs e)
        {

            StudentModel student = (StudentModel)StudentsListView.SelectedItem;

            Navigation.PushAsync(new StudentProfilePage(student));
            StudentsListView.SelectedItem = null;


        }
    }
}
