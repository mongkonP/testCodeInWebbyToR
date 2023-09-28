using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0120__struct.C0020__struct
{
    //http://www.java2s.com/Tutorial/CSharp/0120__struct/Referencevaluetypeinastruct.htm
    public partial  class frmReferencevaluetypeinastruct:Form
    {
        public frmReferencevaluetypeinastruct()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmReferencevaluetypeinastruct
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmReferencevaluetypeinastruct";
            this.Text = "frmReferencevaluetypeinastruct";
            this.Load += new System.EventHandler(this.frmReferencevaluetypeinastruct_Load);
            this.ResumeLayout(false);

        }

        private void frmReferencevaluetypeinastruct_Load(object sender, EventArgs e)
        {

        }
    }
}
