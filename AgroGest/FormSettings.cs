using Model;
using Styles;
using System.Windows.Forms;

namespace AgroGest
{
    public partial class FormSettings : Form
    {
        #region VARIABLES
        Style style = new Style();
        #endregion // end VARIABLES

        public FormSettings()
        {
            InitializeComponent();
            this.TopLevel = false;
            initButtonBoderRadius();
        }

        private void initButtonBoderRadius()
        {
            style.SetButtonBorderRadius(buttonApply, 10);
            style.SetButtonBorderRadius(buttonSave, 10);
            style.SetButtonBorderRadius(buttonReset, 10);
            style.SetButtonBorderRadius(buttonClose, 10);
        }

        #region INIT COMPONENTS

        #endregion // end INIT COMPONENTS

        #region MAINFRAME COMPONENTS

        #endregion // end MAINFRAME COMPONENTS

        #region METHODS

        #endregion // end METHODS
    }
}
