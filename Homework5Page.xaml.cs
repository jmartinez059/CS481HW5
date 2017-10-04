using Xamarin.Forms;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Homework5
{
	public partial class Homework5Page : ContentPage
	{
		public Homework5Page()
		{
			InitializeComponent();
		}

		async void Button_Enter(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new SharkList());
		}
	}
}