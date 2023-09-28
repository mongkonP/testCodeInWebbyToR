using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0450__LINQ.C0240__Class_Init
{
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/ThestandardobjectcreationandinitializationvsLinq.htm
    public partial  class frmThestandardobjectcreationandinitializationvsLinq:Form
    {
        public frmThestandardobjectcreationandinitializationvsLinq()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmThestandardobjectcreationandinitializationvsLinq
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmThestandardobjectcreationandinitializationvsLinq";
            this.Text = "frmThestandardobjectcreationandinitializationvsLinq";
            this.Load += new System.EventHandler(this.frmThestandardobjectcreationandinitializationvsLinq_Load);
            this.ResumeLayout(false);

        }

        private void frmThestandardobjectcreationandinitializationvsLinq_Load(object sender, EventArgs e)
        {

        }
    }
}
