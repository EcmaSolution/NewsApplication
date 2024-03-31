using NewsApplication.Models;
using NewsApplication.Services;

namespace NewsApplication.Pages;

public partial class NewsPage : ContentPage
{
    private List<Article>? Articles { get; set; }

    private readonly List<ArticleCategory>? _categories =
    [
        new(){Name = "General"},
        new(){Name = "World"},
        new(){Name = "Nation"},
        new(){Name = "Business"},
        new(){Name = "Technology"},
        new(){Name = "Entertainment"},
        new(){Name = "Sports"},
        new(){Name = "Science"},
        new(){Name = "Health"}
    ];

    public NewsPage()
    {
		InitializeComponent();
        Articles = new List<Article>();
        CollectionViewCategories.ItemsSource = _categories;
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();

        await PassArticleCategoryName("General");
    }

    private async Task PassArticleCategoryName(string category)
    {
        CollectionViewNews.ItemsSource = null;
        Articles?.Clear();
        ApiService service = new ApiService();
        var articles = await service.GetNews(category, "en");

        Articles = articles?.Articles;

        CollectionViewNews.ItemsSource = Articles;
    }

    private async void CollectionViewCategories_OnSelectionChanged(object? sender, SelectionChangedEventArgs e)
    {
        var selectedItem = e.CurrentSelection.FirstOrDefault() as ArticleCategory;
        await PassArticleCategoryName(selectedItem!.Name);
    }
}