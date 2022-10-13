using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEN_Project.PresentationLayer.Forms.ClientOptions;

namespace SEN_Project.PresentationLayer
{
    class PresentationController
    {
        public static PresentationController current;
        public PresentationController    ()
        {
            current = this;
            ClientTableOptions = new TableOptions();
            ClientTableOptions.AddForm = new frmAddClient();
        }

        public enum State
        {
            CallCenter,
            Database,
        }
        Form1 MainForm => Form1.current ?? new Form1();
        DatabaseForm DBForm => DatabaseForm.current ?? new DatabaseForm();
        State currentState;

        TableOptions ClientTableOptions;
        TableOptions CallTableOptions;

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
                        DBForm.CurrentOptions = ClientTableOptions;
                        break;
                    default:
                        break;
                }
                currentState = value;
            }
        }
    }
}
