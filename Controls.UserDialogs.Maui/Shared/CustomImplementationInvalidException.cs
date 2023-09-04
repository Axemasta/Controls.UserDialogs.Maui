using System.Text;

namespace Controls.UserDialogs.Maui;

public class CustomImplementationInvalidException : Exception
{
    public CustomImplementationInvalidException()
        : base($"Custom implementations must implement {nameof(IUserDialogs)}")
    {
    }
}

