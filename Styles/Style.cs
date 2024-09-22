using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;


namespace Styles
{
    public class Style
    {
        #region VARIABLES

        #endregion // end VARIABLES

        #region CONSTRUCTOR
        public Style() { }
        #endregion // end CONSTRUCTOR

        #region METHODS
        /// <summary>
        /// Establece un borde redondeado para el botón especificado.
        /// </summary>
        /// <param name="button"> El botón al que se le establecerá el borde redondeado.</param>
        /// <param name="borderRadius"> El radio de la esquina del borde.</param>
        public void SetButtonBorderRadius(Button button, int borderRadius)
        {
            if (button != null)
            {
                // Se crea un objeto GraphicsPath para construir el borde redondeado
                GraphicsPath path = new GraphicsPath();
                // Se inicia la figura del borde redondeado
                path.StartFigure();
                // Se agrega el arco superior izquierdo del borde redondeado
                path.AddArc(0, 0, borderRadius * 2, borderRadius * 2, 180, 90);
                // Se agrega la línea superior del borde redondeado
                path.AddLine(borderRadius, 0, button.Width - borderRadius, 0);
                // Se agrega el arco superior derecho del borde redondeado
                path.AddArc(button.Width - borderRadius * 2, 0, borderRadius * 2, borderRadius * 2, 270, 90);
                // Se agrega la línea derecha del borde redondeado
                path.AddLine(button.Width, borderRadius, button.Width, button.Height - borderRadius);
                // Se agrega el arco inferior derecho del borde redondeado
                path.AddArc(button.Width - borderRadius * 2, button.Height - borderRadius * 2, borderRadius * 2, borderRadius * 2, 0, 90);
                // Se agrega la línea inferior del borde redondeado
                path.AddLine(button.Width - borderRadius, button.Height, borderRadius, button.Height);
                // Se agrega el arco inferior izquierdo del borde redondeado
                path.AddArc(0, button.Height - borderRadius * 2, borderRadius * 2, borderRadius * 2, 90, 90);
                // Se cierra la figura del borde redondeado
                path.CloseFigure();
                // Se establece el borde redondeado al botón especificado
                button.Region = new Region(path);
            }
        }

        #endregion // end METHODS

        #region SETTERS AND SETTERS

        #endregion // end SETTERS AND SETTERS
    }
}
