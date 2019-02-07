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
using YazilimSinamaStokTakipSistemi.Views.Users;
using YazilimSinamaStokTakipSistemi.Controller;
using YazilimSinamaStokTakipSistemi.Model;

namespace YazilimSinamaStokTakipSistemi
{
    public partial class LoginForm : DevExpress.XtraEditors.XtraForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        public static string _session { get; set; }
        public static int _userIdSession { get; set; }

        //Departman yetkili girişi
        private void tileDepartmanYetkilisi_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            DepartmanYetkilisiForm DYF = new DepartmanYetkilisiForm();
            DYF.Show();
            this.Hide();
        }

        //Satıs sorumlusu girişi
        private void tileSatisSorumlusu_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            SatisSorumlusuForm SSF = new SatisSorumlusuForm();
            SSF.Show();
            this.Hide();
        }

        //Admin girişi
        private void tileAdminGiris_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            AdminForm ALF = new AdminForm();
            ALF.Show();
            this.Hide();
        }
    }
}
