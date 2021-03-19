using Plugin.Media;
using Plugin.Media.Abstractions;
using System;
using System.Collections.Generic;
using System.IO;
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


        private async void Button_Clicked(object sender, EventArgs e)
        {
            var isInitialize = await CrossMedia.Current.Initialize();
            if (!CrossMedia.Current.IsCameraAvailable || !CrossMedia.Current.IsPickPhotoSupported || !CrossMedia.IsSupported || !isInitialize)
            {
                await DisplayAlert("Error", "No cuenta con permisos para seleccionar una foto", "OK");
                return;
            }
            var file = await CrossMedia.Current.PickPhotoAsync(new PickMediaOptions{
                PhotoSize = PhotoSize.Full,
                CompressionQuality = 50
            });
            byte[] imageArray = System.IO.File.ReadAllBytes(file.Path);
            Imagen.Source = ImageSource.FromStream(() => new MemoryStream(imageArray));
            Imagen.HeightRequest = 280;
            txtImagen.Text = txtTexto.Text;
            ContenidoOculto.IsVisible = true;
            ContenidoTema.IsVisible = false;
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            var isInitialize = await CrossMedia.Current.Initialize();
            if (!CrossMedia.Current.IsCameraAvailable || !CrossMedia.Current.IsTakePhotoSupported || !CrossMedia.IsSupported || !isInitialize)
            {
                await DisplayAlert("Error", "No cuenta con permisos para tomar una foto", "OK");
                return;
            }
            var file = await CrossMedia.Current.TakePhotoAsync(new StoreCameraMediaOptions
            {
                PhotoSize = PhotoSize.Full,
                CompressionQuality = 50
            });
            byte[] imageArray = System.IO.File.ReadAllBytes(file.Path);
            Imagen.Source = ImageSource.FromStream(() => new MemoryStream(imageArray));
            Imagen.HeightRequest = 280;
            ContenidoOculto.IsVisible = true;
            ContenidoTema.IsVisible = false;
        }
    }
}