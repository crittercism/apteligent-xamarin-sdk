using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataSamples.ModelServices
{
    public interface IDataService : IDisposable
    {
        void SaveChanges(Action onSuccess = null, Action<Exception> onError = null);
        void RejectChanges();
    }
}
