using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4_LTCSDL
{
    public partial class frmSinhVien : Form
    {
        DanhSachSinhVien ds;
        public frmSinhVien()
        { 
            InitializeComponent();
        }
        private SinhVien GetSinhVienn()
        {
            SinhVien sv = new SinhVien();
            bool gt = true;
            sv.Ma = this.mtbMa.Text;
            sv.HoTen = this.txtHoTen.Text;
            sv.Mail = this.txtEmail.Text;
            sv.DiaChi = this.txtDiaChi.Text;
            sv.Hinh = this.txtLink.Text;
            sv.NgaySinh = this.dtbNgaySinh.Value;
            if (rdNu.Checked)
                gt = false;
            sv.GioiTinh = gt;
            sv.Lop = this.cbbLop.Text;
            sv.SDT = this.mtbSDT.Text;
            return sv;
        }
        private SinhVien GetSinhVienLV(ListViewItem lvitem)
        {
            SinhVien sv = new SinhVien();
            sv.Ma = lvitem.SubItems[0].Text;
            sv.HoTen = lvitem.SubItems[1].Text;
            sv.Mail = lvitem.SubItems[2].Text;
            sv.DiaChi = lvitem.SubItems[3].Text;
            sv.Hinh = lvitem.SubItems[4].Text;
            sv.NgaySinh = DateTime.Parse(lvitem.SubItems[5].Text);
            sv.GioiTinh = false;
            if (lvitem.SubItems[6].Text == "Nam")
                sv.GioiTinh = true;
            sv.Lop = lvitem.SubItems[7].Text;
            sv.SDT = lvitem.SubItems[8].Text;
            return sv;
        }
        private void ThietLapThongTin(SinhVien sv)
        {
            this.mtbMa.Text = sv.Ma;
            this.txtHoTen.Text = sv.HoTen;
            this.txtEmail.Text = sv.Mail;
            this.txtDiaChi.Text = sv.DiaChi;
            this.txtLink.Text = sv.Hinh;
            this.dtbNgaySinh.Value = sv.NgaySinh;
            if (sv.GioiTinh)
                this.rdNam.Checked = true;
            else
                this.rdNu.Checked = true;
            this.cbbLop.Text = sv.Lop;
            this.mtbSDT.Text = sv.SDT;
        }
        private void ThemSV(SinhVien sv)
        {
            ListViewItem lvitem = new ListViewItem(sv.Ma);
            lvitem.SubItems.Add(sv.HoTen);
            lvitem.SubItems.Add(sv.Mail);
            lvitem.SubItems.Add(sv.DiaChi);
            lvitem.SubItems.Add(sv.Hinh);
            lvitem.SubItems.Add(sv.NgaySinh.ToShortDateString());
            string gt = "nữ";
            if (sv.GioiTinh)
                gt = "Nam";
            lvitem.SubItems.Add(gt);
            lvitem.SubItems.Add(sv.Lop);
            lvitem.SubItems.Add(sv.SDT);
            this.lvSinhVien.Items.Add(lvitem);
        }
        private void LoadListView()
        {
            this.lvSinhVien.Items.Clear();
            foreach (SinhVien sv in ds.DanhSach)
            {
                ThemSV(sv);
            }
        }
        private void frmSinhVien_Load(object sender, EventArgs e)
        {
            ds = new DanhSachSinhVien();
            ds.DocTuFile();
            LoadListView();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn lưu lại danh sách đã thay đổi không", "Chọn", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (result == DialogResult.Yes)
            {
                
            }
            else
            {
                Application.Exit();
            }
        }

        private void btnHinh_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Select Picture";
            dlg.Filter = "Image Files (JPEG, GIF, BMP, etc.)|"
            + "*.jpg;*.jpeg;*.gif;*.bmp;"
            + "*.tif;*.tiff;*.png|"
            + "JPEG files (*.jpg;*.jpeg)|*.jpg;*.jpeg|"
            + "GIF files (*.gif)|*.gif|"
            + "BMP files (*.bmp)|*.bmp|"
            + "TIFF files (*.tif;*.tiff)|*.tif;*.tiff|"
            + "PNG files (*.png)|*.png|"
            + "All files (*.*)|*.*";
            dlg.InitialDirectory = Environment.CurrentDirectory;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                var fileName = dlg.FileName;
                txtLink.Text = fileName;
                pbHinh.Load(fileName);
            }
        }

        private void btnMatDinh_Click(object sender, EventArgs e)
        {
            this.mtbMa.Text = "";
            this.txtHoTen.Text = "";
            this.txtEmail.Text = "";
            this.txtDiaChi.Text = "";
            this.txtLink.Text = "";
            this.dtbNgaySinh.Value = DateTime.Now;
            this.rdNam.Checked = false;
            this.rdNu.Checked = false;
            this.cbbLop.Text = this.cbbLop.Items[0].ToString();
            this.mtbSDT.Text = "";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            SinhVien sv = GetSinhVienn();
            SinhVien kq = ds.Tim(sv.Ma, delegate (object obj1, object obj2)
           {
               return (obj2 as SinhVien).Ma.CompareTo(obj1.ToString());
           });
            if (kq != null)
            {
                MessageBox.Show("Mã đã tồn tại!", "Lỗi thêm dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.ds.Them(sv);
                this.LoadListView();
            }
        }

        private void lvSinhVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            var count = lvSinhVien.SelectedItems.Count;
            if (count > 0)
            {
                var item = lvSinhVien.SelectedItems[0];

                mtbMa.Text = item.SubItems[0].Text;
                txtHoTen.Text = item.SubItems[1].Text;
                txtEmail.Text = item.SubItems[2].Text;
                txtDiaChi.Text = item.SubItems[3].Text;
                txtLink.Text = item.SubItems[4].Text;
                dtbNgaySinh.Value = DateTime.Parse(item.SubItems[5].Text);
                rdNu.Checked = true;
                if (item.SubItems[6].Text == "Nam")
                    rdNam.Checked = true;
                cbbLop.SelectedItem = item.SubItems[7].Text;
                mtbSDT.Text = item.SubItems[8].Text;
            }
        }
        private int SoSanhTheoMa(object obj1, object obj2)
        {
            SinhVien sv = obj2 as SinhVien;
            return sv.Ma.CompareTo(obj1);
        }
        private void lvSinhVien_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            var count = lvSinhVien.CheckedItems.Count;
            toolStripStatusLabel1.Text = $"Số lượng item được chọn là {count}";
        }

        private void tsmiDelete_Click(object sender, EventArgs e)
        {
            int count, i;
            ListViewItem lvitem;
            count = this.lvSinhVien.Items.Count - 1;

            for (i = count; i >= 0; i--)
            {
                lvitem = this.lvSinhVien.Items[i];
                if (lvitem.Checked)
                    ds.Xoa(lvitem.SubItems[0].Text, SoSanhTheoMa);
            }
            this.LoadListView();
        }

        private void stmiLoadTatCa_Click(object sender, EventArgs e)
        {
            ds.DocTuFile();
            LoadListView();
        }
    }
}
