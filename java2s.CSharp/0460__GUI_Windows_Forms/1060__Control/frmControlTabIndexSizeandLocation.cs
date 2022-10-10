using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C1060__Control
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/ControlTabIndexSizeandLocation.htm
    public partial  class frmControlTabIndexSizeandLocation:Form
    {
        public frmControlTabIndexSizeandLocation()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmControlTabIndexSizeandLocation
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmControlTabIndexSizeandLocation";
            this.Text = "frmControlTabIndexSizeandLocation";
            this.Load += new System.EventHandler(this.frmControlTabIndexSizeandLocation_Load);
            this.ResumeLayout(false);

        }

        private void frmControlTabIndexSizeandLocation_Load(object sender, EventArgs e)
        {

        }
    }
}
