using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace AppDesktop_1_2
{
    public partial class Form5 : Form
    {
        // Lớp lưu trữ thông tin một nét vẽ
        public class Stroke
        {
            public List<Point> Points { get; set; } = new List<Point>();
            public Color StrokeColor { get; set; }
            public float PenWidth { get; set; } = 3f; // Độ dày nét vẽ
        }

        // Khai báo các biến quản lý trạng thái vẽ
        private List<Stroke> strokes = new List<Stroke>();
        private Stroke currentStroke = null;
        private bool isDrawing = false;
        private Color currentColor = Color.Black; // Màu mặc định

        public Form5()
        {
            InitializeComponent();

            // Bật KeyPreview để Form nhận sự kiện phím (dùng cho Ctrl+Z)
            this.KeyPreview = true;

            // Bật DoubleBuffered cho Panel để vẽ mượt hơn, không bị giật/nhấp nháy
            typeof(Panel).InvokeMember("DoubleBuffered",
                System.Reflection.BindingFlags.SetProperty |
                System.Reflection.BindingFlags.Instance |
                System.Reflection.BindingFlags.NonPublic,
                null, panelDraw, new object[] { true });
        }

        #region Sự kiện Vẽ trên Panel

        private void panelDraw_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDrawing = true;
                currentStroke = new Stroke
                {
                    StrokeColor = currentColor
                };
                currentStroke.Points.Add(e.Location);
                strokes.Add(currentStroke);
            }
        }

        private void panelDraw_MouseMove(object sender, MouseEventArgs e)
        {
            // 1. Cập nhật nhãn hiện tọa độ chuột
            lblToaDo.Text = $"x = {e.X}, y = {e.Y}";

            // 2. Thêm điểm vào nét vẽ nếu đang giữ chuột trái
            if (isDrawing && currentStroke != null)
            {
                currentStroke.Points.Add(e.Location);
                panelDraw.Invalidate(); // Yêu cầu vẽ lại panel
            }
        }

        private void panelDraw_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDrawing = false;
                currentStroke = null;
            }
        }

        private void panelDraw_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Vẽ lại toàn bộ các nét vẽ có trong danh sách
            foreach (var stroke in strokes)
            {
                if (stroke.Points.Count > 1)
                {
                    using (Pen pen = new Pen(stroke.StrokeColor, stroke.PenWidth))
                    {
                        pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
                        pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
                        pen.LineJoin = System.Drawing.Drawing2D.LineJoin.Round;

                        e.Graphics.DrawLines(pen, stroke.Points.ToArray());
                    }
                }
            }
        }

        #endregion

        #region Nút chọn màu và nút xóa

        // Chọn màu bằng ColorDialog
        private void btnSelectColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                currentColor = colorDialog1.Color;
            }
        }

        // Xóa toàn bộ nét vẽ
        private void btnClear_Click(object sender, EventArgs e)
        {
            strokes.Clear();
            panelDraw.Invalidate();
        }

        #endregion

        #region Phím tắt Ctrl + Z (Xóa nét vẽ cuối)

        private void Form5_KeyDown(object sender, KeyEventArgs e)
        {
            // Kiểm tra phím Ctrl + Z
            if (e.Control && e.KeyCode == Keys.Z)
            {
                if (strokes.Count > 0)
                {
                    strokes.RemoveAt(strokes.Count - 1); // Xóa nét vẽ cuối cùng
                    panelDraw.Invalidate();              // Vẽ lại màn hình
                }
            }
        }

        #endregion
    }
}