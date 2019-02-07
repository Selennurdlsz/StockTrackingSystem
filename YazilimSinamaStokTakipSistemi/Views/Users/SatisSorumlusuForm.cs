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
    public partial class SatisSorumlusuForm : DevExpress.XtraEditors.XtraForm
    {
        //SatisSorumlusunun Giriş Yaptığı formdur

        public SatisSorumlusuForm()
        {
            InitializeComponent();
        }

        //Form ekranındaki bilgilerin doğruluğunu test eder
        //Doğru bilgiler girildiyse SatisSorumlusuIslev formunu açar
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
                var result = KullaniciController.UserSatisSorumlusuLogin(user);
                LoginForm._session = eRoller.SatisSorumlusu.ToString();
                LoginForm._userIdSession = result.KullaniciId;
                SatisGorevlisiIslevleri dyif = new SatisGorevlisiIslevleri();
                dyif.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata Meydana Geldi !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //SatisSorumlusuFormu nun kapatılması durumunda loginForm a geri döner
        private void SatisSorumlusuForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoginForm lf = new LoginForm();
            lf.Show();
        }
    }
}