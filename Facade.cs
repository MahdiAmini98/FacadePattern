using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacadePattern.SubSystem1;
using FacadePattern.SubSystem2;
using FacadePattern.SubSystem3;

namespace FacadePattern
{
    public class Facade
    {
        public void doSomething()
        {
            Class1 class1 = new Class1();
            Class2 class2 = new Class2();
            Class3 class3 = new Class3();

            class1.Action1();
            class2.Action2();
            class3.Action3();
            class1.Finish();
        }
    }
}
