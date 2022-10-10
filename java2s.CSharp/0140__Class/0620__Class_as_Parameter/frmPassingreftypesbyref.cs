using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0140__Class.C0620__Class_as_Parameter
{
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/Passingreftypesbyref.htm
    public partial  class frmPassingreftypesbyref:Form
    {
        public frmPassingreftypesbyref()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmPassingreftypesbyref
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmPassingreftypesbyref";
            this.Text = "frmPassingreftypesbyref";
            this.Load += new System.EventHandler(this.frmPassingreftypesbyref_Load);
            this.ResumeLayout(false);

        }

        private void frmPassingreftypesbyref_Load(object sender, EventArgs e)
        {

        }
    }
}
