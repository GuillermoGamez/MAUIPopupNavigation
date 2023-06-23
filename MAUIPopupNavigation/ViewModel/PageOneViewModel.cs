using System;
using CommunityToolkit.Mvvm.Input;

namespace MAUIPopupNavigation.ViewModel
{
	public class PageOneViewModel : BaseViewModel
	{
		public PageOneViewModel()
		{
			BackButtonCommand = new RelayCommand(async () => await BackButton());
		}

		public bool IsModal { get; set; }
		public bool IsShell { get; set; }
		public bool IsPopup { get; set; }
		public RelayCommand BackButtonCommand { get; private set; }
		public Action CloseAction { get; set; }

		public async Task BackButton()
		{
			if (IsShell)
				await Shell.Current.Navigation.PopAsync();
			else if (IsModal)
				await Shell.Current.Navigation.PopModalAsync();
			else if (IsPopup)
				CloseAction?.Invoke();
		}
	}
}

