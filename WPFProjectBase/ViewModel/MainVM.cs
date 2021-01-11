using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Text;

namespace WPFProjectBase.ViewModel
{
    public class MainVM : ViewModelBase
    {
        public RelayCommand TestCommand { get; set; }


        public MainVM()
        {
            TestCommand = new RelayCommand(() =>
            {

            });
        }

    }
}
