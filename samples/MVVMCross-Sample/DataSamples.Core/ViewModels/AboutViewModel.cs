using System;
using Intersoft.Crosslight;
using Intersoft.Crosslight.Input;
using Intersoft.Crosslight.ViewModels;

namespace DataSamples.ViewModels
{
    public class AboutViewModel : ViewModelBase
    {
        private string _greetingText;

        public AboutViewModel()
        {
            this.GreetingText = "Hello World from Crosslight!";
            this.LearnMoreCommand = new DelegateCommand(ExecuteLearnMore);
        }

        public DelegateCommand LearnMoreCommand { get; set; }

        public string GreetingText
        {
            get { return _greetingText; }
            set
            {
                if (_greetingText != value)
                {
                    _greetingText = value;
                    OnPropertyChanged("GreetingText");
                }
            }
        }

        private void ExecuteLearnMore(object parameter)
        {
			//Crash instead
			throw new System.Exception("MyCustom Exception");
            //this.MobileService.Browser.Navigate("http://www.intersoftpt.com/crosslight");
        }
    }
}

