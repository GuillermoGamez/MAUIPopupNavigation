using CommunityToolkit.Maui.Views;
using MAUIPopupNavigation.ViewModel;

namespace MAUIPopupNavigation.View;

public partial class PageOnePopup : Popup
{
	public PageOnePopup(PageOneViewModel viewModel)
	{
		InitializeComponent();
		Size = new Size(250, 250);
		BindingContext = viewModel;
        viewModel.CloseAction = new Action(() => Close());
    }
}