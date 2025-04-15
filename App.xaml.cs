using TodoList_Flowmodoro.Helper;
using TodoList_Flowmodoro.Views;
using NavigationPage = Microsoft.Maui.Controls.NavigationPage;

namespace TodoList_Flowmodoro;

public partial class App : Application
{
    private static SQLiteDatabaseHelper _db;

    public static SQLiteDatabaseHelper DB
    {
        get
        {
            if (_db == null)
            {
                string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "banco_sqlite_todo.db3");
                _db = new SQLiteDatabaseHelper(path);
            }
            
            return _db;
        }
    }
    
    public App()
    {
        InitializeComponent();
    }

    protected override Window CreateWindow(IActivationState? activationState)
    {
        //return new Window(new AppShell());
        return new Window(new NavigationPage(new TodoList()));
    }
}