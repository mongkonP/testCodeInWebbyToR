using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0220__Data_Structure.C0680__List
{
    //http://www.java2s.com/Tutorial/CSharp/0220__Data-Structure/VectorextendsList.htm
    public partial  class frmVectorextendsList:Form
    {
        public frmVectorextendsList()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmVectorextendsList
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmVectorextendsList";
            this.Text = "frmVectorextendsList";
            this.Load += new System.EventHandler(this.frmVectorextendsList_Load);
            this.ResumeLayout(false);

        }

        private void frmVectorextendsList_Load(object sender, EventArgs e)
        {

        }
    }
}
