using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C0820__MenuItem
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/OwnerDrawnMenuItem.htm
    public partial  class frmOwnerDrawnMenuItem:Form
    {
        public frmOwnerDrawnMenuItem()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmOwnerDrawnMenuItem
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmOwnerDrawnMenuItem";
            this.Text = "frmOwnerDrawnMenuItem";
            this.Load += new System.EventHandler(this.frmOwnerDrawnMenuItem_Load);
            this.ResumeLayout(false);

        }

        private void frmOwnerDrawnMenuItem_Load(object sender, EventArgs e)
        {

        }
    }
}
