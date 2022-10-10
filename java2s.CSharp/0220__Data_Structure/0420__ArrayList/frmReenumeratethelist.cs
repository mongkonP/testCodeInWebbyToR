using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0220__Data_Structure.C0420__ArrayList
{
    //http://www.java2s.com/Tutorial/CSharp/0220__Data-Structure/Reenumeratethelist.htm
    public partial  class frmReenumeratethelist:Form
    {
        public frmReenumeratethelist()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmReenumeratethelist
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmReenumeratethelist";
            this.Text = "frmReenumeratethelist";
            this.Load += new System.EventHandler(this.frmReenumeratethelist_Load);
            this.ResumeLayout(false);

        }

        private void frmReenumeratethelist_Load(object sender, EventArgs e)
        {

        }
    }
}
