using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace ClassLibrary1
{
    [Guid("77C507CE-E6D8-4780-B7E6-46526271CD05")]
    [ComVisible(true)]
    [ClassInterface(ClassInterfaceType.None)]
    public class Class1 : IClass1
    {
        public double SumVector(double[] arr)
        {
            double sum = 0;
            foreach(var d in arr)
            {
                sum += d;
            }
            return sum;
        }
    }
}
