using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using fatemeh_HardWare.BL;

namespace fatemeh_HardWare
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            //اگر دکمه enter را زد
            if (e.KeyChar == 13)
            {
                //از کلاس کاربر یک شی جدید بگیرد
                Person myUser = new Person();
                try
                {
                    //اگر اطلاعات صحیح بود
                    if (myUser.CheckLogin(Int32.Parse( txtUser.Text), txtPassword.Text))
                    {
                        ServiceManager.User = Int32.Parse(txtUser.Text);
                        frmPerson newForm = new frmPerson();
                        newForm.Show();
                        this.Dispose();
                    }
                    else//اگر اشتباه بود
                    {
                        MessageBox.Show(null,
                            "نام کاربری یا پسورد اشتباه است", "اخطار"
                            , MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ServiceManager.Exit();
                    }
                }
            
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            }
        }
    

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
