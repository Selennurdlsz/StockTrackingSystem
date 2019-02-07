using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using YazilimSinamaStokTakipSistemi.Controller;
using YazilimSinamaStokTakipSistemi.Model;

namespace YazilimSinamaStokTakipSistemi.Views.Demirbaşlar
{
    public partial class DemirbasDuzenleForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public DemirbasDuzenleForm(int demirbasNo)
        {
            if (demirbasNo == 0) return;
            this.demirbasNo = demirbasNo;
            InitializeComponent();
        }

        public int demirbasNo;

        private void DemirbasDuzenleForm_Load(object sender, EventArgs e)
        {
            //Tools.ComboBoxKategorileriGetir(cmb_Categories);
            Tools.ComboBoxSirketGetir(cmb_Sirket);

            DemirbasGetir();
        }

        private void DemirbasGetir()
        {
            var result = DemirbasController.DemirbasGetir(demirbasNo);
            lbl_SeciliUrun.Text = lbl_DemirbasAciklama.Text = lbl_DemirbasAdet.Text = lbl_DemirbasKod.Text = string.Empty;
            lbl_DemirbasAdet.Text = "Demirbaş Adeti: "; lbl_DemirbasAdet.Text += txt_Adet.Text = result.DemirbasAdedi.ToString();
            lbl_DemirbasAciklama.Text = "Demirbaş Ozellik"; lbl_DemirbasAciklama.Text += txt_Aciklama.Text = result.DemirbasOzellikleri;
            lbl_DemirbasKod.Text = "Demirbaş Kod: "; lbl_DemirbasKod.Text += result.DemirbasKodu;
        }

        private void btn_DemirbasEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(cmb_Sirket.SelectedValue.ToString()))
                {
                    throw new Exception("Lütfen Fakülte ve Departman Bilgilerini Kontrol Ediniz !");

                }

                if (string.IsNullOrEmpty(txt_Adet.Text) || short.Parse(txt_Adet.Text) < 0)
                {
                    throw new Exception("Lütfen Adet Bilgisini Kontrol Ediniz !");
                }

                DemirbasController.DemirbasGuncelle(demirbasNo, Convert.ToInt32(cmb_Sirket.SelectedValue.ToString()), Convert.ToInt32(cmb_Departments.SelectedValue.ToString()), Convert.ToInt32(txt_Adet.Text), txt_Aciklama.Text);
                MessageBox.Show("İşlem Başarılı !", "Başarılı !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DemirbasGetir();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Dikkat !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cmb_Sirket_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }
    }
}