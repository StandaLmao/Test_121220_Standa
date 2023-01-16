using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_121220_Standa
{
    public partial class Form1 : Form
    {
        int global_id = EmployeeHandler.getIdsList().Count;
        bool updating = false;

        public Form1()
        {
            InitializeComponent();
            updateGui();
            Text = EmployeeHandler.ReadTable().Count.ToString();
        }

        public void updateGui()
        {
            lEmployees.Text = "";
            EmployeeHandler.ReadTable().ForEach((Employee e) =>
            {
                lEmployees.Text += e.ToString() + "\n";
            });
            if (updating)
            {
                Employee employee = EmployeeHandler.ReadOne(EmployeeHandler.getIdsList()[global_id]);
                bSubmit.Text = "Update";
                iFirstName.Text = employee.firstName;
                iLastName.Text = employee.lastName;
                iPhoneNum.Text = employee.phoneNum;
                iEmail.Text = employee.email;
                iBirthDate.Text = employee.birthDate;
            }
            else
            {
                bSubmit.Text = "Insert";
                iFirstName.Text = "";
                iLastName.Text = "";
                iPhoneNum.Text = "";
                iEmail.Text = "";
                iBirthDate.Text = "";
            }
            Text = global_id.ToString();
        }

        private void bSubmit_Click(object sender, EventArgs e)
        {
            if (!updating)
            {
                EmployeeHandler.Insert(new Employee(
                -1,
                iFirstName.Text,
                iLastName.Text,
                iPhoneNum.Text,
                iEmail.Text,
                iBirthDate.Text
                ));
            }
            else
            {
                EmployeeHandler.Update(EmployeeHandler.getIdsList()[global_id],new Employee(
                -1,
                iFirstName.Text,
                iLastName.Text,
                iPhoneNum.Text,
                iEmail.Text,
                iBirthDate.Text
                ));
            }
            updateGui();
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            EmployeeHandler.Delete(EmployeeHandler.getIdsList()[global_id]);
            updateGui();
        }

        private void bRight_Click(object sender, EventArgs e)
        {
            global_id += 1;
            List<int> ids = EmployeeHandler.getIdsList();
            if (global_id < ids.Count)
            {
                updating = true;
            }
            else
            {
                global_id = ids.Count;
                updating = false;
            }
            updateGui();
        }

        private void bLeft_Click(object sender, EventArgs e)
        {
            global_id -= 1;
            List<int> ids = EmployeeHandler.getIdsList();
            if (global_id >= 0)
            {
                
                updating = true;
            }
            else
            {
                updating = false;
                global_id = ids.Count;
            }
            updateGui();
        }
    }
}
