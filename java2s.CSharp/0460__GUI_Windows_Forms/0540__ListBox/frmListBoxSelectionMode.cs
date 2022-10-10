using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C0540__ListBox
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/ListBoxSelectionMode.htm
    public partial  class frmListBoxSelectionMode:Form
    {
        public frmListBoxSelectionMode()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmListBoxSelectionMode
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmListBoxSelectionMode";
            this.Text = "frmListBoxSelectionMode";
            this.Load += new System.EventHandler(this.frmListBoxSelectionMode_Load);
            this.ResumeLayout(false);

        }

        private void frmListBoxSelectionMode_Load(object sender, EventArgs e)
        {

        }
    }
}
