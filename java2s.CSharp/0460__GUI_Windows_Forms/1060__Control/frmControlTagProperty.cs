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
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/ControlTagProperty.htm
    public partial  class frmControlTagProperty:Form
    {
        public frmControlTagProperty()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmControlTagProperty
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmControlTagProperty";
            this.Text = "frmControlTagProperty";
            this.Load += new System.EventHandler(this.frmControlTagProperty_Load);
            this.ResumeLayout(false);

        }

        private void frmControlTagProperty_Load(object sender, EventArgs e)
        {

        }
    }
}
