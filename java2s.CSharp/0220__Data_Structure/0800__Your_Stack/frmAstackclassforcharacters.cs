using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0220__Data_Structure.C0800__Your_Stack
{
    //http://www.java2s.com/Tutorial/CSharp/0220__Data-Structure/Astackclassforcharacters.htm
    public partial  class frmAstackclassforcharacters:Form
    {
        public frmAstackclassforcharacters()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAstackclassforcharacters
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAstackclassforcharacters";
            this.Text = "frmAstackclassforcharacters";
            this.Load += new System.EventHandler(this.frmAstackclassforcharacters_Load);
            this.ResumeLayout(false);

        }

        private void frmAstackclassforcharacters_Load(object sender, EventArgs e)
        {

        }
    }
}
