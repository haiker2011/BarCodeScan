using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using PostOpDev;
using ZXing.Mobile;
namespace PostOp
{
    /*
     实现在可移植中定义的接口
     */
    public class BarCodeScan:IBarCodeScan
    {
        ZXing.Mobile.MobileBarcodeScanner scanner;
        public  BarCodeScan()
        {
             Context s = null;//定义为全局变量
             //scanner = new ZXing.Mobile.MobileBarcodeScanner(s);
             scanner = new MobileBarcodeScanner(s);
          
        }
        public async void scan()
        {
            var result = await scanner.Scan();

            if (result != null)
                Console.WriteLine("Scanned Barcode: " + result.Text);
        }
    }
}