using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace DataGrid
{
    public class Product : INotifyPropertyChanged, ICloneable
    {
        public string _id { get; set; }
        public string name { get; set; }
        public double price { get; set; }
        public string producer { get; set; }
        public int manufacture { get; set; }

        public event PropertyChangedEventHandler? PropertyChanged;

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
