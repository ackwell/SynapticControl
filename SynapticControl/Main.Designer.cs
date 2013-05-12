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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_main
            // 
            this.panel_main.ColumnCount = 3;
            this.panel_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.panel_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panel_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.panel_main.Controls.Add(this.listView_apps, 0, 0);
            this.panel_main.Controls.Add(this.button1, 0, 1);
            this.panel_main.Controls.Add(this.button2, 1, 1);
            this.panel_main.Controls.Add(this.button3, 2, 1);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(5, 5);
            this.panel_main.Name = "panel_main";
            this.panel_main.RowCount = 2;
            this.panel_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panel_main.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panel_main.Size = new System.Drawing.Size(560, 505);
            this.panel_main.TabIndex = 0;
            // 
            // listView_apps
            // 
            this.listView_apps.BackColor = System.Drawing.SystemColors.Window;
            this.listView_apps.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_appName,
            this.col_appExe,
            this.col_appClassName,
            this.col_appMatchType});
            this.panel_main.SetColumnSpan(this.listView_apps, 3);
            this.listView_apps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView_apps.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView_apps.Location = new System.Drawing.Point(0, 0);
            this.listView_apps.Margin = new System.Windows.Forms.Padding(0);
            this.listView_apps.Name = "listView_apps";
            this.listView_apps.Size = new System.Drawing.Size(560, 476);
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 479);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.Location = new System.Drawing.Point(242, 479);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(482, 479);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 515);
            this.Controls.Add(this.panel_main);
            this.Name = "Main";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "SynapticsControl";
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;


    }
}

