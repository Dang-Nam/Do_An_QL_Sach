using System;
using System.Data;
using System.Data.SqlClient;

namespace ClassLibrary
{
    public class Read_DB
    {
        public string cnstr;

        public string get_khach_hang()
        {
            string json = "";
            try
            {
                using (SqlConnection conn = new SqlConnection(cnstr))
                {
                    conn.Open();
                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "SP_API";
                        cmd.Parameters.Add("@action", SqlDbType.VarChar, 50).Value = "get_khach_hang";
                        object result = cmd.ExecuteScalar();
                        json = (string)result;
                    }
                }
            }
            catch
            {
                json = "{\"ok\":0,\"msg\":\"Lỗi rồi\"}";
            }
            return json;
        }

        public string get_nhan_vien()
        {
            string json = "";
            try
            {
                using (SqlConnection conn = new SqlConnection(cnstr))
                {
                    conn.Open();
                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "SP_API";
                        cmd.Parameters.Add("@action", SqlDbType.VarChar, 50).Value = "get_nhan_vien";
                        object result = cmd.ExecuteScalar();
                        json = (string)result;
                    }
                }
            }
            catch
            {
                json = "{\"ok\":0,\"msg\":\"Lỗi rồi\"}";
            }
            return json;
        }

        public string get_sach()
        {
            string json = "";
            try
            {
                using (SqlConnection conn = new SqlConnection(cnstr))
                {
                    conn.Open();
                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "SP_API";
                        cmd.Parameters.Add("@action", SqlDbType.VarChar, 50).Value = "get_sach";
                        object result = cmd.ExecuteScalar();
                        json = (string)result;
                    }
                }
            }
            catch
            {
                json = "{\"ok\":0,\"msg\":\"Lỗi rồi\"}";
            }
            return json;
        }

        // Thêm sách
        public string AddSach(string MaSach, string TenSach, string TacGia, string NhaXuatBan, int NamXuatBan, string TheLoai)
        {
            string json = "";
            try
            {
                using (SqlConnection conn = new SqlConnection(cnstr))
                {
                    conn.Open();
                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "SP_API";
                        cmd.Parameters.Add("@action", SqlDbType.VarChar, 50).Value = "add_sach";
                        cmd.Parameters.Add("@MaSach", SqlDbType.VarChar, 50).Value = MaSach;
                        cmd.Parameters.Add("@TenSach", SqlDbType.NVarChar, 255).Value = TenSach;
                        cmd.Parameters.Add("@TacGia", SqlDbType.NVarChar, 255).Value = TacGia;
                        cmd.Parameters.Add("@NhaXuatBan", SqlDbType.NVarChar, 255).Value = NhaXuatBan;
                        cmd.Parameters.Add("@NamXuatBan", SqlDbType.Int).Value = NamXuatBan;
                        cmd.Parameters.Add("@TheLoai", SqlDbType.NVarChar, 100).Value = TheLoai;
                        object result = cmd.ExecuteScalar();
                        json = (string)result;
                    }
                }
            }
            catch (Exception ex)
            {
                json = "{\"ok\":0,\"msg\":\"Lỗi rồi: " + ex.Message + "\"}";
            }
            return json;
        }

        // Thêm nhân viên
        public string AddNhanVien(string MaNhanVien, string HoTen, string ChucVu)
        {
            string json = "";
            try
            {
                using (SqlConnection conn = new SqlConnection(cnstr))
                {
                    conn.Open();
                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "SP_API";
                        cmd.Parameters.Add("@action", SqlDbType.VarChar, 50).Value = "add_nhanvien";
                        cmd.Parameters.Add("@MaNhanVien", SqlDbType.VarChar, 50).Value = MaNhanVien;
                        cmd.Parameters.Add("@HoTen", SqlDbType.NVarChar, 255).Value = HoTen;
                        cmd.Parameters.Add("@ChucVu", SqlDbType.NVarChar, 100).Value = ChucVu;
                        object result = cmd.ExecuteScalar();
                        json = (string)result;
                    }
                }
            }
            catch (Exception ex)
            {
                json = "{\"ok\":0,\"msg\":\"Lỗi rồi: " + ex.Message + "\"}";
            }
            return json;
        }

        // Thêm khách hàng
        public string AddKhachHang(string MaKhachHang, string TenKhachHang, string ThongTinLienLac)
        {
            string json = "";
            try
            {
                using (SqlConnection conn = new SqlConnection(cnstr))
                {
                    conn.Open();
                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "SP_API";
                        cmd.Parameters.Add("@action", SqlDbType.VarChar, 50).Value = "add_khachhang";
                        cmd.Parameters.Add("@MaKhachHang", SqlDbType.VarChar, 50).Value = MaKhachHang;
                        cmd.Parameters.Add("@TenKhachHang", SqlDbType.NVarChar, 255).Value = TenKhachHang;
                        cmd.Parameters.Add("@ThongTinLienLac", SqlDbType.NVarChar, 50).Value = ThongTinLienLac;
                        object result = cmd.ExecuteScalar();
                        json = (string)result;
                    }
                }
            }
            catch (Exception ex)
            {
                json = "{\"ok\":0,\"msg\":\"Lỗi rồi: " + ex.Message + "\"}";
            }
            return json;
        }

        // Thêm giao dịch
        public string AddGiaoDich(string MaGiaoDich, string MaSach, string MaKhachHang, string NgayMuon, string NgayTra, string TinhTrang, string MaNhanVien)
        {
            string json = "";
            try
            {
                using (SqlConnection conn = new SqlConnection(cnstr))
                {
                    conn.Open();
                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "SP_API";
                        cmd.Parameters.Add("@action", SqlDbType.VarChar, 50).Value = "add_giaodich";
                        cmd.Parameters.Add("@MaGiaoDich", SqlDbType.VarChar, 50).Value = MaGiaoDich;
                        cmd.Parameters.Add("@MaSach", SqlDbType.VarChar, 50).Value = MaSach;
                        cmd.Parameters.Add("@MaKhachHang", SqlDbType.VarChar, 50).Value = MaKhachHang;
                        cmd.Parameters.Add("@NgayMuon", SqlDbType.DateTime).Value = DateTime.TryParse(NgayMuon, out var startDate) ? (object)startDate : DBNull.Value;
                        cmd.Parameters.Add("@NgayTra", SqlDbType.DateTime).Value = DateTime.TryParse(NgayTra, out var endDate) ? (object)endDate : DBNull.Value;
                        cmd.Parameters.Add("@TinhTrang", SqlDbType.NVarChar, 255).Value = TinhTrang;
                        cmd.Parameters.Add("@MaNhanVien", SqlDbType.VarChar, 50).Value = MaNhanVien;
                        object result = cmd.ExecuteScalar();
                        json = (string)result;
                    }
                }
            }
            catch (Exception ex)
            {
                json = "{\"ok\":0,\"msg\":\"Lỗi rồi: " + ex.Message + "\"}";
            }
            return json;
        }

        // Cập nhật sách
        public string UpdateSach(string MaSach, string TenSach, string TacGia, string NhaXuatBan, int NamXuatBan, string TheLoai)
        {
            string json = "";
            try
            {
                using (SqlConnection conn = new SqlConnection(cnstr))
                {
                    conn.Open();
                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "SP_API";
                        cmd.Parameters.Add("@action", SqlDbType.VarChar, 50).Value = "update_sach";
                        cmd.Parameters.Add("@MaSach", SqlDbType.VarChar, 50).Value = MaSach;
                        cmd.Parameters.Add("@TenSach", SqlDbType.NVarChar, 255).Value = TenSach;
                        cmd.Parameters.Add("@TacGia", SqlDbType.NVarChar, 255).Value = TacGia;
                        cmd.Parameters.Add("@NhaXuatBan", SqlDbType.NVarChar, 255).Value = NhaXuatBan;
                        cmd.Parameters.Add("@NamXuatBan", SqlDbType.Int).Value = NamXuatBan;
                        cmd.Parameters.Add("@TheLoai", SqlDbType.NVarChar, 100).Value = TheLoai;
                        object result = cmd.ExecuteScalar();
                        json = (string)result;
                    }
                }
            }
            catch (Exception ex)
            {
                json = "{\"ok\":0,\"msg\":\"Lỗi rồi: " + ex.Message + "\"}";
            }
            return json;
        }

        // Cập nhật nhân viên
        public string UpdateNhanVien(string MaNhanVien, string HoTen, string ChucVu)
        {
            string json = "";
            try
            {
                using (SqlConnection conn = new SqlConnection(cnstr))
                {
                    conn.Open();
                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "SP_API";
                        cmd.Parameters.Add("@action", SqlDbType.VarChar, 50).Value = "update_nhanvien";
                        cmd.Parameters.Add("@MaNhanVien", SqlDbType.VarChar, 50).Value = MaNhanVien;
                        cmd.Parameters.Add("@HoTen", SqlDbType.NVarChar, 255).Value = HoTen;
                        cmd.Parameters.Add("@ChucVu", SqlDbType.NVarChar, 100).Value = ChucVu;
                        object result = cmd.ExecuteScalar();
                        json = (string)result;
                    }
                }
            }
            catch (Exception ex)
            {
                json = "{\"ok\":0,\"msg\":\"Lỗi rồi: " + ex.Message + "\"}";
            }
            return json;
        }

        // Cập nhật khách hàng
        public string UpdateKhachHang(string MaKhachHang, string TenKhachHang, string ThongTinLienLac)
        {
            string json = "";
            try
            {
                using (SqlConnection conn = new SqlConnection(cnstr))
                {
                    conn.Open();
                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "SP_API";
                        cmd.Parameters.Add("@action", SqlDbType.VarChar, 50).Value = "update_khachhang";
                        cmd.Parameters.Add("@MaKhachHang", SqlDbType.VarChar, 50).Value = MaKhachHang;
                        cmd.Parameters.Add("@TenKhachHang", SqlDbType.NVarChar, 255).Value = TenKhachHang;
                        cmd.Parameters.Add("@ThongTinLienLac", SqlDbType.NVarChar, 50).Value = ThongTinLienLac;
                        object result = cmd.ExecuteScalar();
                        json = (string)result;
                    }
                }
            }
            catch (Exception ex)
            {
                json = "{\"ok\":0,\"msg\":\"Lỗi rồi: " + ex.Message + "\"}";
            }
            return json;
        }

        // Cập nhật giao dịch
        public string UpdateGiaoDich(string MaGiaoDich, string MaSach, string MaKhachHang, string NgayMuon, string NgayTra, string TinhTrang, string MaNhanVien)
        {
            string json = "";
            try
            {
                using (SqlConnection conn = new SqlConnection(cnstr))
                {
                    conn.Open();
                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "SP_API";
                        cmd.Parameters.Add("@action", SqlDbType.VarChar, 50).Value = "update_giaodich";
                        cmd.Parameters.Add("@MaGiaoDich", SqlDbType.VarChar, 50).Value = MaGiaoDich;
                        cmd.Parameters.Add("@MaSach", SqlDbType.VarChar, 50).Value = MaSach;
                        cmd.Parameters.Add("@MaKhachHang", SqlDbType.VarChar, 50).Value = MaKhachHang;
                        cmd.Parameters.Add("@NgayMuon", SqlDbType.DateTime).Value = DateTime.TryParse(NgayMuon, out var startDate) ? (object)startDate : DBNull.Value;
                        cmd.Parameters.Add("@NgayTra", SqlDbType.DateTime).Value = DateTime.TryParse(NgayTra, out var endDate) ? (object)endDate : DBNull.Value;
                        cmd.Parameters.Add("@TinhTrang", SqlDbType.NVarChar, 255).Value = TinhTrang;
                        cmd.Parameters.Add("@MaNhanVien", SqlDbType.VarChar, 50).Value = MaNhanVien;
                        object result = cmd.ExecuteScalar();
                        json = (string)result;
                    }
                }
            }
            catch (Exception ex)
            {
                json = "{\"ok\":0,\"msg\":\"Lỗi rồi: " + ex.Message + "\"}";
            }
            return json;
        }

        // Xóa sách
        public string DeleteSach(string MaSach)
        {
            string json = "";
            try
            {
                using (SqlConnection conn = new SqlConnection(cnstr))
                {
                    conn.Open();
                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "SP_API";
                        cmd.Parameters.Add("@action", SqlDbType.VarChar, 50).Value = "delete_sach";
                        cmd.Parameters.Add("@MaSach", SqlDbType.VarChar, 50).Value = MaSach;
                        object result = cmd.ExecuteScalar();
                        json = (string)result;
                    }
                }
            }
            catch (Exception ex)
            {
                json = "{\"ok\":0,\"msg\":\"Lỗi rồi: " + ex.Message + "\"}";
            }
            return json;
        }

        // Xóa nhân viên
        public string DeleteNhanVien(string MaNhanVien)
        {
            string json = "";
            try
            {
                using (SqlConnection conn = new SqlConnection(cnstr))
                {
                    conn.Open();
                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "SP_API";
                        cmd.Parameters.Add("@action", SqlDbType.VarChar, 50).Value = "delete_nhanvien";
                        cmd.Parameters.Add("@MaNhanVien", SqlDbType.VarChar, 50).Value = MaNhanVien;
                        object result = cmd.ExecuteScalar();
                        json = (string)result;
                    }
                }
            }
            catch (Exception ex)
            {
                json = "{\"ok\":0,\"msg\":\"Lỗi rồi: " + ex.Message + "\"}";
            }
            return json;
        }

        // Xóa khách hàng
        public string DeleteKhachHang(string MaKhachHang)
        {
            string json = "";
            try
            {
                using (SqlConnection conn = new SqlConnection(cnstr))
                {
                    conn.Open();
                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "SP_API";
                        cmd.Parameters.Add("@action", SqlDbType.VarChar, 50).Value = "delete_khachhang";
                        cmd.Parameters.Add("@MaKhachHang", SqlDbType.VarChar, 50).Value = MaKhachHang;
                        object result = cmd.ExecuteScalar();
                        json = (string)result;
                    }
                }
            }
            catch (Exception ex)
            {
                json = "{\"ok\":0,\"msg\":\"Lỗi rồi: " + ex.Message + "\"}";
            }
            return json;
        }

        // Xóa giao dịch
        public string DeleteGiaoDich(string MaGiaoDich)
        {
            string json = "";
            try
            {
                using (SqlConnection conn = new SqlConnection(cnstr))
                {
                    conn.Open();
                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "SP_API";
                        cmd.Parameters.Add("@action", SqlDbType.VarChar, 50).Value = "delete_giaodich";
                        cmd.Parameters.Add("@MaGiaoDich", SqlDbType.VarChar, 50).Value = MaGiaoDich;
                        object result = cmd.ExecuteScalar();
                        json = (string)result;
                    }
                }
            }
            catch (Exception ex)
            {
                json = "{\"ok\":0,\"msg\":\"Lỗi rồi: " + ex.Message + "\"}";
            }
            return json;
        }
    }
}
