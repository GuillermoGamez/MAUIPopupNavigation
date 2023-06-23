using MAUIPopupNavigation.ViewModel;

namespace MAUIPopupNavigation.View;

public partial class PageOneView : ContentPage
{
	public PageOneView(PageOneViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}
