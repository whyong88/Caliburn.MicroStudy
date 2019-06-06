﻿using System;
using System.Windows;
using Caliburn.Micro;

namespace WpfApp1.Results
{
    public class VisualStateResult:ResultBase
    {
        public VisualStateResult(string stateName, bool useTransitions = true)
        {
            StateName = stateName;
            UseTransitions = useTransitions;
        }

        public string StateName { get;  }

        public bool UseTransitions { get; }

        public override void Execute(CoroutineExecutionContext context)
        {
            if (!(context.View is FrameworkElement))
            {
                throw new InvalidOperationException("View must be a FrameworkElement to use VisualStateResult");
            }

            var view = (FrameworkElement) context.View;
            var success = VisualStateManager.GoToElementState(view, StateName, UseTransitions);
            OnCompleted();
        }
    }
}