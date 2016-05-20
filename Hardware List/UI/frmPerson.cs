using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using fatemeh_HardWare.BL;
using fatemeh_HardWare.Data;

namespace fatemeh_HardWare
{
    public partial class frmPerson : Form
    {
        public frmPerson()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Person newPerson = new Person();
            if (newPerson.Add(txtName.Text,
                txtLastName.Text,
                txtDakheli.Text,
                Convert.ToInt32(cmbBuilding.SelectedValue),
                txtRoomE.Text,
                Convert.ToInt32(cmbGroup.SelectedValue)))
            {
                MessageBox.Show("عملیات با موفقیت انجام شد");
            }

            else
            {
                MessageBox.Show(newPerson.Message);
            }

            this.frmPerson_Load(sender, e);
        }

        private void frmPerson_Load(object sender, EventArgs e)
        {
            Person myPerson = new Person();

            lblCode.Text = (myPerson.GetLastCode() + 1).ToString();
            
            txtDakheli.Text = "";
            txtName.Text = "";
            txtLastName.Text = "";
            txtDakheliE.Text = "";
            txtNameE.Text = "";
            txtLastNameE.Text = "";
            txtRoom.Text = "";
            txtRoomE.Text = "";
            txtCode.Text = "";


            //لیست ساختمان ها
            var b = myPerson.SelectAllBuldings();
            cmbBuilding.DataSource = b;
            cmbBuilding.DisplayMember = "Name";
            cmbBuilding.ValueMember = "Code";

            //لیست گروه ها
            cmbGroup.DataSource = myPerson.SelectAllGroups();
            cmbGroup.DisplayMember = "Name";
            cmbGroup.ValueMember = "Code";


            //لیست ساختمان ها
            cmbBuildE.DataSource = b;
            cmbBuildE.DisplayMember = "Name";
            cmbBuildE.ValueMember = "Code";

            //لیست گروه ها
            cmbGroupE.DataSource = myPerson.SelectAllGroups();
            cmbGroupE.DisplayMember = "Name";
            cmbGroupE.ValueMember = "Code";

            //
           
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.frmPerson_Load(sender, e);
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ServiceManager.Exit();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                Person myPerson = new Person(Convert.ToInt32(txtCode.Text));

                if (myPerson.Message != null)
                {
                    MessageBox.Show(myPerson.Message);
                    this.frmPerson_Load(sender, e);
                }
                else
                {
                    txtLastNameE.Text = myPerson.LastName;
                    txtNameE.Text = myPerson.Name;
                    txtDakheliE.Text = myPerson.Dakheli;
                    txtRoomE.Text = myPerson.Room;
                    cmbBuildE.Text = myPerson.GetBuildingName(myPerson.Bulding);
                    cmbGroupE.Text = myPerson.GetGroupName(myPerson.Group);
                }
            }
            catch
            {
                MessageBox.Show("کد پرسنل را وارد کنید");
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                Person myPerson = new Person(Convert.ToInt32(txtCode.Text));
                if (myPerson.Update(Convert.ToInt32(txtCode.Text),
                        txtNameE.Text,
                        txtLastNameE.Text,
                        txtDakheliE.Text,
                        Convert.ToInt32(cmbBuildE.SelectedValue),
                        txtRoomE.Text,
                        Convert.ToInt32(cmbGroupE.SelectedValue)))
                {
                    MessageBox.Show("عملیات با موفقیت انجام شد");
                }

                else
                {
                    MessageBox.Show(myPerson.Message);
                }
            }
            catch
            {
                MessageBox.Show("کد پرسنل را وارد کنید");
            }

            this.frmPerson_Load(sender, e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Person myPerson = new Person(Convert.ToInt32(txtCode.Text));
                if (myPerson.Freezing(Convert.ToInt32(txtCode.Text)))
                {
                    MessageBox.Show("عملیات با موفقیت انجام شد");
                }

                else
                {
                    MessageBox.Show(myPerson.Message);
                }
            }
            catch
            {
                MessageBox.Show("کد پرسنل را وارد کنید");
            }
            this.frmPerson_Load(sender, e);

        }

        private void btnPerson_Click(object sender, EventArgs e)
        {

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

        private void btnUser_Click(object sender, EventArgs e)
        {
            frmUser frm = new frmUser();
            frm.Show();
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Person myPerson = new Person();
            var checkedButton = groupBox2.Controls.OfType<RadioButton>().Where(r => r.Checked == true).FirstOrDefault();

            if (myPerson.Search(checkedButton.Text, txtSearch.Text))
            {
                //نمایش به کاربر

                dataGridView1.DataSource = myPerson.PersonSearch;

                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.AllowUserToDeleteRows = false;
                dataGridView1.MultiSelect = false;
                dataGridView1.AllowDrop = false;
                dataGridView1.ReadOnly = true;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dataGridView1.Columns[0].HeaderText = "کد پرسنل";
                dataGridView1.Columns[1].HeaderText = "نام ";
                dataGridView1.Columns[2].HeaderText = "نام خانوادگی";
                dataGridView1.Columns[3].HeaderText = "داخلی";
                dataGridView1.Columns[4].HeaderText = "نام گروه";
                dataGridView1.Columns[5].HeaderText = "نام ساختمان";
                dataGridView1.Columns[6].Visible = false;
                dataGridView1.Columns[7].Visible = false;
                dataGridView1.Columns[8].Visible = false;
                dataGridView1.Columns[9].Visible = false;
            }

            else
            {
                MessageBox.Show(myPerson.Message);
            }

            this.frmPerson_Load(sender, e);
        }
        
    }
}
