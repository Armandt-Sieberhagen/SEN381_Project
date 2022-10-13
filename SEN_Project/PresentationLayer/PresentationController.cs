using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEN_Project.PresentationLayer
{
    class PresentationController
    {
        public static PresentationController current;
        public PresentationController    ()
        {
            current = this;
        }

        public enum State
        {
            CallCenter,
            Database,
        }
        Form1 MainForm => Form1.current ?? new Form1();
        DatabaseForm DBFOrm => DatabaseForm.current ?? new DatabaseForm();
        State currentState;
        public State CurrentState { 
            get {
                return currentState;
            }
            set {
                switch (value)
                {
                    case State.CallCenter:
                        MainForm.Show();
                        DBFOrm.Hide();
                        break;
                    case State.Database:
                        MainForm.Hide();
                        DBFOrm.Show();
                        break;
                    default:
                        break;
                }
                currentState = value;
            }
        }
    }
}
