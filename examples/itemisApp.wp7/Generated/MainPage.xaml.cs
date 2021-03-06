using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace ItemisApp
{
	public partial class MainPage : PhoneApplicationPage
	{
		// Constructor
		public MainPage()
		{
			InitializeComponent();
			NewsBlogListListBox.DataContext = App.RootViewModelProvider.BlogpostsModelProvider();
			TueSessionListListBox.DataContext = App.RootViewModelProvider.SessionsByDayModelProvider("2011-03-22");
			WedSessionListListBox.DataContext = App.RootViewModelProvider.SessionsByDayModelProvider("2011-03-23");
			ThuSessionListListBox.DataContext = App.RootViewModelProvider.SessionsByDayModelProvider("2011-03-24");
			SpeakersSpeakersListListBox.DataContext = App.RootViewModelProvider.AllSpeakersModelProvider();
			this.Loaded += new RoutedEventHandler(MainPage_Loaded);
		}

		// Load data for the ViewModel Items
		private void MainPage_Loaded(object sender, RoutedEventArgs e)
		{
			if (!App.RootViewModelProvider.IsDataLoaded)
			{
				App.RootViewModelProvider.LoadData();
			}
		}
		
		private void NewsBlogList_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			if (NewsBlogListListBox.SelectedIndex == -1)
				return;
			NavigationService.Navigate(new Uri("/Generated/BlogDetailsDetailsView.xaml?itemByIndex=" + NewsBlogListListBox.SelectedIndex, UriKind.Relative));
						
		}

		private void TueSessionList_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			if (TueSessionListListBox.SelectedIndex == -1)
				return;
			NavigationService.Navigate(new Uri("/Generated/SessionDetailsDetailsView.xaml?itemByIndex=" + TueSessionListListBox.SelectedIndex, UriKind.Relative));
						
		}

		private void WedSessionList_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			if (WedSessionListListBox.SelectedIndex == -1)
				return;
			NavigationService.Navigate(new Uri("/Generated/SessionDetailsDetailsView.xaml?itemByIndex=" + WedSessionListListBox.SelectedIndex, UriKind.Relative));
						
		}

		private void ThuSessionList_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			if (ThuSessionListListBox.SelectedIndex == -1)
				return;
			NavigationService.Navigate(new Uri("/Generated/SessionDetailsDetailsView.xaml?itemByIndex=" + ThuSessionListListBox.SelectedIndex, UriKind.Relative));
						
		}

		private void SpeakersSpeakersList_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			if (SpeakersSpeakersListListBox.SelectedIndex == -1)
				return;
			NavigationService.Navigate(new Uri("/Generated/SpeakerDetailsDetailsView.xaml?itemByIndex=" + SpeakersSpeakersListListBox.SelectedIndex, UriKind.Relative));
						
		}
	}
}
