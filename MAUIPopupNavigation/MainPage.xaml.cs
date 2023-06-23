using MAUIPopupNavigation.View;
using MAUIPopupNavigation.ViewModel;
namespace MAUIPopupNavigation;

public partial class MainPage : ContentPage
{
	public MainPage(MainPageViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
		viewModel.Title = "Main Page";

		Routing.RegisterRoute(nameof(PageOneView), typeof(PageOneView));
	}
}