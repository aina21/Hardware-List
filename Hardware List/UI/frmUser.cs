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
    public partial class frmUser : Form
    {
        public frmUser()
        {
            InitializeComponent();
        }

        private void frmUser_Load(object sender, EventArgs e)
        {
            lblUserCode.Text = ServiceManager.User.ToString();
            txtTozihat.Text = "";

            Person myPerson = new Person(Convert.ToInt32(lblUserCode.Text));
            Equipment myEquipment = new Equipment();

            //لیست ساختمان ها
            var b = myPerson.SelectAllBuldings();
            cmbBuild.DataSource = b;
            cmbBuild.DisplayMember = "Name";
            cmbBuild.ValueMember = "Code";

            //لیست گروه ها
            cmbGroup.DataSource = myPerson.SelectAllGroups();
            cmbGroup.DisplayMember = "Name";
            cmbGroup.ValueMember = "Code";

            if (myPerson.Message != null)
            {
                MessageBox.Show(myPerson.Message);
            }
            else
            {
                txtLastName.Text = myPerson.LastName;
                txtName.Text = myPerson.Name;
                txtDakheli.Text = myPerson.Dakheli;
                txtRoom.Text = myPerson.Room;
                cmbBuild.Text = myPerson.GetBuildingName(myPerson.Bulding);
                cmbGroup.Text = myPerson.GetGroupName(myPerson.Group);
            }

            ////
            cmbType.DataSource = cmbEquipment.DataSource = myEquipment.SelectAllEquipmentOfPerson(lblUserCode.Text);
            cmbEquipment.DisplayMember = "NameEquipment";
            cmbEquipment.ValueMember = "CodeEquipment";

            //cmbType.DataSource = myEquipment.SelectAllEquipmentOfPerson(lblUserCode.Text);
            cmbType.DisplayMember = "NameHardware";
            cmbType.ValueMember = "CodeEquipment";

            
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

        private void btnReport_Click(object sender, EventArgs e)
        {
            frmReport frm = new frmReport();
            frm.Show();
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ServiceManager.Exit();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Person myPerson = new Person(Convert.ToInt32(lblUserCode.Text));
            if (myPerson.Update(Convert.ToInt32(lblUserCode.Text),
                    txtName.Text,
                    txtLastName.Text,
                    txtDakheli.Text,
                    Convert.ToInt32(cmbBuild.SelectedValue),
                    txtRoom.Text,
                    Convert.ToInt32(cmbGroup.SelectedValue)))
            {
                MessageBox.Show("عملیات با موفقیت انجام شد");
            }

            else
            {
                MessageBox.Show(myPerson.Message);
            }
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            frmUser_Load(sender, e);
        }

        private void btnCancle2_Click(object sender, EventArgs e)
        {
            frmUser_Load(sender, e);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                Equipment myEquipment = new Equipment();
                if (myEquipment.ChangeStatus(Convert.ToInt32(cmbEquipment.SelectedValue), lblUserCode.Text, txtTozihat.Text))
                {
                    MessageBox.Show("عملیات با موفقیت انجام شد");
                }

                else
                {
                    MessageBox.Show(myEquipment.Message);
                }
            }
            catch
            {
                MessageBox.Show("کد پرسنل را وارد کنید");
            }
            this.frmUser_Load(sender, e);
        }
    }
}
