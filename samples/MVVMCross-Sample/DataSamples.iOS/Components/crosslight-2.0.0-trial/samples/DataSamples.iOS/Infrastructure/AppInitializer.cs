using System;
using Intersoft.Crosslight;
using DataSamples.Infrastructure;

namespace DataSamples.iOS.Infrastructure
{
    public sealed class AppInitializer : IApplicationInitializer
    {
        public IApplicationService GetApplicationService(IApplicationContext context)
        {
            return new DataSamplesAppService(context);
        }

        public void InitializeApplication(IApplicationHost appHost)
        {
        }

        public void InitializeComponents(IApplicationHost appHost)
        {
        }

        public void InitializeServices(IApplicationHost appHost)
        {
        }
    }
}

