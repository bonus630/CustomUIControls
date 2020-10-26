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
    /// Interaction logic for ChromeTextBox.xaml
    /// </summary>
    public partial class ChromeTextBox : TextBox,INotifyPropertyChanged
    {
        List<ChromeTextBoxButton> buttonsLeft = new List<ChromeTextBoxButton>();
        List<ChromeTextBoxButton> buttonsRight = new List<ChromeTextBoxButton>();
        public ChromeTextBox()
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
        [Browsable(false)]
        public new double Width { get; set; }

        //public FontFamily Noto
        //{
        //    get
        //    {
        //        FontFamily family = new FontFamily(new Uri("CustomUIControls.Resources.NotoSans-Regular.ttf"), "noto");
        //        return family;
        //    }
        //}
        private StyleTheme theme;
        [Category("Theme")]
        public StyleTheme Mode
        {
            get { return theme; }
            set { theme = value; OnPropertyChanged(); }
        }
       
        public Thickness Margins
        {
            get {
                Thickness margin = new Thickness();
                double left = 15;
                if(buttonsLeft.Count > 0)
                     left =  (buttonsLeft.Count * 33);
                double right = 15;
                if (buttonsRight.Count > 0)
                    right = buttonsRight.Count * 33;
                margin.Left = left;
                margin.Right = right;
                margin.Top = 0;
                margin.Bottom =0;
                return margin; }
            set {; }
        }
        
        [Browsable(false)]
        public new Brush Foreground
        {
            get
            {
                if (theme == StyleTheme.Normal)
                    return SystemColors.ControlTextBrush;
                else
                    return SystemColors.ControlLightBrush;
            }
          
        }

        public string TextBoxStaticBorder
        {
            get
            {
                if (theme == StyleTheme.Normal)
                    return "#FFB3CEFB";
                else
                    return "";
            }
        }
        public string TextBoxMouseOverBorder
        {
            get
            {
                if (theme == StyleTheme.Normal)
                    return "#FF7EB4EA";
                else
                    return "#FF7EB4EA";
            }
        }
        public string TextBoxFocusBorder
        {
            get
            {
                if (theme == StyleTheme.Normal)
                    return "#FFB3CEFB";
                else
                    return "#FF5B6E8B";
            }
        }
        public string TextBoxFocusBackground
        {
            get
            {
                if (theme == StyleTheme.Normal)
                    return "#FFFFFFFF";
                else
                    return "#FF3C4043";
            }
        }
        public string TextBoxStaticBackground
        {
            get
            { 
                if (theme == StyleTheme.Normal)
                    return "#FFF1F3F4";
                else
                    return "#FF282C2F";
               
            }
        }
        public string TextBoxMouseOverBackground
        {
            get
            {
                if (theme == StyleTheme.Normal)
                    return "#FFE8EAED";
                else
                    return "#FF2F3336";
            }
        }
        [Category("Buttons")]
        public List<ChromeTextBoxButton> ButtonsRight
        {
            get { return buttonsRight; }
            set { buttonsRight = value; }
        }
        [Category("Buttons")]
        public List<ChromeTextBoxButton> ButtonsLeft
        {
            get { return buttonsLeft; }
            set { buttonsLeft = value; }
        }
        [Category("Buttons")]
        public ChromeTextBoxButton ButtonRight
        {
            get ;             set  ; 
        }
        [Browsable(false)]
        public new Brush Background { get; set; }
       
        
        [Browsable(false)]
        public new Brush BorderBrush { get; set; }
        [Browsable(false)]
        public new Brush OpacityMask { get; set; }
    }
    public enum StyleTheme
    {
        Normal,
        Private
    }
}