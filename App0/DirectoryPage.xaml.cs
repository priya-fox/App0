using SQLite;

namespace App0;

//public partial class DirectoryPage : ContentPage
//{
//public DirectoryPage()
//{
//InitializeComponent();
//}

//}
public class DirectoryPages
{
    private readonly SQLiteAsyncConnection _connection;

    public DirectoryPages(string staff)
    {
        _connection = new SQLiteAsyncConnection("Staff.db");
        _connection.CreateTableAsync<Staff>().Wait();
    }

    public Task<List<Staff>> GetStaffAsync()
    {
        return _connection.Table<Staff>().ToListAsync();



    }

}

