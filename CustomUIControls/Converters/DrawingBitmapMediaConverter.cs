using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows;
using System.Windows.Interop;
using System.Windows.Media.Imaging;
using System.Resources;
using br.corp.bonus630.wpf.CustomUIControls.Properties;

namespace br.corp.bonus630.wpf.CustomUIControls.Converters
{
    public class DrawingBitmapMediaConverter : IValueConverter
    {
        private static CultureInfo cultureInfo;
        private static string resourceName;
        private static global::System.Resources.ResourceManager resourceMan;
        private static string resourceBase;

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            //    "TesteTreeViewBinding.Properties.Resources.Search_32px"
            string res = value.ToString();
            string[] p = res.Split('.');
            resourceBase = string.Format("{0}.{1}.{2}", p[0], p[1], p[2]);
            resourceName = res.Replace(resourceBase, "");
            cultureInfo = culture;
            resourceName = value.ToString();
            System.Drawing.Bitmap bitmap = GetBitmap();
            var bitmapSource = Imaging.CreateBitmapSourceFromHBitmap(bitmap.GetHbitmap(), IntPtr.Zero, Int32Rect.Empty, BitmapSizeOptions.FromEmptyOptions());
            bitmap.Dispose();
            return bitmapSource;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    
      

    }
}
