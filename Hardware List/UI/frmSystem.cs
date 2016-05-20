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
    public partial class frmSystem : Form
    {
        public frmSystem()
        {
            InitializeComponent();
        }

        private void btnPerson_Click(object sender, EventArgs e)
        {
            frmPerson frm = new frmPerson();
            frm.Show();
            this.Close();
        }

        private void btnEquipment_Click(object sender, EventArgs e)
        {
            frmEquipment frm = new frmEquipment();
            frm.Show();
            this.Close();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            frmReport frm = new frmReport();
            frm.Show();
            this.Close();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            frmUser frm = new frmUser();
            frm.Show();
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ServiceManager.Exit();
        }


        private void frmSystem_Load(object sender, EventArgs e)
        {
            SystemPerson mySystem = new SystemPerson();

            txtCode.Text = "";

            cmbCPU.DataSource = mySystem.SelectAllCPU();
            cmbCPU.DisplayMember = "NameCPU";
            cmbCPU.ValueMember = "CodeCPU";

            cmbCase.DataSource = mySystem.SelectAllCase();
            cmbCase.DisplayMember = "NameCase";
            cmbCase.ValueMember = "CodeCase";

            cmbDisplay.DataSource = mySystem.SelectAllDisplay();
            cmbDisplay.DisplayMember = "NameDisplay";
            cmbDisplay.ValueMember = "CodeDisplay";

            cmbHDD.DataSource = mySystem.SelectAllHDD();
            cmbHDD.DisplayMember = "NameHDD";
            cmbHDD.ValueMember = "CodeHDD";

            cmbKeyboard.DataSource = mySystem.SelectAllKeyboard();
            cmbKeyboard.DisplayMember = "NameKeyboard";
            cmbKeyboard.ValueMember = "CodeKeyboard";

            cmbMouse.DataSource = mySystem.SelectAllMouse();
            cmbMouse.DisplayMember = "NameMouse";
            cmbMouse.ValueMember = "CodeMouse";

            cmbODD.DataSource = mySystem.SelectAllODD();
            cmbODD.DisplayMember = "NameODD";
            cmbODD.ValueMember = "CodeODD";

            cmbPCI.DataSource = mySystem.SelectAllPCI();
            cmbPCI.DisplayMember = "NamePCI";
            cmbPCI.ValueMember = "CodePCI";

            cmbPrinter.DataSource = mySystem.SelectAllPrinter();
            cmbPrinter.DisplayMember = "NamePrinter";
            cmbPrinter.ValueMember = "CodePrinter";

            cmbRAM.DataSource = mySystem.SelectAllRAM();
            cmbRAM.DisplayMember = "NameRAM";
            cmbRAM.ValueMember = "CodeRAM";

            cmbVGA.DataSource = mySystem.SelectAllVGA();
            cmbVGA.DisplayMember = "NameVGA";
            cmbVGA.ValueMember = "CodeVGA";

            cmbMain.DataSource = mySystem.SelectAllMain();
            cmbMain.DisplayMember = "NameMain";
            cmbMain.ValueMember = "CodeMain";

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            SystemPerson newSystem = new SystemPerson();
            if (newSystem.Add(txtCode.Text,
                Convert.ToInt32(cmbCPU.SelectedValue),
                Convert.ToInt32(cmbCase.SelectedValue),
                Convert.ToInt32(cmbDisplay.SelectedValue),
                Convert.ToInt32(cmbHDD.SelectedValue),
                Convert.ToInt32(cmbKeyboard.SelectedValue),
                Convert.ToInt32(cmbMain.SelectedValue),
                Convert.ToInt32(cmbMouse.SelectedValue),
                Convert.ToInt32(cmbODD.SelectedValue),
                Convert.ToInt32(cmbPCI.SelectedValue),
                Convert.ToInt32(cmbPrinter.SelectedValue),
                Convert.ToInt32(cmbRAM.SelectedValue),
                Convert.ToInt32(cmbVGA.SelectedValue)))
            {
                MessageBox.Show("عملیات با موفقیت انجام شد");
            }

            else
            {
                MessageBox.Show(newSystem.Message);
            }

            this.frmSystem_Load(sender, e);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            frmSystem_Load(sender, e);
        }
    }
}
