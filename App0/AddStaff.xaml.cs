namespace App0;

public partial class AddStaff : ContentPage
{
    private readonly DatabaseService _databaseService;

    public AddStaff(DatabaseService databaseService)
    {
        InitializeComponent();
        _databaseService = databaseService;
    }

    private async void OnAddStaffClicked(object sender, EventArgs e)
    {
        Staff newStaff = new Staff
        {
            Name = NameEntry.Text,
            Phone = PhoneEntry.Text,
            Department = DepartmentEntry.Text,
            AddressStreet = AddressStreetEntry.Text,
            AddressCity = AddressCityEntry.Text,
            AddressState = AddressStateEntry.Text,
            AddressZip = AddressZipEntry.Text,
            AddressCountry = AddressCountryEntry.Text
        };
        await _databaseService.AddStaffAsync(newStaff);
        await Navigation.PopAsync(); // Go back to Main Page
    }
}
