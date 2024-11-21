using Microsoft.Maui.Controls;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App0
{
    public partial class MainPage : ContentPage
    {
        private readonly DatabaseService _databaseService;

        public MainPage()
        {
            InitializeComponent();
            _databaseService = new DatabaseService();
            LoadStaffAsync();
        }

        private async Task LoadStaffAsync()
        {
            StaffListView.ItemsSource = await _databaseService.GetStaffAsync();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await LoadStaffAsync(); // Refresh the staff list when returning to the page
        }

        private async void OnAddStaffButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddStaff(_databaseService));
        }

        private async void OnClearDatabaseButtonClicked(object sender, EventArgs e)
        {
            await _databaseService.ClearDatabaseAsync();
            await LoadStaffAsync();
        }

        private async void OnStaffSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem is Staff selectedStaff)
            {
                await Navigation.PushAsync(new StaffDetailsPage(selectedStaff, _databaseService));
                StaffListView.SelectedItem = null; // Deselect item
            }
        }
    }
}

