using Caliburn.Micro;
using WpfApp1.ViewModels.Events;

namespace WpfApp1.ViewModels
{
    public class EventAggregationViewModel:Screen
    {
        public EventAggregationViewModel(IEventAggregator eventAggregator)
        {
            Source = new EventSourceViewModel(eventAggregator);
            Destination = new EventDestinationViewModel(eventAggregator);
        }

        public EventSourceViewModel Source { get; }

        public EventDestinationViewModel Destination { get; }
    }
}