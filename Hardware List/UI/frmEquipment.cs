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
    public partial class frmEquipment : Form
    {
        public frmEquipment()
        {
            InitializeComponent();
        }

        private void frmEquipment_Load(object sender, EventArgs e)
        {
            Equipment myEquipment = new Equipment();
            lblCode.Text = (myEquipment.GetLastCode() + 1).ToString();

            txtModel.Text = "";
            txtModelE.Text = "";
            txtSearch.Text = "";
            txtWaranty.Text = "";
            txtWarantyE.Text = "";
            txtCode.Text = "";

            txtWarBegin.Format = DateTimePickerFormat.Custom;
            txtWarBegin.CustomFormat = "dd/MM/yyyy";
            txtWarBwginE.Format = DateTimePickerFormat.Custom;
            txtWarBwginE.CustomFormat = "dd/MM/yyyy";
            txtWarEnd.Format = DateTimePickerFormat.Custom;
            txtWarEnd.CustomFormat = "dd/MM/yyyy";
            txtWarEndE.Format = DateTimePickerFormat.Custom;
            txtWarEndE.CustomFormat = "dd/MM/yyyy";

            //لیست وضعیت

            cmbAccess.DataSource = myEquipment.SelectAllPersons();
            cmbAccess.DisplayMember = "CodePerson";
            cmbAccess.ValueMember = "CodePerson";

            //cmbAccessE.DataSource = myEquipment.SelectAllPersons();
            //cmbAccessE.DisplayMember = "CodePerson";
            //cmbAccessE.ValueMember = "CodePerson";

            cmbState.DataSource = myEquipment.SelectAllStates();
            cmbState.DisplayMember = "NameState";
            cmbState.ValueMember = "CodeState";

            cmbStatusE.DataSource = myEquipment.SelectAllStates();
            cmbStatusE.DisplayMember = "NameState";
            cmbStatusE.ValueMember = "CodeState";


            cmbType.DataSource = myEquipment.SelectAllHardwares();
            cmbType.DisplayMember = "NameHardware";
            cmbType.ValueMember = "CodeHardware";

            cmbTypeE.DataSource = myEquipment.SelectAllHardwares();
            cmbTypeE.DisplayMember = "NameHardware";
            cmbTypeE.ValueMember = "CodeHardware";


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ServiceManager.Exit();
        }

        private void btnPerson_Click(object sender, EventArgs e)
        {
            frmPerson frm = new frmPerson();
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

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Equipment newEquipment = new Equipment();
            if (newEquipment.Add(Convert.ToInt32(cmbType.SelectedValue),
                txtModel.Text,
                txtWaranty.Text,
                txtWarBegin.Text,
                txtWarEnd.Text,
                Convert.ToInt32(cmbState.SelectedValue),
                Convert.ToInt32(cmbAccess.SelectedValue)))
            {
                MessageBox.Show("عملیات با موفقیت انجام شد");
            }

            else
            {
                MessageBox.Show(newEquipment.Message);
            }

            this.frmEquipment_Load(sender, e);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.frmEquipment_Load(sender, e);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                Equipment myEquipment = new Equipment(Convert.ToInt32(txtCode.Text));

                if (myEquipment.Message != null)
                {
                    MessageBox.Show(myEquipment.Message);
                    this.frmEquipment_Load(sender, e);
                }
                else
                {
                    txtModelE.Text = myEquipment.Model;
                    txtWarantyE.Text = myEquipment.Warranty;
                    txtWarBwginE.Text = myEquipment.WarBegin;
                    txtWarEndE.Text = myEquipment.WarEnd;
                    cmbStatusE.Text = myEquipment.GetStateCode(myEquipment.State);
                    cmbTypeE.Text = myEquipment.GetHardwareCode(myEquipment.Hardware);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                Equipment myEquipment = new Equipment(Convert.ToInt32(txtCode.Text));
                if (myEquipment.Update(Convert.ToInt32(txtCode.Text),
                    Convert.ToInt32(cmbTypeE.SelectedValue),
                    txtModelE.Text,
                    txtWarantyE.Text,
                    txtWarBwginE.Text,
                    txtWarEndE.Text,
                    Convert.ToInt32(cmbStatusE.SelectedValue)))
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
                MessageBox.Show("کد قطعه را درست وارد کنید");
            }

            this.frmEquipment_Load(sender, e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Equipment myEquipment = new Equipment(Convert.ToInt32(txtCode.Text));
                if (myEquipment.Freezing(Convert.ToInt32(txtCode.Text)))
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
            this.frmEquipment_Load(sender, e);

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Equipment myEquipment= new Equipment();
            var checkedButton = groupBox2.Controls.OfType<RadioButton>().Where(r => r.Checked == true).FirstOrDefault();

            if (myEquipment.Search(checkedButton.Text, txtSearch.Text))
            {
                //نمایش به کاربر

                dataGridView1.DataSource = myEquipment.SearchEquipment;

                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.AllowUserToDeleteRows = false;
                dataGridView1.MultiSelect = false;
                dataGridView1.AllowDrop = false;
                dataGridView1.ReadOnly = true;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dataGridView1.Columns[0].HeaderText = "کد قطعه";
                dataGridView1.Columns[1].HeaderText = "نوع ";
                dataGridView1.Columns[2].HeaderText = "مدل";
                dataGridView1.Columns[3].HeaderText = "نام گارانتی";
                dataGridView1.Columns[4].HeaderText = "وضعیت";
                dataGridView1.Columns[5].Visible = false;
                dataGridView1.Columns[6].Visible = false;
                dataGridView1.Columns[7].Visible = false;
                dataGridView1.Columns[8].Visible = false;
                dataGridView1.Columns[9].Visible = false;


            }

            else
            {
                MessageBox.Show(myEquipment.Message);
            }

            this.frmEquipment_Load(sender, e);
        
        }

        private void txtWarBegin_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtWarEndE_FormatChanged(object sender, EventArgs e)
        {
            
        }

        //private void cmbStatusE_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (cmbStatusE.SelectedValue.Equals(1))
        //        cmbAccessE.Enabled = false;
        //    else if (cmbStatusE.SelectedValue.Equals(2))
        //        cmbAccessE.Enabled = true;

        //}

        private void cmbState_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbState.SelectedValue.Equals(1))
                cmbAccess.Enabled = false;
            else if (cmbState.SelectedValue.Equals(2))
                cmbAccess.Enabled = true;
        }

    }
}
