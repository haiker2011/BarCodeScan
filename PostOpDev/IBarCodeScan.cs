using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostOpDev
{
    /*
     定义接口，对android和iOS不同的方法进行封装定义
     */
    public interface IBarCodeScan
    {
        void scan();
    }
}
