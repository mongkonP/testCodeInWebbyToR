using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0220__Data_Structure.C0880__IEnumerator
{
    //http://www.java2s.com/Tutorial/CSharp/0220__Data-Structure/IteratorWorkflow.htm
    public partial  class frmIteratorWorkflow:Form
    {
        public frmIteratorWorkflow()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmIteratorWorkflow
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmIteratorWorkflow";
            this.Text = "frmIteratorWorkflow";
            this.Load += new System.EventHandler(this.frmIteratorWorkflow_Load);
            this.ResumeLayout(false);

        }

        private void frmIteratorWorkflow_Load(object sender, EventArgs e)
        {

        }
    }
}
