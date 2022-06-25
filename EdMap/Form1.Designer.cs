
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
            this.storageButtonAdd = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.distanceLable = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.label3 = new System.Windows.Forms.Label();
            this.getPathButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
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
            this.gMapControl1.Location = new System.Drawing.Point(229, 12);
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
            this.gMapControl1.Size = new System.Drawing.Size(839, 666);
            this.gMapControl1.TabIndex = 0;
            this.gMapControl1.Zoom = 0D;
            this.gMapControl1.OnMapClick += new GMap.NET.WindowsForms.MapClick(this.gMapControl1_OnMapClick);
            this.gMapControl1.OnMarkerEnter += new GMap.NET.WindowsForms.MarkerEnter(this.gMapControl1_OnMarkerEnter);
            this.gMapControl1.OnMarkerLeave += new GMap.NET.WindowsForms.MarkerLeave(this.gMapControl1_OnMarkerLeave);
            this.gMapControl1.Load += new System.EventHandler(this.gMapControl1_Load_1);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.storageButtonAdd);
            this.panel1.Controls.Add(this.clearButton);
            this.panel1.Controls.Add(this.addButton);
            this.panel1.Controls.Add(this.distanceLable);
            this.panel1.Controls.Add(this.treeView1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.getPathButton);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(210, 665);
            this.panel1.TabIndex = 1;
            // 
            // storageButtonAdd
            // 
            this.storageButtonAdd.Location = new System.Drawing.Point(3, 101);
            this.storageButtonAdd.Name = "storageButtonAdd";
            this.storageButtonAdd.Size = new System.Drawing.Size(204, 33);
            this.storageButtonAdd.TabIndex = 10;
            this.storageButtonAdd.Text = "Добавить склад";
            this.storageButtonAdd.UseVisualStyleBackColor = true;
            this.storageButtonAdd.Click += new System.EventHandler(this.storageButtonAdd_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(3, 629);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(204, 33);
            this.clearButton.TabIndex = 9;
            this.clearButton.Text = "Очистить";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(3, 62);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(204, 33);
            this.addButton.TabIndex = 8;
            this.addButton.Text = "Добавить точку";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // distanceLable
            // 
            this.distanceLable.AutoSize = true;
            this.distanceLable.Location = new System.Drawing.Point(104, 39);
            this.distanceLable.Name = "distanceLable";
            this.distanceLable.Size = new System.Drawing.Size(18, 20);
            this.distanceLable.TabIndex = 7;
            this.distanceLable.Text = "0";
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(3, 140);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(204, 483);
            this.treeView1.TabIndex = 6;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Растояние:";
            // 
            // getPathButton
            // 
            this.getPathButton.Location = new System.Drawing.Point(3, 3);
            this.getPathButton.Name = "getPathButton";
            this.getPathButton.Size = new System.Drawing.Size(204, 33);
            this.getPathButton.TabIndex = 0;
            this.getPathButton.Text = "Посчитать";
            this.getPathButton.UseVisualStyleBackColor = true;
            this.getPathButton.Click += new System.EventHandler(this.getPathButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 690);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gMapControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
    }
}

