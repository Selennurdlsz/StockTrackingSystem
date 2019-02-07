using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using YazilimSinamaStokTakipSistemi.Controller;
using YazilimSinamaStokTakipSistemi.Model;

namespace YazilimSinamaStokTakipSistemi.Views.Users
{
    public partial class AdminForm : DevExpress.XtraEditors.XtraForm
    {
        //Adminin Giriş Yaptığı formdur

        public AdminForm()
        {
            InitializeComponent();
        }

        //Form ekranındaki bilgilerin doğruluğunu test eder
        //Doğru bilgiler girildiyse AdminIslev formunu açar
        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            try
            {
                Kullanicilar user = new Kullanicilar();
                user.KullaniciAdi = txtKullaniciAdi.Text;
                user.Sifre = txtSifre.Text;
                string md5 = Tools.CreateMD5(user.Sifre);
                if (string.IsNullOrEmpty(user.KullaniciAdi) || string.IsNullOrEmpty(md5))
                {
                    throw new ValidationException("Kullanıcı Adı ve Şifre Boş Geçilemez !");
                }
                user.Sifre = md5;
                var result = KullaniciController.UserAdminLogin(user);
                LoginForm._session = eRoller.Admin.ToString();
                LoginForm._userIdSession = result.KullaniciId;
                AdminIslevleri dyif = new AdminIslevleri();
                dyif.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata Meydana Geldi !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //AdminFormu nun kapatılması durumunda loginForm a geri döner
        private void AdminForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoginForm lf = new LoginForm();
            lf.Show();
        }
    }
}