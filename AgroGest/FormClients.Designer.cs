namespace AgroGest
{
    partial class FormClients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClients));
            this.panelControlsRigth = new System.Windows.Forms.Panel();
            this.panelFilterMainFrame = new System.Windows.Forms.Panel();
            this.panelTabControl = new System.Windows.Forms.Panel();
            this.panelTabPage1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.buttonVisual = new System.Windows.Forms.Button();
            this.panelTabPage2 = new System.Windows.Forms.Panel();
            this.buttonMarkdown = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonApply = new System.Windows.Forms.Button();
            this.panelMenuTop = new System.Windows.Forms.Panel();
            this.panelDecorateSearch = new System.Windows.Forms.Panel();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.panelSeparatePanelRight = new System.Windows.Forms.Panel();
            this.dataGridViewClients = new System.Windows.Forms.DataGridView();
            this.pictureBoxVisual = new System.Windows.Forms.PictureBox();
            this.pictureBoxMarkdown = new System.Windows.Forms.PictureBox();
            this.pictureBoxSearch = new System.Windows.Forms.PictureBox();
            this.buttonAddClient = new System.Windows.Forms.Button();
            this.panelControlsRigth.SuspendLayout();
            this.panelTabControl.SuspendLayout();
            this.panelTabPage1.SuspendLayout();
            this.panelTabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelMenuTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVisual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMarkdown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControlsRigth
            // 
            this.panelControlsRigth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(20)))), ((int)(((byte)(85)))));
            this.panelControlsRigth.Controls.Add(this.panelFilterMainFrame);
            this.panelControlsRigth.Controls.Add(this.panelTabControl);
            this.panelControlsRigth.Controls.Add(this.panel1);
            this.panelControlsRigth.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControlsRigth.Location = new System.Drawing.Point(560, 48);
            this.panelControlsRigth.Name = "panelControlsRigth";
            this.panelControlsRigth.Padding = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.panelControlsRigth.Size = new System.Drawing.Size(200, 452);
            this.panelControlsRigth.TabIndex = 6;
            // 
            // panelFilterMainFrame
            // 
            this.panelFilterMainFrame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFilterMainFrame.Location = new System.Drawing.Point(10, 52);
            this.panelFilterMainFrame.Name = "panelFilterMainFrame";
            this.panelFilterMainFrame.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.panelFilterMainFrame.Size = new System.Drawing.Size(180, 355);
            this.panelFilterMainFrame.TabIndex = 44;
            // 
            // panelTabControl
            // 
            this.panelTabControl.Controls.Add(this.panelTabPage1);
            this.panelTabControl.Controls.Add(this.panelTabPage2);
            this.panelTabControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTabControl.Location = new System.Drawing.Point(10, 10);
            this.panelTabControl.Name = "panelTabControl";
            this.panelTabControl.Size = new System.Drawing.Size(180, 42);
            this.panelTabControl.TabIndex = 43;
            // 
            // panelTabPage1
            // 
            this.panelTabPage1.Controls.Add(this.panel5);
            this.panelTabPage1.Controls.Add(this.buttonVisual);
            this.panelTabPage1.Controls.Add(this.pictureBoxVisual);
            this.panelTabPage1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelTabPage1.Location = new System.Drawing.Point(0, 0);
            this.panelTabPage1.Name = "panelTabPage1";
            this.panelTabPage1.Size = new System.Drawing.Size(90, 42);
            this.panelTabPage1.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(0, 43);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(180, 100);
            this.panel5.TabIndex = 44;
            // 
            // buttonVisual
            // 
            this.buttonVisual.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonVisual.FlatAppearance.BorderSize = 0;
            this.buttonVisual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVisual.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVisual.ForeColor = System.Drawing.Color.DarkGray;
            this.buttonVisual.Location = new System.Drawing.Point(0, 0);
            this.buttonVisual.Name = "buttonVisual";
            this.buttonVisual.Size = new System.Drawing.Size(90, 37);
            this.buttonVisual.TabIndex = 13;
            this.buttonVisual.Tag = "Visual";
            this.buttonVisual.Text = "Visual";
            this.buttonVisual.UseVisualStyleBackColor = true;
            this.buttonVisual.Click += new System.EventHandler(this.menuLeftActionListener);
            // 
            // panelTabPage2
            // 
            this.panelTabPage2.Controls.Add(this.buttonMarkdown);
            this.panelTabPage2.Controls.Add(this.pictureBoxMarkdown);
            this.panelTabPage2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelTabPage2.Location = new System.Drawing.Point(90, 0);
            this.panelTabPage2.Name = "panelTabPage2";
            this.panelTabPage2.Size = new System.Drawing.Size(90, 42);
            this.panelTabPage2.TabIndex = 2;
            // 
            // buttonMarkdown
            // 
            this.buttonMarkdown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonMarkdown.FlatAppearance.BorderSize = 0;
            this.buttonMarkdown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMarkdown.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMarkdown.ForeColor = System.Drawing.Color.DarkGray;
            this.buttonMarkdown.Location = new System.Drawing.Point(0, 0);
            this.buttonMarkdown.Name = "buttonMarkdown";
            this.buttonMarkdown.Size = new System.Drawing.Size(90, 37);
            this.buttonMarkdown.TabIndex = 13;
            this.buttonMarkdown.Tag = "Markdown";
            this.buttonMarkdown.Text = "Markdown";
            this.buttonMarkdown.UseVisualStyleBackColor = true;
            this.buttonMarkdown.Click += new System.EventHandler(this.menuLeftActionListener);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonReset);
            this.panel1.Controls.Add(this.buttonApply);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(10, 407);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.panel1.Size = new System.Drawing.Size(180, 45);
            this.panel1.TabIndex = 41;
            // 
            // buttonReset
            // 
            this.buttonReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(122)))), ((int)(((byte)(153)))));
            this.buttonReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonReset.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonReset.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(92)))), ((int)(((byte)(255)))));
            this.buttonReset.FlatAppearance.BorderSize = 0;
            this.buttonReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReset.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReset.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonReset.Location = new System.Drawing.Point(100, 0);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(80, 35);
            this.buttonReset.TabIndex = 32;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = false;
            // 
            // buttonApply
            // 
            this.buttonApply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(122)))), ((int)(((byte)(153)))));
            this.buttonApply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonApply.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonApply.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(92)))), ((int)(((byte)(255)))));
            this.buttonApply.FlatAppearance.BorderSize = 0;
            this.buttonApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonApply.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonApply.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonApply.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonApply.Location = new System.Drawing.Point(0, 0);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(80, 35);
            this.buttonApply.TabIndex = 31;
            this.buttonApply.Text = "Apply";
            this.buttonApply.UseVisualStyleBackColor = false;
            // 
            // panelMenuTop
            // 
            this.panelMenuTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(16)))), ((int)(((byte)(72)))));
            this.panelMenuTop.Controls.Add(this.panelDecorateSearch);
            this.panelMenuTop.Controls.Add(this.textBoxSearch);
            this.panelMenuTop.Controls.Add(this.pictureBoxSearch);
            this.panelMenuTop.Controls.Add(this.buttonAddClient);
            this.panelMenuTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenuTop.Location = new System.Drawing.Point(0, 0);
            this.panelMenuTop.Name = "panelMenuTop";
            this.panelMenuTop.Padding = new System.Windows.Forms.Padding(0, 0, 0, 15);
            this.panelMenuTop.Size = new System.Drawing.Size(760, 48);
            this.panelMenuTop.TabIndex = 5;
            // 
            // panelDecorateSearch
            // 
            this.panelDecorateSearch.BackColor = System.Drawing.Color.DimGray;
            this.panelDecorateSearch.Location = new System.Drawing.Point(30, 24);
            this.panelDecorateSearch.Name = "panelDecorateSearch";
            this.panelDecorateSearch.Size = new System.Drawing.Size(240, 1);
            this.panelDecorateSearch.TabIndex = 22;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(16)))), ((int)(((byte)(72)))));
            this.textBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSearch.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxSearch.Location = new System.Drawing.Point(30, 0);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(240, 20);
            this.textBoxSearch.TabIndex = 12;
            this.textBoxSearch.Text = "Search...";
            // 
            // panelSeparatePanelRight
            // 
            this.panelSeparatePanelRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(16)))), ((int)(((byte)(72)))));
            this.panelSeparatePanelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelSeparatePanelRight.Location = new System.Drawing.Point(541, 48);
            this.panelSeparatePanelRight.Name = "panelSeparatePanelRight";
            this.panelSeparatePanelRight.Size = new System.Drawing.Size(19, 452);
            this.panelSeparatePanelRight.TabIndex = 8;
            // 
            // dataGridViewClients
            // 
            this.dataGridViewClients.AllowUserToAddRows = false;
            this.dataGridViewClients.AllowUserToDeleteRows = false;
            this.dataGridViewClients.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(20)))), ((int)(((byte)(85)))));
            this.dataGridViewClients.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewClients.Location = new System.Drawing.Point(0, 48);
            this.dataGridViewClients.Name = "dataGridViewClients";
            this.dataGridViewClients.ReadOnly = true;
            this.dataGridViewClients.RowHeadersVisible = false;
            this.dataGridViewClients.ShowCellErrors = false;
            this.dataGridViewClients.ShowCellToolTips = false;
            this.dataGridViewClients.ShowEditingIcon = false;
            this.dataGridViewClients.ShowRowErrors = false;
            this.dataGridViewClients.Size = new System.Drawing.Size(541, 452);
            this.dataGridViewClients.TabIndex = 9;
            // 
            // pictureBoxVisual
            // 
            this.pictureBoxVisual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(122)))), ((int)(((byte)(153)))));
            this.pictureBoxVisual.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBoxVisual.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBoxVisual.Enabled = false;
            this.pictureBoxVisual.InitialImage = null;
            this.pictureBoxVisual.Location = new System.Drawing.Point(0, 37);
            this.pictureBoxVisual.Name = "pictureBoxVisual";
            this.pictureBoxVisual.Size = new System.Drawing.Size(90, 5);
            this.pictureBoxVisual.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxVisual.TabIndex = 12;
            this.pictureBoxVisual.TabStop = false;
            // 
            // pictureBoxMarkdown
            // 
            this.pictureBoxMarkdown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(122)))), ((int)(((byte)(153)))));
            this.pictureBoxMarkdown.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBoxMarkdown.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBoxMarkdown.Enabled = false;
            this.pictureBoxMarkdown.InitialImage = null;
            this.pictureBoxMarkdown.Location = new System.Drawing.Point(0, 37);
            this.pictureBoxMarkdown.Name = "pictureBoxMarkdown";
            this.pictureBoxMarkdown.Size = new System.Drawing.Size(90, 5);
            this.pictureBoxMarkdown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMarkdown.TabIndex = 12;
            this.pictureBoxMarkdown.TabStop = false;
            // 
            // pictureBoxSearch
            // 
            this.pictureBoxSearch.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxSearch.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBoxSearch.Enabled = false;
            this.pictureBoxSearch.Image = global::AgroGest.Properties.Resources.search;
            this.pictureBoxSearch.InitialImage = null;
            this.pictureBoxSearch.Location = new System.Drawing.Point(10, 1);
            this.pictureBoxSearch.Name = "pictureBoxSearch";
            this.pictureBoxSearch.Size = new System.Drawing.Size(15, 15);
            this.pictureBoxSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSearch.TabIndex = 11;
            this.pictureBoxSearch.TabStop = false;
            // 
            // buttonAddClient
            // 
            this.buttonAddClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(122)))), ((int)(((byte)(153)))));
            this.buttonAddClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddClient.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonAddClient.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(92)))), ((int)(((byte)(255)))));
            this.buttonAddClient.FlatAppearance.BorderSize = 0;
            this.buttonAddClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddClient.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddClient.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonAddClient.Image = global::AgroGest.Properties.Resources.aside_add;
            this.buttonAddClient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddClient.Location = new System.Drawing.Point(614, 0);
            this.buttonAddClient.Name = "buttonAddClient";
            this.buttonAddClient.Size = new System.Drawing.Size(146, 33);
            this.buttonAddClient.TabIndex = 0;
            this.buttonAddClient.Tag = "AddClient";
            this.buttonAddClient.Text = "Add New Client";
            this.buttonAddClient.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAddClient.UseVisualStyleBackColor = false;
            // 
            // FormClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(16)))), ((int)(((byte)(72)))));
            this.ClientSize = new System.Drawing.Size(760, 500);
            this.Controls.Add(this.dataGridViewClients);
            this.Controls.Add(this.panelSeparatePanelRight);
            this.Controls.Add(this.panelControlsRigth);
            this.Controls.Add(this.panelMenuTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormClients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormClients";
            this.panelControlsRigth.ResumeLayout(false);
            this.panelTabControl.ResumeLayout(false);
            this.panelTabPage1.ResumeLayout(false);
            this.panelTabPage2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panelMenuTop.ResumeLayout(false);
            this.panelMenuTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVisual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMarkdown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelControlsRigth;
        private System.Windows.Forms.Panel panelMenuTop;
        private System.Windows.Forms.Panel panelDecorateSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.PictureBox pictureBoxSearch;
        private System.Windows.Forms.Button buttonAddClient;
        private System.Windows.Forms.Panel panelSeparatePanelRight;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.Panel panelTabControl;
        private System.Windows.Forms.Panel panelTabPage1;
        private System.Windows.Forms.PictureBox pictureBoxVisual;
        private System.Windows.Forms.Panel panelTabPage2;
        private System.Windows.Forms.PictureBox pictureBoxMarkdown;
        private System.Windows.Forms.Button buttonVisual;
        private System.Windows.Forms.Button buttonMarkdown;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panelFilterMainFrame;
        private System.Windows.Forms.DataGridView dataGridViewClients;
    }
}