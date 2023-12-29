using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimViec.Application.Mapping;
using TimViec.Application.Services;
using TimViec.Application.Services.Interface;
using TimViec.Infrastructure.Modules;

namespace TimViec.Application.Modules
{
    public static class ApplicationModules
    {
        public static IServiceCollection AddApplicationModules(this IServiceCollection services)
        {
            services.AddInfrastructureModule();
            var mapperConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MappingProfile());
            });
            IMapper mapper = mapperConfig.CreateMapper();
            services.AddSingleton(mapper);
            services.AddScoped<ICongViecService, CongViecService>();
            services.AddScoped<ITaiKhoanService, TaiKhoanService>();
            services.AddScoped<ICongtyService, CongTyService>();
            services.AddScoped<IChungChiService, ChungChiService>();
            services.AddScoped<ICongViecDaNopService, CongViecDaNopService>();
            services.AddScoped<IHocVanService,HocVanService>();
            services.AddScoped<IHoSoTimViecService,HoSoTimViecService>();
            services.AddScoped<INgoaiNguService,NgoaiNguService>();
            services.AddScoped<IViecLamService,ViecLamService>();
            return services;
        }
    }
}
