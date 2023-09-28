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
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/MultipleImplementationimplementtwointerfaces.htm
    public partial  class frmMultipleImplementationimplementtwointerfaces:Form
    {
        public frmMultipleImplementationimplementtwointerfaces()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmMultipleImplementationimplementtwointerfaces
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmMultipleImplementationimplementtwointerfaces";
            this.Text = "frmMultipleImplementationimplementtwointerfaces";
            this.Load += new System.EventHandler(this.frmMultipleImplementationimplementtwointerfaces_Load);
            this.ResumeLayout(false);

        }

        private void frmMultipleImplementationimplementtwointerfaces_Load(object sender, EventArgs e)
        {

        }
    }
}
