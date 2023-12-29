using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimViec.Domain.Repositories;
using TimViec.Infrastructure.Repositories;

namespace TimViec.Infrastructure.Modules
{
    public static class InfrastructureModule
    {
        public static IServiceCollection AddInfrastructureModule(this IServiceCollection services)
        {
            services.AddScoped<ICongViecRepo, CongViecRepo>();
            services.AddScoped<ITaiKhoanRepo, TaiKhoanRepo>();
            services.AddScoped<ICongTyRepo, CongTyRepo>();
            services.AddScoped<IChungChiRepo,ChungChiRepo>();
            services.AddScoped<ICongViecDaNopRepo,CongViecDaNopRepo>();
            services.AddScoped<IHocVanRepo,HocVanRepo>();
            services.AddScoped<IHoSoTimViecRepo,HoSoTimViecRepo>();
            services.AddScoped<INgoaiNguRepo,NgoaiNguRepo>();
            services.AddScoped<IViecLamRepo,ViecLamRepo>();
            return services;

        }
    }
}
