using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0220__Data_Structure.C0580__Hashtable
{
    //http://www.java2s.com/Tutorial/CSharp/0220__Data-Structure/RemovekeyvaluepairsfromHashtable.htm
    public partial  class frmRemovekeyvaluepairsfromHashtable:Form
    {
        public frmRemovekeyvaluepairsfromHashtable()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmRemovekeyvaluepairsfromHashtable
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmRemovekeyvaluepairsfromHashtable";
            this.Text = "frmRemovekeyvaluepairsfromHashtable";
            this.Load += new System.EventHandler(this.frmRemovekeyvaluepairsfromHashtable_Load);
            this.ResumeLayout(false);

        }

        private void frmRemovekeyvaluepairsfromHashtable_Load(object sender, EventArgs e)
        {

        }
    }
}
