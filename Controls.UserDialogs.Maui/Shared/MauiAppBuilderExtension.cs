namespace Controls.UserDialogs.Maui;

public static class MauiAppBuilderExtension
{
    public static MauiAppBuilder UseUserDialogs(this MauiAppBuilder builder, Action configure = null)
    {
        configure?.Invoke();

        builder.Services.AddSingleton(typeof(IUserDialogs), UserDialogsConfig.ImplementationType);
        builder.Services.AddTransient<IMauiInitializeService, UserDialogsInitializeService>();

        return builder;
    }
}
