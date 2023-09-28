using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0450__LINQ.C0360__Average
{
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/Averagewithintarray.htm
    public partial  class frmAveragewithintarray:Form
    {
        public frmAveragewithintarray()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAveragewithintarray
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAveragewithintarray";
            this.Text = "frmAveragewithintarray";
            this.Load += new System.EventHandler(this.frmAveragewithintarray_Load);
            this.ResumeLayout(false);

        }

        private void frmAveragewithintarray_Load(object sender, EventArgs e)
        {

        }
    }
}
