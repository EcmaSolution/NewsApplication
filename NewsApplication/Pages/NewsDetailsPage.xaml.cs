using NewsApplication.Models;

namespace NewsApplication.Pages;

public partial class NewsDetailsPage : ContentPage
{
    private string _url;
	public NewsDetailsPage(Article article)
	{
		InitializeComponent();
		Image.Source = article.Image;
		Title.Text = article.Title;
		Description.Text = article.Description;
		_url = article.Url;
	}

    private async void ShareBtn_OnClicked(object? sender, EventArgs e)
    {
        await Share.RequestAsync(new ShareTextRequest
        {
			Uri = _url,
			Text = "Share"
        });
    }
}