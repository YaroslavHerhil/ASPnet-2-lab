using ASPnet_2_lab.Abstract;
using ASPnet_2_lab.Services;

namespace ASPnet_2
{
    public class Startup
    {
        private readonly IConfiguration _configuration;

        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void OldConfigureService()
        {
            PersonService service = new PersonService();
        }

        public void ConfigureService(IServiceCollection services)
        {
            services.AddScoped<IPersonService, PersonService>();
            services.AddRazorPages();
        }

    }
}
