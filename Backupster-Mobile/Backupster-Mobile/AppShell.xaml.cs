using Backupster_Mobile.ViewModels;
using Backupster_Mobile.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Backupster_Mobile
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
