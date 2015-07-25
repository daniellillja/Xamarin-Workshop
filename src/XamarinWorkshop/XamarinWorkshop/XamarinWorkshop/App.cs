using Xamarin.Forms;

namespace XamarinWorkshop
{
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
