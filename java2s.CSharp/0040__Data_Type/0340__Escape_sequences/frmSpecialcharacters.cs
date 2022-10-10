using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0040__Data_Type.C0340__Escape_sequences
{
    //http://www.java2s.com/Tutorial/CSharp/0040__Data-Type/Specialcharacters.htm
    public partial  class frmSpecialcharacters:Form
    {
        public frmSpecialcharacters()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSpecialcharacters
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSpecialcharacters";
            this.Text = "frmSpecialcharacters";
            this.Load += new System.EventHandler(this.frmSpecialcharacters_Load);
            this.ResumeLayout(false);

        }

        private void frmSpecialcharacters_Load(object sender, EventArgs e)
        {

        }
    }
}
