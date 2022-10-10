using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C1280__event
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/UsingEventAccessors.htm
    public partial  class frmUsingEventAccessors:Form
    {
        public frmUsingEventAccessors()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUsingEventAccessors
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUsingEventAccessors";
            this.Text = "frmUsingEventAccessors";
            this.Load += new System.EventHandler(this.frmUsingEventAccessors_Load);
            this.ResumeLayout(false);

        }

        private void frmUsingEventAccessors_Load(object sender, EventArgs e)
        {

        }
    }
}
