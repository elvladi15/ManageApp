using ManageApp.Models;
using Prism.Commands;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace ManageApp.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        public ObservableCollection<NewMusicItem> NewMusicItems { get; }

        public QuickHelpItem BreatheQuickItem { get; set; }
        public QuickHelpItem SleepQuickItem { get; set; }
        public QuickHelpItem AnxiatyQuickItem { get; set; }
        public QuickHelpItem StressQuickItem { get; set; }


        private ICommand SelectedNewMusicItemCommand { get; }

        private NewMusicItem _selectedNewMusicItem;
        public NewMusicItem SelectedNewMusicItem
        {
            get
            {
                return _selectedNewMusicItem;
            }
            set
            {
                _selectedNewMusicItem = value;
                if (_selectedNewMusicItem != null)
                {
                    SelectedNewMusicItemCommand.Execute(_selectedNewMusicItem);
                }
                SelectedNewMusicItem = null;
            }
        }
        public HomeViewModel(INavigationService navigationService) : base(navigationService)
        {
            SelectedNewMusicItemCommand = new DelegateCommand(OnSelectedItem);

            BreatheQuickItem = new QuickHelpItem("breathe_image.png", "Breathe");
            SleepQuickItem = new QuickHelpItem("meditation_icon.png", "Sleep");
            AnxiatyQuickItem = new QuickHelpItem("anxiaty_image.png", "Anxiaty");
            StressQuickItem = new QuickHelpItem("stress_image.png", "Stress");

            NewMusicItems = new ObservableCollection<NewMusicItem>
            {
                new NewMusicItem("cactus_image.jpg","Raining Sidewalk","A cactus (plural cacti, cactuses, or less commonly, cactus) is a member of the plant family Cactaceae, a family comprising about 127 genera with some 1750 known species of the order Caryophyllales. The word 'cactus' derives, through Latin, from the Ancient Greek κάκτος, kaktos, a name originally used by Theophrastus for a spiny plant whose identity is now not certain. Cacti occur in a wide range of shapes and sizes. Most cacti live in habitats subject to at least some drought. Many live in extremely dry environments, even being found in the Atacama Desert, one of the driest places on earth.",5),
                new NewMusicItem("cactus_image.jpg","Spring Morning","A cactus (plural cacti, cactuses, or less commonly, cactus) is a member of the plant family Cactaceae, a family comprising about 127 genera with some 1750 known species of the order Caryophyllales. The word 'cactus' derives, through Latin, from the Ancient Greek κάκτος, kaktos, a name originally used by Theophrastus for a spiny plant whose identity is now not certain. Cacti occur in a wide range of shapes and sizes. Most cacti live in habitats subject to at least some drought. Many live in extremely dry environments, even being found in the Atacama Desert, one of the driest places on earth.",7),
                new NewMusicItem("cactus_image.jpg","First Step","A cactus (plural cacti, cactuses, or less commonly, cactus) is a member of the plant family Cactaceae, a family comprising about 127 genera with some 1750 known species of the order Caryophyllales. The word 'cactus' derives, through Latin, from the Ancient Greek κάκτος, kaktos, a name originally used by Theophrastus for a spiny plant whose identity is now not certain. Cacti occur in a wide range of shapes and sizes. Most cacti live in habitats subject to at least some drought. Many live in extremely dry environments, even being found in the Atacama Desert, one of the driest places on earth.",30),
                new NewMusicItem("cactus_image.jpg","Cactus","A cactus (plural cacti, cactuses, or less commonly, cactus) is a member of the plant family Cactaceae, a family comprising about 127 genera with some 1750 known species of the order Caryophyllales. The word 'cactus' derives, through Latin, from the Ancient Greek κάκτος, kaktos, a name originally used by Theophrastus for a spiny plant whose identity is now not certain. Cacti occur in a wide range of shapes and sizes. Most cacti live in habitats subject to at least some drought. Many live in extremely dry environments, even being found in the Atacama Desert, one of the driest places on earth.",26),
            };
        }
        private async void OnSelectedItem()
        {
            var parameter = new NavigationParameters();
            parameter.Add("SelectedNewMusicItem", SelectedNewMusicItem);
            await NavigationService.NavigateAsync(NavigationConstants.Detail, parameter);
        }
    }
}
