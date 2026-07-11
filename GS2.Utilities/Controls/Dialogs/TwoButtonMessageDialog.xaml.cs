using System.Runtime.InteropServices;

namespace GS2.Utilities.Controls.Dialogs
{
    [ComVisible(false)]
    public partial class TwoButtonMessageDialog
    {
        private TwoButtonMessageDialog()
        {
            InitializeComponent();
        }
        public TwoButtonMessageDialog(TwoButtonMessageDialogVM viewModel) : this()
        {
            this.DataContext = viewModel;
        }

    }
}
