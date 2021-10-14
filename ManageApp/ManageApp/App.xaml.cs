using ManageApp.ViewModels;
using ManageApp.Views;
using Prism;
using Prism.Ioc;
using Prism.Unity;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ManageApp
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer platformInitializer) : base(platformInitializer)
        {
            InitializeComponent();
        }
        protected override void Initialize()
        {
            base.Initialize();
        }

        protected override void OnInitialized()
        {
            NavigationService.NavigateAsync(NavigationConstants.Main);
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainTabbedPage>(NavigationConstants.Main);

            containerRegistry.RegisterForNavigation<HomePage, HomeViewModel>(NavigationConstants.Home);
            containerRegistry.RegisterForNavigation<DetailPage, DetailViewModel>(NavigationConstants.Detail);
        }
    }
}
