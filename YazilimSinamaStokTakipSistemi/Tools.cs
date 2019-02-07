using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using YazilimSinamaStokTakipSistemi.Model;
using YazilimSinamaStokTakipSistemi.Controller;

namespace YazilimSinamaStokTakipSistemi
{
    public static class Tools
    {
        /// <summary>
        /// Göstereceğiniz TextBox Kaynağına Yalnızca Sayi Girilebilmesini Sağlar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static void SadeceSayi(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        
        private static ComboBox ComboBoxDoldur(List<object> dataSource, string valueMember, string displayMember)
        {
            ComboBox cmb = new ComboBox();
            cmb.DataSource = dataSource;
            cmb.ValueMember = valueMember;
            cmb.DisplayMember = displayMember;
            return cmb;
        }

        public static void ComboBoxSirketGetir(ComboBox cmb)
        {
            cmb.DataSource = SirketController.SirkerleriListele();
            cmb.DisplayMember = "SirketAdi";
            cmb.ValueMember = "SirketId";
        }

        /// <summary>
        /// Göstereceğiniz ComboBox Kontrolüne Bölumleri Listeler
        /// </summary>
        /// <param name="cmb">Combobox Kontrolü</param>
        public static void ComboBoxBolumGetir(ComboBox cmb, int departmanId)
        {
            cmb.DataSource = DepartmanController.TumDepartmanlariGetir();
            cmb.DisplayMember = "DepartmanAdi";
            //cmb.ValueMember = "DepartmanId";
        }

        /// <summary>
        /// Girilen Grid ve GridView Kontrolleri içine Stok Listesini Doldurur
        /// </summary>
        /// <param name="grid">Devexpress grid nesnesi</param>
        /// <param name="gridView">Devexpress gridview nesnesi</param>
        public static void StoklariGrideDoldur(GridControl grid, GridView gridView)
        {
            List<StokUrunView> stokListesi = StokController.StoklarıGetir();
            DataTable dtStokList = new DataTable("StokListesi");
            dtStokList.Columns.Add("UrunId", typeof(int));
            dtStokList.Columns.Add("UrunAdi", typeof(string));
            dtStokList.Columns.Add("SatinAlinmaTarihi", typeof(DateTime));
            dtStokList.Columns.Add("SatinAlinilanKurum", typeof(string));
            dtStokList.Columns.Add("Adet", typeof(int));
            foreach (var item in stokListesi)
            {
                dtStokList.Rows.Add(item.Urun.UrunId, item.Urun.UrunAdi, item.Urun.SatinAlinmaTarihi, item.Urun.SatinAlinilanKurum, item.UrunStok.Stok);
            }
            grid.DataSource = dtStokList;
            gridView.Columns["UrunId"].Visible = false;
        }
        /// <summary>
        /// Girilen Grid ve GridView Kontrolleri içine Demirbaş Listesini Doldurur
        /// </summary>
        /// <param name="grid">Devexpress grid nesnesi</param>
        /// <param name="gridView">Devexpress gridview nesnesi</param>
        public static void DemirbaslariGrideDoldur(GridControl grid, GridView gridView)
        {
            var demirbasList = DemirbasController.DemirbaslariListele();
            DataTable dtdemirbasList = new DataTable("demirbasListesi");
            dtdemirbasList.Columns.Add("DemirbasNo", typeof(int));
            dtdemirbasList.Columns.Add("UrunId", typeof(int));
            dtdemirbasList.Columns.Add("DemirbasKodu", typeof(string));
            dtdemirbasList.Columns.Add("DemirbasAdi", typeof(string));
            dtdemirbasList.Columns.Add("DemirbasOzellikleri", typeof(string));
            dtdemirbasList.Columns.Add("DemirbasAdedi", typeof(int));
            foreach (var item in demirbasList)
            {
                dtdemirbasList.Rows.Add(item.DemirbasNo, item.UrunId, item.DemirbasKodu, item.DemirbasAdi, item.DemirbasOzellikleri, item.DemirbasAdedi);
            }
            grid.DataSource = dtdemirbasList;
            gridView.Columns["DemirbasNo"].Visible = false;
            gridView.Columns["UrunId"].Visible = false;
        }
        /// <summary>
        /// Girilen string ifadeyi md5 yapar.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string CreateMD5(string input)
        {
            // Use input string to calculate MD5 hash
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                // Convert the byte array to hexadecimal string
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }
    }
}
