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
using System.Windows.Shapes;
using SmartCA.SmartClient.App.ViewModels;

namespace SmartCA.SmartClient.App.Views
{
    /// <summary>
    /// Interaction logic for SelectProjectView.xaml
    /// </summary>
    public partial class SelectProjectView : Window,IView
    {
        public SelectProjectView()
        {
            InitializeComponent();

            this.DataContext = new SelectProjectViewModel(this);
        }
    }
}
