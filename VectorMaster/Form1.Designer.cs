namespace VectorMaster
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Tools = new System.Windows.Forms.GroupBox();
            this.BrushTools = new System.Windows.Forms.PictureBox();
            this.BrokenLineTools = new System.Windows.Forms.PictureBox();
            this.EraserTriangle = new System.Windows.Forms.PictureBox();
            this.RightTriangleTools = new System.Windows.Forms.PictureBox();
            this.IsoscelesTriangleTools = new System.Windows.Forms.PictureBox();
            this.RhombusTools = new System.Windows.Forms.PictureBox();
            this.EllipseTools = new System.Windows.Forms.PictureBox();
            this.RectangleTools = new System.Windows.Forms.PictureBox();
            this.LineTools = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonPipette = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.buttonColor = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.buttonMoveVertex = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Tools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BrushTools)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BrokenLineTools)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EraserTriangle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightTriangleTools)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IsoscelesTriangleTools)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RhombusTools)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EllipseTools)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RectangleTools)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LineTools)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(257, 69);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(877, 446);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // Tools
            // 
            this.Tools.BackColor = System.Drawing.Color.Crimson;
            this.Tools.Controls.Add(this.BrushTools);
            this.Tools.Controls.Add(this.BrokenLineTools);
            this.Tools.Controls.Add(this.EraserTriangle);
            this.Tools.Controls.Add(this.RightTriangleTools);
            this.Tools.Controls.Add(this.IsoscelesTriangleTools);
            this.Tools.Controls.Add(this.RhombusTools);
            this.Tools.Controls.Add(this.EllipseTools);
            this.Tools.Controls.Add(this.RectangleTools);
            this.Tools.Controls.Add(this.LineTools);
            this.Tools.Location = new System.Drawing.Point(21, 69);
            this.Tools.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Tools.Name = "Tools";
            this.Tools.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Tools.Size = new System.Drawing.Size(111, 447);
            this.Tools.TabIndex = 2;
            this.Tools.TabStop = false;
            // 
            // BrushTools
            // 
            this.BrushTools.Image = ((System.Drawing.Image)(resources.GetObject("BrushTools.Image")));
            this.BrushTools.Location = new System.Drawing.Point(39, 293);
            this.BrushTools.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BrushTools.Name = "BrushTools";
            this.BrushTools.Size = new System.Drawing.Size(33, 31);
            this.BrushTools.TabIndex = 11;
            this.BrushTools.TabStop = false;
            this.BrushTools.Click += new System.EventHandler(this.BrushTools_Click);
            // 
            // BrokenLineTools
            // 
            this.BrokenLineTools.Image = ((System.Drawing.Image)(resources.GetObject("BrokenLineTools.Image")));
            this.BrokenLineTools.Location = new System.Drawing.Point(39, 254);
            this.BrokenLineTools.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BrokenLineTools.Name = "BrokenLineTools";
            this.BrokenLineTools.Size = new System.Drawing.Size(33, 31);
            this.BrokenLineTools.TabIndex = 10;
            this.BrokenLineTools.TabStop = false;
            this.BrokenLineTools.Click += new System.EventHandler(this.BrokenLineTools_Click);
            // 
            // EraserTriangle
            // 
            this.EraserTriangle.Image = ((System.Drawing.Image)(resources.GetObject("EraserTriangle.Image")));
            this.EraserTriangle.Location = new System.Drawing.Point(39, 377);
            this.EraserTriangle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EraserTriangle.Name = "EraserTriangle";
            this.EraserTriangle.Size = new System.Drawing.Size(33, 31);
            this.EraserTriangle.TabIndex = 10;
            this.EraserTriangle.TabStop = false;
            this.EraserTriangle.Click += new System.EventHandler(this.EraserTriangle_Click);
            // 
            // RightTriangleTools
            // 
            this.RightTriangleTools.Image = ((System.Drawing.Image)(resources.GetObject("RightTriangleTools.Image")));
            this.RightTriangleTools.Location = new System.Drawing.Point(39, 214);
            this.RightTriangleTools.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RightTriangleTools.Name = "RightTriangleTools";
            this.RightTriangleTools.Size = new System.Drawing.Size(33, 31);
            this.RightTriangleTools.TabIndex = 9;
            this.RightTriangleTools.TabStop = false;
            this.RightTriangleTools.Click += new System.EventHandler(this.RightTriangleTools_Click);
            // 
            // IsoscelesTriangleTools
            // 
            this.IsoscelesTriangleTools.Image = ((System.Drawing.Image)(resources.GetObject("IsoscelesTriangleTools.Image")));
            this.IsoscelesTriangleTools.Location = new System.Drawing.Point(39, 176);
            this.IsoscelesTriangleTools.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.IsoscelesTriangleTools.Name = "IsoscelesTriangleTools";
            this.IsoscelesTriangleTools.Size = new System.Drawing.Size(33, 31);
            this.IsoscelesTriangleTools.TabIndex = 8;
            this.IsoscelesTriangleTools.TabStop = false;
            this.IsoscelesTriangleTools.Click += new System.EventHandler(this.IsoscelesTriangleTools_Click);
            // 
            // RhombusTools
            // 
            this.RhombusTools.Image = ((System.Drawing.Image)(resources.GetObject("RhombusTools.Image")));
            this.RhombusTools.Location = new System.Drawing.Point(39, 138);
            this.RhombusTools.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RhombusTools.Name = "RhombusTools";
            this.RhombusTools.Size = new System.Drawing.Size(33, 31);
            this.RhombusTools.TabIndex = 7;
            this.RhombusTools.TabStop = false;
            this.RhombusTools.Click += new System.EventHandler(this.RhombusTools_Click);
            // 
            // EllipseTools
            // 
            this.EllipseTools.Image = ((System.Drawing.Image)(resources.GetObject("EllipseTools.Image")));
            this.EllipseTools.Location = new System.Drawing.Point(39, 100);
            this.EllipseTools.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EllipseTools.Name = "EllipseTools";
            this.EllipseTools.Size = new System.Drawing.Size(33, 31);
            this.EllipseTools.TabIndex = 6;
            this.EllipseTools.TabStop = false;
            this.EllipseTools.Click += new System.EventHandler(this.EllipseTools_Click);
            // 
            // RectangleTools
            // 
            this.RectangleTools.Image = ((System.Drawing.Image)(resources.GetObject("RectangleTools.Image")));
            this.RectangleTools.Location = new System.Drawing.Point(39, 62);
            this.RectangleTools.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RectangleTools.Name = "RectangleTools";
            this.RectangleTools.Size = new System.Drawing.Size(33, 31);
            this.RectangleTools.TabIndex = 5;
            this.RectangleTools.TabStop = false;
            this.RectangleTools.Click += new System.EventHandler(this.RectangleTools_Click);
            // 
            // LineTools
            // 
            this.LineTools.Image = ((System.Drawing.Image)(resources.GetObject("LineTools.Image")));
            this.LineTools.Location = new System.Drawing.Point(39, 23);
            this.LineTools.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LineTools.Name = "LineTools";
            this.LineTools.Size = new System.Drawing.Size(33, 31);
            this.LineTools.TabIndex = 4;
            this.LineTools.TabStop = false;
            this.LineTools.Click += new System.EventHandler(this.LineTools_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SlateGray;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.buttonMoveVertex);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.buttonPipette);
            this.groupBox1.Controls.Add(this.trackBar1);
            this.groupBox1.Controls.Add(this.buttonColor);
            this.groupBox1.Location = new System.Drawing.Point(1165, 28);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(140, 577);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(16, 138);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(115, 15);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "Толщина линии";
            // 
            // buttonPipette
            // 
            this.buttonPipette.BackColor = System.Drawing.Color.LightGreen;
            this.buttonPipette.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPipette.Location = new System.Drawing.Point(7, 334);
            this.buttonPipette.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPipette.Name = "buttonPipette";
            this.buttonPipette.Size = new System.Drawing.Size(125, 53);
            this.buttonPipette.TabIndex = 6;
            this.buttonPipette.Text = "Пипетка";
            this.buttonPipette.UseVisualStyleBackColor = false;
            this.buttonPipette.Click += new System.EventHandler(this.buttonPipette_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBar1.Location = new System.Drawing.Point(45, 23);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.trackBar1.Maximum = 11;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar1.Size = new System.Drawing.Size(56, 242);
            this.trackBar1.TabIndex = 4;
            this.trackBar1.Value = 1;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // buttonColor
            // 
            this.buttonColor.BackColor = System.Drawing.Color.LightGreen;
            this.buttonColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonColor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonColor.Location = new System.Drawing.Point(7, 273);
            this.buttonColor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonColor.Name = "buttonColor";
            this.buttonColor.Size = new System.Drawing.Size(125, 53);
            this.buttonColor.TabIndex = 5;
            this.buttonColor.Text = "Выбор цвета";
            this.buttonColor.UseVisualStyleBackColor = false;
            this.buttonColor.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // buttonMoveVertex
            // 
            this.buttonMoveVertex.BackColor = System.Drawing.Color.LightGreen;
            this.buttonMoveVertex.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonMoveVertex.Location = new System.Drawing.Point(7, 396);
            this.buttonMoveVertex.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonMoveVertex.Name = "buttonMoveVertex";
            this.buttonMoveVertex.Size = new System.Drawing.Size(125, 53);
            this.buttonMoveVertex.TabIndex = 5;
            this.buttonMoveVertex.Text = "Премещение вершины";
            this.buttonMoveVertex.UseVisualStyleBackColor = false;
            this.buttonMoveVertex.Click += new System.EventHandler(this.buttonMoveVertex_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(7, 458);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 53);
            this.button1.TabIndex = 4;
            this.button1.Text = "Перемещение фигуры";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1321, 626);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Tools);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Tools.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BrushTools)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BrokenLineTools)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EraserTriangle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightTriangleTools)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IsoscelesTriangleTools)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RhombusTools)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EllipseTools)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RectangleTools)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LineTools)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox Tools;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button buttonColor;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button buttonPipette;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox LineTools;
        private System.Windows.Forms.PictureBox EraserTriangle;
        private System.Windows.Forms.PictureBox RightTriangleTools;
        private System.Windows.Forms.PictureBox IsoscelesTriangleTools;
        private System.Windows.Forms.PictureBox RhombusTools;
        private System.Windows.Forms.PictureBox EllipseTools;
        private System.Windows.Forms.PictureBox RectangleTools;
        private System.Windows.Forms.PictureBox BrokenLineTools;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button buttonMoveVertex;
        private System.Windows.Forms.PictureBox BrushTools;
        private System.Windows.Forms.Button button1;
    }
}

