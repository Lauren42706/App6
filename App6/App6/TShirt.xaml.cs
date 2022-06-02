using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App6.Models;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App6
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TShirt : ContentPage
    {
        public IList<Clothes> NewClothes { get; set; }
        public TShirt()
        {
            InitializeComponent();

            Label header = new Label
            {
                Text = "T-Shirts",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            // Create the CarouselView.
            CarouselView carouselView = new CarouselView
            {
                ItemTemplate = new DataTemplate(() =>
                {
                    StackLayout rootStackLayout = new StackLayout();

                    Frame frame = new Frame
                    {
                        HasShadow = true,
                        BorderColor = Color.Gray,
                        Margin = new Thickness(20),
                        HeightRequest = 300,
                        HorizontalOptions = LayoutOptions.Center,
                        VerticalOptions = LayoutOptions.CenterAndExpand
                    };

                    StackLayout stackLayout = new StackLayout();

                    Label nameLabel = new Label
                    {
                        FontAttributes = FontAttributes.Bold,
                        FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                        HorizontalOptions = LayoutOptions.Center,
                        VerticalOptions = LayoutOptions.Center
                    };
                    nameLabel.SetBinding(Label.TextProperty, "Name");

                    Image image = new Image
                    {
                        Aspect = Aspect.AspectFill,
                        HeightRequest = 150,
                        WidthRequest = 150,
                        HorizontalOptions = LayoutOptions.Center
                    };
                    image.SetBinding(Image.SourceProperty, "Image");

                    Label locationLabel = new Label
                    {
                        HorizontalOptions = LayoutOptions.Center
                    };
                    locationLabel.SetBinding(Label.TextProperty, "Size");

                    Label detailsLabel = new Label
                    {
                        FontAttributes = FontAttributes.Italic,
                        HorizontalOptions = LayoutOptions.Center,
                        MaxLines = 5,
                        LineBreakMode = LineBreakMode.TailTruncation
                    };
                    detailsLabel.SetBinding(Label.TextProperty, "Details");

                    stackLayout.Children.Add(nameLabel);
                    stackLayout.Children.Add(image);
                    stackLayout.Children.Add(locationLabel);
                    stackLayout.Children.Add(detailsLabel);

                    frame.Content = stackLayout;
                    rootStackLayout.Children.Add(frame);

                    return rootStackLayout;
                })
            };
            carouselView.SetBinding(ItemsView.ItemsSourceProperty, "NewClothes");

            // Build the page.
            Title = "T-Shirts";
            Content = new StackLayout
            {
                Margin = new Thickness(20),
                Children =
                {
                    header,
                    carouselView
                }
            };

            CreateClothesCollection();
            BindingContext = this;
        }
        void CreateClothesCollection()
        {
            NewClothes = new List<Clothes>();

            NewClothes.Add(new Clothes
            {
                Image = "tshirt1",
                Name = "Programmer",
                GStyle = Gender.Male,
                Size = "XL",
                Colour = "Red"
            });

            NewClothes.Add(new Clothes
            {
                Image = "tshirt2",
                Name = "Baboon",
                GStyle = Gender.Male,
                Size = "S",
                Colour = "Red"
            });

            NewClothes.Add(new Clothes
            {
                Image = "tshirt3",
                Name = "Baboon",
                GStyle = Gender.Male,
                Size = "L",
                Colour = "Red"
            });

            NewClothes.Add(new Clothes
            {
                Image = "tshirt4",
                Name = "Baboon",
                GStyle = Gender.Male,
                Size = "M",
                Colour = "Red"
            });
        }

        async void Tshirt(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TShirtItemPage
            {
                BindingContext = this
            });
        }
    }
}