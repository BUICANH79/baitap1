using QLGV.Model;
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

namespace QLGV.Forms
{
    /// <summary>
    /// Interaction logic for GiaoVienInfo.xaml
    /// </summary>
    public partial class GiaoVienInfo : Window
    {
        public GiaoVienInfo()
        {
           
        }
        private GiaoVien _gv;
        public GiaoVienInfo(GiaoVien gv):this()
        {
            InitializeComponent();
            _gv = gv;
            Title = string.Format("Thông tin giáo viên ({0})", _gv.TenGiaoVien);
            txtHoTen.Text = _gv.TenGiaoVien;
            txtSoDT.Text = _gv.SoDT;
            txtGhiChu.Text = _gv.GhiChu;
            txtDonVi.Text = _gv.TenDonVi;
            txtCoSo.Text = _gv.TenCoSo;
        }
        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
