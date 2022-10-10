using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0140__Class.C0760__Properties
{
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/PropertyAnditsassociatedField.htm
    public partial  class frmPropertyAnditsassociatedField:Form
    {
        public frmPropertyAnditsassociatedField()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmPropertyAnditsassociatedField
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmPropertyAnditsassociatedField";
            this.Text = "frmPropertyAnditsassociatedField";
            this.Load += new System.EventHandler(this.frmPropertyAnditsassociatedField_Load);
            this.ResumeLayout(false);

        }

        private void frmPropertyAnditsassociatedField_Load(object sender, EventArgs e)
        {

        }
    }
}
