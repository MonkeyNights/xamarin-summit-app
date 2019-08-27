using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace EventApp.XamarinSummit.Views.ControlTemplates
{
    public partial class HeaderContentView : ContentView
    {
        public static readonly BindableProperty CanGoBackProperty;

        public HeaderContentView()
        {
            InitializeComponent();
        }

        public bool CanGoBack
        {
            get => GoBackView.IsVisible;
            set => GoBackView.IsVisible = value;
        }

        public string HeaderTitle
        {
            get => HeaderTitleLabel.Text;
            set => HeaderTitleLabel.Text = value;
        }

        public bool ShowProfileView
        {
            get => ProfileView.IsVisible;
            set => ProfileView.IsVisible = value;
        }

        public string ProfileInitials
        {
            get => ProfileInitialsLabel.Text;
            set => ProfileInitialsLabel.Text = value;
        }

    }
}
