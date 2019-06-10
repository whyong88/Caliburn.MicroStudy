﻿using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Threading;
using Caliburn.Micro;
using WpfApp1.ViewModels;

namespace WpfApp1
{
    public class Bootstrapper:BootstrapperBase
    {
        private SimpleContainer container;

        public Bootstrapper()
        {
            Initialize();
        }

        protected override void Configure()
        {
            container = new SimpleContainer();
            container.Instance(container);

            container.Singleton<IWindowManager, WindowManager>();
            container.Singleton<IEventAggregator, EventAggregator>();

            container
                .PerRequest<ShellViewModel>()
                .PerRequest<MenuViewModel>()
                .PerRequest<ActionsViewModel>()
                .PerRequest<BindingsViewModel>()
                .PerRequest<BubblingViewModel>()
                .PerRequest<ConductorViewModel>()
                .PerRequest<CoroutineViewModel>()
                .PerRequest<DesignTimeViewModel>()
                .PerRequest<EventAggregationViewModel>();
        }

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            DisplayRootViewFor<ShellViewModel>();
        }

        protected override object GetInstance(Type service, string key)
        {
            return container.GetInstance(service, key);
        }

        protected override IEnumerable<object> GetAllInstances(Type service)
        {
            return container.GetAllInstances(service);
        }

        protected override void BuildUp(object instance)
        {
            container.BuildUp(instance);
        }
        protected override void OnUnhandledException(object sender, DispatcherUnhandledExceptionEventArgs e)
        {
            e.Handled = true;
            MessageBox.Show(e.Exception.Message, "An error as occurred", MessageBoxButton.OK);
        }
    }
}