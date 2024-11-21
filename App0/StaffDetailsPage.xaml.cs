using Microsoft.Maui.Controls;

namespace App0
{
    public partial class StaffDetailsPage : ContentPage
    {
        private readonly DatabaseService _databaseService;
        private readonly Staff _staff;

        public StaffDetailsPage(Staff staff, DatabaseService databaseService)
        {
            InitializeComponent();
            _databaseService = databaseService;
            _staff = staff;
            LoadStaffDetails();
        }

        private void LoadStaffDetails()
        {
            NameEntry.Text = _staff.Name;
            PhoneEntry.Text = _staff.Phone;
            DepartmentEntry.Text = _staff.Department;
            AddressStreetEntry.Text = _staff.AddressStreet;
            AddressCityEntry.Text = _staff.AddressCity;
            AddressStateEntry.Text = _staff.AddressState;
            AddressZipEntry.Text = _staff.AddressZip;
            AddressCountryEntry.Text = _staff.AddressCountry;
        }

        private async void OnUpdateButtonClicked(object sender, EventArgs e)
        {
            _staff.Name = NameEntry.Text;
            _staff.Phone = PhoneEntry.Text;
            _staff.Department = DepartmentEntry.Text;
            _staff.AddressStreet = AddressStreetEntry.Text;
            _staff.AddressCity = AddressCityEntry.Text;
            _staff.AddressState = AddressStateEntry.Text;
            _staff.AddressZip = AddressZipEntry.Text;
            _staff.AddressCountry = AddressCountryEntry.Text;

            await _databaseService.UpdateStaffAsync(_staff);
            await Navigation.PopAsync(); // Return to Main Page
        }

        private async void OnDeleteButtonClicked(object sender, EventArgs e)
        {
            await _databaseService.DeleteStaffAsync(_staff);
            await Navigation.PopAsync(); // Return to Main Page
        }
    }
}
