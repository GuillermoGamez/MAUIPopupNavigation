using System;
using CommunityToolkit.Mvvm.ComponentModel;

namespace MAUIPopupNavigation.ViewModel
{
	public class BaseViewModel : ObservableObject
    {
		public BaseViewModel()
		{
		}

		public string Title { get; set; }
	}
}

