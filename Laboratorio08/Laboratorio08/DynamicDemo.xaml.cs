﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Laboratorio08
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DynamicDemo : ContentPage
    {
        bool originalStyle = true;
        public DynamicDemo()
        {
            InitializeComponent();
            Resources["searchBarStyle"] = Resources["blueSearchBarStyle"];
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            if (originalStyle)
            {
                Resources["searchBarStyle"] = Resources["greenSearchBarStyle"];
                originalStyle = false;
            }
            else
            {
                Resources["searchBarStyle"] = Resources["blueSearchBarStyle"];
                originalStyle = true;
            }
        }
    }
}