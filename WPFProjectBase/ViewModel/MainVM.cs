﻿using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Text;
using WPFProjectBase.Services;

namespace WPFProjectBase.ViewModel
{
    public class MainVM : ObservableRecipient
    {
        public RelayCommand TestCommand { get; set; }

        private string testValue;
        private ConfigService configService;

        public string TestValue
        {
            get => testValue;
            set => SetProperty(ref testValue, value);
        }

        public MainVM(ConfigService configService)
        {
            this.configService = configService;

            TestCommand = new RelayCommand(() =>
            {
                TestValue = this.configService.Config.DatabaseConfiguration.DatabaseName;
            });
        }

    }
}
