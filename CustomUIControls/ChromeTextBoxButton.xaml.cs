using System;
using System.Collections.Generic;
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
using System.ComponentModel;

namespace br.corp.bonus630.wpf.CustomUIControls
{
    /// <summary>
    /// Interaction logic for ChromeTextBoxButton.xaml
    /// </summary>
    public partial class ChromeTextBoxButton : Button,INotifyPropertyChanged
    {
        public ChromeTextBoxButton()
        {
            InitializeComponent();
            this.DataContext = this;
           
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
        private StyleTheme theme;
        [Category("Theme")]
        public StyleTheme Mode
        {
            get { return theme; }
            set { theme = value;
                OnPropertyChanged();
            }
        }

        public string TextBoxMouseOverBackground
        {
            get
            {
                if (theme == StyleTheme.Normal)
                    return "#FFDEE0E1";
                else
                    return "#FF4B4F52";
            }
        }
        [Browsable(false)]
        public new object Content
        {
            get; set;
        }
        [Browsable(false)]
        public new Brush Background { get; set; }
        [Browsable(false)]
        public new Brush Foreground { get; set; }
        [Browsable(false)]
        public new Brush BorderBrush { get; set; }
        [Browsable(false)]
        public new Brush OpacityMask { get; set; }
        [Category("Common")]
        public ImageSource Source { get; set; }
        [Category("Common")]
        public Stretch Stretch { get; set; }
        [Category("Common")]
        public StretchDirection StretchDirection { get; set; }
       
       
      
        //[Category("Miscellaneous")]
        //public side Side { get; set; }
        //public enum side
        //{
        //    Left,
        //    Right
        //}
    }
}
