using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunicationsToolkit
{
    public class WinformToolkit
    {
        public static void InvokeOnThread(Control control, Action method)
        {
            if (control.IsHandleCreated)
            {
                control.Invoke(method);
            }
            else
            {
                method();
            }
        }
        /// <summary>
        /// 将一个控件转化为图片并保存
        /// </summary>
        /// <param name="control">保存的控件</param>
        /// <param name="path">保存路径</param>
        /// <param name="name">文件名</param>
        public static void DrawToBitmap(Control control, string path, string name)
        {
            Bitmap bitmap = new Bitmap(control.Width, control.Height);
            control.DrawToBitmap(bitmap, new Rectangle(0, 0, control.Width, control.Height));
            if (!Directory.Exists(path)) Directory.CreateDirectory(path);
            bitmap.Save(path + "\\" + name + ".bmp");
        }
        /// <summary>
        /// 得到一个矩形阵列的坐标
        /// </summary>
        /// <param name="x">阵列起始X坐标</param>
        /// <param name="y">阵列起始Y坐标</param>
        /// <param name="count">阵列元素个数</param>
        /// <param name="length">每行的元素个数</param>
        /// <param name="xInterval">阵列坐标x方向间距</param>
        /// <param name="yInterval">阵列坐标y方向间距</param>
        /// <returns>阵列坐标列表</returns>
        public static List<Point> SetLocation(int x, int y, int count, int length, int xInterval, int yInterval)
        {
            int o = x;
            List<Point> locationList = new List<Point>();
            for (int i = 0; i < count; i++)
            {
                locationList.Add(new Point(x, y));
                x = x + xInterval;
                if ((i + 1) % length == 0)
                {
                    x = o;
                    y = y + yInterval;
                }
            }
            return locationList;
        }
        /// <summary>
        /// 设置一个Label组成的矩形阵列
        /// </summary>
        /// <param name="labelsLocation">阵列坐标列表</param>
        /// <param name="labelSize">Label大小（方形）</param>
        /// <param name="code">每个阵列的标记</param>
        /// <param name="offset">标记相对于起始坐标的偏移</param>
        /// <returns>包含标记的Label阵列列表</returns>
        public static List<Label> SetLabel(List<Point> labelsLocation, int labelSize, string code, Point offset)
        {
            List<Label> labelList = new List<Label>();
            Label title = new Label();
            title.Name = code;
            title.Width = 150;
            title.ForeColor = Color.OrangeRed;
            title.Text = code;
            title.Location = new Point(labelsLocation[0].X, labelsLocation[0].Y - offset.Y);
            labelList.Add(title);
            for (int i = 0; i < labelsLocation.Count; i++)
            {
                Label slot = new Label();
                slot.Name = code + i.ToString();
                slot.Width = labelSize;
                slot.Height = labelSize;
                slot.ForeColor = Color.Blue;
                slot.BackColor = Color.LightSkyBlue;
                slot.Text = (i + 1).ToString();
                slot.Location = labelsLocation[i];
                labelList.Add(slot);
            }
            return labelList;
        }
        /// <summary>
        /// 在控件上绘制Label列表
        /// </summary>
        /// <param name="canvasControl">需要绘制的控件</param>
        /// <param name="labels">Label列表</param>
        public static void DrawLabel(Control canvasControl, List<Label> labels)
        {
            for (int i = 0; i < labels.Count; i++)
            {
                canvasControl.Controls.Add(labels[i]);
            }
        }
        /// <summary>
        /// 展示两排标签的值
        /// </summary>
        /// <param name="control">展示标签的控件</param>
        /// <param name="labelCount">控件数量</param>
        /// <param name="labels1">初始化的控件1列表</param>
        /// <param name="labels2">初始化的控件2列表</param>
        public static void InitializeDisplayLabel(Control control, int labelCount, List<Label> labels1, List<Label> labels2, int xInterval)
        {
            control.Controls.Clear();
            labels1.Clear();
            labels2.Clear();
            List<Point> points = SetLocation(10, 10, labelCount, 12, xInterval, 50);
            for (int i = 0; i < labelCount; i++)
            {
                labels1.Add(new Label() { Width = xInterval, Location = points[i] });
            }
            for (int i = 0; i < labelCount; i++)
            {
                labels2.Add(new Label() { Width = xInterval, Location = new Point(points[i].X, points[i].Y + 25) });
            }
            DrawLabel(control, labels1);
            DrawLabel(control, labels2);
        }
    }
}
