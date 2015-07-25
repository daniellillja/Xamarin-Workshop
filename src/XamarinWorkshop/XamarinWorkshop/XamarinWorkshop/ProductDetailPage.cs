using System;
using Xamarin.Forms;
using XamarinWorkshop.Models;

namespace XamarinWorkshop
{
    public class ProductDetailPage : ContentPage
    {
        private readonly Product _selectedProduct;
        private Label _nameLabel;
        private Label _priceLabel;
        private Label _descriptionLabel;
        private Image _productImage;

        public ProductDetailPage(Product selectedProduct)
        {
            _selectedProduct = selectedProduct;

            SetupView(selectedProduct);
        }

        private void SetupView(Product selectedProduct)
        {
            SetupLabels();
            SetupImage();
            var view = new StackLayout()
            {
                Children =
                {
                    _nameLabel, _priceLabel, _descriptionLabel, _productImage
                
                } // TODO: refactor into a list of Labels
            };
            Content = view;
        }

        private void SetupImage()
        {
            _productImage = new Image()
            {
                Source = ImageSource.FromUri(new Uri(_selectedProduct.ImgUrl))
            };
        }

        private void SetupLabels()
        {
            SetupNameLabel();
            SetupPriceLabel();
            SetupDescriptionLabel();
        }

        private void SetupDescriptionLabel()
        {
            _descriptionLabel = new Label()
            {
                Text = _selectedProduct.Description
            };
        }

        private void SetupPriceLabel()
        {

            _priceLabel = new Label()
            {
                Text = _selectedProduct.Price
            };

        }

        private void SetupNameLabel()
        {
            _nameLabel = new Label()
            {
                Text = _selectedProduct.Name
            };

        }
    }
}