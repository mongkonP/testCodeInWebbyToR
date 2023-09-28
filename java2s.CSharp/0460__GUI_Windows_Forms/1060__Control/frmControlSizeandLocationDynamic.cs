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
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/ControlSizeandLocationDynamic.htm
    public partial  class frmControlSizeandLocationDynamic:Form
    {
        public frmControlSizeandLocationDynamic()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmControlSizeandLocationDynamic
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmControlSizeandLocationDynamic";
            this.Text = "frmControlSizeandLocationDynamic";
            this.Load += new System.EventHandler(this.frmControlSizeandLocationDynamic_Load);
            this.ResumeLayout(false);

        }

        private void frmControlSizeandLocationDynamic_Load(object sender, EventArgs e)
        {

        }
    }
}
