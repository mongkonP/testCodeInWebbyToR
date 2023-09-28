using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0220__Data_Structure.C0020__Array
{
    //http://www.java2s.com/Tutorial/CSharp/0220__Data-Structure/ArrayDeclarationwithinitialization.htm
    public partial  class frmArrayDeclarationwithinitialization:Form
    {
        public frmArrayDeclarationwithinitialization()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmArrayDeclarationwithinitialization
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmArrayDeclarationwithinitialization";
            this.Text = "frmArrayDeclarationwithinitialization";
            this.Load += new System.EventHandler(this.frmArrayDeclarationwithinitialization_Load);
            this.ResumeLayout(false);

        }

        private void frmArrayDeclarationwithinitialization_Load(object sender, EventArgs e)
        {

        }
    }
}
