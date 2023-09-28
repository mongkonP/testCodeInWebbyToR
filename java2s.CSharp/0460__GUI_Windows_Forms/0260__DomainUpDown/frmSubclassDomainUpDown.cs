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
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/SubclassDomainUpDown.htm
    public partial  class frmSubclassDomainUpDown:Form
    {
        public frmSubclassDomainUpDown()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSubclassDomainUpDown
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSubclassDomainUpDown";
            this.Text = "frmSubclassDomainUpDown";
            this.Load += new System.EventHandler(this.frmSubclassDomainUpDown_Load);
            this.ResumeLayout(false);

        }

        private void frmSubclassDomainUpDown_Load(object sender, EventArgs e)
        {

        }
    }
}
