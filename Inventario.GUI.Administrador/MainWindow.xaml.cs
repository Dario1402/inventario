using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Inventario.GUI.Administrador
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            PutButtonsEmployeeInEdition(false);
            CleanTextBoxEmployee();
        }

        private void CleanTextBoxEmployee()
        {
            TbxEmployeeLastName.Clear();
            TbxEmployeeArea.Clear();
            TbxEmployeeId.Text = "";
            TbxEmployeeName.Clear();
        }

        private void PutButtonsEmployeeInEdition(bool value)
        {
            BtnEmployeeCancel.IsEnabled = value;
            BtnEmployeeUpdate.IsEnabled = !value;
            BtnEmployeeDelete.IsEnabled = !value;
            BtnEmployeeInsert.IsEnabled = value;
            BtnEmployeeNew.IsEnabled = !value;
        }

        private void BtnEmployeeUpdate_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnEmployeeInsert_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnEmployeeCancel_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnEmployeeDelete_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnEmployeeNew_Click(object sender, RoutedEventArgs e)
        {
            CleanTextBoxEmployee();
            BtnEmployeeInsert(true);

        }
    }
}