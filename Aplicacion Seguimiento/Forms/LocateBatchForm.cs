using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacion_Seguimiento.Forms
{
    public partial class LocateBatchForm : Form
    {

        public event Action LanguageChanged;

        public LocateBatchForm()
        {
            InitializeComponent();
            Form1 mainForm = Application.OpenForms.OfType<Form1>().FirstOrDefault();
            if (mainForm != null)
            {
                mainForm.LanguageChanged += UpdateLanguage;
            }
            //apiRequests = new ApiRequestAssignBatchToTruck("http://localhost:64191");
        }

        private void UpdateLanguage()
        {
            buttonAdd.Text = LanguageManager.GetString("Add");
            buttonDelete.Text = LanguageManager.GetString("Delete");
            buttonRefresh.Text = LanguageManager.GetString("Refresh");
            buttonBackToMainMenu.Text = LanguageManager.GetString("Back");

            labelTruckID.Text = LanguageManager.GetString("IDTruck");
            labelEstimatedDate.Text = LanguageManager.GetString("EstimatedDate");
            labelIDBatch.Text = LanguageManager.GetString("LotID");

        }

        private void buttonBackToMainMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
