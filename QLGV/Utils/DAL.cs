using QLGV.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace QLGV.Utils
{
    public static class DAL
    {
        public static List<CoSo> GetListCoSo()
        {
            try
            {
                string sqlText = "SELECT MaCoSo, TenCoSo FROM CoSo";
                List<CoSo> lstCoSo = new List<CoSo>();
                using (SqlConnection connection = new SqlConnection(DAO.sqlConnectionString))
                using (SqlCommand command = new SqlCommand(sqlText, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var kh = new CoSo();
                            kh.MaCoSo = reader.GetString(0);
                            kh.TenCoSo = reader.GetString(1);
                            lstCoSo.Add(kh);

                        }

                    }
                    connection.Close();

                }
                return lstCoSo;

            }

            catch (Exception ex)
            {
                MessageBox.Show("Loi khi mo  ket noi:" + ex.Message);

            }
            return null;
        }
        public static List<DonVi> GetListDonVi(string maCoSo)
        {
            try
            {
                string sqlText = "SELECT MaDonVi, TenDonVi FROM DonVi WHERE MaCoSo='" + maCoSo + "' ORDER BY TenDonVi";
                List<DonVi> lstDonVi = new List<DonVi>();
                using (SqlConnection connection = new SqlConnection(DAO.sqlConnectionString))
                using (SqlCommand command = new SqlCommand(sqlText, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var kh = new DonVi();
                            kh.MaDonVi = reader.GetString(0);
                            kh.TenDonVi = reader.GetString(1);
                            lstDonVi.Add(kh);
                        }
                    }
                    connection.Close();

                }
                return lstDonVi;

            }

            catch (Exception ex)
            {
                MessageBox.Show("Loi khi mo  ket noi:" + ex.Message);

            }
            return null;
        }
        public static List<GiaoVien> GetListGiaoVien(string maDonVi)
        {
            try
            {
                string sqlText = "select ROW_NUMBER() OVER(ORDER BY MaGV) AS STT,a.MaGV,a.HoTen,a.SoDT,a.GhiChu,b.TenDonVi,c.TenCoSo "
                                    + "from GiaoVien a LEFT JOIN DonVi b on a.MaDonVi = b.MaDonVi "
                                    + "LEFT JOIN CoSo c on c.MaCoSo = b.MaCoSo where a.MaDonVi='" + maDonVi + "'";
                List<GiaoVien> lstGiaoVien = new List<GiaoVien>();
                using (SqlConnection connection = new SqlConnection(DAO.sqlConnectionString))
                using (SqlCommand command = new SqlCommand(sqlText, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var kh = new GiaoVien();
                            kh.STT = reader.GetInt64(0);
                            if (!reader.IsDBNull(1))
                                kh.MaGiaoVien = reader.GetString(1);
                            if (!reader.IsDBNull(2))
                                kh.TenGiaoVien = reader.GetString(2);
                            if (!reader.IsDBNull(3))
                                kh.SoDT = reader.GetString(3);
                            if (!reader.IsDBNull(4))
                                kh.GhiChu = reader.GetString(4);
                            if (!reader.IsDBNull(5))
                                kh.TenDonVi = reader.GetString(5);
                            if (!reader.IsDBNull(6))
                                kh.TenCoSo = reader.GetString(6);
                            lstGiaoVien.Add(kh);

                        }

                    }
                    connection.Close();

                }
                return lstGiaoVien;

            }

            catch (Exception ex)
            {
                MessageBox.Show("Loi khi mo  ket noi:" + ex.Message);

            }
            return null;
        }
        public static int DeleteGiaoVien(string maGV)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(DAO.sqlConnectionString))
                using (SqlCommand command = new SqlCommand("DELETE FROM GiaoVien WHERE MaGV = @MaGV", connection))
                {
                    command.Parameters.Add("MaGV", SqlDbType.VarChar, 50).Value = maGV;
                    connection.Open();
                    var isOk = command.ExecuteNonQuery();
                    connection.Close();
                    return isOk;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Loi khi mo  ket noi:" + ex.Message);
                return -1;

            }

        }
    }
}
