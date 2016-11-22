namespace E1Parser {
    partial class MainWindow {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.eventsList = new System.Windows.Forms.DataGridView();
            this.addressField = new System.Windows.Forms.TextBox();
            this.browserButton = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.layoutManager = new System.Windows.Forms.TableLayoutPanel();
            this.addressLabel = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.place = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.eventsList)).BeginInit();
            this.layoutManager.SuspendLayout();
            this.SuspendLayout();
            // 
            // eventsList
            // 
            this.eventsList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.eventsList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.eventsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eventsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.date,
            this.place,
            this.name});
            this.layoutManager.SetColumnSpan(this.eventsList, 2);
            this.eventsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eventsList.Location = new System.Drawing.Point(4, 29);
            this.eventsList.Margin = new System.Windows.Forms.Padding(4);
            this.eventsList.Name = "eventsList";
            this.eventsList.RowHeadersWidth = 4;
            this.eventsList.Size = new System.Drawing.Size(904, 196);
            this.eventsList.TabIndex = 0;
            this.eventsList.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.eventsList_CellMouseUp);
            // 
            // addressField
            // 
            this.addressField.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.addressField.Location = new System.Drawing.Point(82, 275);
            this.addressField.Margin = new System.Windows.Forms.Padding(4);
            this.addressField.Name = "addressField";
            this.addressField.ReadOnly = true;
            this.addressField.Size = new System.Drawing.Size(826, 25);
            this.addressField.TabIndex = 1;
            // 
            // browserButton
            // 
            this.browserButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.browserButton.Location = new System.Drawing.Point(756, 430);
            this.browserButton.Margin = new System.Windows.Forms.Padding(4);
            this.browserButton.Name = "browserButton";
            this.browserButton.Size = new System.Drawing.Size(152, 33);
            this.browserButton.TabIndex = 2;
            this.browserButton.Text = "open with browser";
            this.browserButton.UseVisualStyleBackColor = true;
            this.browserButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.browserButton_MouseUp);
            // 
            // title
            // 
            this.layoutManager.SetColumnSpan(this.title, 2);
            this.title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.title.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.title.Location = new System.Drawing.Point(4, 0);
            this.title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(904, 25);
            this.title.TabIndex = 1;
            this.title.Text = "Ekaterinburg art events";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // layoutManager
            // 
            this.layoutManager.ColumnCount = 2;
            this.layoutManager.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 78F));
            this.layoutManager.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutManager.Controls.Add(this.title, 0, 0);
            this.layoutManager.Controls.Add(this.eventsList, 0, 1);
            this.layoutManager.Controls.Add(this.addressField, 1, 2);
            this.layoutManager.Controls.Add(this.addressLabel, 0, 2);
            this.layoutManager.Controls.Add(this.browserButton, 1, 3);
            this.layoutManager.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutManager.Location = new System.Drawing.Point(0, 0);
            this.layoutManager.Name = "layoutManager";
            this.layoutManager.RowCount = 4;
            this.layoutManager.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.layoutManager.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.33621F));
            this.layoutManager.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.8319F));
            this.layoutManager.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.8319F));
            this.layoutManager.Size = new System.Drawing.Size(912, 467);
            this.layoutManager.TabIndex = 4;
            // 
            // addressLabel
            // 
            this.addressLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(3, 279);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(72, 18);
            this.addressLabel.TabIndex = 3;
            this.addressLabel.Text = "address:";
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.id.HeaderText = "N";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 41;
            // 
            // date
            // 
            this.date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.date.HeaderText = "date";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            this.date.Width = 65;
            // 
            // place
            // 
            this.place.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.place.HeaderText = "place";
            this.place.Name = "place";
            this.place.ReadOnly = true;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.HeaderText = "event";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(912, 467);
            this.Controls.Add(this.layoutManager);
            this.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainWindow";
            this.Text = "E1Parser";
            ((System.ComponentModel.ISupportInitialize)(this.eventsList)).EndInit();
            this.layoutManager.ResumeLayout(false);
            this.layoutManager.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox addressField;
        private System.Windows.Forms.Button browserButton;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.DataGridView eventsList;
        private System.Windows.Forms.TableLayoutPanel layoutManager;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn place;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
    }
}

