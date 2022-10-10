using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0220__Data_Structure.C0600__IDictionary
{
    //http://www.java2s.com/Tutorial/CSharp/0220__Data-Structure/Creatingalistfromadictionary.htm
    public partial  class frmCreatingalistfromadictionary:Form
    {
        public frmCreatingalistfromadictionary()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCreatingalistfromadictionary
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCreatingalistfromadictionary";
            this.Text = "frmCreatingalistfromadictionary";
            this.Load += new System.EventHandler(this.frmCreatingalistfromadictionary_Load);
            this.ResumeLayout(false);

        }

        private void frmCreatingalistfromadictionary_Load(object sender, EventArgs e)
        {

        }
    }
}
