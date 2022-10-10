using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0440__I18N_Internationalization.C0260__Unicode
{
    //http://www.java2s.com/Tutorial/CSharp/0440__I18N-Internationalization/ListtheUnicodecodepointofeachofthecontrolcharacters.htm
    public partial  class frmListtheUnicodecodepointofeachofthecontrolcharacters:Form
    {
        public frmListtheUnicodecodepointofeachofthecontrolcharacters()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmListtheUnicodecodepointofeachofthecontrolcharacters
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmListtheUnicodecodepointofeachofthecontrolcharacters";
            this.Text = "frmListtheUnicodecodepointofeachofthecontrolcharacters";
            this.Load += new System.EventHandler(this.frmListtheUnicodecodepointofeachofthecontrolcharacters_Load);
            this.ResumeLayout(false);

        }

        private void frmListtheUnicodecodepointofeachofthecontrolcharacters_Load(object sender, EventArgs e)
        {

        }
    }
}
