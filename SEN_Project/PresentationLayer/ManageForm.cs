using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SEN_Project.BusinessLogicLayer;

namespace SEN_Project.PresentationLayer
{
    public partial class ManageForm : TableForm
    {
        public ManageForm()
        {
            InitializeComponent();
        }
        public ObjectVoid ConfirmCallback;

        public  virtual void    SetObject   (object _Object)
        {

        }

        private void ManageForm_Load(object sender, EventArgs e)
        {

        }
    }
}
