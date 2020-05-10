using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageDisplayer
{
    public partial class ImageDisplayerForm : Form
    {
        private int x0, y0, cropWidth, cropHeight;
        private Image _img;
        
        private Pen _Pen;
        public ImageDisplayerForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// when mouse down
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbOriginalImage_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                //get start position
                if (e.Button == MouseButtons.Left)
                {
                    x0 = e.X;
                    y0 = e.Y;
                    Cursor = Cursors.Cross;

                    //prepare pen 
                    _Pen = new Pen(Color.Black, 1);
                    _Pen.DashStyle = DashStyle.DashDotDot;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occur in MouseDown event." + ex.Message);
            }

        }

        /// <summary>
        /// when mouse move
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbOriginalImage_MouseMove(object sender, MouseEventArgs e)
        {
            //draw select rectangle
            try
            {
                if (e.Button == MouseButtons.Left)
                {
                    pbOriginalImage.Refresh();
                    cropWidth = e.X - x0;
                    cropHeight = e.Y - y0;
                    pbOriginalImage.CreateGraphics().DrawRectangle(_Pen, x0, y0, cropWidth, cropHeight);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error occur in MouseMove event." + ex.Message);
            }

        }
        /// <summary>
        /// when mouse up
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbOriginalImage_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Left)
                {
                    //set cursor back to default
                    Cursor = Cursors.Default;
                    //get mouse current position , calculate rantangle wide and height
                    int wide = e.X - x0;
                    int hight = e.Y - y0;
                    if ((wide < 1) || (hight < 1)) return;

                    //
                    Rectangle rect = new Rectangle(x0, y0, wide, hight);
                    //Original image
                    Bitmap bm_source = new Bitmap(pbOriginalImage.Image, pbOriginalImage.Width, pbOriginalImage.Height);

                    Bitmap bm_temp = new Bitmap(wide, hight);
                    //create graphics and crop image
                    using (Graphics gr = Graphics.FromImage(bm_temp))
                    {
                        gr.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                        gr.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
                        gr.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
                        //set image attributes
                        gr.DrawImage(bm_source, 0, 0, rect, GraphicsUnit.Pixel);
                    }

                    //update picture box "select area"
                    _img = bm_temp;
                    pbSelectArea.Image = bm_temp;
                    pbSelectArea.Width = bm_temp.Width;
                    pbSelectArea.Height = bm_temp.Height;
                    tBSize.Value = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occur in MouseUp event." + ex.Message);
            }
        }

        /// <summary>
        /// close form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Change image size
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tBSize_Scroll(object sender, EventArgs e)
        {
            if (pbSelectArea.Image == null)
                return;

            var percentage = tBSize.Value;
            Size ModifiedImageSize;

            try
            {
                ModifiedImageSize = new Size((int)(_img.Width * (1 + (double)percentage / 10)), (int)(_img.Height * (1 + (double)percentage / 10)));
                Bitmap bm_source = new Bitmap(_img);
                // Make a bitmap for the result
                Bitmap bm_temp = new Bitmap(ModifiedImageSize.Width, ModifiedImageSize.Height);
                // Make a Graphics object for the result Bitmap.
                using (Graphics gr = Graphics.FromImage(bm_temp))
                {
                    // Copy the source image into the destination bitmap.
                    gr.DrawImage(bm_source, 0, 0, bm_temp.Width, bm_temp.Height);
                }
                // Display the result.
                pbSelectArea.Image = bm_temp;
                pbSelectArea.Width = bm_temp.Width;
                pbSelectArea.Height = bm_temp.Height;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error occur in Scroll event." + ex.Message);
            }
        }

        /// <summary>
        /// Rotate image 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btRotateLeft_Click(object sender, EventArgs e)
        {
            if (pbSelectArea.Image == null)
                return;

            RotateImageByButton(RotateDirection.Left);

        }

        /// <summary>
        /// Rotate image 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btRotateRight_Click(object sender, EventArgs e)
        {
            if (pbSelectArea.Image == null)
                return;

            RotateImageByButton(RotateDirection.Right);
        }

        /// <summary>
        /// Select image file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btOpen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog oDialog = new OpenFileDialog() {
                    Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF",
                    Multiselect = false
            })
            {
                if (oDialog.ShowDialog() == DialogResult.OK)
                {
                    pbOriginalImage.SizeMode = PictureBoxSizeMode.StretchImage;
                    pbOriginalImage.Image = Image.FromFile(oDialog.FileName);
                    tbImage.Text = oDialog.FileName;
                    pbSelectArea.Image = null;
                    tBSize.Value = 0;
                }
            }
        }

        private void RotateImageByButton(RotateDirection rd)
        {
            Image bm_dest;

            try
            {
                if (rd == RotateDirection.Left)
                    bm_dest = RotateImage(_img, -90);
                else
                    bm_dest = RotateImage(_img, 90);
                pbSelectArea.Image = bm_dest;
                pbSelectArea.Width = bm_dest.Width;
                pbSelectArea.Height = bm_dest.Height;
                pbSelectArea.Refresh();
                _img = bm_dest;
                tBSize.Value = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occur in RotateImageByButton." + ex.Message);
            }
        }

        public static Image RotateImage(Image img, float rotationAngle)
        {
            Bitmap RotatedImage = null;


            // Find the size of the image's rotated bounding box.
            Matrix rotation = new Matrix();
            rotation.Rotate(rotationAngle);
            int old_wid = img.Width;
            int old_hgt = img.Height;
            PointF[] points =
            {
                new PointF(0, 0),
                new PointF(old_wid, 0),
                new PointF(0, old_hgt),
                new PointF(old_wid, old_hgt),
            };
            rotation.TransformPoints(points);
            float[] xs =
                { points[0].X, points[1].X, points[2].X, points[3].X };
            float[] ys =
                { points[0].Y, points[1].Y, points[2].Y, points[3].Y };
            int new_wid = (int)(xs.Max() - xs.Min());
            int new_hgt = (int)(ys.Max() - ys.Min());

            // Make the rotated image.
            RotatedImage = new Bitmap(new_wid, new_hgt);
            using (Graphics gr = Graphics.FromImage(RotatedImage))
            {
                gr.TranslateTransform(-old_wid / 2, -old_hgt / 2,
                    MatrixOrder.Append);
                gr.RotateTransform(rotationAngle, MatrixOrder.Append);
                gr.TranslateTransform(new_wid / 2, new_hgt / 2,
                    MatrixOrder.Append);
                RectangleF source_rect = new RectangleF(0, 0,
                    img.Width, img.Height);
                PointF[] dest_points =
                {
                    new PointF(0, 0),
                    new PointF(img.Width, 0),
                    new PointF(0, img.Height),
                };
                gr.DrawImage(img, dest_points, source_rect,
                    GraphicsUnit.Pixel);
            }
            return RotatedImage;
        }
    }

    public enum RotateDirection
    {
        Left,
        Right
    }
}
