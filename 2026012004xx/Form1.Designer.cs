namespace MenuStrip
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.字型ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.細明體ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.標楷體ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.微軟正黑體ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.樣式ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.粗體ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.斜體ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.加底線ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LblMsg = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.字型ToolStripMenuItem,
            this.樣式ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 字型ToolStripMenuItem
            // 
            this.字型ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.細明體ToolStripMenuItem,
            this.標楷體ToolStripMenuItem,
            this.微軟正黑體ToolStripMenuItem});
            this.字型ToolStripMenuItem.Name = "字型ToolStripMenuItem";
            this.字型ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.字型ToolStripMenuItem.Text = "字型";
            // 
            // 細明體ToolStripMenuItem
            // 
            this.細明體ToolStripMenuItem.Name = "細明體ToolStripMenuItem";
            this.細明體ToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.細明體ToolStripMenuItem.Text = "細明體";
            this.細明體ToolStripMenuItem.Click += new System.EventHandler(this.細明體ToolStripMenuItem_Click);
            // 
            // 標楷體ToolStripMenuItem
            // 
            this.標楷體ToolStripMenuItem.Name = "標楷體ToolStripMenuItem";
            this.標楷體ToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.標楷體ToolStripMenuItem.Text = "標楷體";
            this.標楷體ToolStripMenuItem.Click += new System.EventHandler(this.標楷體ToolStripMenuItem_Click);
            // 
            // 微軟正黑體ToolStripMenuItem
            // 
            this.微軟正黑體ToolStripMenuItem.Name = "微軟正黑體ToolStripMenuItem";
            this.微軟正黑體ToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.微軟正黑體ToolStripMenuItem.Text = "微軟正黑體";
            this.微軟正黑體ToolStripMenuItem.Click += new System.EventHandler(this.微軟正黑體ToolStripMenuItem_Click);
            // 
            // 樣式ToolStripMenuItem
            // 
            this.樣式ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.粗體ToolStripMenuItem,
            this.斜體ToolStripMenuItem,
            this.加底線ToolStripMenuItem});
            this.樣式ToolStripMenuItem.Name = "樣式ToolStripMenuItem";
            this.樣式ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.樣式ToolStripMenuItem.Text = "樣式";
            // 
            // 粗體ToolStripMenuItem
            // 
            this.粗體ToolStripMenuItem.Name = "粗體ToolStripMenuItem";
            this.粗體ToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.粗體ToolStripMenuItem.Text = "粗體";
            this.粗體ToolStripMenuItem.Click += new System.EventHandler(this.粗體ToolStripMenuItem_Click);
            // 
            // 斜體ToolStripMenuItem
            // 
            this.斜體ToolStripMenuItem.Name = "斜體ToolStripMenuItem";
            this.斜體ToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.斜體ToolStripMenuItem.Text = "斜體";
            this.斜體ToolStripMenuItem.Click += new System.EventHandler(this.斜體ToolStripMenuItem_Click);
            // 
            // 加底線ToolStripMenuItem
            // 
            this.加底線ToolStripMenuItem.Name = "加底線ToolStripMenuItem";
            this.加底線ToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.加底線ToolStripMenuItem.Text = "加底線";
            this.加底線ToolStripMenuItem.Click += new System.EventHandler(this.加底線ToolStripMenuItem_Click);
            // 
            // LblMsg
            // 
            this.LblMsg.AutoSize = true;
            this.LblMsg.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblMsg.Location = new System.Drawing.Point(27, 40);
            this.LblMsg.Name = "LblMsg";
            this.LblMsg.Size = new System.Drawing.Size(42, 15);
            this.LblMsg.TabIndex = 1;
            this.LblMsg.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 95);
            this.Controls.Add(this.LblMsg);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 字型ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 樣式ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 細明體ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 標楷體ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 微軟正黑體ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 粗體ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 斜體ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 加底線ToolStripMenuItem;
        private System.Windows.Forms.Label LblMsg;
    }
}