using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C1100__Control_Relation
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/ControlParentandChildrelation.htm
    public partial  class frmControlParentandChildrelation:Form
    {
        public frmControlParentandChildrelation()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmControlParentandChildrelation
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmControlParentandChildrelation";
            this.Text = "frmControlParentandChildrelation";
            this.Load += new System.EventHandler(this.frmControlParentandChildrelation_Load);
            this.ResumeLayout(false);

        }

        private void frmControlParentandChildrelation_Load(object sender, EventArgs e)
        {

        }
    }
}
