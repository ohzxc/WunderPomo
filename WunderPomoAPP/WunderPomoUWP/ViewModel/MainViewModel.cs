using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;

namespace WunderPomoUWP.ViewModel
{
    public class MainViewModel
    {
        private ObservableCollection<TaskViewModel> localTaskList;

        public ObservableCollection<TaskViewModel> LocalTaskList
        {
            get { return localTaskList; }
            set { localTaskList = value; }
        }


    }
}
