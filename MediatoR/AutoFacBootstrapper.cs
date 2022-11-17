using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public class AutoFacBootstrapper
    {
        public static IContainer Container => SetContainer();
            
            
        public static IContainer SetContainer()
        {
           var container= new ContainerBuilder();
            container.RegisterAssemblyTypes(Assembly.GetExecutingAssembly()).AsClosedTypesOf(typeof(ICommandHandler<,>)).AsImplementedInterfaces();
                 //Where(s => s.GetInterfaces().Any(d=>d.IsGenericType && d.GetGenericTypeDefinition().Equals(typeof(ICommandHandler<,>)) )).AsImplementedInterfaces();
            
            
            //var d = Assembly.GetExecutingAssembly().DefinedTypes;

            //foreach(var type in d)
            //{
            //    var dd = type.GetInterfaces().Any(s => s.IsGenericType && s.GetGenericTypeDefinition().Equals(typeof(ICommandHandler<,>)));
            //}
            
            
            container.RegisterGeneric(typeof(Mediator<,>)).As(typeof(IMediator<,>)).InstancePerDependency();
           return container.Build();
        }    

       
        
    }
}
