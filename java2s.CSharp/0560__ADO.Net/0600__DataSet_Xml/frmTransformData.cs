using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0560__ADO.Net.C0600__DataSet_Xml
{
    //http://www.java2s.com/Tutorial/CSharp/0560__ADO.Net/TransformData.htm
    public partial  class frmTransformData:Form
    {
        public frmTransformData()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmTransformData
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmTransformData";
            this.Text = "frmTransformData";
            this.Load += new System.EventHandler(this.frmTransformData_Load);
            this.ResumeLayout(false);

        }

        private void frmTransformData_Load(object sender, EventArgs e)
        {

        }
    }
}
