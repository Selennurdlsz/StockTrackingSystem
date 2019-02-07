using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YazilimSinamaStokTakipSistemi.Controller;

namespace YazilimSinamaStokTakipSistemi.Views.Departmanlar
{
    public partial class DepartmanEkleForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public DepartmanEkleForm()
        {
            InitializeComponent();
        }

        private void btn_DepartmanEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_DepartmanAdi.Text))
                {
                    throw new ValidationException("Departman Adını Boş Geçemezsiniz !");
                }
                DepartmanController.DepartmanEkle(txt_DepartmanAdi.Text, Convert.ToInt32(cmb_Departman.SelectedValue));
                MessageBox.Show("Oda Başarıyla Eklendi !", "İşlem Başarılı !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DepartmanKisiYetkilendirForm adForm = new DepartmanKisiYetkilendirForm();
                adForm.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata Meydana Geldi !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DepartmanKisiYetkilendirForm adForm = new DepartmanKisiYetkilendirForm();
            adForm.Show();
            this.Close();
        }

        private void DepartmanEkleForm_Load(object sender, EventArgs e)
        {
            Tools.ComboBoxSirketGetir(cmb_Sirket);
        }

        private void cmb_Sirket_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_Sirket.SelectedIndex == -1) return;
            // int Sirket = int.Parse(cmb_Sirket.SelectedValue.ToString());
            //Tools.ComboBoxBolumGetir(cmb_Departman, Sirket);
        }
    }
}