using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0220__Data_Structure.C0500__ArrayList_Serialization
{
    //http://www.java2s.com/Tutorial/CSharp/0220__Data-Structure/DeserializeanArrayListobjectfromabinaryfile.htm
    public partial  class frmDeserializeanArrayListobjectfromabinaryfile:Form
    {
        public frmDeserializeanArrayListobjectfromabinaryfile()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDeserializeanArrayListobjectfromabinaryfile
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDeserializeanArrayListobjectfromabinaryfile";
            this.Text = "frmDeserializeanArrayListobjectfromabinaryfile";
            this.Load += new System.EventHandler(this.frmDeserializeanArrayListobjectfromabinaryfile_Load);
            this.ResumeLayout(false);

        }

        private void frmDeserializeanArrayListobjectfromabinaryfile_Load(object sender, EventArgs e)
        {

        }
    }
}
