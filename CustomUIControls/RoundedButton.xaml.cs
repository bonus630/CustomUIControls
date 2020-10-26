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
    /// Interaction logic for RoundedButton.xaml
    /// </summary>
    public partial class RoundedButton : Button, INotifyPropertyChanged
    {
        public RoundedButton()
        {
            InitializeComponent();
            this.DataContext = this;
         
        }
        private Brush backgroundOver;

        [Category("Brush")]
        public Brush BackgroundOver
        {
            get { return backgroundOver; }
            set { backgroundOver = value; OnPropertyChanged(); }
        }
        private double cornerRadius;

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
        [Category("Layout"), Description("Curve the corners of the button when the corner radius value is greater than 0.")]
        public double CornerRadius
        { get { return cornerRadius; } set { cornerRadius = value;OnPropertyChanged(); } }
        
      
    }
}
