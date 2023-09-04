namespace Controls.UserDialogs.Maui;

internal class UserDialogsInitializeService : IMauiInitializeService
{
    public void Initialize(IServiceProvider services)
    {
        var userDialogs = services.GetService<IUserDialogs>();

        UserDialogs.Instance = userDialogs;
    }
}
