using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCounterApp.Model
{
    internal class Student :Object
    {
        private string _name;//instance variable
        private static int _count;

        public Student(string name) {
            this._name = name;
            _count += 1;
        }

        public int GetCount() { //instance method
          return _count;
        }

        public static int HeadCount() { //static method
            return _count;
        }

    }
}
