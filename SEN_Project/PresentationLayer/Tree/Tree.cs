using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SEN_Project.DataAccessLayer;
using SEN_Project.BusinessLogicLayer;
using SEN_Project.PresentationLayer;

namespace SEN_Project.PresentationLayer.Tree
{
    public partial class Tree : SEN_Project.PresentationLayer.TableForm
    {
        public Tree()
        {
            InitializeComponent();
            UpdateNodes();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void UpdateNodes() //This looks in the database and adds the appropriate nodes
        {
            List<Client> Clients =  BusinessLogic.current.GetAll<Client>();
            int count = 0;
            foreach (Client client in Clients)
            {
                TreeNode node = new TreeNode(client.FirstName + " " + client.LastName);//
                treeView1.Nodes.Add(node);
                List<Claim> claims = databaseAccess.GetClaimByClientID(count);
                int ClaimCount = 0;                
                foreach (Claim claim in claims)
                {
                    treeView1.Nodes[count].Nodes.Add(claim.TreeViewID());
                    treeView1.Nodes[count].Nodes[ClaimCount].Nodes.Add(claim.TreeViewStatus());
                    treeView1.Nodes[count].Nodes[ClaimCount].Nodes.Add(claim.TreeViewPrice());
                    treeView1.Nodes[count].Nodes[ClaimCount].Nodes.Add(claim.TreeViewProcedure());
                    ClaimCount++;
                }
                count++;
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Form1.current.Show();
        }
    }
}
