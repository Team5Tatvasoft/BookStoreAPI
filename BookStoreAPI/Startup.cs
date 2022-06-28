namespace BookStoreAPI
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {

        }
        public void configure(IApplicationBuilder app,IWebHostEnvironment webHost)
        {
            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
