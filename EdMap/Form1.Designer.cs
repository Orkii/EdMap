
namespace EdMap {
    partial class Form1 {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent() {
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.LoadCapacityNUD = new System.Windows.Forms.NumericUpDown();
            this.storageButtonAdd = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.distanceLable = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.label3 = new System.Windows.Forms.Label();
            this.getPathButton = new System.Windows.Forms.Button();
            this.loadPanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LoadCapacityNUD)).BeginInit();
            this.loadPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // gMapControl1
            // 
            this.gMapControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.LevelsKeepInMemory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(230, 12);
            this.gMapControl1.MarkersEnabled = true;
            this.gMapControl1.MaxZoom = 2;
            this.gMapControl1.MinZoom = 2;
            this.gMapControl1.MouseWheelZoomEnabled = true;
            this.gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl1.Name = "gMapControl1";
            this.gMapControl1.NegativeMode = false;
            this.gMapControl1.PolygonsEnabled = true;
            this.gMapControl1.RetryLoadTile = 0;
            this.gMapControl1.RoutesEnabled = true;
            this.gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl1.ShowTileGridLines = false;
            this.gMapControl1.Size = new System.Drawing.Size(1066, 935);
            this.gMapControl1.TabIndex = 0;
            this.gMapControl1.Zoom = 0D;
            this.gMapControl1.OnMapClick += new GMap.NET.WindowsForms.MapClick(this.gMapControl1_OnMapClick);
            this.gMapControl1.Load += new System.EventHandler(this.gMapControl1_Load_1);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.LoadCapacityNUD);
            this.panel1.Controls.Add(this.storageButtonAdd);
            this.panel1.Controls.Add(this.clearButton);
            this.panel1.Controls.Add(this.addButton);
            this.panel1.Controls.Add(this.distanceLable);
            this.panel1.Controls.Add(this.treeView1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.getPathButton);
            this.panel1.Location = new System.Drawing.Point(14, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(210, 933);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "label";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(3, 25);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(202, 35);
            this.progressBar1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 135);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Грузоподъемность:";
            // 
            // LoadCapacityNUD
            // 
            this.LoadCapacityNUD.Location = new System.Drawing.Point(3, 160);
            this.LoadCapacityNUD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LoadCapacityNUD.Name = "LoadCapacityNUD";
            this.LoadCapacityNUD.Size = new System.Drawing.Size(202, 26);
            this.LoadCapacityNUD.TabIndex = 11;
            // 
            // storageButtonAdd
            // 
            this.storageButtonAdd.Location = new System.Drawing.Point(3, 100);
            this.storageButtonAdd.Name = "storageButtonAdd";
            this.storageButtonAdd.Size = new System.Drawing.Size(202, 32);
            this.storageButtonAdd.TabIndex = 10;
            this.storageButtonAdd.Text = "Добавить склад";
            this.storageButtonAdd.UseVisualStyleBackColor = true;
            this.storageButtonAdd.Click += new System.EventHandler(this.storageButtonAdd_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(3, 584);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(202, 32);
            this.clearButton.TabIndex = 9;
            this.clearButton.Text = "Очистить";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(3, 62);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(202, 32);
            this.addButton.TabIndex = 8;
            this.addButton.Text = "Добавить точку";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // distanceLable
            // 
            this.distanceLable.AutoSize = true;
            this.distanceLable.Location = new System.Drawing.Point(104, 38);
            this.distanceLable.Name = "distanceLable";
            this.distanceLable.Size = new System.Drawing.Size(18, 20);
            this.distanceLable.TabIndex = 7;
            this.distanceLable.Text = "0";
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(3, 270);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(202, 308);
            this.treeView1.TabIndex = 6;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Растояние:";
            // 
            // getPathButton
            // 
            this.getPathButton.Location = new System.Drawing.Point(3, 3);
            this.getPathButton.Name = "getPathButton";
            this.getPathButton.Size = new System.Drawing.Size(202, 32);
            this.getPathButton.TabIndex = 0;
            this.getPathButton.Text = "Посчитать";
            this.getPathButton.UseVisualStyleBackColor = true;
            this.getPathButton.Click += new System.EventHandler(this.getPathButton_Click);
            // 
            // loadPanel
            // 
            this.loadPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loadPanel.Controls.Add(this.label2);
            this.loadPanel.Controls.Add(this.progressBar1);
            this.loadPanel.Location = new System.Drawing.Point(14, 207);
            this.loadPanel.Name = "loadPanel";
            this.loadPanel.Size = new System.Drawing.Size(210, 70);
            this.loadPanel.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 619);
            this.label4.MaximumSize = new System.Drawing.Size(200, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "label4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1308, 958);
            this.Controls.Add(this.loadPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gMapControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LoadCapacityNUD)).EndInit();
            this.loadPanel.ResumeLayout(false);
            this.loadPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button getPathButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label distanceLable;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button storageButtonAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown LoadCapacityNUD;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel loadPanel;
        private System.Windows.Forms.Label label4;
    }
}

