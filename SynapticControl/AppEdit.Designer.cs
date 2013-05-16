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
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("3 Finger Flicks", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem("Up");
            System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem("Down");
            System.Windows.Forms.ListViewItem listViewItem11 = new System.Windows.Forms.ListViewItem("Left");
            System.Windows.Forms.ListViewItem listViewItem12 = new System.Windows.Forms.ListViewItem("Right");
            this.panel_appEdit = new System.Windows.Forms.TableLayoutPanel();
            this.panel_appDetails = new System.Windows.Forms.TableLayoutPanel();
            this.label_appKey = new System.Windows.Forms.Label();
            this.label_appExe = new System.Windows.Forms.Label();
            this.label_appMatchType = new System.Windows.Forms.Label();
            this.label_className = new System.Windows.Forms.Label();
            this.text_appClassName = new System.Windows.Forms.TextBox();
            this.text_appExe = new System.Windows.Forms.TextBox();
            this.text_appMatchType = new System.Windows.Forms.TextBox();
            this.text_appKey = new System.Windows.Forms.TextBox();
            this.listView_actions = new System.Windows.Forms.ListView();
            this.col_gesture = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_action = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel_buttons = new System.Windows.Forms.Panel();
            this.button_ok = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_edit = new System.Windows.Forms.Button();
            this.panel_appEdit.SuspendLayout();
            this.panel_appDetails.SuspendLayout();
            this.panel_buttons.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_appEdit
            // 
            this.panel_appEdit.ColumnCount = 1;
            this.panel_appEdit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panel_appEdit.Controls.Add(this.panel_appDetails, 0, 0);
            this.panel_appEdit.Controls.Add(this.listView_actions, 0, 1);
            this.panel_appEdit.Controls.Add(this.panel_buttons, 0, 2);
            this.panel_appEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_appEdit.Location = new System.Drawing.Point(0, 0);
            this.panel_appEdit.Name = "panel_appEdit";
            this.panel_appEdit.RowCount = 3;
            this.panel_appEdit.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panel_appEdit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panel_appEdit.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panel_appEdit.Size = new System.Drawing.Size(434, 511);
            this.panel_appEdit.TabIndex = 0;
            // 
            // panel_appDetails
            // 
            this.panel_appDetails.AutoSize = true;
            this.panel_appDetails.ColumnCount = 2;
            this.panel_appDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panel_appDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panel_appDetails.Controls.Add(this.label_appKey, 0, 0);
            this.panel_appDetails.Controls.Add(this.label_appExe, 1, 0);
            this.panel_appDetails.Controls.Add(this.label_appMatchType, 1, 2);
            this.panel_appDetails.Controls.Add(this.label_className, 0, 2);
            this.panel_appDetails.Controls.Add(this.text_appClassName, 0, 3);
            this.panel_appDetails.Controls.Add(this.text_appExe, 1, 1);
            this.panel_appDetails.Controls.Add(this.text_appMatchType, 1, 3);
            this.panel_appDetails.Controls.Add(this.text_appKey, 0, 1);
            this.panel_appDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_appDetails.Location = new System.Drawing.Point(3, 3);
            this.panel_appDetails.Name = "panel_appDetails";
            this.panel_appDetails.RowCount = 4;
            this.panel_appDetails.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panel_appDetails.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panel_appDetails.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panel_appDetails.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panel_appDetails.Size = new System.Drawing.Size(428, 88);
            this.panel_appDetails.TabIndex = 0;
            // 
            // label_appKey
            // 
            this.label_appKey.AutoSize = true;
            this.label_appKey.Location = new System.Drawing.Point(3, 5);
            this.label_appKey.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label_appKey.Name = "label_appKey";
            this.label_appKey.Size = new System.Drawing.Size(35, 13);
            this.label_appKey.TabIndex = 0;
            this.label_appKey.Text = "Name";
            // 
            // label_appExe
            // 
            this.label_appExe.AutoSize = true;
            this.label_appExe.Location = new System.Drawing.Point(217, 5);
            this.label_appExe.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label_appExe.Name = "label_appExe";
            this.label_appExe.Size = new System.Drawing.Size(60, 13);
            this.label_appExe.TabIndex = 1;
            this.label_appExe.Text = "Executable";
            // 
            // label_appMatchType
            // 
            this.label_appMatchType.AutoSize = true;
            this.label_appMatchType.Location = new System.Drawing.Point(217, 49);
            this.label_appMatchType.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label_appMatchType.Name = "label_appMatchType";
            this.label_appMatchType.Size = new System.Drawing.Size(80, 13);
            this.label_appMatchType.TabIndex = 3;
            this.label_appMatchType.Text = "AppMatchType";
            // 
            // label_className
            // 
            this.label_className.AutoSize = true;
            this.label_className.Location = new System.Drawing.Point(3, 49);
            this.label_className.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label_className.Name = "label_className";
            this.label_className.Size = new System.Drawing.Size(63, 13);
            this.label_className.TabIndex = 2;
            this.label_className.Text = "Class Name";
            // 
            // text_appClassName
            // 
            this.text_appClassName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.text_appClassName.Location = new System.Drawing.Point(3, 65);
            this.text_appClassName.Name = "text_appClassName";
            this.text_appClassName.Size = new System.Drawing.Size(208, 20);
            this.text_appClassName.TabIndex = 5;
            // 
            // text_appExe
            // 
            this.text_appExe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.text_appExe.Location = new System.Drawing.Point(217, 21);
            this.text_appExe.Name = "text_appExe";
            this.text_appExe.Size = new System.Drawing.Size(208, 20);
            this.text_appExe.TabIndex = 6;
            // 
            // text_appMatchType
            // 
            this.text_appMatchType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.text_appMatchType.Location = new System.Drawing.Point(217, 65);
            this.text_appMatchType.Name = "text_appMatchType";
            this.text_appMatchType.Size = new System.Drawing.Size(208, 20);
            this.text_appMatchType.TabIndex = 7;
            // 
            // text_appKey
            // 
            this.text_appKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.text_appKey.Enabled = false;
            this.text_appKey.Location = new System.Drawing.Point(3, 21);
            this.text_appKey.Name = "text_appKey";
            this.text_appKey.Size = new System.Drawing.Size(208, 20);
            this.text_appKey.TabIndex = 4;
            // 
            // listView_actions
            // 
            this.listView_actions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_gesture,
            this.col_action});
            this.listView_actions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView_actions.FullRowSelect = true;
            listViewGroup3.Header = "3 Finger Flicks";
            listViewGroup3.Name = "group_3FingerGestures";
            listViewGroup3.Tag = "3FingerGestures";
            this.listView_actions.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup3});
            listViewItem9.Group = listViewGroup3;
            listViewItem9.Tag = "ActionID1";
            listViewItem10.Group = listViewGroup3;
            listViewItem10.Tag = "ActionID5";
            listViewItem11.Group = listViewGroup3;
            listViewItem11.Tag = "ActionID7";
            listViewItem12.Group = listViewGroup3;
            listViewItem12.Tag = "ActionID3";
            this.listView_actions.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem9,
            listViewItem10,
            listViewItem11,
            listViewItem12});
            this.listView_actions.Location = new System.Drawing.Point(6, 100);
            this.listView_actions.Margin = new System.Windows.Forms.Padding(6, 6, 6, 3);
            this.listView_actions.MultiSelect = false;
            this.listView_actions.Name = "listView_actions";
            this.listView_actions.Size = new System.Drawing.Size(422, 378);
            this.listView_actions.TabIndex = 1;
            this.listView_actions.UseCompatibleStateImageBehavior = false;
            this.listView_actions.View = System.Windows.Forms.View.Details;
            this.listView_actions.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView_actions_MouseDoubleClick);
            // 
            // col_gesture
            // 
            this.col_gesture.Text = "Gesture";
            this.col_gesture.Width = 150;
            // 
            // col_action
            // 
            this.col_action.Text = "Action";
            this.col_action.Width = 100;
            // 
            // panel_buttons
            // 
            this.panel_buttons.Controls.Add(this.button_ok);
            this.panel_buttons.Controls.Add(this.button_cancel);
            this.panel_buttons.Controls.Add(this.button_edit);
            this.panel_buttons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_buttons.Location = new System.Drawing.Point(0, 481);
            this.panel_buttons.Margin = new System.Windows.Forms.Padding(0);
            this.panel_buttons.Name = "panel_buttons";
            this.panel_buttons.Padding = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.panel_buttons.Size = new System.Drawing.Size(434, 30);
            this.panel_buttons.TabIndex = 2;
            // 
            // button_ok
            // 
            this.button_ok.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_ok.Location = new System.Drawing.Point(279, 0);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(75, 25);
            this.button_ok.TabIndex = 2;
            this.button_ok.Text = "OK";
            this.button_ok.UseVisualStyleBackColor = true;
            this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_cancel.Location = new System.Drawing.Point(354, 0);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(75, 25);
            this.button_cancel.TabIndex = 1;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // button_edit
            // 
            this.button_edit.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_edit.Location = new System.Drawing.Point(5, 0);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(75, 25);
            this.button_edit.TabIndex = 0;
            this.button_edit.Text = "Edit";
            this.button_edit.UseVisualStyleBackColor = true;
            this.button_edit.Click += new System.EventHandler(this.button_edit_Click);
            // 
            // AppEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(434, 511);
            this.Controls.Add(this.panel_appEdit);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AppEdit";
            this.ShowInTaskbar = false;
            this.Text = "SynapticControl";
            this.Load += new System.EventHandler(this.AppEdit_Load);
            this.ResizeEnd += new System.EventHandler(this.AppEdit_ResizeEnd);
            this.panel_appEdit.ResumeLayout(false);
            this.panel_appEdit.PerformLayout();
            this.panel_appDetails.ResumeLayout(false);
            this.panel_appDetails.PerformLayout();
            this.panel_buttons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel panel_appEdit;
        private System.Windows.Forms.TableLayoutPanel panel_appDetails;
        private System.Windows.Forms.Label label_appKey;
        private System.Windows.Forms.Label label_appExe;
        private System.Windows.Forms.Label label_appMatchType;
        private System.Windows.Forms.Label label_className;
        private System.Windows.Forms.TextBox text_appKey;
        private System.Windows.Forms.TextBox text_appClassName;
        private System.Windows.Forms.TextBox text_appExe;
        private System.Windows.Forms.TextBox text_appMatchType;
        private System.Windows.Forms.ListView listView_actions;
        private System.Windows.Forms.ColumnHeader col_gesture;
        private System.Windows.Forms.ColumnHeader col_action;
        private System.Windows.Forms.Panel panel_buttons;
        private System.Windows.Forms.Button button_ok;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button button_edit;
    }
}