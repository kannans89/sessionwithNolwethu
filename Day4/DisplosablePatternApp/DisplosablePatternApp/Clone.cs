using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DisplosablePatternApp
{
    class Clone :IDisposable
    {

        public int Id { get; set; }

        public Clone(int id) { 
           this.Id = id;
        }


        ~Clone() { // Destructor  for GC
            MessageBox.Show($"Aaaah..you got me {this.Id}");
        }

        public void Dispose() // For programmer to call
        {
            MessageBox.Show($"I have been disposed # {Id}");
        }
    }
}
