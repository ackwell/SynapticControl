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
            this.panel_buttons = new System.Windows.Forms.Panel();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_ok = new System.Windows.Forms.Button();
            this.panel_actionEdit.SuspendLayout();
            this.panel_buttons.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_actionEdit
            // 
            this.panel_actionEdit.ColumnCount = 2;
            this.panel_actionEdit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.panel_actionEdit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panel_actionEdit.Controls.Add(this.label1, 0, 0);
            this.panel_actionEdit.Controls.Add(this.comboBox_action, 1, 0);
            this.panel_actionEdit.Controls.Add(this.panel_buttons, 0, 2);
            this.panel_actionEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_actionEdit.Location = new System.Drawing.Point(0, 0);
            this.panel_actionEdit.Name = "panel_actionEdit";
            this.panel_actionEdit.RowCount = 3;
            this.panel_actionEdit.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panel_actionEdit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panel_actionEdit.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panel_actionEdit.Size = new System.Drawing.Size(284, 261);
            this.panel_actionEdit.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
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
            this.comboBox_action.Location = new System.Drawing.Point(53, 5);
            this.comboBox_action.Margin = new System.Windows.Forms.Padding(3, 5, 5, 3);
            this.comboBox_action.Name = "comboBox_action";
            this.comboBox_action.Size = new System.Drawing.Size(226, 21);
            this.comboBox_action.TabIndex = 1;
            // 
            // panel_buttons
            // 
            this.panel_actionEdit.SetColumnSpan(this.panel_buttons, 2);
            this.panel_buttons.Controls.Add(this.button_ok);
            this.panel_buttons.Controls.Add(this.button_cancel);
            this.panel_buttons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_buttons.Location = new System.Drawing.Point(0, 231);
            this.panel_buttons.Margin = new System.Windows.Forms.Padding(0);
            this.panel_buttons.Name = "panel_buttons";
            this.panel_buttons.Padding = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.panel_buttons.Size = new System.Drawing.Size(284, 30);
            this.panel_buttons.TabIndex = 2;
            // 
            // button_cancel
            // 
            this.button_cancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_cancel.Location = new System.Drawing.Point(204, 0);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(75, 25);
            this.button_cancel.TabIndex = 0;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // button_ok
            // 
            this.button_ok.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_ok.Location = new System.Drawing.Point(129, 0);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(75, 25);
            this.button_ok.TabIndex = 1;
            this.button_ok.Text = "OK";
            this.button_ok.UseVisualStyleBackColor = true;
            this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
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
            this.panel_buttons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel panel_actionEdit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_action;
        private System.Windows.Forms.Panel panel_buttons;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button button_ok;
    }
}