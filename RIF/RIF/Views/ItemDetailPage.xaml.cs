﻿using RIF.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace RIF.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}