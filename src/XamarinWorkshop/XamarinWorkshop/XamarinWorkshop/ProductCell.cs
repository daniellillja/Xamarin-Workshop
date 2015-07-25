using Xamarin.Forms;

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
}