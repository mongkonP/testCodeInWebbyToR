using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0620__unsafe.C0040__Pointer
{
    //http://www.java2s.com/Tutorial/CSharp/0620__unsafe/Anarraynamewithanindexyieldsapointertothestartofthearray.htm
    public partial  class frmAnarraynamewithanindexyieldsapointertothestartofthearray:Form
    {
        public frmAnarraynamewithanindexyieldsapointertothestartofthearray()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAnarraynamewithanindexyieldsapointertothestartofthearray
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAnarraynamewithanindexyieldsapointertothestartofthearray";
            this.Text = "frmAnarraynamewithanindexyieldsapointertothestartofthearray";
            this.Load += new System.EventHandler(this.frmAnarraynamewithanindexyieldsapointertothestartofthearray_Load);
            this.ResumeLayout(false);

        }

        private void frmAnarraynamewithanindexyieldsapointertothestartofthearray_Load(object sender, EventArgs e)
        {

        }
    }
}
