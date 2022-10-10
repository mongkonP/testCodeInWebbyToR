using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0300__File_Directory_Stream.C0600__Binary_Serialization
{
    //http://www.java2s.com/Tutorial/CSharp/0300__File-Directory-Stream/CustomizedSerialization.htm
    public partial  class frmCustomizedSerialization:Form
    {
        public frmCustomizedSerialization()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCustomizedSerialization
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCustomizedSerialization";
            this.Text = "frmCustomizedSerialization";
            this.Load += new System.EventHandler(this.frmCustomizedSerialization_Load);
            this.ResumeLayout(false);

        }

        private void frmCustomizedSerialization_Load(object sender, EventArgs e)
        {

        }
    }
}
