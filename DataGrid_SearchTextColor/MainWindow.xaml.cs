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

namespace DataGrid_SearchTextColor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ICollectionView LstStudentView { get; set; }

        public static string SearchText { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            List<Student> lstStu = new List<Student>();
            lstStu.Add(new Student() { ID = "1001", Name = "张三", Age = 18 });
            lstStu.Add(new Student() { ID = "1002", Name = "里斯", Age = 18 });
            lstStu.Add(new Student() { ID = "1003", Name = "王五", Age = 18 });
            lstStu.Add(new Student() { ID = "1004", Name = "赵六", Age = 18 });

            LstStudentView = CollectionViewSource.GetDefaultView(lstStu);
            this.DataContext = this;
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.SearchText = this.tbxSearchBox.Text.Trim();
            this.LstStudentView.Refresh();
        }
    }
}
