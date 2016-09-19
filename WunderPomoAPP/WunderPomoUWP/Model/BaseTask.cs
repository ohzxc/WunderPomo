using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;

namespace WunderPomoUWP.Model
{
    public class BaseTask : ObservableObject
    {

        private string id;

        public string ID
        {
            get { return id; }
            set { id = value; RaisePropertyChanged(nameof(ID)); }
        }

        private string title;

        public string Title
        {
            get { return title; }
            set { title = value; RaisePropertyChanged(nameof(Title)); }
        }

        private string describe;

        public string Describe
        {
            get { return describe; }
            set { describe = value; RaisePropertyChanged(nameof(Describe)); }
        }


    }
}
