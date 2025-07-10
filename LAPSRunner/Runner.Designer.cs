
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
            btnRunImmediate = new Button();
            removeImmediate = new Button();
            groupBox2 = new GroupBox();
            panel3 = new Panel();
            btnRunCache = new Button();
            removeCache = new Button();
            lstCache = new ListView();
            caColId = new ColumnHeader();
            caColName = new ColumnHeader();
            caColInstanceCount = new ColumnHeader();
            caColPath = new ColumnHeader();
            save = new Button();
            shift = new Button();
            runnerIcon = new NotifyIcon(components);
            contextMenuStrip1 = new ContextMenuStrip(components);
            miRestore = new ToolStripMenuItem();
            miExit = new ToolStripMenuItem();
            panel1 = new Panel();
            panel4 = new Panel();
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
            panel2.Controls.Add(btnRunImmediate);
            panel2.Controls.Add(removeImmediate);
            panel2.Location = new Point(369, 13);
            panel2.Name = "panel2";
            panel2.Size = new Size(117, 29);
            panel2.TabIndex = 10;
            // 
            // btnRunImmediate
            // 
            btnRunImmediate.Location = new Point(3, 3);
            btnRunImmediate.Name = "btnRunImmediate";
            btnRunImmediate.Size = new Size(75, 23);
            btnRunImmediate.TabIndex = 9;
            btnRunImmediate.Text = "Run";
            toolTip1.SetToolTip(btnRunImmediate, "Run everything in the immediate list");
            btnRunImmediate.UseVisualStyleBackColor = true;
            btnRunImmediate.Click += btnRunImmediate_Click;
            // 
            // removeImmediate
            // 
            removeImmediate.Location = new Point(84, 3);
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
            panel3.Controls.Add(btnRunCache);
            panel3.Controls.Add(removeCache);
            panel3.Location = new Point(371, 13);
            panel3.Name = "panel3";
            panel3.Size = new Size(117, 29);
            panel3.TabIndex = 11;
            // 
            // btnRunCache
            // 
            btnRunCache.Location = new Point(3, 3);
            btnRunCache.Name = "btnRunCache";
            btnRunCache.Size = new Size(75, 23);
            btnRunCache.TabIndex = 6;
            btnRunCache.Text = "Run";
            toolTip1.SetToolTip(btnRunCache, "Run everything in the cached list");
            btnRunCache.UseVisualStyleBackColor = true;
            btnRunCache.Click += btnRun_Click;
            // 
            // removeCache
            // 
            removeCache.Location = new Point(84, 3);
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
            // save
            // 
            save.Location = new Point(67, 1);
            save.Name = "save";
            save.Size = new Size(58, 23);
            save.TabIndex = 5;
            save.Text = ">>";
            toolTip1.SetToolTip(save, "Moved to cached list");
            save.UseVisualStyleBackColor = true;
            save.Click += save_Click;
            // 
            // shift
            // 
            shift.Location = new Point(5, 1);
            shift.Name = "shift";
            shift.Size = new Size(58, 23);
            shift.TabIndex = 8;
            shift.Text = "<<";
            toolTip1.SetToolTip(shift, "Move to immediate list");
            shift.UseVisualStyleBackColor = true;
            shift.Click += shift_Click;
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
            panel4.Controls.Add(shift);
            panel4.Controls.Add(save);
            panel4.Location = new Point(431, 5);
            panel4.Name = "panel4";
            panel4.Size = new Size(128, 27);
            panel4.TabIndex = 9;
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
        private Button save;
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
        private Button btnRunCache;
        private Button shift;
        private NotifyIcon runnerIcon;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem miRestore;
        private ToolStripMenuItem miExit;
        private Button btnRunImmediate;
        private Panel panel1;
        private SplitContainer splitContainer1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private ToolTip toolTip1;
    }
}
