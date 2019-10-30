namespace WindowsFormsApp1
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.videoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vebCamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.motionDetectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.etalonMethodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.justDiffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contoursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Play_button = new System.Windows.Forms.Button();
            this.Pause_button = new System.Windows.Forms.Button();
            this.FirstImageBox = new Emgu.CV.UI.ImageBox();
            this.ResultImageBox = new Emgu.CV.UI.ImageBox();
            this.secondToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.foregroundMaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterMaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rectToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FirstImageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResultImageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.motionDetectToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.videoToolStripMenuItem,
            this.vebCamToolStripMenuItem});
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.loadToolStripMenuItem.Text = "Load";
            // 
            // videoToolStripMenuItem
            // 
            this.videoToolStripMenuItem.Name = "videoToolStripMenuItem";
            this.videoToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.videoToolStripMenuItem.Text = "Video";
            this.videoToolStripMenuItem.Click += new System.EventHandler(this.videoToolStripMenuItem_Click);
            // 
            // vebCamToolStripMenuItem
            // 
            this.vebCamToolStripMenuItem.Name = "vebCamToolStripMenuItem";
            this.vebCamToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.vebCamToolStripMenuItem.Text = "Web-Cam";
            this.vebCamToolStripMenuItem.Click += new System.EventHandler(this.vebCamToolStripMenuItem_Click);
            // 
            // motionDetectToolStripMenuItem
            // 
            this.motionDetectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.etalonMethodToolStripMenuItem,
            this.secondToolStripMenuItem});
            this.motionDetectToolStripMenuItem.Name = "motionDetectToolStripMenuItem";
            this.motionDetectToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.motionDetectToolStripMenuItem.Text = "Motion Detect";
            // 
            // etalonMethodToolStripMenuItem
            // 
            this.etalonMethodToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.justDiffToolStripMenuItem,
            this.contoursToolStripMenuItem,
            this.rectToolStripMenuItem});
            this.etalonMethodToolStripMenuItem.Name = "etalonMethodToolStripMenuItem";
            this.etalonMethodToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.etalonMethodToolStripMenuItem.Text = "Etalon Method";
            // 
            // justDiffToolStripMenuItem
            // 
            this.justDiffToolStripMenuItem.Name = "justDiffToolStripMenuItem";
            this.justDiffToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.justDiffToolStripMenuItem.Text = "Just Diff";
            this.justDiffToolStripMenuItem.Click += new System.EventHandler(this.justDiffToolStripMenuItem_Click);
            // 
            // contoursToolStripMenuItem
            // 
            this.contoursToolStripMenuItem.Name = "contoursToolStripMenuItem";
            this.contoursToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.contoursToolStripMenuItem.Text = "Contours";
            this.contoursToolStripMenuItem.Click += new System.EventHandler(this.contoursToolStripMenuItem_Click);
            // 
            // rectToolStripMenuItem
            // 
            this.rectToolStripMenuItem.Name = "rectToolStripMenuItem";
            this.rectToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.rectToolStripMenuItem.Text = "Rect";
            this.rectToolStripMenuItem.Click += new System.EventHandler(this.rectToolStripMenuItem_Click);
            // 
            // Play_button
            // 
            this.Play_button.Location = new System.Drawing.Point(322, 27);
            this.Play_button.Name = "Play_button";
            this.Play_button.Size = new System.Drawing.Size(75, 23);
            this.Play_button.TabIndex = 2;
            this.Play_button.Text = "Play";
            this.Play_button.UseVisualStyleBackColor = true;
            this.Play_button.Visible = false;
            this.Play_button.Click += new System.EventHandler(this.Play_button_Click);
            // 
            // Pause_button
            // 
            this.Pause_button.Location = new System.Drawing.Point(403, 27);
            this.Pause_button.Name = "Pause_button";
            this.Pause_button.Size = new System.Drawing.Size(75, 23);
            this.Pause_button.TabIndex = 3;
            this.Pause_button.Text = "Pause";
            this.Pause_button.UseVisualStyleBackColor = true;
            this.Pause_button.Visible = false;
            this.Pause_button.Click += new System.EventHandler(this.Pause_button_Click);
            // 
            // FirstImageBox
            // 
            this.FirstImageBox.Location = new System.Drawing.Point(12, 61);
            this.FirstImageBox.Name = "FirstImageBox";
            this.FirstImageBox.Size = new System.Drawing.Size(379, 377);
            this.FirstImageBox.TabIndex = 2;
            this.FirstImageBox.TabStop = false;
            // 
            // ResultImageBox
            // 
            this.ResultImageBox.Location = new System.Drawing.Point(409, 61);
            this.ResultImageBox.Name = "ResultImageBox";
            this.ResultImageBox.Size = new System.Drawing.Size(379, 377);
            this.ResultImageBox.TabIndex = 4;
            this.ResultImageBox.TabStop = false;
            // 
            // secondToolStripMenuItem
            // 
            this.secondToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.foregroundMaskToolStripMenuItem,
            this.filterMaskToolStripMenuItem,
            this.rectToolStripMenuItem1});
            this.secondToolStripMenuItem.Name = "secondToolStripMenuItem";
            this.secondToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.secondToolStripMenuItem.Text = "Second Methods";
            // 
            // foregroundMaskToolStripMenuItem
            // 
            this.foregroundMaskToolStripMenuItem.Name = "foregroundMaskToolStripMenuItem";
            this.foregroundMaskToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.foregroundMaskToolStripMenuItem.Text = "foregroundMask";
            this.foregroundMaskToolStripMenuItem.Click += new System.EventHandler(this.foregroundMaskToolStripMenuItem_Click);
            // 
            // filterMaskToolStripMenuItem
            // 
            this.filterMaskToolStripMenuItem.Name = "filterMaskToolStripMenuItem";
            this.filterMaskToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.filterMaskToolStripMenuItem.Text = "Filter Mask";
            this.filterMaskToolStripMenuItem.Click += new System.EventHandler(this.filterMaskToolStripMenuItem_Click);
            // 
            // rectToolStripMenuItem1
            // 
            this.rectToolStripMenuItem1.Name = "rectToolStripMenuItem1";
            this.rectToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.rectToolStripMenuItem1.Text = "Drow Rect";
            this.rectToolStripMenuItem1.Click += new System.EventHandler(this.rectToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ResultImageBox);
            this.Controls.Add(this.FirstImageBox);
            this.Controls.Add(this.Pause_button);
            this.Controls.Add(this.Play_button);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FirstImageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResultImageBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem videoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vebCamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem motionDetectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem etalonMethodToolStripMenuItem;
        private System.Windows.Forms.Button Play_button;
        private System.Windows.Forms.Button Pause_button;
        private Emgu.CV.UI.ImageBox FirstImageBox;
        private Emgu.CV.UI.ImageBox ResultImageBox;
        private System.Windows.Forms.ToolStripMenuItem justDiffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contoursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem secondToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem foregroundMaskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filterMaskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rectToolStripMenuItem1;
    }
}

