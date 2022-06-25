
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
            this.label1 = new System.Windows.Forms.Label();
            this.LoadCapacityNUD = new System.Windows.Forms.NumericUpDown();
            this.storageButtonAdd = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.distanceLable = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.label3 = new System.Windows.Forms.Label();
            this.getPathButton = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LoadCapacityNUD)).BeginInit();
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
            this.gMapControl1.Location = new System.Drawing.Point(153, 8);
            this.gMapControl1.Margin = new System.Windows.Forms.Padding(2);
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
            this.gMapControl1.Size = new System.Drawing.Size(631, 523);
            this.gMapControl1.TabIndex = 0;
            this.gMapControl1.Zoom = 0D;
            this.gMapControl1.OnMapClick += new GMap.NET.WindowsForms.MapClick(this.gMapControl1_OnMapClick);
            this.gMapControl1.Load += new System.EventHandler(this.gMapControl1_Load_1);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.progressBar1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.LoadCapacityNUD);
            this.panel1.Controls.Add(this.storageButtonAdd);
            this.panel1.Controls.Add(this.clearButton);
            this.panel1.Controls.Add(this.addButton);
            this.panel1.Controls.Add(this.distanceLable);
            this.panel1.Controls.Add(this.treeView1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.getPathButton);
            this.panel1.Location = new System.Drawing.Point(9, 8);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(140, 522);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Грузоподъемность:";
            // 
            // LoadCapacityNUD
            // 
            this.LoadCapacityNUD.Location = new System.Drawing.Point(5, 110);
            this.LoadCapacityNUD.Name = "LoadCapacityNUD";
            this.LoadCapacityNUD.Size = new System.Drawing.Size(132, 20);
            this.LoadCapacityNUD.TabIndex = 11;
            // 
            // storageButtonAdd
            // 
            this.storageButtonAdd.Location = new System.Drawing.Point(2, 65);
            this.storageButtonAdd.Margin = new System.Windows.Forms.Padding(2);
            this.storageButtonAdd.Name = "storageButtonAdd";
            this.storageButtonAdd.Size = new System.Drawing.Size(136, 21);
            this.storageButtonAdd.TabIndex = 10;
            this.storageButtonAdd.Text = "Добавить склад";
            this.storageButtonAdd.UseVisualStyleBackColor = true;
            this.storageButtonAdd.Click += new System.EventHandler(this.storageButtonAdd_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(2, 498);
            this.clearButton.Margin = new System.Windows.Forms.Padding(2);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(136, 21);
            this.clearButton.TabIndex = 9;
            this.clearButton.Text = "Очистить";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(2, 40);
            this.addButton.Margin = new System.Windows.Forms.Padding(2);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(136, 21);
            this.addButton.TabIndex = 8;
            this.addButton.Text = "Добавить точку";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // distanceLable
            // 
            this.distanceLable.AutoSize = true;
            this.distanceLable.Location = new System.Drawing.Point(69, 25);
            this.distanceLable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.distanceLable.Name = "distanceLable";
            this.distanceLable.Size = new System.Drawing.Size(13, 13);
            this.distanceLable.TabIndex = 7;
            this.distanceLable.Text = "0";
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(2, 199);
            this.treeView1.Margin = new System.Windows.Forms.Padding(2);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(137, 294);
            this.treeView1.TabIndex = 6;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Растояние:";
            // 
            // getPathButton
            // 
            this.getPathButton.Location = new System.Drawing.Point(2, 2);
            this.getPathButton.Margin = new System.Windows.Forms.Padding(2);
            this.getPathButton.Name = "getPathButton";
            this.getPathButton.Size = new System.Drawing.Size(136, 21);
            this.getPathButton.TabIndex = 0;
            this.getPathButton.Text = "Посчитать";
            this.getPathButton.UseVisualStyleBackColor = true;
            this.getPathButton.Click += new System.EventHandler(this.getPathButton_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(3, 171);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(134, 23);
            this.progressBar1.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 538);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gMapControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LoadCapacityNUD)).EndInit();
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
    }
}

