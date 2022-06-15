
using Prism.Mvvm;
using Prism.Navigation;
using SwagApp.servicess.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SwagApp.ViewModels
{
    public class ViewModelBase : BindableBase, IInitialize, INavigationAware, IDestructible
    { 
    protected INavigationService NavigationService { get; private set; }

    protected ILocalDatabase Database { get; private set; }

        private string _title;
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public ViewModelBase(INavigationService navigationService, ILocalDatabase database)

        {
            NavigationService = navigationService;
            Database = database;
        }

        public ViewModelBase(INavigationService navigationService)
        {
            NavigationService = navigationService;
        }

        public virtual void Initialize(INavigationParameters parameters)
        {

        }

        public virtual void OnNavigatedFrom(INavigationParameters parameters)
        {

        }

        public virtual void OnNavigatedTo(INavigationParameters parameters)
        {

        }

        public virtual void Destroy()
        {

        }

    }

}
