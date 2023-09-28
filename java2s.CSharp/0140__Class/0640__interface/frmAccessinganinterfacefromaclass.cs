using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0140__Class.C0640__interface
{
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/Accessinganinterfacefromaclass.htm
    public partial  class frmAccessinganinterfacefromaclass:Form
    {
        public frmAccessinganinterfacefromaclass()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAccessinganinterfacefromaclass
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAccessinganinterfacefromaclass";
            this.Text = "frmAccessinganinterfacefromaclass";
            this.Load += new System.EventHandler(this.frmAccessinganinterfacefromaclass_Load);
            this.ResumeLayout(false);

        }

        private void frmAccessinganinterfacefromaclass_Load(object sender, EventArgs e)
        {

        }
    }
}
