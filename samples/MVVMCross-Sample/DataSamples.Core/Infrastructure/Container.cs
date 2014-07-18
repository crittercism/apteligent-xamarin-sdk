using Intersoft.Crosslight.Containers;
using System;
using System.ComponentModel;
using System.Windows;

namespace DataSamples.Infrastructure
{
    public class Container
    {
        private static IDependencyContainer _current = null;

        public static IDependencyContainer Current
        {
            get
            {
                if (_current == null)
                    _current = new IocContainer();

                return _current;
            }
        }
    }
}
