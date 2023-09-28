using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0020__Language_Basics.C0340__Try_Catch
{
    //http://www.java2s.com/Tutorial/CSharp/0020__Language-Basics/Catchexceptionwithwrongtypeinsideafunction.htm
    public partial  class frmCatchexceptionwithwrongtypeinsideafunction:Form
    {
        public frmCatchexceptionwithwrongtypeinsideafunction()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCatchexceptionwithwrongtypeinsideafunction
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCatchexceptionwithwrongtypeinsideafunction";
            this.Text = "frmCatchexceptionwithwrongtypeinsideafunction";
            this.Load += new System.EventHandler(this.frmCatchexceptionwithwrongtypeinsideafunction_Load);
            this.ResumeLayout(false);

        }

        private void frmCatchexceptionwithwrongtypeinsideafunction_Load(object sender, EventArgs e)
        {

        }
    }
}
