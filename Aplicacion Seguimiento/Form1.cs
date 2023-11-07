using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacion_Seguimiento
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            customMenus();
        }


        private void customMenus()
        {
            panelMyOrders.Visible = false;
        }

        private void hideMenus()
        {
            if (panelMyOrders.Visible == true)
            {
                panelMyOrders.Visible = false;
            }
        }

        private void showMenus(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideMenus();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private Form currentForm = null;

        private void showForm(Form newForm)
        {
            if (currentForm != null)
            {
                panelFormsLoader.Controls.Remove(currentForm);
                currentForm.Dispose();
            }

            currentForm = newForm;
            newForm.TopLevel = false;
            panelFormsLoader.Controls.Add(newForm);
            newForm.FormBorderStyle = FormBorderStyle.None;
            newForm.Dock = DockStyle.Fill;
            panelFormsLoader.Tag = newForm;
            newForm.BringToFront();
            newForm.Show();
        }

        private void buttonTrackBatch_Click(object sender, EventArgs e)
        {

        }

        private void buttonMyOrders_Click(object sender, EventArgs e)
        {
            showMenus(panelMyOrders);
        }
    }
}
