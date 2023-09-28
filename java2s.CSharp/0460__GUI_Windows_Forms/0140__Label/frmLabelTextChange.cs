using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C0140__Label
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/LabelTextChange.htm
    public partial  class frmLabelTextChange:Form
    {
        public frmLabelTextChange()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmLabelTextChange
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmLabelTextChange";
            this.Text = "frmLabelTextChange";
            this.Load += new System.EventHandler(this.frmLabelTextChange_Load);
            this.ResumeLayout(false);

        }

        private void frmLabelTextChange_Load(object sender, EventArgs e)
        {

        }
    }
}
