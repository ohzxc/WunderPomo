﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using WunderPomoUWP.ViewModel;

//“空白页”项模板在 http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409 上有介绍

namespace WunderPomoUWP
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            var datacontext = new MainViewModel();
            var localTaskList = new ObservableCollection<TaskViewModel>();
            localTaskList.Add(new TaskViewModel { Task = new Model.BaseTask() { Title = "t1" } });
            localTaskList.Add(new TaskViewModel { Task = new Model.BaseTask() { Title = "t2" } });
            localTaskList.Add(new TaskViewModel { Task = new Model.BaseTask() { Title = "t3" } });
            datacontext.LocalTaskList = localTaskList;
            DataContext = datacontext;
            this.InitializeComponent();
            
        }
    }
}
