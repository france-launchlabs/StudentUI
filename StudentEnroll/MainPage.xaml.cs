using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace StudentEnroll
{

    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        void ViewAll_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new ViewAllStudentsPage());
        }

        void Create_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new CreateStudentPage());
        }

        void ChangeCode_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new VerificationPage());

        }
    }
}
