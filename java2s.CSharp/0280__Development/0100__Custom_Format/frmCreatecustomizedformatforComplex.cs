using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0280__Development.C0100__Custom_Format
{
    //http://www.java2s.com/Tutorial/CSharp/0280__Development/CreatecustomizedformatforComplex.htm
    public partial  class frmCreatecustomizedformatforComplex:Form
    {
        public frmCreatecustomizedformatforComplex()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCreatecustomizedformatforComplex
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCreatecustomizedformatforComplex";
            this.Text = "frmCreatecustomizedformatforComplex";
            this.Load += new System.EventHandler(this.frmCreatecustomizedformatforComplex_Load);
            this.ResumeLayout(false);

        }

        private void frmCreatecustomizedformatforComplex_Load(object sender, EventArgs e)
        {

        }
    }
}
