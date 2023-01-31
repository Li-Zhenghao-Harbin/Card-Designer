
namespace Card_Designer
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Pic_Background = new System.Windows.Forms.PictureBox();
            this.Pn_Description = new System.Windows.Forms.Panel();
            this.Pn_Description_Content = new System.Windows.Forms.Panel();
            this.Rtx_Description = new System.Windows.Forms.RichTextBox();
            this.Lbl_Description = new System.Windows.Forms.Label();
            this.Pn_Shapes = new System.Windows.Forms.Panel();
            this.Pn_Shapes_Content = new System.Windows.Forms.Panel();
            this.Btn_Shapes_Clear = new System.Windows.Forms.Button();
            this.Btn_Shapes_LowerTriangle = new System.Windows.Forms.Button();
            this.Btn_Shapes_UpperTriangle = new System.Windows.Forms.Button();
            this.Btn_Shapes_Square = new System.Windows.Forms.Button();
            this.Tx_Shapes = new System.Windows.Forms.TextBox();
            this.Lbl_Shapes = new System.Windows.Forms.Label();
            this.Pn_Points = new System.Windows.Forms.Panel();
            this.Pn_Points_Content = new System.Windows.Forms.Panel();
            this.Num_Points = new System.Windows.Forms.NumericUpDown();
            this.Lbl_Points = new System.Windows.Forms.Label();
            this.Pn_Title = new System.Windows.Forms.Panel();
            this.Pn_Title_Content = new System.Windows.Forms.Panel();
            this.Tx_Title = new System.Windows.Forms.TextBox();
            this.Lbl_Title = new System.Windows.Forms.Label();
            this.Pn_Level = new System.Windows.Forms.Panel();
            this.Pn_Level_Content = new System.Windows.Forms.Panel();
            this.Combo_Level = new System.Windows.Forms.ComboBox();
            this.Lbl_Level = new System.Windows.Forms.Label();
            this.Pn_Icon = new System.Windows.Forms.Panel();
            this.Pn_Icon_Content = new System.Windows.Forms.Panel();
            this.Btn_Icon = new System.Windows.Forms.Button();
            this.Tx_Icon = new System.Windows.Forms.TextBox();
            this.Lbl_Icon = new System.Windows.Forms.Label();
            this.Pic_Icon = new System.Windows.Forms.PictureBox();
            this.Lbl_CardTitle = new System.Windows.Forms.Label();
            this.Lbl_CardPoints = new System.Windows.Forms.Label();
            this.Lbl_CardDescription = new System.Windows.Forms.Label();
            this.Lbl_CardShape = new System.Windows.Forms.Label();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutCardDesignerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Background)).BeginInit();
            this.Pn_Description.SuspendLayout();
            this.Pn_Description_Content.SuspendLayout();
            this.Pn_Shapes.SuspendLayout();
            this.Pn_Shapes_Content.SuspendLayout();
            this.Pn_Points.SuspendLayout();
            this.Pn_Points_Content.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Num_Points)).BeginInit();
            this.Pn_Title.SuspendLayout();
            this.Pn_Title_Content.SuspendLayout();
            this.Pn_Level.SuspendLayout();
            this.Pn_Level_Content.SuspendLayout();
            this.Pn_Icon.SuspendLayout();
            this.Pn_Icon_Content.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Icon)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.MenuStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(1108, 48);
            this.MenuStrip.TabIndex = 0;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(73, 38);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutCardDesignerToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(105, 38);
            this.aboutToolStripMenuItem.Text = "&About";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 48);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.Lbl_CardShape);
            this.splitContainer1.Panel1.Controls.Add(this.Lbl_CardDescription);
            this.splitContainer1.Panel1.Controls.Add(this.Lbl_CardPoints);
            this.splitContainer1.Panel1.Controls.Add(this.Lbl_CardTitle);
            this.splitContainer1.Panel1.Controls.Add(this.Pic_Icon);
            this.splitContainer1.Panel1.Controls.Add(this.Pic_Background);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.Pn_Description);
            this.splitContainer1.Panel2.Controls.Add(this.Pn_Shapes);
            this.splitContainer1.Panel2.Controls.Add(this.Pn_Points);
            this.splitContainer1.Panel2.Controls.Add(this.Pn_Title);
            this.splitContainer1.Panel2.Controls.Add(this.Pn_Level);
            this.splitContainer1.Panel2.Controls.Add(this.Pn_Icon);
            this.splitContainer1.Size = new System.Drawing.Size(1108, 1191);
            this.splitContainer1.SplitterDistance = 800;
            this.splitContainer1.TabIndex = 1;
            // 
            // Pic_Background
            // 
            this.Pic_Background.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Pic_Background.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pic_Background.Image = global::Card_Designer.Properties.Resources.BG1;
            this.Pic_Background.Location = new System.Drawing.Point(0, 0);
            this.Pic_Background.Name = "Pic_Background";
            this.Pic_Background.Size = new System.Drawing.Size(800, 1191);
            this.Pic_Background.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pic_Background.TabIndex = 0;
            this.Pic_Background.TabStop = false;
            // 
            // Pn_Description
            // 
            this.Pn_Description.Controls.Add(this.Pn_Description_Content);
            this.Pn_Description.Controls.Add(this.Lbl_Description);
            this.Pn_Description.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pn_Description.Location = new System.Drawing.Point(0, 666);
            this.Pn_Description.Name = "Pn_Description";
            this.Pn_Description.Size = new System.Drawing.Size(304, 525);
            this.Pn_Description.TabIndex = 5;
            // 
            // Pn_Description_Content
            // 
            this.Pn_Description_Content.Controls.Add(this.Rtx_Description);
            this.Pn_Description_Content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pn_Description_Content.Location = new System.Drawing.Point(0, 40);
            this.Pn_Description_Content.Name = "Pn_Description_Content";
            this.Pn_Description_Content.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.Pn_Description_Content.Size = new System.Drawing.Size(304, 485);
            this.Pn_Description_Content.TabIndex = 1;
            // 
            // Rtx_Description
            // 
            this.Rtx_Description.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Rtx_Description.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Rtx_Description.Location = new System.Drawing.Point(0, 10);
            this.Rtx_Description.Name = "Rtx_Description";
            this.Rtx_Description.Size = new System.Drawing.Size(304, 465);
            this.Rtx_Description.TabIndex = 0;
            this.Rtx_Description.Text = "";
            this.Rtx_Description.TextChanged += new System.EventHandler(this.Rtx_Description_TextChanged);
            // 
            // Lbl_Description
            // 
            this.Lbl_Description.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.Lbl_Description.Dock = System.Windows.Forms.DockStyle.Top;
            this.Lbl_Description.Location = new System.Drawing.Point(0, 0);
            this.Lbl_Description.Name = "Lbl_Description";
            this.Lbl_Description.Size = new System.Drawing.Size(304, 40);
            this.Lbl_Description.TabIndex = 0;
            this.Lbl_Description.Text = "Description";
            this.Lbl_Description.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Pn_Shapes
            // 
            this.Pn_Shapes.Controls.Add(this.Pn_Shapes_Content);
            this.Pn_Shapes.Controls.Add(this.Lbl_Shapes);
            this.Pn_Shapes.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pn_Shapes.Location = new System.Drawing.Point(0, 411);
            this.Pn_Shapes.Name = "Pn_Shapes";
            this.Pn_Shapes.Size = new System.Drawing.Size(304, 255);
            this.Pn_Shapes.TabIndex = 4;
            // 
            // Pn_Shapes_Content
            // 
            this.Pn_Shapes_Content.Controls.Add(this.Btn_Shapes_Clear);
            this.Pn_Shapes_Content.Controls.Add(this.Btn_Shapes_LowerTriangle);
            this.Pn_Shapes_Content.Controls.Add(this.Btn_Shapes_UpperTriangle);
            this.Pn_Shapes_Content.Controls.Add(this.Btn_Shapes_Square);
            this.Pn_Shapes_Content.Controls.Add(this.Tx_Shapes);
            this.Pn_Shapes_Content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pn_Shapes_Content.Location = new System.Drawing.Point(0, 40);
            this.Pn_Shapes_Content.Name = "Pn_Shapes_Content";
            this.Pn_Shapes_Content.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.Pn_Shapes_Content.Size = new System.Drawing.Size(304, 215);
            this.Pn_Shapes_Content.TabIndex = 1;
            // 
            // Btn_Shapes_Clear
            // 
            this.Btn_Shapes_Clear.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_Shapes_Clear.Location = new System.Drawing.Point(0, 165);
            this.Btn_Shapes_Clear.Name = "Btn_Shapes_Clear";
            this.Btn_Shapes_Clear.Size = new System.Drawing.Size(304, 40);
            this.Btn_Shapes_Clear.TabIndex = 4;
            this.Btn_Shapes_Clear.Text = "Clear";
            this.Btn_Shapes_Clear.UseVisualStyleBackColor = true;
            this.Btn_Shapes_Clear.Click += new System.EventHandler(this.Btn_Shapes_Clear_Click);
            // 
            // Btn_Shapes_LowerTriangle
            // 
            this.Btn_Shapes_LowerTriangle.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_Shapes_LowerTriangle.Location = new System.Drawing.Point(0, 125);
            this.Btn_Shapes_LowerTriangle.Name = "Btn_Shapes_LowerTriangle";
            this.Btn_Shapes_LowerTriangle.Size = new System.Drawing.Size(304, 40);
            this.Btn_Shapes_LowerTriangle.TabIndex = 3;
            this.Btn_Shapes_LowerTriangle.Text = "+ Lower Triangle";
            this.Btn_Shapes_LowerTriangle.UseVisualStyleBackColor = true;
            this.Btn_Shapes_LowerTriangle.Click += new System.EventHandler(this.Btn_Shapes_LowerTriangle_Click);
            // 
            // Btn_Shapes_UpperTriangle
            // 
            this.Btn_Shapes_UpperTriangle.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_Shapes_UpperTriangle.Location = new System.Drawing.Point(0, 85);
            this.Btn_Shapes_UpperTriangle.Name = "Btn_Shapes_UpperTriangle";
            this.Btn_Shapes_UpperTriangle.Size = new System.Drawing.Size(304, 40);
            this.Btn_Shapes_UpperTriangle.TabIndex = 2;
            this.Btn_Shapes_UpperTriangle.Text = "+ Upper Triangle";
            this.Btn_Shapes_UpperTriangle.UseVisualStyleBackColor = true;
            this.Btn_Shapes_UpperTriangle.Click += new System.EventHandler(this.Btn_Shapes_UpperTriangle_Click);
            // 
            // Btn_Shapes_Square
            // 
            this.Btn_Shapes_Square.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_Shapes_Square.Location = new System.Drawing.Point(0, 45);
            this.Btn_Shapes_Square.Name = "Btn_Shapes_Square";
            this.Btn_Shapes_Square.Size = new System.Drawing.Size(304, 40);
            this.Btn_Shapes_Square.TabIndex = 1;
            this.Btn_Shapes_Square.Text = "+ Square";
            this.Btn_Shapes_Square.UseVisualStyleBackColor = true;
            this.Btn_Shapes_Square.Click += new System.EventHandler(this.Btn_Shapes_Square_Click);
            // 
            // Tx_Shapes
            // 
            this.Tx_Shapes.Dock = System.Windows.Forms.DockStyle.Top;
            this.Tx_Shapes.Location = new System.Drawing.Point(0, 10);
            this.Tx_Shapes.Name = "Tx_Shapes";
            this.Tx_Shapes.ReadOnly = true;
            this.Tx_Shapes.Size = new System.Drawing.Size(304, 35);
            this.Tx_Shapes.TabIndex = 0;
            // 
            // Lbl_Shapes
            // 
            this.Lbl_Shapes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.Lbl_Shapes.Dock = System.Windows.Forms.DockStyle.Top;
            this.Lbl_Shapes.Location = new System.Drawing.Point(0, 0);
            this.Lbl_Shapes.Name = "Lbl_Shapes";
            this.Lbl_Shapes.Size = new System.Drawing.Size(304, 40);
            this.Lbl_Shapes.TabIndex = 0;
            this.Lbl_Shapes.Text = "Shapes";
            this.Lbl_Shapes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Pn_Points
            // 
            this.Pn_Points.Controls.Add(this.Pn_Points_Content);
            this.Pn_Points.Controls.Add(this.Lbl_Points);
            this.Pn_Points.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pn_Points.Location = new System.Drawing.Point(0, 319);
            this.Pn_Points.Name = "Pn_Points";
            this.Pn_Points.Size = new System.Drawing.Size(304, 92);
            this.Pn_Points.TabIndex = 3;
            // 
            // Pn_Points_Content
            // 
            this.Pn_Points_Content.Controls.Add(this.Num_Points);
            this.Pn_Points_Content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pn_Points_Content.Location = new System.Drawing.Point(0, 40);
            this.Pn_Points_Content.Name = "Pn_Points_Content";
            this.Pn_Points_Content.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.Pn_Points_Content.Size = new System.Drawing.Size(304, 52);
            this.Pn_Points_Content.TabIndex = 1;
            // 
            // Num_Points
            // 
            this.Num_Points.Dock = System.Windows.Forms.DockStyle.Top;
            this.Num_Points.Location = new System.Drawing.Point(0, 10);
            this.Num_Points.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.Num_Points.Name = "Num_Points";
            this.Num_Points.ReadOnly = true;
            this.Num_Points.Size = new System.Drawing.Size(304, 35);
            this.Num_Points.TabIndex = 0;
            this.Num_Points.ValueChanged += new System.EventHandler(this.Num_Points_ValueChanged);
            // 
            // Lbl_Points
            // 
            this.Lbl_Points.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.Lbl_Points.Dock = System.Windows.Forms.DockStyle.Top;
            this.Lbl_Points.Location = new System.Drawing.Point(0, 0);
            this.Lbl_Points.Name = "Lbl_Points";
            this.Lbl_Points.Size = new System.Drawing.Size(304, 40);
            this.Lbl_Points.TabIndex = 0;
            this.Lbl_Points.Text = "Points";
            this.Lbl_Points.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Pn_Title
            // 
            this.Pn_Title.Controls.Add(this.Pn_Title_Content);
            this.Pn_Title.Controls.Add(this.Lbl_Title);
            this.Pn_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pn_Title.Location = new System.Drawing.Point(0, 227);
            this.Pn_Title.Name = "Pn_Title";
            this.Pn_Title.Size = new System.Drawing.Size(304, 92);
            this.Pn_Title.TabIndex = 2;
            // 
            // Pn_Title_Content
            // 
            this.Pn_Title_Content.Controls.Add(this.Tx_Title);
            this.Pn_Title_Content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pn_Title_Content.Location = new System.Drawing.Point(0, 40);
            this.Pn_Title_Content.Name = "Pn_Title_Content";
            this.Pn_Title_Content.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.Pn_Title_Content.Size = new System.Drawing.Size(304, 52);
            this.Pn_Title_Content.TabIndex = 1;
            // 
            // Tx_Title
            // 
            this.Tx_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.Tx_Title.Location = new System.Drawing.Point(0, 10);
            this.Tx_Title.MaxLength = 10;
            this.Tx_Title.Name = "Tx_Title";
            this.Tx_Title.Size = new System.Drawing.Size(304, 35);
            this.Tx_Title.TabIndex = 0;
            this.Tx_Title.TextChanged += new System.EventHandler(this.Tx_Title_TextChanged);
            // 
            // Lbl_Title
            // 
            this.Lbl_Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.Lbl_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.Lbl_Title.Location = new System.Drawing.Point(0, 0);
            this.Lbl_Title.Name = "Lbl_Title";
            this.Lbl_Title.Size = new System.Drawing.Size(304, 40);
            this.Lbl_Title.TabIndex = 0;
            this.Lbl_Title.Text = "Title";
            this.Lbl_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Pn_Level
            // 
            this.Pn_Level.Controls.Add(this.Pn_Level_Content);
            this.Pn_Level.Controls.Add(this.Lbl_Level);
            this.Pn_Level.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pn_Level.Location = new System.Drawing.Point(0, 135);
            this.Pn_Level.Name = "Pn_Level";
            this.Pn_Level.Size = new System.Drawing.Size(304, 92);
            this.Pn_Level.TabIndex = 1;
            // 
            // Pn_Level_Content
            // 
            this.Pn_Level_Content.Controls.Add(this.Combo_Level);
            this.Pn_Level_Content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pn_Level_Content.Location = new System.Drawing.Point(0, 40);
            this.Pn_Level_Content.Name = "Pn_Level_Content";
            this.Pn_Level_Content.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.Pn_Level_Content.Size = new System.Drawing.Size(304, 52);
            this.Pn_Level_Content.TabIndex = 1;
            // 
            // Combo_Level
            // 
            this.Combo_Level.Dock = System.Windows.Forms.DockStyle.Top;
            this.Combo_Level.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Combo_Level.FormattingEnabled = true;
            this.Combo_Level.Items.AddRange(new object[] {
            "Level 1 (Gray)",
            "Level 2 (Blue)",
            "Level 3 (Purple)",
            "Level 4 (Golden)"});
            this.Combo_Level.Location = new System.Drawing.Point(0, 10);
            this.Combo_Level.Name = "Combo_Level";
            this.Combo_Level.Size = new System.Drawing.Size(304, 32);
            this.Combo_Level.TabIndex = 0;
            this.Combo_Level.SelectedIndexChanged += new System.EventHandler(this.Combo_Level_SelectedIndexChanged);
            // 
            // Lbl_Level
            // 
            this.Lbl_Level.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.Lbl_Level.Dock = System.Windows.Forms.DockStyle.Top;
            this.Lbl_Level.Location = new System.Drawing.Point(0, 0);
            this.Lbl_Level.Name = "Lbl_Level";
            this.Lbl_Level.Size = new System.Drawing.Size(304, 40);
            this.Lbl_Level.TabIndex = 0;
            this.Lbl_Level.Text = "Level";
            this.Lbl_Level.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Pn_Icon
            // 
            this.Pn_Icon.Controls.Add(this.Pn_Icon_Content);
            this.Pn_Icon.Controls.Add(this.Lbl_Icon);
            this.Pn_Icon.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pn_Icon.Location = new System.Drawing.Point(0, 0);
            this.Pn_Icon.Name = "Pn_Icon";
            this.Pn_Icon.Size = new System.Drawing.Size(304, 135);
            this.Pn_Icon.TabIndex = 0;
            // 
            // Pn_Icon_Content
            // 
            this.Pn_Icon_Content.Controls.Add(this.Btn_Icon);
            this.Pn_Icon_Content.Controls.Add(this.Tx_Icon);
            this.Pn_Icon_Content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pn_Icon_Content.Location = new System.Drawing.Point(0, 40);
            this.Pn_Icon_Content.Name = "Pn_Icon_Content";
            this.Pn_Icon_Content.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.Pn_Icon_Content.Size = new System.Drawing.Size(304, 95);
            this.Pn_Icon_Content.TabIndex = 1;
            // 
            // Btn_Icon
            // 
            this.Btn_Icon.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_Icon.Location = new System.Drawing.Point(0, 45);
            this.Btn_Icon.Name = "Btn_Icon";
            this.Btn_Icon.Size = new System.Drawing.Size(304, 40);
            this.Btn_Icon.TabIndex = 1;
            this.Btn_Icon.Text = "Select...";
            this.Btn_Icon.UseVisualStyleBackColor = true;
            this.Btn_Icon.Click += new System.EventHandler(this.Btn_Icon_Click);
            // 
            // Tx_Icon
            // 
            this.Tx_Icon.Dock = System.Windows.Forms.DockStyle.Top;
            this.Tx_Icon.Location = new System.Drawing.Point(0, 10);
            this.Tx_Icon.Name = "Tx_Icon";
            this.Tx_Icon.ReadOnly = true;
            this.Tx_Icon.Size = new System.Drawing.Size(304, 35);
            this.Tx_Icon.TabIndex = 0;
            // 
            // Lbl_Icon
            // 
            this.Lbl_Icon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.Lbl_Icon.Dock = System.Windows.Forms.DockStyle.Top;
            this.Lbl_Icon.Location = new System.Drawing.Point(0, 0);
            this.Lbl_Icon.Name = "Lbl_Icon";
            this.Lbl_Icon.Size = new System.Drawing.Size(304, 40);
            this.Lbl_Icon.TabIndex = 0;
            this.Lbl_Icon.Text = "Icon";
            this.Lbl_Icon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Pic_Icon
            // 
            this.Pic_Icon.BackColor = System.Drawing.Color.White;
            this.Pic_Icon.Location = new System.Drawing.Point(200, 110);
            this.Pic_Icon.Name = "Pic_Icon";
            this.Pic_Icon.Size = new System.Drawing.Size(400, 400);
            this.Pic_Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pic_Icon.TabIndex = 1;
            this.Pic_Icon.TabStop = false;
            // 
            // Lbl_CardTitle
            // 
            this.Lbl_CardTitle.Font = new System.Drawing.Font("Times New Roman", 22.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_CardTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.Lbl_CardTitle.Location = new System.Drawing.Point(350, 625);
            this.Lbl_CardTitle.Name = "Lbl_CardTitle";
            this.Lbl_CardTitle.Size = new System.Drawing.Size(400, 80);
            this.Lbl_CardTitle.TabIndex = 2;
            this.Lbl_CardTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lbl_CardPoints
            // 
            this.Lbl_CardPoints.Font = new System.Drawing.Font("Times New Roman", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_CardPoints.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.Lbl_CardPoints.Location = new System.Drawing.Point(90, 600);
            this.Lbl_CardPoints.Name = "Lbl_CardPoints";
            this.Lbl_CardPoints.Size = new System.Drawing.Size(120, 60);
            this.Lbl_CardPoints.TabIndex = 3;
            this.Lbl_CardPoints.Text = "0";
            this.Lbl_CardPoints.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lbl_CardDescription
            // 
            this.Lbl_CardDescription.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_CardDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            this.Lbl_CardDescription.Location = new System.Drawing.Point(100, 770);
            this.Lbl_CardDescription.Name = "Lbl_CardDescription";
            this.Lbl_CardDescription.Size = new System.Drawing.Size(600, 300);
            this.Lbl_CardDescription.TabIndex = 4;
            this.Lbl_CardDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lbl_CardShape
            // 
            this.Lbl_CardShape.Font = new System.Drawing.Font("Adobe 黑体 Std R", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Lbl_CardShape.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.Lbl_CardShape.Location = new System.Drawing.Point(300, 1130);
            this.Lbl_CardShape.Name = "Lbl_CardShape";
            this.Lbl_CardShape.Size = new System.Drawing.Size(200, 40);
            this.Lbl_CardShape.TabIndex = 5;
            this.Lbl_CardShape.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.exportToolStripMenuItem.Text = "&Export...";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(356, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutCardDesignerToolStripMenuItem
            // 
            this.aboutCardDesignerToolStripMenuItem.Name = "aboutCardDesignerToolStripMenuItem";
            this.aboutCardDesignerToolStripMenuItem.Size = new System.Drawing.Size(405, 44);
            this.aboutCardDesignerToolStripMenuItem.Text = "&About Card Designer...";
            this.aboutCardDesignerToolStripMenuItem.Click += new System.EventHandler(this.aboutCardDesignerToolStripMenuItem_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 1239);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.MenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Card Designer";
            this.Activated += new System.EventHandler(this.FrmMain_Activated);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Background)).EndInit();
            this.Pn_Description.ResumeLayout(false);
            this.Pn_Description_Content.ResumeLayout(false);
            this.Pn_Shapes.ResumeLayout(false);
            this.Pn_Shapes_Content.ResumeLayout(false);
            this.Pn_Shapes_Content.PerformLayout();
            this.Pn_Points.ResumeLayout(false);
            this.Pn_Points_Content.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Num_Points)).EndInit();
            this.Pn_Title.ResumeLayout(false);
            this.Pn_Title_Content.ResumeLayout(false);
            this.Pn_Title_Content.PerformLayout();
            this.Pn_Level.ResumeLayout(false);
            this.Pn_Level_Content.ResumeLayout(false);
            this.Pn_Icon.ResumeLayout(false);
            this.Pn_Icon_Content.ResumeLayout(false);
            this.Pn_Icon_Content.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox Pic_Background;
        private System.Windows.Forms.Panel Pn_Icon;
        private System.Windows.Forms.Label Lbl_Icon;
        private System.Windows.Forms.Panel Pn_Icon_Content;
        private System.Windows.Forms.Button Btn_Icon;
        private System.Windows.Forms.TextBox Tx_Icon;
        private System.Windows.Forms.Panel Pn_Level;
        private System.Windows.Forms.Panel Pn_Level_Content;
        private System.Windows.Forms.ComboBox Combo_Level;
        private System.Windows.Forms.Label Lbl_Level;
        private System.Windows.Forms.Panel Pn_Title;
        private System.Windows.Forms.Panel Pn_Title_Content;
        private System.Windows.Forms.TextBox Tx_Title;
        private System.Windows.Forms.Label Lbl_Title;
        private System.Windows.Forms.Panel Pn_Points;
        private System.Windows.Forms.Panel Pn_Points_Content;
        private System.Windows.Forms.NumericUpDown Num_Points;
        private System.Windows.Forms.Label Lbl_Points;
        private System.Windows.Forms.Panel Pn_Shapes;
        private System.Windows.Forms.Panel Pn_Shapes_Content;
        private System.Windows.Forms.Button Btn_Shapes_Clear;
        private System.Windows.Forms.Button Btn_Shapes_LowerTriangle;
        private System.Windows.Forms.Button Btn_Shapes_UpperTriangle;
        private System.Windows.Forms.Button Btn_Shapes_Square;
        private System.Windows.Forms.TextBox Tx_Shapes;
        private System.Windows.Forms.Label Lbl_Shapes;
        private System.Windows.Forms.Panel Pn_Description;
        private System.Windows.Forms.Panel Pn_Description_Content;
        private System.Windows.Forms.RichTextBox Rtx_Description;
        private System.Windows.Forms.Label Lbl_Description;
        private System.Windows.Forms.PictureBox Pic_Icon;
        private System.Windows.Forms.Label Lbl_CardTitle;
        private System.Windows.Forms.Label Lbl_CardPoints;
        private System.Windows.Forms.Label Lbl_CardDescription;
        private System.Windows.Forms.Label Lbl_CardShape;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutCardDesignerToolStripMenuItem;
    }
}

