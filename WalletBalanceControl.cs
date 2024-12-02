using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpenseTrackerApp
{
    public partial class WalletBalanceControl : UserControl
    {
        [Category("Appearance")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public int CurrentWallet { get; set; } = 0;

        public WalletBalanceControl()
        {
            InitializeComponent();
        }
    }
}
