namespace Controls.UserDialogs.Maui;

public class UserDialogsConfig
{
    private static Type _implementationType = typeof(UserDialogsImplementation);

    public static Type ImplementationType
    {
        get => _implementationType;
        set
        {
            if (!typeof(IUserDialogs).IsAssignableFrom(value))
            {
                throw new CustomImplementationInvalidException();
            }

            _implementationType = value;
        }
    }
}