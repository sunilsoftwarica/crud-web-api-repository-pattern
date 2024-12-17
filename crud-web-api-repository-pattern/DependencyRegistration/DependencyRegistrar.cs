using crud_web_api_repository_pattern.Factories;
using crud_web_api_repository_pattern.Repositories.GenericRepository;
using crud_web_api_repository_pattern.Repositories.StudentRepo;
using crud_web_api_repository_pattern.Repositories.UnitOfWorks;
using crud_web_api_repository_pattern.Services;

namespace crud_web_api_repository_pattern.DependencyRegistration
{
    public class DependencyRegistrar
    {
        public static void Register(IServiceCollection services, IConfiguration configuration)
        {
            //Common
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped(typeof(IUnitOfWork), typeof(UnitOfWork));

            //Repository
            services.AddScoped(typeof(IStudentRepository), typeof(StudentRepository));

            //Service
            services.AddScoped(typeof(IStudentService), typeof(StudentService));

            //Factory
            services.AddScoped(typeof(IStudentFactory), typeof(StudentFactory));
        }
    }
}
