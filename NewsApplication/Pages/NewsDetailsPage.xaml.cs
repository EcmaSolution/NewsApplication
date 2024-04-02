using NewsApplication.Models;

namespace NewsApplication.Pages;

public partial class NewsDetailsPage : ContentPage
{
	public NewsDetailsPage(Article article)
	{
		InitializeComponent();
		Image.Source = article.Image;
		Title.Text = article.Title;
		Description.Text = article.Description;
	}
}