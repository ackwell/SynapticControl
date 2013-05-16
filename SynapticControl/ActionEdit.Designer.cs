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
            this.SuspendLayout();
            // 
            // panel_actionEdit
            // 
            this.panel_actionEdit.ColumnCount = 2;
            this.panel_actionEdit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panel_actionEdit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panel_actionEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_actionEdit.Location = new System.Drawing.Point(0, 0);
            this.panel_actionEdit.Name = "panel_actionEdit";
            this.panel_actionEdit.RowCount = 2;
            this.panel_actionEdit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panel_actionEdit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panel_actionEdit.Size = new System.Drawing.Size(284, 261);
            this.panel_actionEdit.TabIndex = 0;
            // 
            // ActionEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.panel_actionEdit);
            this.Name = "ActionEdit";
            this.Text = "ActionEdit";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel panel_actionEdit;
    }
}