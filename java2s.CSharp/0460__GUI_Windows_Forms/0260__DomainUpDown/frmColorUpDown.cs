using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C0260__DomainUpDown
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/ColorUpDown.htm
    public partial  class frmColorUpDown:Form
    {
        public frmColorUpDown()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmColorUpDown
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmColorUpDown";
            this.Text = "frmColorUpDown";
            this.Load += new System.EventHandler(this.frmColorUpDown_Load);
            this.ResumeLayout(false);

        }

        private void frmColorUpDown_Load(object sender, EventArgs e)
        {

        }
    }
}
