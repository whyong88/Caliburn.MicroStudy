﻿using System.Threading;
using Caliburn.Micro;
using WpfApp1.Messages;

namespace WpfApp1.ViewModels.Events
{
    public class EventSourceViewModel:Screen
    {
        private readonly IEventAggregator eventAggregator;
        private string text;

        public EventSourceViewModel(IEventAggregator eventAggregator)
        {
            this.eventAggregator = eventAggregator;
        }

        public string Text
        {
            get { return text; }
            set { Set(ref text, value); }
        }

        public async void Publish()
        {
            await eventAggregator.PublishOnUIThreadAsync(new SimpleMessage(Text), CancellationToken.None);
        }
    }
}