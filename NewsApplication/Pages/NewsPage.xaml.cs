using NewsApplication.Models;
using NewsApplication.Services;

namespace NewsApplication.Pages;

public partial class NewsPage : ContentPage
{
    public List<Article>? Articles { get; set; }

	public NewsPage()
	{
		InitializeComponent();
        Articles = new List<Article>();
	}

    protected override async void OnAppearing()
    {
        base.OnAppearing();

        ApiService service = new ApiService();

        var articles = await service.GetNews();

        Articles = articles?.Articles;

        CollectionViewNews.ItemsSource = Articles;
    }
}