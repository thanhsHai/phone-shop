using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DataGrid
{
    public partial class User : INotifyPropertyChanged, ICloneable
    {
        public string _id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string userName { get; set; }
        public string userPassword { get; set; }

        public event PropertyChangedEventHandler? PropertyChanged;

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
