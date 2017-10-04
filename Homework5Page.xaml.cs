using Xamarin.Forms;
using System;

namespace Homework5
{
	public partial class Homework5Page : ContentPage
	{
		public Homework5Page()
		{
			InitializeComponent();
		}

		async void ButtonEnter(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new SharkList());
		}
	}
}
