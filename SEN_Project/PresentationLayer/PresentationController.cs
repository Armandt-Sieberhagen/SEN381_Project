using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SEN_Project.PresentationLayer.Forms.ClientOptions;
using SEN_Project.PresentationLayer.Addresses.AddressCreator;

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
            AddressOptions.UpdateForm = new AddressCreator();
        }

        public enum State
        {
            CallCenter,
            Database,
        }
        Form1 MainForm => Form1.current ?? new Form1();
        DatabaseForm DBForm => DatabaseForm.current ?? new DatabaseForm();
        State currentState;

        public TableOptions AddressOptions;
        public TableOptions ConditionsOptions;
        public TableOptions ProvidersOptions;
        public TableOptions TreatmentsOptions;
        public TableOptions PackagesOptions;
        public TableOptions PolicyDataOptions;

        public State CurrentState { 
            get {
                return currentState;
            }
            set {
                switch (value)
                {
                    case State.CallCenter:
                        MainForm.Show();
                        DBForm.Hide();
                        break;
                    case State.Database:
                        MainForm.Hide();
                        DBForm.Show();
                        break;
                    default:
                        break;
                }
                currentState = value;
            }
        }

        public  void    ShowError   (string Message)
        {
            MessageBox.Show(Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
