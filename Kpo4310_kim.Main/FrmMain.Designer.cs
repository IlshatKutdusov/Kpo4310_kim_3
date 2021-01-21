namespace Kpo4310.kim.Main
{
    partial class FrmMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.MMenu = new System.Windows.Forms.MenuStrip();
            this.mmFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mmAccessory = new System.Windows.Forms.ToolStripMenuItem();
            this.mnOpenAccessory = new System.Windows.Forms.ToolStripMenuItem();
            this.SStatus = new System.Windows.Forms.StatusStrip();
            this.dgvMockAccessoryListCommand = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.mnSave = new System.Windows.Forms.ToolStripMenuItem();
            this.MMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMockAccessoryListCommand)).BeginInit();
            this.SuspendLayout();
            // 
            // MMenu
            // 
            this.MMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mmFile,
            this.mmAccessory});
            this.MMenu.Location = new System.Drawing.Point(0, 0);
            this.MMenu.Name = "MMenu";
            this.MMenu.Size = new System.Drawing.Size(800, 24);
            this.MMenu.TabIndex = 0;
            this.MMenu.Text = "menuStrip1";
            // 
            // mmFile
            // 
            this.mmFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnOpen,
            this.mnSave,
            this.mnExit});
            this.mmFile.Name = "mmFile";
            this.mmFile.Size = new System.Drawing.Size(57, 20);
            this.mmFile.Text = "1&.Файл";
            // 
            // mnOpen
            // 
            this.mnOpen.Name = "mnOpen";
            this.mnOpen.Size = new System.Drawing.Size(180, 22);
            this.mnOpen.Text = "Открыть";
            this.mnOpen.Click += new System.EventHandler(this.mnOpen_Click);
            // 
            // mnExit
            // 
            this.mnExit.Name = "mnExit";
            this.mnExit.Size = new System.Drawing.Size(180, 22);
            this.mnExit.Text = "Выход";
            this.mnExit.Click += new System.EventHandler(this.mnExit_Click);
            // 
            // mmAccessory
            // 
            this.mmAccessory.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnOpenAccessory});
            this.mmAccessory.Name = "mmAccessory";
            this.mmAccessory.Size = new System.Drawing.Size(122, 20);
            this.mmAccessory.Text = "2&.Комплектующие";
            // 
            // mnOpenAccessory
            // 
            this.mnOpenAccessory.Name = "mnOpenAccessory";
            this.mnOpenAccessory.Size = new System.Drawing.Size(216, 22);
            this.mnOpenAccessory.Text = "Открыть комплектующее";
            this.mnOpenAccessory.Click += new System.EventHandler(this.mnOpenAccessory_Click);
            // 
            // SStatus
            // 
            this.SStatus.Location = new System.Drawing.Point(0, 428);
            this.SStatus.Name = "SStatus";
            this.SStatus.Size = new System.Drawing.Size(800, 22);
            this.SStatus.TabIndex = 1;
            this.SStatus.Text = "statusStrip1";
            // 
            // dgvMockAccessoryListCommand
            // 
            this.dgvMockAccessoryListCommand.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMockAccessoryListCommand.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMockAccessoryListCommand.Location = new System.Drawing.Point(0, 24);
            this.dgvMockAccessoryListCommand.Name = "dgvMockAccessoryListCommand";
            this.dgvMockAccessoryListCommand.Size = new System.Drawing.Size(800, 404);
            this.dgvMockAccessoryListCommand.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 406);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // mnSave
            // 
            this.mnSave.Name = "mnSave";
            this.mnSave.Size = new System.Drawing.Size(180, 22);
            this.mnSave.Text = "Сохранить";
            this.mnSave.Click += new System.EventHandler(this.mnSave_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvMockAccessoryListCommand);
            this.Controls.Add(this.SStatus);
            this.Controls.Add(this.MMenu);
            this.MainMenuStrip = this.MMenu;
            this.Name = "FrmMain";
            this.Text = "КПО:4310:Вдовичев";
            this.MMenu.ResumeLayout(false);
            this.MMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMockAccessoryListCommand)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MMenu;
        private System.Windows.Forms.ToolStripMenuItem mmFile;
        private System.Windows.Forms.ToolStripMenuItem mnExit;
        private System.Windows.Forms.ToolStripMenuItem mnOpen;
        private System.Windows.Forms.StatusStrip SStatus;
        private System.Windows.Forms.DataGridView dgvMockAccessoryListCommand;
        private System.Windows.Forms.ToolStripMenuItem mmAccessory;
        private System.Windows.Forms.ToolStripMenuItem mnOpenAccessory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem mnSave;
    }
}

