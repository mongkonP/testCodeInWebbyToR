using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0040__Data_Type.C0760__enums_Definition
{
    //http://www.java2s.com/Tutorial/CSharp/0040__Data-Type/RetrievinganEnumerationNamewithGetName.htm
    public partial  class frmRetrievinganEnumerationNamewithGetName:Form
    {
        public frmRetrievinganEnumerationNamewithGetName()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmRetrievinganEnumerationNamewithGetName
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmRetrievinganEnumerationNamewithGetName";
            this.Text = "frmRetrievinganEnumerationNamewithGetName";
            this.Load += new System.EventHandler(this.frmRetrievinganEnumerationNamewithGetName_Load);
            this.ResumeLayout(false);

        }

        private void frmRetrievinganEnumerationNamewithGetName_Load(object sender, EventArgs e)
        {

        }
    }
}
