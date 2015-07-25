using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Channels;
using System.Text;

using Xamarin.Forms;
using XamarinWorkshop;
using XamarinWorkshop.Models;

namespace XamarinWorkshop
{
    public class ProductCell : ViewCell
    {
        public ProductCell()
        {
            var nameLabel = new Label()
            {
                HorizontalOptions = LayoutOptions.FillAndExpand
            };
            nameLabel.SetBinding(Label.TextProperty, "Name");
            var view = new StackLayout()
            {
                Orientation = StackOrientation.Horizontal,
                Children = { nameLabel }
            };
            View = view;
        }
    }

    public class ProductListPage : ContentPage
    {
        private ListView _listViewOfProducts;

        public ProductListPage(List<Product> products)
        {
            SetupListViewOfProducts(products);
            SetupContent();
        }

        private void SetupListViewOfProducts(List<Product> products)
        {
            _listViewOfProducts = new ListView()
            {
                RowHeight = 40,
                ItemsSource = products,
                ItemTemplate = new DataTemplate(typeof(ProductCell))
            };
        }
        
        private void SetupContent()
        {
            Content = new StackLayout() { VerticalOptions = LayoutOptions.FillAndExpand, Children = { _listViewOfProducts } };
        }
    }


    public class App : Application
    {
        public App()
        {
            // The root page of your application
            var productRepository = new ProductRepository();
            var products = productRepository.GetAllProducts();
            MainPage = new ProductListPage(products);

        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
