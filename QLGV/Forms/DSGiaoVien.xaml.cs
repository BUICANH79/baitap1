using QLGV.Model;
using QLGV.Utils;
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
using System.Windows.Shapes;

namespace QLGV.Forms
{
    /// <summary>
    /// Interaction logic for GiaoVien.xaml
    /// </summary>
    public partial class DSGiaoVien : Window
    {
        GiaoVienViewModel vm;
        public DSGiaoVien()
        {
            InitializeComponent();
            vm = new GiaoVienViewModel();
            DataContext = vm;
        }


        private void BtnThoatClick(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Quản lý GV", MessageBoxButton.YesNo, MessageBoxImage.Question);
            switch (result)
            {
                case MessageBoxResult.Yes:
                    System.Windows.Application.Current.Shutdown();
                    break;
                case MessageBoxResult.No:
                    break;
            }
        }
        private void grGiaoVien_Delete(object sender, RoutedEventArgs e)
        {
            var menuItem = (MenuItem)sender;

            var contextMenu = (ContextMenu)menuItem.Parent;

            var item = (DataGrid)contextMenu.PlacementTarget;
            var b = item.SelectedValue;
            if (b is GiaoVien)
            {
                var c = b as GiaoVien;
                MessageBoxResult result = MessageBox.Show("Bạn muốn xóa giáo viên " + c.TenGiaoVien + " khỏi cơ sở dữ liệu?", "Xóa giáo viên?", MessageBoxButton.YesNo, MessageBoxImage.Question);
                switch (result)
                {
                    case MessageBoxResult.Yes:
                        var deleteResult = DAL.DeleteGiaoVien(c.MaGiaoVien);
                        if (deleteResult > -1)
                        {
                            MessageBox.Show("Xóa Giáo viên khỏi cơ sở dữ liệu thành công");
                        }
                        break;
                    case MessageBoxResult.No:
                        break;
                }
            }
        }
        private void grGiaoVien_ShowInfo(object sender, RoutedEventArgs e)
        {
            var menuItem = (MenuItem)sender;

            var contextMenu = (ContextMenu)menuItem.Parent;

            var item = (DataGrid)contextMenu.PlacementTarget;
            var b = item.SelectedValue;
            if (b is GiaoVien)
            {
                var c = b as GiaoVien;
                var giaoVienInfo = new GiaoVienInfo(c);
                giaoVienInfo.ShowDialog();
            }
        }
        private void grGiaoVien_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (sender != null)
            {
                DataGridRow row = sender as DataGridRow;
                if (row != null)
                {
                    var item = row.DataContext as GiaoVien;
                    if (item != null)
                    {
                        var giaoVienInfo = new GiaoVienInfo(item);
                        giaoVienInfo.ShowDialog();
                    }
                }
            }
        }
    }
    public class GiaoVienViewModel : INotifyPropertyChanged
    {
        public GiaoVienViewModel()
        {
            _listCoSo = new CollectionView(DAL.GetListCoSo());
        }

        CollectionView _listCoSo;
        public CollectionView ListCoSo
        {
            get { return _listCoSo; }
        }

        private string _coSoItem;
        public string CoSoItem
        {
            get { return _coSoItem; }
            set
            {
                if (_coSoItem == value) return;
                _coSoItem = value;
                if (!string.IsNullOrEmpty(_coSoItem))
                {
                    _listDonVi = new CollectionView(DAL.GetListDonVi(_coSoItem));
                    OnPropertyChanged("ListDonVi");
                }
                OnPropertyChanged("CoSoItem");
            }
        }

        CollectionView _listDonVi;
        public CollectionView ListDonVi
        {
            get { return _listDonVi; }
        }

        private string _donViItem;
        public string DonViItem
        {
            get { return _donViItem; }
            set
            {
                if (_donViItem == value) return;
                _donViItem = value;
                IsShowContextMenu = false;
                if (!string.IsNullOrEmpty(_donViItem))
                {
                    var dt = DAL.GetListGiaoVien(_donViItem);
                    _listGV = new CollectionView(dt);
                    OnPropertyChanged("ListGiaovien");
                    if (dt != null && dt.Count > 0)
                        IsShowContextMenu = true;
                }
                OnPropertyChanged("DonViItem");
                OnPropertyChanged("IsShowContextMenu");
            }
        }

        CollectionView _listGV;
        public CollectionView ListGiaovien
        {
            get { return _listGV; }
        }

        private GiaoVien _gv;
        public GiaoVien GiaoVienItem
        {
            get { return _gv; }
            set
            {
                if (_gv == value) return;
                _gv = value;
                OnPropertyChanged("GiaoVienItem");
            }
        }
        private bool _IsShowContextMenu;
        public bool IsShowContextMenu
        {
            get { return _IsShowContextMenu; }
            set
            {
                if (_IsShowContextMenu == value) return;
                _IsShowContextMenu = value;
                OnPropertyChanged("IsShowContextMenu");
            }
        }


        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }

}
