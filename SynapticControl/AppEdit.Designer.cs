namespace SynapticControl
{
    partial class AppEdit
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
            this.panel_appEdit = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // panel_appEdit
            // 
            this.panel_appEdit.ColumnCount = 1;
            this.panel_appEdit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panel_appEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_appEdit.Location = new System.Drawing.Point(0, 0);
            this.panel_appEdit.Name = "panel_appEdit";
            this.panel_appEdit.RowCount = 2;
            this.panel_appEdit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panel_appEdit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panel_appEdit.Size = new System.Drawing.Size(661, 587);
            this.panel_appEdit.TabIndex = 0;
            // 
            // AppEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 587);
            this.Controls.Add(this.panel_appEdit);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AppEdit";
            this.ShowInTaskbar = false;
            this.Text = "SynapticControl - ";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel panel_appEdit;
    }
}