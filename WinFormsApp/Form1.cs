using VectorDraw.Professional.vdObjects;
using vdControls;
using VectorDraw.Geometry;
using VectorDraw.Professional.vdFigures;

namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        private vdFramedControl vdFramedControl;
        private bool isDrawing;
        private gPoint startPoint;

        public Form1()
        {
            InitializeComponent();
            InitializeVectorDraw();

        }

        private void InitializeVectorDraw()
        {
            vdFramedControl = new vdFramedControl();
            vdFramedControl.Dock = DockStyle.Fill;
            this.Controls.Add(vdFramedControl);

            vdDocument doc = vdFramedControl.BaseControl.ActiveDocument;

            // Event Handlers for mouse actions
            vdFramedControl.BaseControl.vdMouseDown += BaseControl_vdMouseDown;
            vdFramedControl.BaseControl.vdMouseMove += BaseControl_vdMouseMove;
            vdFramedControl.BaseControl.vdMouseUp += BaseControl_vdMouseUp;
        }


        private void BaseControl_vdMouseDown(MouseEventArgs e, ref bool cancel)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDrawing = true;
                startPoint = new gPoint(e.X, e.Y);
            }
        }

        private void BaseControl_vdMouseMove(MouseEventArgs e, ref bool cancel)
        {
            if (isDrawing)
            {
                gPoint endPoint = new gPoint(e.X, e.Y);
                DrawLine(startPoint, endPoint);
                startPoint = endPoint;
            }
        }

        private void BaseControl_vdMouseUp(MouseEventArgs e, ref bool cancel)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDrawing = false;
            }
        }

        private void DrawLine(gPoint start, gPoint end)
        {
            vdDocument doc = vdFramedControl.BaseControl.ActiveDocument;

            // Create a new line
            vdLine line = new vdLine();
            line.SetUnRegisterDocument(doc);
            line.setDocumentDefaults();
            line.StartPoint = start;
            line.EndPoint = end;

            // Add the line to the document
            doc.Model.Entities.AddItem(line);

            // Update the display
            doc.Redraw(true);
        }

        
    }
}
