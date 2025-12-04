using System.Windows.Forms;
using System.Threading;

namespace Calculator
{
    public partial class Form1
    {
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.F5)
            {
                InitializeCustomComponents();
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}