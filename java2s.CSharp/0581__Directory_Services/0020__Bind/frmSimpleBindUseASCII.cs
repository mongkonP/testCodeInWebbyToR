using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0581__Directory_Services.C0020__Bind
{
    //http://www.java2s.com/Tutorial/CSharp/0581__Directory-Services/SimpleBindUseASCII.htm
    public partial  class frmSimpleBindUseASCII:Form
    {
        public frmSimpleBindUseASCII()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSimpleBindUseASCII
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSimpleBindUseASCII";
            this.Text = "frmSimpleBindUseASCII";
            this.Load += new System.EventHandler(this.frmSimpleBindUseASCII_Load);
            this.ResumeLayout(false);

        }

        private void frmSimpleBindUseASCII_Load(object sender, EventArgs e)
        {

        }
    }
}
