using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C0180__CheckBox
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/ChangeLabelfontbyCheckBoxes.htm
    public partial  class frmChangeLabelfontbyCheckBoxes:Form
    {
        public frmChangeLabelfontbyCheckBoxes()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmChangeLabelfontbyCheckBoxes
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmChangeLabelfontbyCheckBoxes";
            this.Text = "frmChangeLabelfontbyCheckBoxes";
            this.Load += new System.EventHandler(this.frmChangeLabelfontbyCheckBoxes_Load);
            this.ResumeLayout(false);

        }

        private void frmChangeLabelfontbyCheckBoxes_Load(object sender, EventArgs e)
        {

        }
    }
}
