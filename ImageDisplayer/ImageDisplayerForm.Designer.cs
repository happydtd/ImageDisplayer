namespace ImageDisplayer
{
    partial class ImageDisplayerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImageDisplayerForm));
            this.btOpen = new System.Windows.Forms.Button();
            this.tbImage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pbOriginalImage = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.pbSelectArea = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btRotateRight = new System.Windows.Forms.Button();
            this.btRotateLeft = new System.Windows.Forms.Button();
            this.tBSize = new System.Windows.Forms.TrackBar();
            this.btClose = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.pbOriginalImage)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSelectArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btOpen
            // 
            this.btOpen.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOpen.ForeColor = System.Drawing.Color.DimGray;
            this.btOpen.Location = new System.Drawing.Point(683, 21);
            this.btOpen.Name = "btOpen";
            this.btOpen.Size = new System.Drawing.Size(145, 35);
            this.btOpen.TabIndex = 4;
            this.btOpen.Text = "Open";
            this.btOpen.UseVisualStyleBackColor = true;
            this.btOpen.Click += new System.EventHandler(this.btOpen_Click);
            // 
            // tbImage
            // 
            this.tbImage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbImage.Location = new System.Drawing.Point(131, 27);
            this.tbImage.Name = "tbImage";
            this.tbImage.ReadOnly = true;
            this.tbImage.Size = new System.Drawing.Size(518, 26);
            this.tbImage.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(10, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Image name :";
            // 
            // pbOriginalImage
            // 
            this.pbOriginalImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(51)))));
            this.pbOriginalImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbOriginalImage.Location = new System.Drawing.Point(0, 0);
            this.pbOriginalImage.Name = "pbOriginalImage";
            this.pbOriginalImage.Size = new System.Drawing.Size(941, 684);
            this.pbOriginalImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbOriginalImage.TabIndex = 0;
            this.pbOriginalImage.TabStop = false;
            this.pbOriginalImage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbOriginalImage_MouseDown);
            this.pbOriginalImage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbOriginalImage_MouseMove);
            this.pbOriginalImage.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbOriginalImage_MouseUp);
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.splitContainer3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(327, 764);
            this.panel2.TabIndex = 1;
            // 
            // splitContainer3
            // 
            this.splitContainer3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.AutoScroll = true;
            this.splitContainer3.Panel1.Controls.Add(this.splitContainer4);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(51)))));
            this.splitContainer3.Panel2.Controls.Add(this.btClose);
            this.splitContainer3.Size = new System.Drawing.Size(327, 764);
            this.splitContainer3.SplitterDistance = 687;
            this.splitContainer3.TabIndex = 0;
            // 
            // splitContainer4
            // 
            this.splitContainer4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.AutoScroll = true;
            this.splitContainer4.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(51)))));
            this.splitContainer4.Panel1.Controls.Add(this.pbSelectArea);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(51)))));
            this.splitContainer4.Panel2.Controls.Add(this.label3);
            this.splitContainer4.Panel2.Controls.Add(this.label2);
            this.splitContainer4.Panel2.Controls.Add(this.btRotateRight);
            this.splitContainer4.Panel2.Controls.Add(this.btRotateLeft);
            this.splitContainer4.Panel2.Controls.Add(this.tBSize);
            this.splitContainer4.Size = new System.Drawing.Size(327, 687);
            this.splitContainer4.SplitterDistance = 516;
            this.splitContainer4.TabIndex = 0;
            // 
            // pbSelectArea
            // 
            this.pbSelectArea.Location = new System.Drawing.Point(1, 8);
            this.pbSelectArea.Name = "pbSelectArea";
            this.pbSelectArea.Size = new System.Drawing.Size(300, 300);
            this.pbSelectArea.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbSelectArea.TabIndex = 0;
            this.pbSelectArea.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(41, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Rotate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(41, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Resize";
            // 
            // btRotateRight
            // 
            this.btRotateRight.Image = ((System.Drawing.Image)(resources.GetObject("btRotateRight.Image")));
            this.btRotateRight.Location = new System.Drawing.Point(161, 88);
            this.btRotateRight.Name = "btRotateRight";
            this.btRotateRight.Size = new System.Drawing.Size(26, 26);
            this.btRotateRight.TabIndex = 3;
            this.btRotateRight.UseVisualStyleBackColor = true;
            this.btRotateRight.Click += new System.EventHandler(this.btRotateRight_Click);
            // 
            // btRotateLeft
            // 
            this.btRotateLeft.Image = ((System.Drawing.Image)(resources.GetObject("btRotateLeft.Image")));
            this.btRotateLeft.Location = new System.Drawing.Point(129, 88);
            this.btRotateLeft.Name = "btRotateLeft";
            this.btRotateLeft.Size = new System.Drawing.Size(26, 26);
            this.btRotateLeft.TabIndex = 2;
            this.btRotateLeft.UseVisualStyleBackColor = true;
            this.btRotateLeft.Click += new System.EventHandler(this.btRotateLeft_Click);
            // 
            // tBSize
            // 
            this.tBSize.LargeChange = 1;
            this.tBSize.Location = new System.Drawing.Point(117, 40);
            this.tBSize.Maximum = 5;
            this.tBSize.Name = "tBSize";
            this.tBSize.Size = new System.Drawing.Size(184, 42);
            this.tBSize.TabIndex = 1;
            this.tBSize.Scroll += new System.EventHandler(this.tBSize_Scroll);
            // 
            // btClose
            // 
            this.btClose.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClose.ForeColor = System.Drawing.Color.DimGray;
            this.btClose.Location = new System.Drawing.Point(92, 20);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(145, 35);
            this.btClose.TabIndex = 1;
            this.btClose.Text = "Close";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(51)))));
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Size = new System.Drawing.Size(1280, 768);
            this.splitContainer1.SplitterDistance = 945;
            this.splitContainer1.TabIndex = 2;
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.AutoScroll = true;
            this.splitContainer2.Panel1.Controls.Add(this.pbOriginalImage);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(51)))));
            this.splitContainer2.Panel2.Controls.Add(this.btOpen);
            this.splitContainer2.Panel2.Controls.Add(this.label1);
            this.splitContainer2.Panel2.Controls.Add(this.tbImage);
            this.splitContainer2.Size = new System.Drawing.Size(945, 768);
            this.splitContainer2.SplitterDistance = 688;
            this.splitContainer2.TabIndex = 5;
            // 
            // ImageDisplayerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 768);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ImageDisplayerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Image Displayer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pbOriginalImage)).EndInit();
            this.panel2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel1.PerformLayout();
            this.splitContainer4.Panel2.ResumeLayout(false);
            this.splitContainer4.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbSelectArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBSize)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbImage;
        private System.Windows.Forms.Button btOpen;
        private System.Windows.Forms.PictureBox pbOriginalImage;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pbSelectArea;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.Button btRotateRight;
        private System.Windows.Forms.Button btRotateLeft;
        private System.Windows.Forms.TrackBar tBSize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

