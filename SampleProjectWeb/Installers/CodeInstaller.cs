using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BLL;
using BLL.Abstract;
using DAL;
using DAL.Abstract;

namespace TechnicalTest.Installers
{
    public class CodeInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {            
            container.Register(Component.For<IAuthenticationManager>().ImplementedBy<AuthenticationManager>());
        }
    }
}