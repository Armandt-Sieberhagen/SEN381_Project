using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SEN_Project.PresentationLayer;
using SEN_Project.DataAccessLayer;
using SEN_Project.BusinessLogicLayer;
using SEN_Project.DataLayer;

namespace SEN_Project
{
    public partial class Form1 : Form
    {
        public static Form1 current;
        public Form1()
        {
            current = this;
            InitializeComponent();
        }

        private void btnViewDatabase_Click(object sender, EventArgs e)
        {
            PresentationController.current.CurrentState = PresentationController.State.Database;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            new BusinessLogic();
            new GlobalDataLayer().Initialize();
            new PresentationController();
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            Factory.GetAddClientForm().Show();
        }
    }
}
