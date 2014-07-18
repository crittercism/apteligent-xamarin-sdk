using System;
using Intersoft.Crosslight.ViewModels;
using DataSamples.Models;
using Intersoft.Crosslight;

namespace DataSamples.ViewModels
{
    public class ItemDetailViewModel : DetailViewModelBase<Item>
    {
        public override void Navigated(NavigatedParameter parameter)
        {
            this.Item = parameter.Data as Item;
        }
    }
}

