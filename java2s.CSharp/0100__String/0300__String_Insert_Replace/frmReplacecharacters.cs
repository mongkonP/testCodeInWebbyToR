using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0100__String.C0300__String_Insert_Replace
{
    //http://www.java2s.com/Tutorial/CSharp/0100__String/Replacecharacters.htm
    public partial  class frmReplacecharacters:Form
    {
        public frmReplacecharacters()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmReplacecharacters
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmReplacecharacters";
            this.Text = "frmReplacecharacters";
            this.Load += new System.EventHandler(this.frmReplacecharacters_Load);
            this.ResumeLayout(false);

        }

        private void frmReplacecharacters_Load(object sender, EventArgs e)
        {

        }
    }
}
