namespace RSL.Views
{
    partial class WorkView
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.scenePage = new System.Windows.Forms.TabPage();
            this.plotPage = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.inspectorPage = new System.Windows.Forms.TabPage();
            this.generatorPage = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pauseButton = new System.Windows.Forms.Button();
            this.playButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tabControl2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tabControl1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(844, 498);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tabControl2
            // 
            this.tabControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl2.Controls.Add(this.scenePage);
            this.tabControl2.Controls.Add(this.plotPage);
            this.tabControl2.Location = new System.Drawing.Point(203, 48);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(638, 447);
            this.tabControl2.TabIndex = 1;
            // 
            // scenePage
            // 
            this.scenePage.Location = new System.Drawing.Point(4, 22);
            this.scenePage.Name = "scenePage";
            this.scenePage.Padding = new System.Windows.Forms.Padding(3);
            this.scenePage.Size = new System.Drawing.Size(630, 416);
            this.scenePage.TabIndex = 0;
            this.scenePage.Text = "Scene";
            this.scenePage.UseVisualStyleBackColor = true;
            // 
            // plotPage
            // 
            this.plotPage.Location = new System.Drawing.Point(4, 22);
            this.plotPage.Name = "plotPage";
            this.plotPage.Padding = new System.Windows.Forms.Padding(3);
            this.plotPage.Size = new System.Drawing.Size(630, 421);
            this.plotPage.TabIndex = 1;
            this.plotPage.Text = "Plot";
            this.plotPage.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.inspectorPage);
            this.tabControl1.Controls.Add(this.generatorPage);
            this.tabControl1.Location = new System.Drawing.Point(3, 48);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(194, 447);
            this.tabControl1.TabIndex = 0;
            // 
            // inspectorPage
            // 
            this.inspectorPage.Location = new System.Drawing.Point(4, 22);
            this.inspectorPage.Name = "inspectorPage";
            this.inspectorPage.Padding = new System.Windows.Forms.Padding(3);
            this.inspectorPage.Size = new System.Drawing.Size(186, 421);
            this.inspectorPage.TabIndex = 0;
            this.inspectorPage.Text = "Inspector";
            this.inspectorPage.UseVisualStyleBackColor = true;
            // 
            // generatorPage
            // 
            this.generatorPage.Location = new System.Drawing.Point(4, 22);
            this.generatorPage.Name = "generatorPage";
            this.generatorPage.Padding = new System.Windows.Forms.Padding(3);
            this.generatorPage.Size = new System.Drawing.Size(413, 440);
            this.generatorPage.TabIndex = 1;
            this.generatorPage.Text = "Generator";
            this.generatorPage.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.groupBox1, 2);
            this.groupBox1.Controls.Add(this.pauseButton);
            this.groupBox1.Controls.Add(this.playButton);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(838, 39);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // pauseButton
            // 
            this.pauseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pauseButton.Location = new System.Drawing.Point(424, 11);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(99, 22);
            this.pauseButton.TabIndex = 1;
            this.pauseButton.Text = "Pause";
            this.pauseButton.UseVisualStyleBackColor = true;
            // 
            // playButton
            // 
            this.playButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.playButton.Location = new System.Drawing.Point(318, 11);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(100, 22);
            this.playButton.TabIndex = 0;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = true;
            // 
            // WorkView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "WorkView";
            this.Size = new System.Drawing.Size(844, 498);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage inspectorPage;
        private System.Windows.Forms.TabPage generatorPage;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage scenePage;
        private System.Windows.Forms.TabPage plotPage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button pauseButton;
        private System.Windows.Forms.Button playButton;
    }
}
