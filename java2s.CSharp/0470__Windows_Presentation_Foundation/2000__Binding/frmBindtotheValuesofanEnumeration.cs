using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C2000__Binding
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/BindtotheValuesofanEnumeration.htm
    public partial  class frmBindtotheValuesofanEnumeration:Form
    {
        public frmBindtotheValuesofanEnumeration()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmBindtotheValuesofanEnumeration
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmBindtotheValuesofanEnumeration";
            this.Text = "frmBindtotheValuesofanEnumeration";
            this.Load += new System.EventHandler(this.frmBindtotheValuesofanEnumeration_Load);
            this.ResumeLayout(false);

        }

        private void frmBindtotheValuesofanEnumeration_Load(object sender, EventArgs e)
        {

        }
    }
}
