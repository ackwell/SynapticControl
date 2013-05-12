namespace SynapticControl
{
    partial class Main
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
            this.panel_main = new System.Windows.Forms.TableLayoutPanel();
            this.listView_apps = new System.Windows.Forms.ListView();
            this.col_appName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_appExe = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_appClassName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_appMatchType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_main
            // 
            this.panel_main.ColumnCount = 3;
            this.panel_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panel_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panel_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panel_main.Controls.Add(this.listView_apps, 0, 0);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(5, 5);
            this.panel_main.Name = "panel_main";
            this.panel_main.RowCount = 2;
            this.panel_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panel_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panel_main.Size = new System.Drawing.Size(560, 505);
            this.panel_main.TabIndex = 0;
            // 
            // listView_apps
            // 
            this.listView_apps.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_appName,
            this.col_appExe,
            this.col_appClassName,
            this.col_appMatchType});
            this.panel_main.SetColumnSpan(this.listView_apps, 3);
            this.listView_apps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView_apps.Location = new System.Drawing.Point(0, 0);
            this.listView_apps.Margin = new System.Windows.Forms.Padding(0);
            this.listView_apps.Name = "listView_apps";
            this.listView_apps.Size = new System.Drawing.Size(560, 252);
            this.listView_apps.TabIndex = 0;
            this.listView_apps.UseCompatibleStateImageBehavior = false;
            this.listView_apps.View = System.Windows.Forms.View.Details;
            // 
            // col_appName
            // 
            this.col_appName.Text = "Application";
            this.col_appName.Width = 100;
            // 
            // col_appExe
            // 
            this.col_appExe.Text = "Executable";
            this.col_appExe.Width = 100;
            // 
            // col_appClassName
            // 
            this.col_appClassName.Text = "Class Name";
            this.col_appClassName.Width = 100;
            // 
            // col_appMatchType
            // 
            this.col_appMatchType.Text = "AppMatchType";
            this.col_appMatchType.Width = 100;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 515);
            this.Controls.Add(this.panel_main);
            this.Name = "Main";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = " SynapticsControl";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResizeEnd += new System.EventHandler(this.Main_ResizeEnd);
            this.panel_main.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel panel_main;
        private System.Windows.Forms.ListView listView_apps;
        private System.Windows.Forms.ColumnHeader col_appName;
        private System.Windows.Forms.ColumnHeader col_appExe;
        private System.Windows.Forms.ColumnHeader col_appClassName;
        private System.Windows.Forms.ColumnHeader col_appMatchType;


    }
}

