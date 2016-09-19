using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using WunderPomoUWP.Model;

namespace WunderPomoUWP.ViewModel
{
    public class TaskViewModel : ObservableObject
    {
        private BaseTask task;

        public BaseTask Task
        {
            get { return task; }
            set { task = value; RaisePropertyChanged(nameof(Task)); }
        }



    }
}
