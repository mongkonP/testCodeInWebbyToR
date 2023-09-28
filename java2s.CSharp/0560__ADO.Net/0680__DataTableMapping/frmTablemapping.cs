using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0560__ADO.Net.C0680__DataTableMapping
{
    //http://www.java2s.com/Tutorial/CSharp/0560__ADO.Net/Tablemapping.htm
    public partial  class frmTablemapping:Form
    {
        public frmTablemapping()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmTablemapping
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmTablemapping";
            this.Text = "frmTablemapping";
            this.Load += new System.EventHandler(this.frmTablemapping_Load);
            this.ResumeLayout(false);

        }

        private void frmTablemapping_Load(object sender, EventArgs e)
        {

        }
    }
}
