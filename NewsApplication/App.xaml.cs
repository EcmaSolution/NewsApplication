using NewsApplication.Pages;

namespace NewsApplication;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        MainPage = new NavigationPage(new NewsPage());
    }
}
