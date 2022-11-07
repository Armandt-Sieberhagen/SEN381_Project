using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SEN_Project.PresentationLayer.Forms;
using SEN_Project.PresentationLayer.Addresses;
using SEN_Project.PresentationLayer.Treatments;
using SEN_Project.BusinessLogicLayer;

namespace SEN_Project.PresentationLayer
{
    class PresentationController
    {
        public static PresentationController current;
        public PresentationController    ()
        {
            current = this;
            AddressOptions = new TableOptions();
            AddressOptions.AddForm = new AddressCreator();
            AddressOptions.UpdateForm = AddressOptions.AddForm;

            TreatmentsOptions = new TableOptions();
            TreatmentsOptions.AddForm = new frmTreatmentAddEdit();
            TreatmentsOptions.UpdateForm = TreatmentsOptions.AddForm;
        }


        public TableOptions AddressOptions;
        public TableOptions ConditionsOptions;
        public TableOptions ProvidersOptions;
        public TableOptions TreatmentsOptions;
        public TableOptions PackagesOptions;
        public TableOptions PolicyDataOptions;

        public  void    ShowError   (string Message)
        {
            MessageBox.Show(Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ShowSuccess(string Message)
        {
            MessageBox.Show(Message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
