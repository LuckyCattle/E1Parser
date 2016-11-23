namespace E1Parser {
    partial class StartForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            this.layoutManager = new System.Windows.Forms.TableLayoutPanel();
            this.title = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.tickTacker = new System.ComponentModel.BackgroundWorker();
            this.mvcStarter = new System.ComponentModel.BackgroundWorker();
            this.terminateButton = new System.Windows.Forms.Button();
            this.layoutManager.SuspendLayout();
            this.SuspendLayout();
            // 
            // layoutManager
            // 
            this.layoutManager.ColumnCount = 1;
            this.layoutManager.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutManager.Controls.Add(this.title, 0, 0);
            this.layoutManager.Controls.Add(this.progressBar, 0, 1);
            this.layoutManager.Controls.Add(this.terminateButton, 0, 2);
            this.layoutManager.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutManager.Location = new System.Drawing.Point(0, 0);
            this.layoutManager.Name = "layoutManager";
            this.layoutManager.RowCount = 3;
            this.layoutManager.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutManager.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutManager.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.layoutManager.Size = new System.Drawing.Size(444, 115);
            this.layoutManager.TabIndex = 0;
            // 
            // title
            // 
            this.title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.title.Location = new System.Drawing.Point(134, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(176, 18);
            this.title.TabIndex = 0;
            this.title.Text = "loading data from web";
            // 
            // progressBar
            // 
            this.progressBar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.progressBar.Location = new System.Drawing.Point(58, 39);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(328, 30);
            this.progressBar.Step = 5;
            this.progressBar.TabIndex = 1;
            // 
            // tickTacker
            // 
            this.tickTacker.WorkerSupportsCancellation = true;
            // 
            // mvcStarter
            // 
            this.mvcStarter.WorkerSupportsCancellation = true;
            // 
            // terminateButton
            // 
            this.terminateButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.terminateButton.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.terminateButton.Location = new System.Drawing.Point(178, 79);
            this.terminateButton.Name = "terminateButton";
            this.terminateButton.Size = new System.Drawing.Size(87, 29);
            this.terminateButton.TabIndex = 2;
            this.terminateButton.Text = "cancel";
            this.terminateButton.UseVisualStyleBackColor = true;
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 115);
            this.ControlBox = false;
            this.Controls.Add(this.layoutManager);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StartForm";
            this.Text = "E1Parser";
            this.Shown += new System.EventHandler(this.StartForm_Shown);
            this.layoutManager.ResumeLayout(false);
            this.layoutManager.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel layoutManager;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.ComponentModel.BackgroundWorker tickTacker;
        private System.ComponentModel.BackgroundWorker mvcStarter;
        private System.Windows.Forms.Button terminateButton;
    }
}