using LibraryManagementSystemBackend.Helpers;

namespace LibraryManagementSystemBackend
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            #region Add services to the container.

            DependencyInjectionHelper.ConfigureServices(builder);

            var app = builder.Build();

            #endregion

            #region Configure the HTTP request pipeline.

            app.UseHttpsRedirection();
            app.UseAuthorization();
            app.UseExceptionHandler();

            app.MapControllers();

            app.Run();
            
            #endregion
        }
    }
}
