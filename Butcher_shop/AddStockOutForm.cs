using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Butcher_shop
{
    public partial class AddStockOutForm : Form
    {
        bool dragging = false;
        Point dragCursorPoint;
        Point dragFormPoint;

        Color primaryOrange = Color.FromArgb(245, 124, 0);
        Color secondaryGreen = Color.FromArgb(46, 125, 50);

        Font uiFont;

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000; // WS_EX_COMPOSITED for flicker-free rendering
                return cp;
            }
        }

        public AddStockOutForm()
        {
            InitializeComponent();

            // Apply Reference Form Properties
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer |
                          ControlStyles.AllPaintingInWmPaint |
                          ControlStyles.UserPaint |
                          ControlStyles.ResizeRedraw, true);

            // Setup Draggable Form Events
            this.MouseDown += Form_MouseDown;
            this.MouseMove += Form_MouseMove;
            this.MouseUp += Form_MouseUp;

            ApplyStylesAndLayout();
        }

        private void ApplyStylesAndLayout()
        {
            FontFamily fontFamily;
            try { fontFamily = new FontFamily("Roboto"); }
            catch { fontFamily = new FontFamily("Segoe UI"); }
            uiFont = new Font(fontFamily, 10F, FontStyle.Regular);

            // Apply the smoother 30px corner radius
            RoundFormCorners(30);

            // 1. Setup Close Button (Slightly right-shifted per new requirements)
            btnClose.Text = "✕";
            btnClose.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            btnClose.ForeColor = Color.Gray;
            btnClose.BackColor = Color.Transparent;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(20, 0, 0, 0);
            btnClose.FlatAppearance.MouseDownBackColor = Color.FromArgb(40, 0, 0, 0);
            btnClose.Size = new Size(40, 40);
            btnClose.Location = new Point(this.Width - 40, 10);
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.Cursor = Cursors.Hand;
            btnClose.Click += (s, e) => this.Close();
            btnClose.MouseEnter += (s, e) => btnClose.ForeColor = Color.Black;
            btnClose.MouseLeave += (s, e) => btnClose.ForeColor = Color.Gray;

            // 2. Setup Title
            lblTitle.Font = new Font(uiFont.FontFamily, 14F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(40, 40, 40);
            lblTitle.Location = new Point(40, 20);

            // 3. Setup Inputs Layout
            Label[] labels = { lblProduct, lblQuantity, lblDate, lblReason };
            Control[] inputs = { txtProductID, txtQuantity, dtpDate, txtReason };
            string[] labelTexts = { "Product ID:", "Quantity Out:", "Date:", "Reason:" };

            int startY = 70;
            int leftMargin = 40;
            int rightMargin = 40;
            int fixedLabelWidth = 110;
            int horizontalGap = 10;
            int rowSpacing = 50;

            for (int i = 0; i < 4; i++)
            {
                // Format Labels
                labels[i].Text = labelTexts[i];
                labels[i].Font = uiFont;
                labels[i].ForeColor = Color.FromArgb(40, 40, 40);
                labels[i].AutoSize = true;
                labels[i].Location = new Point(leftMargin, startY + 3);

                // Format Inputs (TextBoxes & DateTimePicker)
                inputs[i].Font = uiFont;
                int inputX = leftMargin + fixedLabelWidth + horizontalGap;
                inputs[i].Location = new Point(inputX, startY);
                inputs[i].Size = new Size(this.Width - inputX - rightMargin, 28);
                inputs[i].Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

                // Only apply BorderStyle to TextBoxes, not the DateTimePicker
                if (inputs[i] is TextBox)
                {
                    ((TextBox)inputs[i]).BorderStyle = BorderStyle.FixedSingle;
                }

                startY += rowSpacing;
            }

            // 4. Setup Buttons
            btnSave.Size = new Size(110, 40);
            btnSave.BackColor = primaryOrange;
            btnSave.ForeColor = Color.White;
            StyleAsModernButton(btnSave);

            btnCancel.Size = new Size(110, 40);
            btnCancel.BackColor = secondaryGreen;
            btnCancel.ForeColor = Color.White;
            StyleAsModernButton(btnCancel);

            PositionButtons();
        }

        private void PositionButtons()
        {
            if (btnSave != null && btnCancel != null)
            {
                int spacing = 20;
                int totalBtnWidth = btnSave.Width + spacing + btnCancel.Width;
                int startX = (this.Width - totalBtnWidth) / 2;
                int btnY = this.Height - 70;

                btnSave.Location = new Point(startX, btnY);
                btnCancel.Location = new Point(startX + btnSave.Width + spacing, btnY);
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            RoundFormCorners(30);
            PositionButtons();
        }

        private void StyleAsModernButton(Button btn)
        {
            btn.Font = new Font(uiFont.FontFamily, 10F, FontStyle.Bold);
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Cursor = Cursors.Hand;
            btn.ForeColor = Color.Transparent;

            btn.Paint += ModernButton_Paint;
            btn.MouseEnter += (s, e) => btn.Invalidate();
            btn.MouseLeave += (s, e) => btn.Invalidate();
            btn.MouseDown += (s, e) => btn.Invalidate();
            btn.MouseUp += (s, e) => btn.Invalidate();
        }

        private void ModernButton_Paint(object sender, PaintEventArgs e)
        {
            Button btn = sender as Button;
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            e.Graphics.Clear(this.BackColor);

            int radius = 18;
            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddArc(0, 0, radius, radius, 180, 90);
                path.AddArc(btn.Width - radius, 0, radius, radius, 270, 90);
                path.AddArc(btn.Width - radius, btn.Height - radius, radius, radius, 0, 90);
                path.AddArc(0, btn.Height - radius, radius, radius, 90, 90);
                path.CloseFigure();

                Point cursorLocation = btn.PointToClient(Cursor.Position);
                bool isHovered = btn.ClientRectangle.Contains(cursorLocation);
                bool isPressed = isHovered && Control.MouseButtons == MouseButtons.Left;

                Color bgColor = btn.BackColor;
                if (isPressed) bgColor = ControlPaint.Dark(btn.BackColor, 0.1f);
                else if (isHovered) bgColor = ControlPaint.Light(btn.BackColor, 0.2f);

                using (SolidBrush brush = new SolidBrush(bgColor))
                {
                    e.Graphics.FillPath(brush, path);
                }
            }

            TextRenderer.DrawText(e.Graphics, btn.Text, btn.Font, btn.ClientRectangle, Color.White,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }

        protected override void WndProc(ref Message m)
        {
            const int WM_NCHITTEST = 0x84;
            const int HTLEFT = 10, HTRIGHT = 11, HTTOP = 12, HTTOPLEFT = 13;
            const int HTTOPRIGHT = 14, HTBOTTOM = 15, HTBOTTOMLEFT = 16, HTBOTTOMRIGHT = 17;
            const int resizeArea = 10;

            if (m.Msg == WM_NCHITTEST)
            {
                Point cursor = this.PointToClient(Cursor.Position);

                if (cursor.X <= resizeArea && cursor.Y <= resizeArea) { m.Result = (IntPtr)HTTOPLEFT; return; }
                if (cursor.X >= this.Width - resizeArea && cursor.Y <= resizeArea) { m.Result = (IntPtr)HTTOPRIGHT; return; }
                if (cursor.X <= resizeArea && cursor.Y >= this.Height - resizeArea) { m.Result = (IntPtr)HTBOTTOMLEFT; return; }
                if (cursor.X >= this.Width - resizeArea && cursor.Y >= this.Height - resizeArea) { m.Result = (IntPtr)HTBOTTOMRIGHT; return; }
                if (cursor.X <= resizeArea) { m.Result = (IntPtr)HTLEFT; return; }
                if (cursor.X >= this.Width - resizeArea) { m.Result = (IntPtr)HTRIGHT; return; }
                if (cursor.Y <= resizeArea) { m.Result = (IntPtr)HTTOP; return; }
                if (cursor.Y >= this.Height - resizeArea) { m.Result = (IntPtr)HTBOTTOM; return; }
            }
            base.WndProc(ref m);
        }

        private void RoundFormCorners(int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(this.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(this.Width - radius, this.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, this.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();
            this.Region = new Region(path);
        }

        // Dragging Logic
        private void Form_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void Form_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point diff = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(diff));
            }
        }

        private void Form_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        // ORIGINAL BUSINESS LOGIC & EVENT HANDLERS
        private void btnSave_Click(object sender, EventArgs e)
        {
            string productID = txtProductID.Text;
            string quantity = txtQuantity.Text;
            string reason = txtReason.Text;
            string date = dtpDate.Value.ToString("yyyy-MM-dd");

            if (productID == "" || quantity == "")
            {
                MessageBox.Show("Please fill required fields.");
                return;
            }

            string query = "INSERT INTO STOCK_OUT (product_id, quantity_out, date, reason) " +
                           "VALUES ('" + productID + "','" + quantity + "','" + date + "','" + reason + "')";

            Butcher db = new Butcher();
            db.sqlManager(query);

            MessageBox.Show("Stock Out recorded successfully!");

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}