using System.Collections.Generic;
using Xamarin.Forms;
using XamarinWorkshop.Models;

namespace XamarinWorkshop
{
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
                ItemTemplate = new DataTemplate(typeof(ProductCell)),
            };

            _listViewOfProducts.ItemSelected += (sender, args) =>
            {
                var selectedProduct = (Product) args.SelectedItem;
                var productDetailPage = new ProductDetailPage(selectedProduct);

                var navigationPage = new NavigationPage(productDetailPage);

                Navigation.PushModalAsync(navigationPage);
            };
        }
        
        private void SetupContent()
        {
            Content = new StackLayout() { VerticalOptions = LayoutOptions.FillAndExpand, Children = { _listViewOfProducts } };
        }
    }
}