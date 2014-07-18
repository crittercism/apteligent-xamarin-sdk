using Intersoft.Crosslight;
using Intersoft.Crosslight.WinPhone;
using DataSamples.Infrastructure;

namespace DataSamples.WinPhone.Infrastructure
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
