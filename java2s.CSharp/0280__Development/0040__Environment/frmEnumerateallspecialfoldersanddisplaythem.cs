using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0280__Development.C0040__Environment
{
    //http://www.java2s.com/Tutorial/CSharp/0280__Development/Enumerateallspecialfoldersanddisplaythem.htm
    public partial  class frmEnumerateallspecialfoldersanddisplaythem:Form
    {
        public frmEnumerateallspecialfoldersanddisplaythem()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmEnumerateallspecialfoldersanddisplaythem
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmEnumerateallspecialfoldersanddisplaythem";
            this.Text = "frmEnumerateallspecialfoldersanddisplaythem";
            this.Load += new System.EventHandler(this.frmEnumerateallspecialfoldersanddisplaythem_Load);
            this.ResumeLayout(false);

        }

        private void frmEnumerateallspecialfoldersanddisplaythem_Load(object sender, EventArgs e)
        {

        }
    }
}
