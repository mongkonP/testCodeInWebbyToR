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
    //http://www.java2s.com/Tutorial/CSharp/0040__Data-Type/FamilyofIntegers.htm
    public partial  class frmFamilyofIntegers:Form
    {
        public frmFamilyofIntegers()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmFamilyofIntegers
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmFamilyofIntegers";
            this.Text = "frmFamilyofIntegers";
            this.Load += new System.EventHandler(this.frmFamilyofIntegers_Load);
            this.ResumeLayout(false);

        }

        private void frmFamilyofIntegers_Load(object sender, EventArgs e)
        {

        }
    }
}
