using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace data_binding
{
    public enum Manufacturers { countprod_inc, countfabr_inc, metmak_inc }
    public enum Models { cpr36, cf24, mm57 }
    public class Wat_count : INotifyPropertyChanged
    {
        private string text_block_of_man, text_block_of_mod;//производитель и модель
        private int text_block_of_ser_numb;
        private DateTime Time;
        private bool Is_intended;
        public event PropertyChangedEventHandler PropertyChanged = delegate { };
        public Wat_count()
        {
            this.Manufacturer = "";
            this.Model = "";
            this.Ser_numb = 0;//исходное значение серийного номера
        }
        public string Manufacturer
        {
            get { return this.text_block_of_man; }
            set
            {
                this.text_block_of_man = value;
                this.On_prop_chang();
            }
        }
        public string Model
        {
            get { return this.text_block_of_mod; }
            set
            {
                this.text_block_of_mod = value;
                this.On_prop_chang();
            }
        }
        public int Ser_numb
        {
            get { return this.text_block_of_ser_numb; }
            set
            {
                this.text_block_of_ser_numb = value;
                this.On_prop_chang();
            }
        }
        public DateTime DateTime
        {
            get { return this.Time; }
            set
            {
                this.Time = value;
                this.On_prop_chang();
            }
        }
        public bool Is_int
        {
            get { return this.Is_intended; }
            set
            {
                this.Is_intended = value;
                this.On_prop_chang();
            }
        }
        public void On_prop_chang([CallerMemberName] string propertyName = null) { this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName)); }
    }
}