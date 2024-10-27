using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication
{
    public partial class API : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string action = this.Request["action"];

            switch (action)
            {
                case "get_nhan_vien":
                    get_nhan_vien();
                    break;
                case "get_khach_hang":
                    get_khach_hang();
                    break;
                case "get_sach":
                    get_sach();
                    break;

                case "add_sach":
                    add_sach();
                    break;
                case "update_sach":
                    update_sach();
                    break;
                case "delete_sach":
                    delete_sach();
                    break;

                case "add_nhanvien":
                    add_nhanvien();
                    break;
                case "update_nhanvien":
                    update_nhanvien();
                    break;
                case "delete_nhanvien":
                    delete_nhanvien();
                    break;

                case "add_khachhang":
                    add_khachhang();
                    break;
                case "update_khachhang":
                    update_khachhang();
                    break;
                case "delete_khachhang":
                    delete_khachhang();
                    break;

                case "add_giaodich":
                    add_giaodich();
                    break;
                case "update_giaodich":
                    update_giaodich();
                    break;
                case "delete_giaodich":
                    delete_giaodich();
                    break;

                default:
                    thong_bao_loi();
                    break;
            }
        }

        void thong_bao_loi()
        {
            string rep = "{\"ok\":false,\"msg\":\"Lỗi rồi nhé, ko có action này!\"}";
            this.Response.Write(rep);
        }

        ClassLibrary.Read_DB get_db()
        {
            ClassLibrary.Read_DB db = new ClassLibrary.Read_DB();
            db.cnstr = "Data Source=NAMDZ\\DANGNAM;Initial Catalog=QL_sach;Integrated Security=True;";
            return db;
        }

        void get_nhan_vien()
        {
            var db = get_db();
            string result = db.get_nhan_vien();
            this.Response.Write(result);
        }
        void get_khach_hang()
        {
            var db = get_db();
            string result = db.get_khach_hang();
            this.Response.Write(result);
        }
        void get_sach()
        {
            var db = get_db();
            string result = db.get_sach();
            this.Response.Write(result);
        }

        void add_sach()
        {
            var db = get_db();
            string maSach = Request["MaSach"];
            string tenSach = Request["TenSach"];
            string tacGia = Request["TacGia"];
            string nhaXuatBan = Request["NhaXuatBan"];
            int namXuatBan = int.Parse(Request["NamXuatBan"]);
            string theLoai = Request["TheLoai"];

            string result = db.AddSach(maSach, tenSach, tacGia, nhaXuatBan, namXuatBan, theLoai);
            this.Response.Write(result);
        }

        void update_sach()
        {
            var db = get_db();
            string maSach = Request["MaSach"];
            string tenSach = Request["TenSach"];
            string tacGia = Request["TacGia"];
            string nhaXuatBan = Request["NhaXuatBan"];
            int namXuatBan = int.Parse(Request["NamXuatBan"]);
            string theLoai = Request["TheLoai"];

            string result = db.UpdateSach(maSach, tenSach, tacGia, nhaXuatBan, namXuatBan, theLoai);
            this.Response.Write(result);
        }

        void delete_sach()
        {
            var db = get_db();
            string maSach = Request["MaSach"];

            string result = db.DeleteSach(maSach);
            this.Response.Write(result);
        }

        void add_nhanvien()
        {
            var db = get_db();
            string maNhanVien = Request["MaNhanVien"];
            string hoTen = Request["HoTen"];
            string chucVu = Request["ChucVu"];

            string result = db.AddNhanVien(maNhanVien, hoTen, chucVu);
            this.Response.Write(result);
        }

        void update_nhanvien()
        {
            var db = get_db();
            string maNhanVien = Request["MaNhanVien"];
            string hoTen = Request["HoTen"];
            string chucVu = Request["ChucVu"];

            string result = db.UpdateNhanVien(maNhanVien, hoTen, chucVu);
            this.Response.Write(result);
        }

        void delete_nhanvien()
        {
            var db = get_db();
            string maNhanVien = Request["MaNhanVien"];

            string result = db.DeleteNhanVien(maNhanVien);
            this.Response.Write(result);
        }

        void add_khachhang()
        {
            var db = get_db();
            string maKhachHang = Request["MaKhachHang"];
            string tenKhachHang = Request["TenKhachHang"];
            string thongTinLienLac = Request["ThongTinLienLac"];

            string result = db.AddKhachHang(maKhachHang, tenKhachHang, thongTinLienLac);
            this.Response.Write(result);
        }

        void update_khachhang()
        {
            var db = get_db();
            string maKhachHang = Request["MaKhachHang"];
            string tenKhachHang = Request["TenKhachHang"];
            string thongTinLienLac = Request["ThongTinLienLac"];

            string result = db.UpdateKhachHang(maKhachHang, tenKhachHang, thongTinLienLac);
            this.Response.Write(result);
        }

        void delete_khachhang()
        {
            var db = get_db();
            string maKhachHang = Request["MaKhachHang"];

            string result = db.DeleteKhachHang(maKhachHang);
            this.Response.Write(result);
        }

        void add_giaodich()
        {
            var db = get_db();
            string maGiaoDich = Request["MaGiaoDich"];
            string maSach = Request["MaSach"];
            string maKhachHang = Request["MaKhachHang"];
            string ngayMuon = Request["NgayMuon"];
            string ngayTra = Request["NgayTra"];
            string tinhTrang = Request["TinhTrang"];
            string maNhanVien = Request["MaNhanVien"];

            string result = db.AddGiaoDich(maGiaoDich, maSach, maKhachHang, ngayMuon, ngayTra, tinhTrang, maNhanVien);
            this.Response.Write(result);
        }

        void update_giaodich()
        {
            var db = get_db();
            string maGiaoDich = Request["MaGiaoDich"];
            string maSach = Request["MaSach"];
            string maKhachHang = Request["MaKhachHang"];
            string ngayMuon = Request["NgayMuon"];
            string ngayTra = Request["NgayTra"];
            string tinhTrang = Request["TinhTrang"];
            string maNhanVien = Request["MaNhanVien"];

            string result = db.UpdateGiaoDich(maGiaoDich, maSach, maKhachHang, ngayMuon, ngayTra, tinhTrang, maNhanVien);
            this.Response.Write(result);
        }

        void delete_giaodich()
        {
            var db = get_db();
            string maGiaoDich = Request["MaGiaoDich"];

            string result = db.DeleteGiaoDich(maGiaoDich);
            this.Response.Write(result);
        }
    }
}