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

namespace QLGV
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //txtServerName.Text = "DESKTOP-8PS0UCH";
            txtCataLog.Text = "QLGV";
         txtUserName.Text = "user";
            txtPassword.Password = "12345678"; 
        }
            
        private void BtnConnect_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtServerName.Text))
                {
                    MessageBox.Show("Chưa nhập Tên máy");
                    txtServerName.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txtCataLog.Text))
                {
                    MessageBox.Show("Chưa nhập Tên CSDL");
                    txtCataLog.Focus();
                    return;
                }
                QLGV.Utils.DAO.SetConnnectionString(txtServerName.Text.Trim(), txtCataLog.Text.Trim(),
                    txtUserName.Text, txtPassword.Password.ToString());
                var isConnectOk = QLGV.Utils.DAO.IsConnect();
                if (isConnectOk)
                {
                    MessageBox.Show("Kết nối CSDL thành công");
                    this.Hide();
                    var giaoVien = new QLGV.Forms.DSGiaoVien();
                    giaoVien.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Kết nối CSDL không thành công. Vui lòng kiểm tra lại");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {
            var response = MessageBox.Show("Bạn thực sự muốn thoát?", "Thoát ...",
                                     MessageBoxButton.YesNo, MessageBoxImage.Exclamation);
            if (response == MessageBoxResult.Yes)
            {
                this.Close();
            }
            else
            {

            }

        }
    }
}