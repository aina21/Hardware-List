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
    public partial class frmReport : Form
    {
        public frmReport()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            Person myPerson = new Person();
            Equipment myEquipment = new Equipment();

            txtEquCode.Text = "";
            txtEquModel.Text = "";
            txtEquSystem.Text = "";
            txtPerCode.Text = "";
            txtPerDakheli.Text = "";
            txtPerLastName.Text = "";
            txtPerName.Text = "";
            txtTozihat.Text = "";

            txtDate.Format = DateTimePickerFormat.Custom;
            txtDate.CustomFormat = "dd/MM/yyyy";

            //لیست ساختمان ها
            var b = myPerson.SelectAllBuldings();
            cmbPerBuild.DataSource = b;
            cmbPerBuild.DisplayMember = "Name";
            cmbPerBuild.ValueMember = "Code";

            //لیست گروه ها
            cmbPerGroup.DataSource = myPerson.SelectAllGroups();
            cmbPerGroup.DisplayMember = "Name";
            cmbPerGroup.ValueMember = "Code";

            cmbEquType.DataSource = myEquipment.SelectAllHardwares();
            cmbEquType.DisplayMember = "NameHardware";
            cmbEquType.ValueMember = "CodeHardware";



        }

        private void btnPerOk_Click(object sender, EventArgs e)
        {
            try
            {
                Person myPerson = new Person(Convert.ToInt32(txtPerCode.Text));
                Equipment myEquipment = new Equipment();

                if (myPerson.Message != null)
                {
                    MessageBox.Show(myPerson.Message);
                    this.frmReport_Load(sender, e);
                }
                else
                {
                    txtPerLastName.Text = myPerson.LastName;
                    txtPerName.Text = myPerson.Name;
                    txtPerDakheli.Text = myPerson.Dakheli;
                    cmbPerBuild.Text = myPerson.GetBuildingName(myPerson.Bulding);
                    cmbPerGroup.Text = myPerson.GetGroupName(myPerson.Group);
                    cmbPerEquipment.DataSource = myEquipment.SelectAllEquipmentOfPerson(txtPerCode.Text);
                    cmbPerEquipment.DisplayMember = "NameEquipment";
                    cmbPerEquipment.ValueMember = "CodeEquipment";
                }
            }
            catch
            {
                MessageBox.Show("کد پرسنل را وارد کنید");
            }
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

        private void btnSystem_Click(object sender, EventArgs e)
        {
            frmSystem frm = new frmSystem();
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

        private void btnEquOk_Click(object sender, EventArgs e)
        {
            try
            {
                Equipment myEquipment = new Equipment(Convert.ToInt32(txtEquCode.Text));
                SystemPerson mySystem = new SystemPerson();

                if (myEquipment.Message != null)
                {
                    MessageBox.Show(myEquipment.Message);
                    this.frmReport_Load(sender, e);
                }
                else
                {
                    txtEquModel.Text = myEquipment.Model;
                    cmbEquType.Text = myEquipment.GetHardwareCode(myEquipment.Hardware);
                    txtEquSystem.Text = mySystem.GetSystemOfEquipment(Convert.ToInt32(txtEquCode.Text)).ToString();
                    txtTozihat.Text = myEquipment.SelectAllEquipmentOfDate(Convert.ToInt32(txtEquCode.Text), txtDate.Text);
                    
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
    }
}
