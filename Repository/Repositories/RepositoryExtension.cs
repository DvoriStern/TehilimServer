using Microsoft.Extensions.DependencyInjection;
using Repository.Entity;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    public static class RepositoryExtension
    {
        public static IServiceCollection AddRepository(this IServiceCollection services)
        {
            services.AddScoped(typeof(IRepository<ChaptersOfTehilim>), typeof(ChaptersOfTehilimRepository));
            services.AddScoped(typeof(IRepository<Group>), typeof(GroupRepository));
            services.AddScoped(typeof(IRepository<NameForPrayer>), typeof(NameForPrayerRepository));
            services.AddScoped(typeof(IRepository<RequestPrayer>), typeof(RequestPrayerRepository));
            services.AddScoped(typeof(IRepository<Sharing>), typeof(SharingRepository));
            services.AddScoped(typeof(IRepository<User>), typeof(UserRepository));
            services.AddScoped(typeof(IRepository<ChaptersTehilimToRead>), typeof(ChaptersTehilimToRead));
            return services;

        }
    }
}
