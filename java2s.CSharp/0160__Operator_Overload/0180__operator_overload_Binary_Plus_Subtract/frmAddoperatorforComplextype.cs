using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0160__Operator_Overload.C0180__operator_overload_Binary_Plus_Subtract
{
    //http://www.java2s.com/Tutorial/CSharp/0160__Operator-Overload/AddoperatorforComplextype.htm
    public partial  class frmAddoperatorforComplextype:Form
    {
        public frmAddoperatorforComplextype()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAddoperatorforComplextype
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAddoperatorforComplextype";
            this.Text = "frmAddoperatorforComplextype";
            this.Load += new System.EventHandler(this.frmAddoperatorforComplextype_Load);
            this.ResumeLayout(false);

        }

        private void frmAddoperatorforComplextype_Load(object sender, EventArgs e)
        {

        }
    }
}
