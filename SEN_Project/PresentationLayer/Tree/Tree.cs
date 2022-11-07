using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SEN_Project.DataAccessLayer;
using SEN_Project.BusinessLogicLayer;

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
            DataAccessLayer.DatabaseAccess databaseAccess = new DataAccessLayer.DatabaseAccess();
            List<Client> Clients =  databaseAccess.GetAllClients();
            int count = 0;
            foreach (Client client in Clients)
            {
                TreeNode node = new TreeNode(client.FirstName );//+ " " + client.LastName
                treeView1.Nodes.Add(node);
                treeView1.Nodes[count].Nodes.Add("Test");
                treeView1.Nodes[count].Nodes[0].Nodes.Add(client.ClientID.ToString());
                List<Claim> claims = databaseAccess.GetClaimByClientID(client.ClientID);
                foreach (Claim claim in claims)
                {
                    treeView1.Nodes[count].Nodes.Add(claim.ID);
                    treeView1.Nodes[count].Nodes.Add("Test");
                    treeView1.Nodes[count].Nodes[0].Nodes.Add(claim.ToLine());
                    treeView1.Nodes[count].Nodes[0].Nodes.Add("Test");

                }
                count++;
            }


        }
    }
}
