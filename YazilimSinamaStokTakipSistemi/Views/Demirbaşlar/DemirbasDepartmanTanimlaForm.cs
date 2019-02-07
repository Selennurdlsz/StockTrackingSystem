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

namespace YazilimSinamaStokTakipSistemi.Views.Demirbaşlar
{
    public partial class DemirbasDepartmanTanimlaForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public DemirbasDepartmanTanimlaForm()
        {
            InitializeComponent();
        }

        private void DemirbasDepartmanTanimlaForm_Load(object sender, EventArgs e)
        {
            var departmanlarListesi = DepartmanController.TumDepartmanlariGetir();
            DataTable dtBitenStokList = new DataTable("departmanlarListesi");
            dtBitenStokList.Columns.Add("departmanId", typeof(int));
            dtBitenStokList.Columns.Add("departmanAdi", typeof(string));
            foreach (var item in departmanlarListesi)
            {
                dtBitenStokList.Rows.Add(item.Departman.DepartmanId, item.Departman.DepartmanAdi);
            }
            grid_Departman.DataSource = dtBitenStokList;
            //gridView_Departman.Columns["DepartmanId"].Visible = false;

            Tools.DemirbaslariGrideDoldur(grid_Demirbas, gridView_Demirbas);
        }

        private int departmanId, demirbasId, secilenAdet;

        private void txt_Adet_KeyPress(object sender, KeyPressEventArgs e)
        {
            Tools.SadeceSayi(sender, e);
        }

        private void btn_DepartmanDemirbasKisi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_Adet.Text) || int.Parse(txt_Adet.Text) <= 0)
                {
                    throw new Exception("Lütfen Demirbaş Adedini Kontrol Ediniz !");
                }
                if (departmanId == 0 || demirbasId == 0)
                {
                    throw new Exception("Lütfen Departman Ve Demirbaş Seçimlerinizi Kontrol Ediniz Bu Değerler Boş Geçilemez !");
                }
                int adet = int.Parse(txt_Adet.Text);
                if (adet > secilenAdet)
                {
                    throw new Exception("Adet Bilgisi Var Olan Adetten Sayısından Büyük Girilemez!");
                }
                DepartmanPersonelController.DepartmanaDemirbasEkle(demirbasId, departmanId, adet);
                MessageBox.Show("İşlem Başarılı !", "Başarılı !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show("Eklendi");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Dikkat !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void gridView_Demirbas_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            demirbasId = int.Parse(gridView_Demirbas.GetRowCellValue(gridView_Demirbas.FocusedRowHandle, "DemirbasNo").ToString());
            secilenAdet = int.Parse(gridView_Demirbas.GetRowCellValue(gridView_Demirbas.FocusedRowHandle, "DemirbasAdedi").ToString());
            lbl_demirbas.Text = string.Empty;
            lbl_demirbas.Text += "Seçilen Demirbaş: " + gridView_Demirbas.GetRowCellValue(gridView_Demirbas.FocusedRowHandle, "DemirbasAdi");
        }

        private void gridView_Departman_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            departmanId = int.Parse(gridView_Departman.GetRowCellValue(gridView_Departman.FocusedRowHandle, "DepartmanId").ToString());
            lbl_departman.Text = string.Empty;
            lbl_departman.Text += "Seçilen Departman: " + gridView_Departman.GetRowCellValue(gridView_Departman.FocusedRowHandle, "DepartmanAdi");
        }
    }
}