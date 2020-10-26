using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace br.corp.bonus630.wpf.CustomUIControls
{
    /// <summary>
    /// Interaction logic for CircleCloseButton.xaml
    /// </summary>
    public partial class CircleCloseButton : Button
    {
        public CircleCloseButton()
        {
            InitializeComponent();
            this.DataContext = this; Path path = new Path();
            this.Height = 20;
            this.Width = 20;
           
        }

       
        [Browsable(false)]
        public new object Content
        {
            get;
            set;
        }
        [Browsable(false)]
        public new object Width
        {
            get;
            set;
        }
        [Browsable(false)]
        public new object Height
        {
            get;
            set;
        }
        [Category("Brush")]
        public Brush BackgroundOver
        {
            get;set;
        }
        [Category("Brush")]
        public Brush ForegroundOver
        {
            get; set;
        }
        //protected PathGeometry Path1
        //{
        //    get
        //    {
        //        PathGeometry geometry = new PathGeometry();
        //        Matrix matrix = geometry.Transform.Value;
        //        matrix.M11 = 4;
        //        matrix.M12 = 4;
        //        matrix.M21 = 16;
        //        matrix.M22 = 16;

        //        return geometry;
        //    }
        //}
        ////M4,16 L16,4
        //      protected PathGeometry Path2
        //{
        //    get
        //    {
        //        PathGeometry geometry = new PathGeometry();
        //        Matrix matrix = geometry.Transform.Value;
                
        //        matrix.M11 = 4;
        //        matrix.M12 = 16;
        //        matrix.M21 = 16;
        //        matrix.M22 = 4;

        //        return  geometry;
        //    }
        //}


    }
}
