$(document).ready(function () {
    function loadTable() {
        loadNhanVien();
        loadKhachHang();
        loadSach();
    }
    function loadNhanVien() {
        var container = $("#nhanvien-container");
        container.empty();
        container.append('<div>Đang tải dữ liệu...</div>');

        $.post('API.aspx', { action: 'get_nhan_vien' }, function (data) {
            container.empty();
            if (data.length > 0) {
                data.forEach(record => {
                    var nhanVienDiv = $(`<div class='info' id='nhanvien-${record.MaNhanVien}'></div>`);
                    nhanVienDiv.append($("<div></div>").text("Mã nhân viên: " + record.MaNhanVien));
                    nhanVienDiv.append($("<div></div>").text("Họ tên: " + record.HoTen));
                    nhanVienDiv.append($("<div></div>").text("Chức vụ: " + record.ChucVu));
                    nhanVienDiv.append(`<button onclick="sua_nhanvien('${record.MaNhanVien}', this)">Sửa</button>
                                    <button onclick="xoa_nhanvien('${record.MaNhanVien}', this)">Xóa</button>`);
                    container.append(nhanVienDiv);
                });
            } else {
                container.append('<div>Không có dữ liệu nào.</div>');
            }
        }, 'json');
    }

    function loadKhachHang() {
        var container = $("#khachhang-container");
        container.empty();
        container.append('<div>Đang tải dữ liệu...</div>');

        $.post('API.aspx', { action: 'get_khach_hang' }, function (data) {
            container.empty();
            if (data.length > 0) {
                data.forEach(record => {
                    var khachHangDiv = $(`<div class='info' id='khachhang-${record.MaKhachHang}'></div>`);
                    khachHangDiv.append($("<div></div>").text("Mã khách hàng: " + record.MaKhachHang));
                    khachHangDiv.append($("<div></div>").text("Tên khách hàng: " + record.TenKhachHang));
                    khachHangDiv.append($("<div></div>").text("Thông tin liên lạc: " + record.ThongTinLienLac));
                    khachHangDiv.append(`<button onclick="sua_khachhang('${record.MaKhachHang}', this)">Sửa</button>
                                     <button onclick="xoa_khachhang('${record.MaKhachHang}', this)">Xóa</button>`);
                    container.append(khachHangDiv);
                });
            } else {
                container.append('<div>Không có dữ liệu nào.</div>');
            }
        }, 'json');
    }
    function loadSach() {
        var container = $("#sach-container");
        container.empty();
        container.append('<div>Đang tải dữ liệu...</div>');

        $.post('API.aspx', { action: 'get_sach' }, function (data) {
            container.empty();
            if (data.length > 0) {
                data.forEach(record => {
                    var sachDiv = $("<div class='info'></div>");
                    sachDiv.append($("<div></div>").text("Mã sách: " + record.MaSach));
                    sachDiv.append($("<div></div>").text("Tên sách: " + record.TenSach));
                    sachDiv.append($("<div></div>").text("Tác giả: " + record.TacGia));
                    sachDiv.append($("<div></div>").text("Nhà xuất bản: " + record.NhaXuatBan));
                    sachDiv.append($("<div></div>").text("Năm xuất bản: " + record.NamXuatBan));
                    sachDiv.append($("<div></div>").text("Thể loại: " + record.TheLoai));
                    sachDiv.append(`<button onclick="sua_sach('${record.MaSach}', this)">Sửa</button>
                                <button onclick="xoa_sach('${record.MaSach}', this)">Xóa</button>`);
                    container.append(sachDiv);
                });
            } else {
                container.append('<div>Không có dữ liệu nào.</div>');
            }
        }, 'json');
    }
    window.sua_khachhang = function (makhachhang, button) {
        var khachHangDiv = $('#khachhang-' + makhachhang); 
        var currentTenKhachHang = khachHangDiv.find('div').eq(1).text().replace("Tên khách hàng: ", "").trim();
        var currentThongTinLienLac = khachHangDiv.find('div').eq(2).text().replace("Thông tin liên lạc: ", "").trim();

        var html = `
    <form id="editKhachHangForm">
        <div class="mb-3">
            <label for="tenkhachHangEditInput" class="form-label">Tên Khách Hàng</label>
            <input type="text" class="form-control" id="tenkhachHangEditInput" value="${currentTenKhachHang}">
        </div>
        <div class="mb-3">
            <label for="thongTinLienLacEditInput" class="form-label">Thông Tin Liên Lạc</label>
            <input type="text" class="form-control" id="thongTinLienLacEditInput" value="${currentThongTinLienLac}">
        </div>
    </form>
    `;

        $.confirm({
            title: 'Chỉnh Sửa Khách Hàng',
            content: html,
            buttons: {
                save: {
                    text: 'Sửa',
                    btnClass: 'btn-primary',
                    action: function () {
                        var newTenKhachHang = $('#tenkhachHangEditInput').val();
                        var newThongTinLienLac = $('#thongTinLienLacEditInput').val();

                        $.post('API.aspx', { action: 'update_khachhang', makhachhang: makhachhang, tenkhachhang: newTenKhachHang, thongtinlienlac: newThongTinLienLac }, function (data) {
                            if (data.ok) {
                                $.alert('Chỉnh Sửa Thành Công');
                                khachHangDiv.find('div').eq(1).text("Tên khách hàng: " + newTenKhachHang);
                                khachHangDiv.find('div').eq(2).text("Thông tin liên lạc: " + newThongTinLienLac);
                            } else {
                                $.alert('Chỉnh Sửa Thất Bại');
                            }
                        }, 'json');
                    }
                },
                cancel: {
                    text: 'Hủy',
                    btnClass: 'btn-secondary',
                }
            }
        });
    };

    window.sua_nhanvien = function (manhanvien, button) {
        var nhanVienDiv = $('#nhanvien-' + manhanvien); 
        var currentHoTen = nhanVienDiv.find('div').eq(1).text().replace("Họ tên: ", "").trim();
        var currentChucVu = nhanVienDiv.find('div').eq(2).text().replace("Chức vụ: ", "").trim();

        var html = `
    <form id="editNhanVienForm">
        <div class="mb-3">
            <label for="hoTenEditInput" class="form-label">Họ Tên</label>
            <input type="text" class="form-control" id="hoTenEditInput" value="${currentHoTen}">
        </div>
        <div class="mb-3">
            <label for="chucVuEditInput" class="form-label">Chức Vụ</label>
            <input type="text" class="form-control" id="chucVuEditInput" value="${currentChucVu}">
        </div>
    </form>
    `;

        $.confirm({
            title: 'Chỉnh Sửa Nhân Viên',
            content: html,
            buttons: {
                save: {
                    text: 'Sửa',
                    btnClass: 'btn-primary',
                    action: function () {
                        var newHoTen = $('#hoTenEditInput').val();
                        var newChucVu = $('#chucVuEditInput').val();

                        $.post('API.aspx', { action: 'update_nhanvien', manhanvien: manhanvien, hoten: newHoTen, chucvu: newChucVu }, function (data) {
                            if (data.ok) {
                                $.alert('Chỉnh Sửa Thành Công');
                                nhanVienDiv.find('div').eq(1).text("Họ tên: " + newHoTen);
                                nhanVienDiv.find('div').eq(2).text("Chức vụ: " + newChucVu);
                            } else {
                                $.alert('Chỉnh Sửa Thất Bại');
                            }
                        }, 'json');
                    }
                },
                cancel: {
                    text: 'Hủy',
                    btnClass: 'btn-secondary',
                }
            }
        });
    };


    window.sua_sach = function (masach, button) {
        var sachDiv = $(button).closest('.info');
        var currentTenSach = sachDiv.find('div').eq(1).text().replace("Tên sách: ", "").trim();
        var currentTacGia = sachDiv.find('div').eq(2).text().replace("Tác giả: ", "").trim();
        var currentNhaXuatBan = sachDiv.find('div').eq(3).text().replace("Nhà xuất bản: ", "").trim();
        var currentNamXuatBan = sachDiv.find('div').eq(4).text().replace("Năm xuất bản: ", "").trim();
        var currentTheLoai = sachDiv.find('div').eq(5).text().replace("Thể loại: ", "").trim();

        var html = `
    <form id="editSachForm">
        <div class="mb-3">
            <label for="tenSachEditInput" class="form-label">Tên Sách</label>
            <input type="text" class="form-control" id="tenSachEditInput" value="${currentTenSach}">
        </div>
        <div class="mb-3">
            <label for="tacGiaEditInput" class="form-label">Tác Giả</label>
            <input type="text" class="form-control" id="tacGiaEditInput" value="${currentTacGia}">
        </div>
        <div class="mb-3">
            <label for="nhaXuatBanEditInput" class="form-label">Nhà Xuất Bản</label>
            <input type="text" class="form-control" id="nhaXuatBanEditInput" value="${currentNhaXuatBan}">
        </div>
        <div class="mb-3">
            <label for="namXuatBanEditInput" class="form-label">Năm Xuất Bản</label>
            <input type="text" class="form-control" id="namXuatBanEditInput" value="${currentNamXuatBan}">
        </div>
        <div class="mb-3">
            <label for="theLoaiEditInput" class="form-label">Thể Loại</label>
            <input type="text" class="form-control" id="theLoaiEditInput" value="${currentTheLoai}">
        </div>
    </form>
    `;

        $.confirm({
            title: 'Chỉnh Sửa Sách',
            content: html,
            buttons: {
                save: {
                    text: 'Sửa',
                    btnClass: 'btn-primary',
                    action: function () {
                        var newTenSach = $('#tenSachEditInput').val();
                        var newTacGia = $('#tacGiaEditInput').val();
                        var newNhaXuatBan = $('#nhaXuatBanEditInput').val();
                        var newNamXuatBan = $('#namXuatBanEditInput').val();
                        var newTheLoai = $('#theLoaiEditInput').val();

                        $.post('API.aspx', { action: 'update_sach', masach: masach, tensach: newTenSach, tacgia: newTacGia, nhaxuatban: newNhaXuatBan,namXuatBan:newNamXuatBan, theloai: newTheLoai }, function (data) {
                            if (data.ok) {
                                $.alert('Chỉnh Sửa Thành Công');
                                sachDiv.find('div').eq(1).text("Tên sách: " + newTenSach);
                                sachDiv.find('div').eq(2).text("Tác giả: " + newTacGia);
                                sachDiv.find('div').eq(3).text("Nhà xuất bản: " + newNhaXuatBan);
                                sachDiv.find('div').eq(4).text("Năm xuất bản: " + newNamXuatBan);
                                sachDiv.find('div').eq(5).text("Thể loại: " + newTheLoai);
                            } else {
                                $.alert('Chỉnh Sửa Thất Bại');
                            }
                        }, 'json');
                    }
                },
                cancel: {
                    text: 'Hủy',
                    btnClass: 'btn-secondary',
                }
            }
        });
    };

    window.them_khachhang = function() {
        var html = `
        <form id="addKhachHangForm">
            <div class="mb-3">
                <label for="maKhachHangInput" class="form-label">Mã Khách Hàng</label>
                <input type="text" class="form-control" id="maKhachHangInput" required>
            </div>
            <div class="mb-3">
                <label for="tenKhachHangInput" class="form-label">Tên Khách Hàng</label>
                <input type="text" class="form-control" id="tenKhachHangInput" required>
            </div>
            <div class="mb-3">
                <label for="thongTinLienLacInput" class="form-label">Thông Tin Liên Lạc</label>
                <input type="text" class="form-control" id="thongTinLienLacInput" required>
            </div>
        </form>
    `;

        $.confirm({
            title: 'Thêm Khách Hàng Mới',
            content: html,
            buttons: {
                add: {
                    text: 'Thêm',
                    btnClass: 'btn-primary',
                    action: function () {
                        var maKhachHang = $('#maKhachHangInput').val();
                        var tenKhachHang = $('#tenKhachHangInput').val();
                        var thongTinLienLac = $('#thongTinLienLacInput').val();

                        $.post('API.aspx', {
                            action: 'add_khachhang',
                            maKhachHang: maKhachHang,
                            tenKhachHang: tenKhachHang,
                            thongTinLienLac: thongTinLienLac
                        }, function (data) {
                            if (data.ok) {
                                $.alert('Thêm khách hàng thành công');
                                loadTable(); 
                            } else {
                                $.alert('Thêm khách hàng thất bại');
                            }
                        }, 'json');
                    }
                },
                cancel: {
                    text: 'Hủy',
                    btnClass: 'btn-secondary'
                }
            }
        });
    }

    window.them_nhanvien = function() {
        var html = `
        <form id="addNhanVienForm">
            <div class="mb-3">
                <label for="maNhanVienInput" class="form-label">Mã Nhân Viên</label>
                <input type="text" class="form-control" id="maNhanVienInput" required>
            </div>
            <div class="mb-3">
                <label for="hoTenInput" class="form-label">Họ Tên</label>
                <input type="text" class="form-control" id="hoTenInput" required>
            </div>
            <div class="mb-3">
                <label for="chucVuInput" class="form-label">Chức Vụ</label>
                <input type="text" class="form-control" id="chucVuInput" required>
            </div>
        </form>
    `;

        $.confirm({
            title: 'Thêm Nhân Viên Mới',
            content: html,
            buttons: {
                add: {
                    text: 'Thêm',
                    btnClass: 'btn-primary',
                    action: function () {
                        var maNhanVien = $('#maNhanVienInput').val();
                        var hoTen = $('#hoTenInput').val();
                        var chucVu = $('#chucVuInput').val();

                        $.post('API.aspx', {
                            action: 'add_nhanvien',
                            maNhanVien: maNhanVien,
                            hoTen: hoTen,
                            chucVu: chucVu
                        }, function (data) {
                            if (data.ok) {
                                $.alert('Thêm nhân viên thành công');
                                loadTable(); 
                            } else {
                                $.alert('Thêm nhân viên thất bại');
                            }
                        }, 'json');
                    }
                },
                cancel: {
                    text: 'Hủy',
                    btnClass: 'btn-secondary'
                }
            }
        });
    }

    window.them_sach = function() {
        var html = `
        <form id="addSachForm">
            <div class="mb-3">
                <label for="maSachInput" class="form-label">Mã Sách</label>
                <input type="text" class="form-control" id="maSachInput" required>
            </div>
            <div class="mb-3">
                <label for="tenSachInput" class="form-label">Tên Sách</label>
                <input type="text" class="form-control" id="tenSachInput" required>
            </div>
            <div class="mb-3">
                <label for="tacGiaInput" class="form-label">Tác Giả</label>
                <input type="text" class="form-control" id="tacGiaInput" required>
            </div>
            <div class="mb-3">
                <label for="nhaXuatBanInput" class="form-label">Nhà Xuất Bản</label>
                <input type="text" class="form-control" id="nhaXuatBanInput">
            </div>
            <div class="mb-3">
                <label for="namXuatBanInput" class="form-label">Năm Xuất Bản</label>
                <input type="number" class="form-control" id="namXuatBanInput" required>
            </div>
            <div class="mb-3">
                <label for="theLoaiInput" class="form-label">Thể Loại</label>
                <input type="text" class="form-control" id="theLoaiInput" required>
            </div>
        </form>
    `;

        $.confirm({
            title: 'Thêm Sách Mới',
            content: html,
            buttons: {
                add: {
                    text: 'Thêm',
                    btnClass: 'btn-primary',
                    action: function () {
                        var maSach = $('#maSachInput').val();
                        var tenSach = $('#tenSachInput').val();
                        var tacGia = $('#tacGiaInput').val();
                        var nhaXuatBan = $('#nhaXuatBanInput').val();
                        var namXuatBan = $('#namXuatBanInput').val();
                        var theLoai = $('#theLoaiInput').val();

                        $.post('API.aspx', {
                            action: 'add_sach',
                            maSach: maSach,
                            tenSach: tenSach,
                            tacGia: tacGia,
                            nhaXuatBan: nhaXuatBan,
                            namXuatBan: namXuatBan,
                            theLoai: theLoai
                        }, function (data) {
                            if (data.ok) {
                                $.alert('Thêm sách thành công');
                                loadTable(); 
                            } else {
                                $.alert('Thêm sách thất bại');
                            }
                        }, 'json');
                    }
                },
                cancel: {
                    text: 'Hủy',
                    btnClass: 'btn-secondary'
                }
            }
        });
    }

   
    window.xoa_khachhang = function (makhachhang, button) {
        $.confirm({
            title: 'Xóa Khách Hàng',
            content: 'Bạn có chắc muốn xóa khách hàng này không?',
            buttons: {
                confirm: {
                    text: 'Xóa',
                    btnClass: 'btn-danger',
                    action: function () {
                        $.post('API.aspx', { action: 'delete_khachhang', makhachhang: makhachhang }, function (data) {
                            if (data.ok) {
                                $.alert('Xóa Khách Hàng Thành Công');
                                $(button).closest('#khachhang-' + makhachhang).remove();
                            } else {
                                $.alert('Xóa Khách Hàng Thất Bại');
                            }
                        }, 'json');
                    }
                },
                cancel: {
                    text: 'Hủy',
                    btnClass: 'btn-secondary',
                }
            }
        });
    };
    window.xoa_nhanvien = function (manhanvien, button) {
        $.confirm({
            title: 'Xóa Nhân Viên',
            content: 'Bạn có chắc muốn xóa nhân viên này không?',
            buttons: {
                confirm: {
                    text: 'Xóa',
                    btnClass: 'btn-danger',
                    action: function () {
                        $.post('API.aspx', { action: 'delete_nhanvien', manhanvien: manhanvien }, function (data) {
                            if (data.ok) {
                                $.alert('Xóa Nhân Viên Thành Công');
                                $(button).closest('#nhanvien-' + manhanvien).remove();
                            } else {
                                $.alert('Xóa Nhân Viên Thất Bại');
                            }
                        }, 'json');
                    }
                },
                cancel: {
                    text: 'Hủy',
                    btnClass: 'btn-secondary',
                }
            }
        });
    };
    window.xoa_sach = function(masach, button) {
        $.confirm({
            title: 'Xóa Sách',
            content: 'Bạn có chắc chắn muốn xóa sách này không?',
            buttons: {
                confirm: {
                    text: 'Xóa',
                    btnClass: 'btn-danger',
                    action: function () {
                        $.post('API.aspx', { action: 'delete_sach', masach: masach }, function (data) {
                            if (data.ok) {
                                $.alert('Xóa sách thành công');
                                $(button).closest('#sach-' + masach).remove();
                            } else {
                                $.alert('Xóa sách thất bại');
                            }
                        }, 'json');
                    }
                },
                cancel: {
                    text: 'Hủy',
                    btnClass: 'btn-secondary'
                }
            }
        });
    }
    
    loadTable();
});
