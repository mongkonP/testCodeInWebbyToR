using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0040__Data_Type.C0060__Integer_Family
{
    //http://www.java2s.com/Tutorial/CSharp/0040__Data-Type/IntegerTypes.htm
    public partial  class frmIntegerTypes:Form
    {
        public frmIntegerTypes()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmIntegerTypes
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmIntegerTypes";
            this.Text = "frmIntegerTypes";
            this.Load += new System.EventHandler(this.frmIntegerTypes_Load);
            this.ResumeLayout(false);

        }

        private void frmIntegerTypes_Load(object sender, EventArgs e)
        {

        }
    }
}
