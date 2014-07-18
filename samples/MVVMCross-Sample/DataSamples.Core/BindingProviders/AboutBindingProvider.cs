using System;
using Intersoft.Crosslight;

namespace DataSamples
{
    public class AboutBindingProvider : BindingProvider
    {
        public AboutBindingProvider()
        {
            this.AddBinding("GreetingLabel", BindableProperties.TextProperty, "GreetingText");
            this.AddBinding("LearnMoreButton", BindableProperties.CommandProperty, "LearnMoreCommand");
        }
    }
}

