 
using Plugin.Media.Abstractions;
using System;
using System.ComponentModel;
using Microsoft.ProjectOxford.Vision;
using Microsoft.ProjectOxford.Vision.Contract;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
 
using System.Net.Http;
using System.Text;
using System.Net.Http.Headers;
using System.Web;
using Plugin.Media;
using System.IO;
using Microsoft.Azure.CognitiveServices.Vision.ComputerVision;

namespace NewNCRHack.Views
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
           
            InitializeComponent();
        }

         
        
        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            
            #region AzuerConfig
            string subscriptionKey = "1d298ac576ee4819b5cb779c1eac8e15";
            string endpoint = "https://azdemosearchvision.cognitiveservices.azure.com/";
            ComputerVisionClient client =
             new ComputerVisionClient(new ApiKeyServiceClientCredentials(subscriptionKey))
             { Endpoint = endpoint };
            #endregion AzuerConfig


            #region CameraOn
            await CrossMedia.Current.Initialize();
           

            btnCapture.IsEnabled = false;

            if (!CrossMedia.Current.IsCameraAvailable || !CrossMedia.Current.IsTakePhotoSupported)
            {
                await DisplayAlert("No Camera", ":( No camera available.", "OK");
                return;
            }
           
            var file = await CrossMedia.Current.TakePhotoAsync(new StoreCameraMediaOptions
            {
                SaveToAlbum = true,
                PhotoSize = PhotoSize.Small,


            });
            
            var Image = ImageSource.FromStream(() => file.GetStream());
            #endregion CameraOn

            var myStream = file.GetStream();

            var result = client.RecognizePrintedTextInStreamAsync(false, myStream);

            
            result.Wait();
            
            StringBuilder sb = new StringBuilder();

            var rst = result.Result;


            foreach (var r in rst.Regions)
            {
                foreach (var t in r.Lines)
                {
                    foreach (var w in t.Words)
                    {

                        sb.Append(w.Text + " ");

                    }
                }
            }

            
            string question = sb.ToString();
            Application.Current.Properties["Name"] = question;
            await Navigation.PushAsync(new InstalNCRSolution());


            
        }
       


    }
}