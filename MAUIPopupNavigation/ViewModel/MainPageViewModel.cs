using System;
using CommunityToolkit.Mvvm;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Maui.Views;
using MAUIPopupNavigation.View;

namespace MAUIPopupNavigation.ViewModel
{
	public class MainPageViewModel : BaseViewModel
	{
		public MainPageViewModel()
		{
            ShellPageOneCommand = new RelayCommand(async () => await ShellPageOne());
			ModalPageOneCommand = new RelayCommand(async () => await ModalPageOne());
			PopupPageOneCommand = new RelayCommand(async () => await PopupPageOne());
		}

		public RelayCommand ShellPageOneCommand { get; private set; }
		public RelayCommand ModalPageOneCommand { get; private set; }
		public RelayCommand PopupPageOneCommand { get; private set; }

		public async Task ShellPageOne()
		{
			var vm = new PageOneViewModel() { Title = "Page One using Shell", IsShell = true };
			await Shell.Current.Navigation.PushAsync(new PageOneView(vm));
		}

		public async Task ModalPageOne()
		{
            var vm = new PageOneViewModel() { Title = "Page One using Modal", IsModal = true };
			await Shell.Current.Navigation.PushModalAsync(new PageOneView(vm));
        }

		public async Task PopupPageOne()
		{
			var vm = new PageOneViewModel() { Title = "Page One using Popup", IsPopup = true };
			await Shell.Current.ShowPopupAsync(new PageOnePopup(vm));
		}
	}
}

