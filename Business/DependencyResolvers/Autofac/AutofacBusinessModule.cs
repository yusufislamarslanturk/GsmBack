using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.CCS;
using Business.Concrete;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using Core.Utilities.Security.Jwt;
using Core.Utilities.Security.JWT;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
         

            builder.RegisterType<TahsilatManager>().As<ITahsilatService>();
            builder.RegisterType<EfTahsilatDal>().As<ITahsilatDal>().SingleInstance();

            builder.RegisterType<FaturaManager>().As<IFaturaService>();
            builder.RegisterType<EfFaturaDal>().As<IFaturaDal>().SingleInstance();

            builder.RegisterType<MusteriManager>().As<IMusteriService>();
            builder.RegisterType<EfMusteriDal>().As<IMusteriDal>().SingleInstance();

            builder.RegisterType<MusteriTarifeManager>().As<IMusteriTarifeService>();
            builder.RegisterType<EfMusteriTarifeDal>().As<IMusteriTarifeDal>().SingleInstance();

            builder.RegisterType<TarifeManager>().As<ITarifeService>();
            builder.RegisterType<EfTarifeDal>().As<ITarifeDal>().SingleInstance();

            builder.RegisterType<AuthManager>().As<IAuthService>();
            builder.RegisterType<JwtHelper>().As<ITokenHelper>();

            builder.RegisterType<UserManager>().As<IUserService>();
            builder.RegisterType<EFUserDal>().As<IUserDal>();



            //builder.RegisterType<AuthManager>().As<IAuthService>();
            //builder.RegisterType<JwtHelper>().As<ITokenHelper>();






            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();
        }
    }
}
