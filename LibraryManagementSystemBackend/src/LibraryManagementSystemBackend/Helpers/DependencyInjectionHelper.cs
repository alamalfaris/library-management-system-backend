namespace LibraryManagementSystemBackend.Helpers
{
    public static class DependencyInjectionHelper
    {
        public static void ConfigureServices(WebApplicationBuilder builder)
        {
            builder.Services.AddControllers();

            builder.Services.AddExceptionHandler<GlobalExceptionHandler>();
            builder.Services.AddProblemDetails();
        }
    }
}
