using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace ClassLibrary1
{
    [Guid("2E09C500-0C87-4EBF-A196-3D0E6770E55D")]
    [ComVisible(true)]
    [InterfaceType(ComInterfaceType.InterfaceIsDual)]
    public interface IClass1
    {
        [DispId(1)]
        double SumVector(double[] arr);
    }
}
