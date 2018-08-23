﻿using MasterPageExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MasterPageExample
{
	public partial class MainPage : MasterDetailPage
	{
		public MainPage()
		{
			InitializeComponent();
            masterPage.ListView.ItemSelected += OnItemSelected;
        }

        private void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as MasterPageItem;
            if (item != null)
            {
                Detail = new NavigationPage((Page)Activator.CreateInstance(item.TargetType));
                masterPage.ListView.SelectedItem = null;
                IsPresented = false;
            }
        }
    }
}
