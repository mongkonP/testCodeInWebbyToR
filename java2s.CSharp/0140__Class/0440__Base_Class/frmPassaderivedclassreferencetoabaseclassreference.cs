using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0140__Class.C0440__Base_Class
{
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/Passaderivedclassreferencetoabaseclassreference.htm
    public partial  class frmPassaderivedclassreferencetoabaseclassreference:Form
    {
        public frmPassaderivedclassreferencetoabaseclassreference()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmPassaderivedclassreferencetoabaseclassreference
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmPassaderivedclassreferencetoabaseclassreference";
            this.Text = "frmPassaderivedclassreferencetoabaseclassreference";
            this.Load += new System.EventHandler(this.frmPassaderivedclassreferencetoabaseclassreference_Load);
            this.ResumeLayout(false);

        }

        private void frmPassaderivedclassreferencetoabaseclassreference_Load(object sender, EventArgs e)
        {

        }
    }
}
