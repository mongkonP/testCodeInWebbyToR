using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0140__Class.C0640__interface
{
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/Baseclassandinterface.htm
    public partial  class frmBaseclassandinterface:Form
    {
        public frmBaseclassandinterface()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmBaseclassandinterface
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmBaseclassandinterface";
            this.Text = "frmBaseclassandinterface";
            this.Load += new System.EventHandler(this.frmBaseclassandinterface_Load);
            this.ResumeLayout(false);

        }

        private void frmBaseclassandinterface_Load(object sender, EventArgs e)
        {

        }
    }
}
