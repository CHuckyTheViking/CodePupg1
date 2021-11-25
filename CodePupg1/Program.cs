using System;
using Autofac;
using CodePupg1.Config;

namespace CodePupg1
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = AFConfig.Configure();

            using (var scope = container.BeginLifetimeScope())
            {
                var app = scope.Resolve<IApplication>();
                app.Run();
            }
        }
    }
}
