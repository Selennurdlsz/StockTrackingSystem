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
    public partial class DepartmanYetkilisiForm : DevExpress.XtraEditors.XtraForm
    {
        //Departman Yetkilisi Giriş Yaptığı formdur

        public DepartmanYetkilisiForm()
        {
            InitializeComponent();
        }

        //Form ekranındaki bilgilerin doğruluğunu test eder
        //Doğru bilgiler girildiyse DepartmanYetkilisiIslev formunu açar
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
                var result = KullaniciController.UserDepartmanYetkilisiLogin(user);
                LoginForm._session = eRoller.DepartmanYetkilisi.ToString();
                LoginForm._userIdSession = result.KullaniciId;
                DepartmanYetkilisiIslevleriForm dyif = new DepartmanYetkilisiIslevleriForm();
                dyif.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata Meydana Geldi !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //DepartmanYetkilisiFormu nun kapatılması durumunda loginForm a geri döner
        private void DepartmanYetkilisiForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoginForm lf = new LoginForm();
            lf.Show();
        }
    }
}