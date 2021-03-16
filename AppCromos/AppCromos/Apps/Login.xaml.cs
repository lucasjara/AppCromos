using AppCromos.Apps.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppCromos.Apps
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnInicio_Clicked(object sender, EventArgs e)
        {
            if (txtNickName.Text != null) {
                Application.Current.Properties["nickname"] = txtNickName.Text.ToUpper();
                Navigation.PushModalAsync(new Crear());
            }
            else
                DisplayAlert("Alerta", "Debe Ingresar su NickName", "OK");
        }
    }
}