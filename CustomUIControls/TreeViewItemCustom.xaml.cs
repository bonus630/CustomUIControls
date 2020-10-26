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

namespace br.corp.bonus630.wpf.CustomUIControls
{
    /// <summary>
    /// Interaction logic for TreeViewItemCustom.xaml
    /// </summary>
    public partial class TreeViewItemCustom : TreeViewItem
    {
        public TreeViewItemCustom()
        {
            InitializeComponent();
            this.DataContext = this;
        }
    }
}
