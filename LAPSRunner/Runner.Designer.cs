
using Runner.Models;

namespace LAPSRunner
{
    partial class Runner
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Runner));
            openFileDialog1 = new OpenFileDialog();
            fileChooser = new Button();
            groupBox1 = new GroupBox();
            lstImmediate = new ListView();
            imColId = new ColumnHeader();
            imColName = new ColumnHeader();
            imColInstanceCount = new ColumnHeader();
            imColPath = new ColumnHeader();
            panel2 = new Panel();
            btnRunSelImmediate = new Button();
            btnRunAllImmediate = new Button();
            removeImmediate = new Button();
            groupBox2 = new GroupBox();
            panel3 = new Panel();
            btnRunSelCache = new Button();
            btnRunAllCache = new Button();
            removeCache = new Button();
            lstCache = new ListView();
            caColId = new ColumnHeader();
            caColName = new ColumnHeader();
            caColInstanceCount = new ColumnHeader();
            caColPath = new ColumnHeader();
            btnSave = new Button();
            btnShift = new Button();
            runnerIcon = new NotifyIcon(components);
            contextMenuStrip1 = new ContextMenuStrip(components);
            miRestore = new ToolStripMenuItem();
            miExit = new ToolStripMenuItem();
            panel1 = new Panel();
            panel4 = new Panel();
            btnSelSave = new Button();
            btnSelShift = new Button();
            splitContainer1 = new SplitContainer();
            toolTip1 = new ToolTip(components);
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            groupBox2.SuspendLayout();
            panel3.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Filter = "All Files (*.exe)|*.exe";
            // 
            // fileChooser
            // 
            fileChooser.Location = new Point(6, 19);
            fileChooser.Name = "fileChooser";
            fileChooser.Size = new Size(105, 23);
            fileChooser.TabIndex = 0;
            fileChooser.Text = "Choose a file";
            toolTip1.SetToolTip(fileChooser, "Choose an executable to add to the immediate");
            fileChooser.UseVisualStyleBackColor = true;
            fileChooser.Click += fileChooser_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lstImmediate);
            groupBox1.Controls.Add(fileChooser);
            groupBox1.Controls.Add(panel2);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(492, 504);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Immediate Files";
            // 
            // lstImmediate
            // 
            lstImmediate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lstImmediate.Columns.AddRange(new ColumnHeader[] { imColId, imColName, imColInstanceCount, imColPath });
            lstImmediate.FullRowSelect = true;
            lstImmediate.GridLines = true;
            lstImmediate.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            lstImmediate.Location = new Point(6, 48);
            lstImmediate.Name = "lstImmediate";
            lstImmediate.Size = new Size(480, 450);
            lstImmediate.TabIndex = 7;
            lstImmediate.UseCompatibleStateImageBehavior = false;
            lstImmediate.View = View.Details;
            lstImmediate.ColumnWidthChanging += lstImmediate_ColumnWidthChanging;
            lstImmediate.MouseDoubleClick += lstImmediate_MouseDoubleClick;
            // 
            // imColId
            // 
            imColId.Text = "Id";
            imColId.Width = 0;
            // 
            // imColName
            // 
            imColName.Text = "Name";
            // 
            // imColInstanceCount
            // 
            imColInstanceCount.Text = "Instance Count";
            // 
            // imColPath
            // 
            imColPath.Text = "Path";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel2.Controls.Add(btnRunSelImmediate);
            panel2.Controls.Add(btnRunAllImmediate);
            panel2.Controls.Add(removeImmediate);
            panel2.Location = new Point(334, 13);
            panel2.Name = "panel2";
            panel2.Size = new Size(152, 29);
            panel2.TabIndex = 10;
            // 
            // btnRunSelImmediate
            // 
            btnRunSelImmediate.Location = new Point(3, 3);
            btnRunSelImmediate.Name = "btnRunSelImmediate";
            btnRunSelImmediate.Size = new Size(48, 23);
            btnRunSelImmediate.TabIndex = 10;
            btnRunSelImmediate.Text = "Run";
            btnRunSelImmediate.UseVisualStyleBackColor = true;
            btnRunSelImmediate.Click += btnRunSelImmediate_Click;
            // 
            // btnRunAllImmediate
            // 
            btnRunAllImmediate.Location = new Point(57, 3);
            btnRunAllImmediate.Name = "btnRunAllImmediate";
            btnRunAllImmediate.Size = new Size(59, 23);
            btnRunAllImmediate.TabIndex = 9;
            btnRunAllImmediate.Text = "Run All";
            toolTip1.SetToolTip(btnRunAllImmediate, "Run everything in the immediate list");
            btnRunAllImmediate.UseVisualStyleBackColor = true;
            btnRunAllImmediate.Click += btnRunAllImmediate_Click;
            // 
            // removeImmediate
            // 
            removeImmediate.Location = new Point(122, 3);
            removeImmediate.Name = "removeImmediate";
            removeImmediate.Size = new Size(25, 23);
            removeImmediate.TabIndex = 6;
            removeImmediate.Text = "-";
            toolTip1.SetToolTip(removeImmediate, "Remove the selected items in the immediate list");
            removeImmediate.UseVisualStyleBackColor = true;
            removeImmediate.Click += removeImmediate_Click;
            // 
            // groupBox2
            // 
            groupBox2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBox2.Controls.Add(panel3);
            groupBox2.Controls.Add(lstCache);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(494, 504);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Cached Files";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel3.Controls.Add(btnRunSelCache);
            panel3.Controls.Add(btnRunAllCache);
            panel3.Controls.Add(removeCache);
            panel3.Location = new Point(354, 13);
            panel3.Name = "panel3";
            panel3.Size = new Size(134, 29);
            panel3.TabIndex = 11;
            // 
            // btnRunSelCache
            // 
            btnRunSelCache.Location = new Point(0, 3);
            btnRunSelCache.Name = "btnRunSelCache";
            btnRunSelCache.Size = new Size(38, 23);
            btnRunSelCache.TabIndex = 9;
            btnRunSelCache.Text = "Run";
            btnRunSelCache.UseVisualStyleBackColor = true;
            btnRunSelCache.Click += btnRunSelCache_Click;
            // 
            // btnRunAllCache
            // 
            btnRunAllCache.Location = new Point(44, 3);
            btnRunAllCache.Name = "btnRunAllCache";
            btnRunAllCache.Size = new Size(55, 23);
            btnRunAllCache.TabIndex = 6;
            btnRunAllCache.Text = "Run All";
            toolTip1.SetToolTip(btnRunAllCache, "Run everything in the cached list");
            btnRunAllCache.UseVisualStyleBackColor = true;
            btnRunAllCache.Click += btnRunAllCache_Click;
            // 
            // removeCache
            // 
            removeCache.Location = new Point(105, 3);
            removeCache.Name = "removeCache";
            removeCache.Size = new Size(25, 23);
            removeCache.TabIndex = 8;
            removeCache.Text = "-";
            toolTip1.SetToolTip(removeCache, "Remove the selected items in the cached list");
            removeCache.UseVisualStyleBackColor = true;
            removeCache.Click += removeCache_Click;
            // 
            // lstCache
            // 
            lstCache.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lstCache.Columns.AddRange(new ColumnHeader[] { caColId, caColName, caColInstanceCount, caColPath });
            lstCache.FullRowSelect = true;
            lstCache.GridLines = true;
            lstCache.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            lstCache.Location = new Point(6, 48);
            lstCache.Name = "lstCache";
            lstCache.Size = new Size(482, 450);
            lstCache.TabIndex = 9;
            lstCache.UseCompatibleStateImageBehavior = false;
            lstCache.View = View.Details;
            lstCache.ColumnWidthChanging += lstCache_ColumnWidthChanging;
            lstCache.MouseDoubleClick += lstCache_MouseDoubleClick;
            // 
            // caColId
            // 
            caColId.Text = "Id";
            caColId.Width = 0;
            // 
            // caColName
            // 
            caColName.Text = "Name";
            // 
            // caColInstanceCount
            // 
            caColInstanceCount.Text = "Instance Count";
            // 
            // caColPath
            // 
            caColPath.Text = "Path";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(109, 0);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(58, 23);
            btnSave.TabIndex = 5;
            btnSave.Text = ">>";
            toolTip1.SetToolTip(btnSave, "Moved to cached list");
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += save_Click;
            // 
            // btnShift
            // 
            btnShift.Location = new Point(47, 0);
            btnShift.Name = "btnShift";
            btnShift.Size = new Size(58, 23);
            btnShift.TabIndex = 8;
            btnShift.Text = "<<";
            toolTip1.SetToolTip(btnShift, "Move to immediate list");
            btnShift.UseVisualStyleBackColor = true;
            btnShift.Click += shift_Click;
            // 
            // runnerIcon
            // 
            runnerIcon.BalloonTipText = "System Tray";
            runnerIcon.BalloonTipTitle = "LAPSRunner";
            runnerIcon.ContextMenuStrip = contextMenuStrip1;
            runnerIcon.Icon = (Icon)resources.GetObject("runnerIcon.Icon");
            runnerIcon.Text = "LAPSRunner";
            runnerIcon.Visible = true;
            runnerIcon.MouseDoubleClick += runnerIcon_MouseDoubleClick;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { miRestore, miExit });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(114, 48);
            // 
            // miRestore
            // 
            miRestore.Name = "miRestore";
            miRestore.Size = new Size(113, 22);
            miRestore.Text = "Restore";
            miRestore.Click += miRestore_Click;
            // 
            // miExit
            // 
            miExit.Name = "miExit";
            miExit.Size = new Size(113, 22);
            miExit.Text = "Exit";
            miExit.Click += miExit_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel4);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(990, 35);
            panel1.TabIndex = 9;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top;
            panel4.Controls.Add(btnSelSave);
            panel4.Controls.Add(btnSelShift);
            panel4.Controls.Add(btnShift);
            panel4.Controls.Add(btnSave);
            panel4.Location = new Point(387, 5);
            panel4.Name = "panel4";
            panel4.Size = new Size(215, 27);
            panel4.TabIndex = 9;
            // 
            // btnSelSave
            // 
            btnSelSave.Location = new Point(173, 0);
            btnSelSave.Name = "btnSelSave";
            btnSelSave.Size = new Size(31, 23);
            btnSelSave.TabIndex = 10;
            btnSelSave.Text = ">";
            btnSelSave.UseVisualStyleBackColor = true;
            btnSelSave.Click += btnSelSave_Click;
            // 
            // btnSelShift
            // 
            btnSelShift.Location = new Point(10, 0);
            btnSelShift.Name = "btnSelShift";
            btnSelShift.Size = new Size(31, 23);
            btnSelShift.TabIndex = 9;
            btnSelShift.Text = "<";
            btnSelShift.UseVisualStyleBackColor = true;
            btnSelShift.Click += btnSelShift_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 35);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(groupBox2);
            splitContainer1.Size = new Size(990, 504);
            splitContainer1.SplitterDistance = 492;
            splitContainer1.TabIndex = 10;
            // 
            // Runner
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(990, 539);
            Controls.Add(splitContainer1);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Runner";
            Text = "LAPS Runner";
            FormClosing += Runner_FormClosing;
            Resize += Runner_Resize;
            groupBox1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            contextMenuStrip1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        private void fileChooser_Click(object sender, EventArgs e)
        {
            var dialogresult = openFileDialog1.ShowDialog(this);
            if (dialogresult == DialogResult.OK)
            {
                var dialog = new NewItem();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    var appInstance = new AppInstance()
                    {
                        Name = dialog.txtName.Text,
                        InstanceCount = Convert.ToInt32(dialog.numInstanceCount.Value),
                        Path = openFileDialog1.FileName
                    };

                    var error = appInstance.Validate();

                    if (String.IsNullOrEmpty(error))
                    {
                        var listViewItem = new ListViewItem(appInstance.SubItem);
                        lstImmediate.Items.Add(listViewItem);

                        ResizeListViewColumns(lstImmediate);
                    } 
                    else
                    {
                        MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private Button fileChooser;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private ListBox cachedList;
        private Button removeImmediate;
        private Button removeCache;
        private Button btnSave;
        private ListView lstImmediate;
        private ColumnHeader imColName;
        private ColumnHeader imColInstanceCount;
        private ColumnHeader imColPath;
        private ListView lstCache;
        private ColumnHeader caColName;
        private ColumnHeader caColInstanceCount;
        private ColumnHeader caColPath;
        private ColumnHeader imColId;
        private ColumnHeader caColId;
        private Button btnRunAllCache;
        private Button btnShift;
        private NotifyIcon runnerIcon;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem miRestore;
        private ToolStripMenuItem miExit;
        private Button btnRunAllImmediate;
        private Panel panel1;
        private SplitContainer splitContainer1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private ToolTip toolTip1;
        private Button btnRunSelImmediate;
        private Button btnRunSelCache;
        private Button btnSelSave;
        private Button btnSelShift;
    }
}
