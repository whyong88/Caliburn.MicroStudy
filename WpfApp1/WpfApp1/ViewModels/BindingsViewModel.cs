using Caliburn.Micro;
using WpfApp1.Common;
using WpfApp1.ViewModels.Activity;

namespace WpfApp1.ViewModels
{
    public class BindingsViewModel:Screen
    {
        private ActivityBaseViewModel selectedActivity;

        public BindingsViewModel()
        {
            Activities = new BindableCollection<ActivityBaseViewModel>
            {
                new MessageActivityViewModel(Lipsum.Get()),
                new PhotoActivityViewModel(Lipsum.Get()),
                new MessageActivityViewModel(Lipsum.Get()),
                new PhotoActivityViewModel(Lipsum.Get())
            };
        }

        public BindableCollection<ActivityBaseViewModel> Activities { get; set; }

        public ActivityBaseViewModel SelectedActivity
        {
            get { return selectedActivity; }
            set { Set(ref selectedActivity, value); }
        }
    }
}