using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C0620__TreeView
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/Treenodeforegroundandbackgroundcolortooltips.htm
    public partial  class frmTreenodeforegroundandbackgroundcolortooltips:Form
    {
        public frmTreenodeforegroundandbackgroundcolortooltips()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmTreenodeforegroundandbackgroundcolortooltips
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmTreenodeforegroundandbackgroundcolortooltips";
            this.Text = "frmTreenodeforegroundandbackgroundcolortooltips";
            this.Load += new System.EventHandler(this.frmTreenodeforegroundandbackgroundcolortooltips_Load);
            this.ResumeLayout(false);

        }

        private void frmTreenodeforegroundandbackgroundcolortooltips_Load(object sender, EventArgs e)
        {

        }
    }
}
