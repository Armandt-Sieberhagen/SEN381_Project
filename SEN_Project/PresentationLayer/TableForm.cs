using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SEN_Project.PresentationLayer
{
    public class TableForm : Form, IResetable
    { 
        public virtual void Reset() { }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // TableForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "TableForm";
            this.Load += new System.EventHandler(this.TableForm_Load);
            this.ResumeLayout(false);

        }

        private void TableForm_Load(object sender, EventArgs e)
        {

        }
    }
}
