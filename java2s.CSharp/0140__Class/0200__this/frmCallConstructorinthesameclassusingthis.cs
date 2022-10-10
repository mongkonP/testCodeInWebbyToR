using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0140__Class.C0200__this
{
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/CallConstructorinthesameclassusingthis.htm
    public partial  class frmCallConstructorinthesameclassusingthis:Form
    {
        public frmCallConstructorinthesameclassusingthis()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCallConstructorinthesameclassusingthis
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCallConstructorinthesameclassusingthis";
            this.Text = "frmCallConstructorinthesameclassusingthis";
            this.Load += new System.EventHandler(this.frmCallConstructorinthesameclassusingthis_Load);
            this.ResumeLayout(false);

        }

        private void frmCallConstructorinthesameclassusingthis_Load(object sender, EventArgs e)
        {

        }
    }
}
