using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppCromos.Apps.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Crear : ContentPage
    {
        public Crear()
        {
            InitializeComponent();
            txtTituloNickName.Text = "NICKNAME: "+Application.Current.Properties["nickname"].ToString();
            txtTituloNumero.Text = "N°: " + "2021";
        }

        private void ImageButton_Clicked(object sender, EventArgs e)
        {
            
        }
    }
}