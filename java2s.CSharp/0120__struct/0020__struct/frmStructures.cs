using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0120__struct.C0020__struct
{
    //http://www.java2s.com/Tutorial/CSharp/0120__struct/Structures.htm
    public partial  class frmStructures:Form
    {
        public frmStructures()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmStructures
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmStructures";
            this.Text = "frmStructures";
            this.Load += new System.EventHandler(this.frmStructures_Load);
            this.ResumeLayout(false);

        }

        private void frmStructures_Load(object sender, EventArgs e)
        {

        }
    }
}
