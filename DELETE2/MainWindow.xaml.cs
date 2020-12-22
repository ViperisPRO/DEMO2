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

namespace DELETE2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<View_StroyMaterial> _MyStroyMaterial; // 
        public List<View_StroyMaterial> MyStroyMaterial   /* MyStroyMaterial это вставляется в MainWindow 
                                                           <DataGrid Grid.Column="1" ItemsSource="{Binding MyStroyMaterial}" AutoGenerateColumns="False">
                                                            MyStroyMaterial это присвоение значиеня*/
        {
            get
            {
                return _MyStroyMaterial; // _ обязательно
            }
            set
            {
                _MyStroyMaterial = value;
            }
        }
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
            MyStroyMaterial = Core.DB.View_StroyMaterial.ToList(); // подключение к БД, StroyMaterial это таблица
        }

    }
}
