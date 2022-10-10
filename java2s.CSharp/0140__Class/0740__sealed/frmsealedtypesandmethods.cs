using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0140__Class.C0740__sealed
{
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/sealedtypesandmethods.htm
    public partial  class frmsealedtypesandmethods:Form
    {
        public frmsealedtypesandmethods()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmsealedtypesandmethods
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmsealedtypesandmethods";
            this.Text = "frmsealedtypesandmethods";
            this.Load += new System.EventHandler(this.frmsealedtypesandmethods_Load);
            this.ResumeLayout(false);

        }

        private void frmsealedtypesandmethods_Load(object sender, EventArgs e)
        {

        }
    }
}
