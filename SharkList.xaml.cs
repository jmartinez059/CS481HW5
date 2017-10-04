using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
//using Homework4.Models;
using Xamarin.Forms;

namespace Homework5
{
	public partial class SharkList : ContentPage
	{
		public SharkList()
		{
			InitializeComponent();

			PopulateSharkList();
		}

		public void PopulateSharkList()
		{
			var listOfSharks = new ObservableCollection<SharkListItem>()
			{
				new SharkListItem() { name = "Great White", image = "white.jpg",
					detail = "Carcharodon Carcharias", url = "https://en.wikipedia.org/wiki/Great_white_shark"},

				new SharkListItem() { name = "Thresher", image = "thresher.jpg",
					detail = "Alopias Vulpinus", url = "https://www.sharksider.com/thresher-shark/"},

				new SharkListItem() { name = "Shovelnose Guitarfish", image = "shovel.jpg",
					detail = "Rhinobatos Productus", url = "https://www.montereybayaquarium.org/animal-guide/fishes/shovelnose-guitarfish"},

				new SharkListItem() { name = "Mako", image = "mako.jpg",
					detail = "Isurus Oxyrinchus", url = "https://www.youtube.com/watch?v=f4LteIKjSn0"},

				new SharkListItem() { name = "Leopard", image = "leopard.jpg",
					detail = "Triakis Semifasciata", url = "https://seaworld.org/Animal-Info/Animal-Bytes/Cartilaginous-Fish/Leopard-Shark"},

				new SharkListItem() { name = "Hammerhead", image = "hammer.jpg",
					detail = "Sphyrna Mokarran", url = "http://www.arkive.org/great-hammerhead/sphyrna-mokarran/"},

				new SharkListItem() { name = "Blue", image = "blue.jpg",
					detail = "Prionace Glauca", url = "http://marinebio.org/species.asp?id=35"},

				new SharkListItem() { name = "Spiny Dogfish", image = "spiny.jpg",
					detail = "Squalus Acanthias", url = "https://a-z-animals.com/animals/spiny-dogfish/"},

			};

			SharkCellListView.ItemsSource = listOfSharks;
		}

		public void NavigateToWebPage(object sender, EventArgs e)
		{
			var listViewItem = (ImageCell)sender;
			var url = (string)listViewItem.CommandParameter;
			Device.OpenUri(new Uri(url));
		}
	}
}