﻿using System;
using System.Windows;

namespace WpfApp1.ViewModels
{
    public class FeatureViewModel
    {
        public FeatureViewModel(string title, string description, Type viewModel)
        {
            ViewModel = viewModel;
            Title = title;
            Description = description;
        }

        public string Title { get; }

        public string Description { get; }

        public Type ViewModel { get; }

    }
}