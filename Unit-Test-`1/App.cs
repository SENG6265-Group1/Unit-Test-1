using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unit_Test__1.Model.Impl;
using System;
using System.Diagnostics;
using Unit_Test__1.Model;
using Unit_Test__1.Model.Impl;

namespace Unit_Test__1
{
    public class App
    {
        private Action<string> writeline;

        public App(Action<string> writeline)
        {
            this.writeline = writeline;
        }

        public void Run()
        {
            Item firstItem = new ItemImpl(1, "First Item", UnitOfMeasure.POUND, 10);
            //Debug.WriteLine(firstItem);
            //Console.WriteLine(firstItem);

            writeline(firstItem.ToString());

        }
    }
}
