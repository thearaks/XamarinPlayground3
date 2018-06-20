using System;
using System.Collections.Generic;
using SlideOverKit;
using Xamarin.Forms;

namespace playground3.Views
{
	public partial class CrashPage : MenuContainerPage
    {
        public CrashPage()
        {
            InitializeComponent();

            ShowButton.Command = new Command(() =>
            {
                this.ShowMenu();
            });

            HideButton.Command = new Command(() =>
            {
                this.HideMenu();
            });

            this.SlideMenu = new RightSideMenu();
        }
    }
}
