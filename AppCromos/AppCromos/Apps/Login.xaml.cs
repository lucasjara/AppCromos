using AppCromos.Apps.Helpers;
using AppCromos.Apps.Models;
using AppCromos.Apps.Views;
using Newtonsoft.Json;
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
        MetodosAPI api = new MetodosAPI();
        JsonResponse jr = new JsonResponse();
        public Login()
        {
            InitializeComponent();
        }

        private void btnInicio_Clicked(object sender, EventArgs e)
        {
            if (txtNickName.Text != null) {
                
                string respuesta = api.ObtenerJSON();
                jr = JsonConvert.DeserializeObject<JsonResponse>(respuesta);
                Application.Current.Properties["nickname"] = txtNickName.Text.ToUpper();
                Application.Current.Properties["codigo"] = jr.data.codigo.ToUpper();
                Navigation.PushModalAsync(new Crear());
            }
            else
                DisplayAlert("Alerta", "Debe Ingresar su NickName", "OK");
        }
    }
}