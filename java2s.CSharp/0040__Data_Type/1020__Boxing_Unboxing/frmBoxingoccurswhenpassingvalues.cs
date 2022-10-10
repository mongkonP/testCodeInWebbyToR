using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0040__Data_Type.C1020__Boxing_Unboxing
{
    //http://www.java2s.com/Tutorial/CSharp/0040__Data-Type/Boxingoccurswhenpassingvalues.htm
    public partial  class frmBoxingoccurswhenpassingvalues:Form
    {
        public frmBoxingoccurswhenpassingvalues()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmBoxingoccurswhenpassingvalues
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmBoxingoccurswhenpassingvalues";
            this.Text = "frmBoxingoccurswhenpassingvalues";
            this.Load += new System.EventHandler(this.frmBoxingoccurswhenpassingvalues_Load);
            this.ResumeLayout(false);

        }

        private void frmBoxingoccurswhenpassingvalues_Load(object sender, EventArgs e)
        {

        }
    }
}
