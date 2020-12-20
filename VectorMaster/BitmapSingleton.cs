using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorMaster
{
    public class BitmapSingleton
    {
        static private BitmapSingleton _instance;
        public Bitmap bitmap { get; set; }
        private BitmapSingleton() {  }

        public static BitmapSingleton CreateBitmap()
        {
            if(_instance == null)
            {
                _instance = new BitmapSingleton();
                return _instance;
            }
            else
            {
                return _instance;
            }
        }
    }
}
