namespace EFARINANGOEXAMEN
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new vistas.Login());
        }
    }
}
