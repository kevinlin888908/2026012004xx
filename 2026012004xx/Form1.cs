namespace MenuStrip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LblMsg.Text = "喝的醉醉，撞的碎碎";
            LblMsg.ForeColor = Color.Red;            // 設前景色為紅色
            LblMsg.Font = new Font("細明體", 16, FontStyle.Bold);
            粗體ToolStripMenuItem.Checked = true;   // 預設粗體項目被勾選
        }

        private void 細明體ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 設字型為細明體、大小為16、原字型樣式
            LblMsg.Font = new Font("細明體", 16, LblMsg.Font.Style);
        }

        private void 標楷體ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LblMsg.Font = new Font("標楷體", 16, LblMsg.Font.Style);
        }

        private void 微軟正黑體ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LblMsg.Font = new Font("微軟正黑體", 16, LblMsg.Font.Style);
        }

        private void 粗體ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LblMsg.Font = new Font(LblMsg.Font, LblMsg.Font.Style ^ FontStyle.Bold);
            粗體ToolStripMenuItem.Checked = !(粗體ToolStripMenuItem.Checked);
        }

        private void 斜體ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LblMsg.Font = new Font(LblMsg.Font, LblMsg.Font.Style ^ FontStyle.Italic);
            斜體ToolStripMenuItem.Checked = !(斜體ToolStripMenuItem.Checked);
        }

        private void 加底線ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LblMsg.Font = new Font(LblMsg.Font, LblMsg.Font.Style ^ FontStyle.Underline);
            加底線ToolStripMenuItem.Checked = !(加底線ToolStripMenuItem.Checked);
        }
    }
}