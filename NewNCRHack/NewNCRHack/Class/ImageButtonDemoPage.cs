using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace NewNCRHack.Class
{
    public class ImageButtonDemoPage : ContentPage
    {
        public ImageButtonDemoPage()
        {
            Label header = new Label
            {
                Text = "ImageButton",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            ImageButton imageButton = new ImageButton
            {
                Source = "https://www.freepnglogos.com/uploads/twitter-logo-png/twitter-bird-symbols-png-logo-0.png",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            // Build the page.
            Title = "ImageButton Demo";
            Content = new StackLayout
            {
                Children = { header, imageButton }
            };
        }
    }
     
}
