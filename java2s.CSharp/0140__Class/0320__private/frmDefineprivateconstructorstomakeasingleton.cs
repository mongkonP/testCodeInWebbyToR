using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0140__Class.C0320__private
{
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/Defineprivateconstructorstomakeasingleton.htm
    public partial  class frmDefineprivateconstructorstomakeasingleton:Form
    {
        public frmDefineprivateconstructorstomakeasingleton()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDefineprivateconstructorstomakeasingleton
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDefineprivateconstructorstomakeasingleton";
            this.Text = "frmDefineprivateconstructorstomakeasingleton";
            this.Load += new System.EventHandler(this.frmDefineprivateconstructorstomakeasingleton_Load);
            this.ResumeLayout(false);

        }

        private void frmDefineprivateconstructorstomakeasingleton_Load(object sender, EventArgs e)
        {

        }
    }
}
