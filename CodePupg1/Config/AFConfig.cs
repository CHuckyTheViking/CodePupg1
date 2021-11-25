using Autofac;
using CodePupg1.Customer;
using CodePupg1.Animal;
using System.Linq;
using System.Reflection;
using CodePupg1.Service;

namespace CodePupg1.Config
{
    internal class AFConfig
    {
        internal static IContainer Configure()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<Application>().As<IApplication>();

            builder.RegisterType<Customers>().InstancePerLifetimeScope();
            builder.RegisterType<AnimalManager>().As<IAnimalManager>();
            builder.RegisterType<Animals>().InstancePerLifetimeScope();
            builder.RegisterType<Dog>().As<IDog>();
            builder.RegisterType<Dog>().InstancePerDependency();
            builder.RegisterType<CustomerManager>().As<ICustomerManager>();
            builder.RegisterType<DropOrPickup>().As<IDropOrPickup>();
            builder.RegisterType<ServiceManager>().As<IServiceManager>();
            builder.RegisterType<Clipping>().As<IClipping>();
            builder.RegisterType<Grooming>().As<IGrooming>();
            builder.RegisterType<CustomerInfo>().As<ICustomerInfo>();


            builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
                .Where(n => n.Namespace.Contains("MainMenu"))
                .As(n => n.GetInterfaces()
                .FirstOrDefault(x => x.Name == "I" + n.Name))
                .AsImplementedInterfaces();

            //builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
            //    .Where(n => n.Namespace.Contains("Customer"))
            //    .As(n => n.GetInterfaces()
            //    .FirstOrDefault(x => x.Name == "I" + n.Name))
            //    .AsImplementedInterfaces();

            //builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
            //    .Where(n => n.Namespace.Contains("Animal"))
            //    .As(n => n.GetInterfaces()
            //    .FirstOrDefault(x => x.Name == "I" + n.Name))
            //    .AsImplementedInterfaces();




            return builder.Build();
        }
    }
}