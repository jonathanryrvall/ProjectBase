using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using System;
using System.Collections.Generic;
using System.Text;
using WPFProjectBase.Services;

namespace WPFProjectBase.ViewModel
{

    public class ViewModelLocator
    {
        public ViewModelLocator()
        {
            // Dialog service



            SimpleIoc.Default.Register<MainVM>();
            SimpleIoc.Default.Register<PathsService>();
            SimpleIoc.Default.Register<ConfigService>();


            //SimpleIoc.Default.Register<AssetsDataService>();
            //SimpleIoc.Default.Register<AssetGraphVM>();
            //SimpleIoc.Default.Register<AssetListVM>();

            // Create design time view services and models
            //     SimpleIoc.Default.Register<IDataService, DesignDataService>();
            ////}
            ////else
            ////{
            ////    // Create run time view services and models
            ////    SimpleIoc.Default.Register<IDataService, DataService>();
            ////}

            //   ServiceLocator.SetLocatorProvider();
            // SimpleIoc.Default.getin



        }


        public MainVM MainVM => SimpleIoc.Default.GetInstance<MainVM>();


    }
}
