using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace StudentEnroll
{
    public partial class StudentProfilePage : ContentPage
    {
        StudentModel student;

        public StudentProfilePage(StudentModel student)
        {
            BindingContext = student;
            InitializeComponent();


            this.student = student;
        }

        void RenameStudent_Clicked(object sender, System.EventArgs e)
        {
            student.Name = "Jonas";
        }
    }
}
