using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C2600__AccessText
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/SettingAccessTextproperties.htm
    public partial  class frmSettingAccessTextproperties:Form
    {
        public frmSettingAccessTextproperties()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSettingAccessTextproperties
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSettingAccessTextproperties";
            this.Text = "frmSettingAccessTextproperties";
            this.Load += new System.EventHandler(this.frmSettingAccessTextproperties_Load);
            this.ResumeLayout(false);

        }

        private void frmSettingAccessTextproperties_Load(object sender, EventArgs e)
        {

        }
    }
}
