namespace LAPSRunner
{
    partial class NewItem
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
            txtName = new TextBox();
            numInstanceCount = new NumericUpDown();
            cPath = new Label();
            lblInstanceCount = new Label();
            btnDone = new Button();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)numInstanceCount).BeginInit();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(141, 28);
            txtName.Name = "txtName";
            txtName.Size = new Size(120, 23);
            txtName.TabIndex = 0;
            // 
            // numInstanceCount
            // 
            numInstanceCount.Location = new Point(141, 57);
            numInstanceCount.Name = "numInstanceCount";
            numInstanceCount.Size = new Size(120, 23);
            numInstanceCount.TabIndex = 1;
            // 
            // cPath
            // 
            cPath.AutoSize = true;
            cPath.Location = new Point(58, 31);
            cPath.Name = "cPath";
            cPath.Size = new Size(39, 15);
            cPath.TabIndex = 2;
            cPath.Text = "Name";
            // 
            // lblInstanceCount
            // 
            lblInstanceCount.AutoSize = true;
            lblInstanceCount.Location = new Point(10, 59);
            lblInstanceCount.Name = "lblInstanceCount";
            lblInstanceCount.Size = new Size(87, 15);
            lblInstanceCount.TabIndex = 3;
            lblInstanceCount.Text = "Instance Count";
            // 
            // btnDone
            // 
            btnDone.DialogResult = DialogResult.OK;
            btnDone.Location = new Point(75, 104);
            btnDone.Name = "btnDone";
            btnDone.Size = new Size(75, 23);
            btnDone.TabIndex = 4;
            btnDone.Text = "Done";
            btnDone.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(156, 104);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // NewItem
            // 
            AcceptButton = btnDone;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(293, 139);
            Controls.Add(btnCancel);
            Controls.Add(btnDone);
            Controls.Add(lblInstanceCount);
            Controls.Add(cPath);
            Controls.Add(numInstanceCount);
            Controls.Add(txtName);
            Name = "NewItem";
            Text = "Edit Item";
            ((System.ComponentModel.ISupportInitialize)numInstanceCount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label cPath;
        private Label lblInstanceCount;
        private Button btnDone;
        private Button btnCancel;
        public TextBox txtName;
        public NumericUpDown numInstanceCount;
    }
}