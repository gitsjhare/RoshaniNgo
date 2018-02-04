using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;

using Roshani.data.Contract;
using Roshani.data.provider;

using Roshani.Provider.User;
using Roshani.Provider.Contract;

namespace Roshani.Services
{
    public static class RegisterServices
    {
        private static string _ConnectionString = string.Empty;
        private static IConfiguration Configuration { get; set; }
        public static void InitiateServiceRegistration(IServiceCollection services, IConfiguration _config)
        {
            Configuration = _config;
            _ConnectionString = Configuration.GetConnectionString("RoshaniMySqlConnect");

            services.AddSingleton<IdatamodelContext,dbContext>(x => new dbContext(_ConnectionString));

            //Providers
            services.AddTransient<IUserDetailProvider,UserDetailProvider>();
            
            //Data objects 
            services.AddTransient<IUsersDetailsData,RoshaniUserDto>();
        }

    }
}