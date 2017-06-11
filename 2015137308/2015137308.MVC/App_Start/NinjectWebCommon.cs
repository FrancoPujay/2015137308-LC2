[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(_2015137308.MVC.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(_2015137308.MVC.App_Start.NinjectWebCommon), "Stop")]

namespace _2015137308.MVC.App_Start
{
    using System;
    using System.Web;

    using Microsoft.Web.Infrastructure.DynamicModuleHelper;

    using Ninject;
    using Ninject.Web.Common;
    using _2015137308.Persistence.Repositories;
    using _2015137308.Persistence;
    using _2015137308.Entities.IRepositories;

    public static class NinjectWebCommon 
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        /// <summary>
        /// Starts the application
        /// </summary>
        public static void Start() 
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            bootstrapper.Initialize(CreateKernel);
        }
        
        /// <summary>
        /// Stops the application.
        /// </summary>
        public static void Stop()
        {
            bootstrapper.ShutDown();
        }
        
        /// <summary>
        /// Creates the kernel that will manage your application.
        /// </summary>
        /// <returns>The created kernel.</returns>
        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            try
            {
                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

                RegisterServices(kernel);
                return kernel;
            }
            catch
            {
                kernel.Dispose();
                throw;
            }
        }

        /// <summary>
        /// Load your modules or register your services here!
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        private static void RegisterServices(IKernel kernel)
        {
            //UnityOfWork
            kernel.Bind<IUnityOfWork>().To<UnityOfWork>();

            //Context
            kernel.Bind<_2015137308DbContext>().To<_2015137308DbContext>();

            kernel.Bind<IBusRepository>().To<BusRepository>();
            kernel.Bind<IClienteRepository>().To<ClienteRepository>();
            kernel.Bind<IEmpleadoRepository>().To<EmpleadoRepository>();
            kernel.Bind<ILugarViajeRepository>().To<LugarViajeRepository>();
            kernel.Bind<IServicioRepository>().To<ServicioRepository>();
            kernel.Bind<IVentaRepository>().To<VentaRepository>();
          
        }        
    }
}
