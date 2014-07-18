using Intersoft.Crosslight;
using Intersoft.Crosslight.Containers;
using DataSamples.ViewModels;
using DataSamples.ModelServices;

namespace DataSamples.Infrastructure
{
    public sealed class DataSamplesAppService : ApplicationServiceBase
    {
        public DataSamplesAppService(IApplicationContext context)
            : base(context)
        {
            Container.Current.Register<IItemRepository, ItemRepository>().WithLifetimeManager(new ContainerLifetime());
            Container.Current.Register<ICategoryRepository, CategoryRepository>().WithLifetimeManager(new ContainerLifetime());
        }

        protected override void OnStart(StartParameter parameter)
        {
            base.OnStart(parameter);

            // Register required core app-level services via IoC
            // Container.Current.Register<IPaymentProcessor, PaypalPaymentProcessor>();

            // Set the root ViewModel to be displayed at startup
            this.SetRootViewModel<NavigationViewModel>();
        }
    }
}
