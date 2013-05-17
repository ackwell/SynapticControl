namespace SynapticControl
{
    partial class ActionEdit
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
            this.panel_actionEdit = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_action = new System.Windows.Forms.ComboBox();
            this.panel_actionEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_actionEdit
            // 
            this.panel_actionEdit.ColumnCount = 2;
            this.panel_actionEdit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.panel_actionEdit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panel_actionEdit.Controls.Add(this.label1, 0, 0);
            this.panel_actionEdit.Controls.Add(this.comboBox_action, 1, 0);
            this.panel_actionEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_actionEdit.Location = new System.Drawing.Point(0, 0);
            this.panel_actionEdit.Name = "panel_actionEdit";
            this.panel_actionEdit.RowCount = 2;
            this.panel_actionEdit.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panel_actionEdit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panel_actionEdit.Size = new System.Drawing.Size(284, 261);
            this.panel_actionEdit.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Action:";
            // 
            // comboBox_action
            // 
            this.comboBox_action.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_action.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_action.FormattingEnabled = true;
            this.comboBox_action.Location = new System.Drawing.Point(49, 3);
            this.comboBox_action.Name = "comboBox_action";
            this.comboBox_action.Size = new System.Drawing.Size(232, 21);
            this.comboBox_action.TabIndex = 1;
            // 
            // ActionEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.panel_actionEdit);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ActionEdit";
            this.ShowInTaskbar = false;
            this.Text = "ActionEdit";
            this.Load += new System.EventHandler(this.ActionEdit_Load);
            this.panel_actionEdit.ResumeLayout(false);
            this.panel_actionEdit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel panel_actionEdit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_action;
    }
}