using ManageApp.Models;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace ManageApp.ViewModels
{
    class DetailViewModel : BaseViewModel,IInitialize
    {
        private INavigationService _navigationService;
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public ICommand BackCommand { get; }
        public DetailViewModel(INavigationService navigationService) : base(navigationService)
        {
            _navigationService = navigationService;
            BackCommand = new Command(() =>
              {
                  _navigationService.GoBackAsync();
              });
        }

        public void Initialize(INavigationParameters parameters)
        {
            NewMusicItem seletedNewMusicItem = parameters.GetValue<NewMusicItem>("SelectedNewMusicItem");
            Title = seletedNewMusicItem.Title;
            Description = seletedNewMusicItem.Description;
            Image = seletedNewMusicItem.Image;
        }
    }
}
