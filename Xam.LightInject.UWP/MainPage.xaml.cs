﻿namespace Xam.LightInject.UWP
{
    public sealed partial class MainPage
    {
        public MainPage()
        {
            this.InitializeComponent();

            LoadApplication(new AppUWP());
        }
    }
}
