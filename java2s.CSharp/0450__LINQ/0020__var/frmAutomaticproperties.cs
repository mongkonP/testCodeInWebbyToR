using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0450__LINQ.C0020__var
{
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/Automaticproperties.htm
    public partial  class frmAutomaticproperties:Form
    {
        public frmAutomaticproperties()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAutomaticproperties
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAutomaticproperties";
            this.Text = "frmAutomaticproperties";
            this.Load += new System.EventHandler(this.frmAutomaticproperties_Load);
            this.ResumeLayout(false);

        }

        private void frmAutomaticproperties_Load(object sender, EventArgs e)
        {

        }
    }
}
