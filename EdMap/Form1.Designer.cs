
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.maxFerTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.lengSignificanceTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.iterationCountTextBox = new System.Windows.Forms.TextBox();
            this.ferStartTextBox = new System.Windows.Forms.TextBox();
            this.evaporationTextBox = new System.Windows.Forms.TextBox();
            this.ferAddConstTextBox = new System.Windows.Forms.TextBox();
            this.minFerTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LoadCapacityNUD = new System.Windows.Forms.NumericUpDown();
            this.storageButtonAdd = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.distanceLable = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.label3 = new System.Windows.Forms.Label();
            this.getPathButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.loadPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.gMapControl1.Location = new System.Drawing.Point(153, 8);
            this.gMapControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.gMapControl1.Size = new System.Drawing.Size(711, 649);
            this.gMapControl1.TabIndex = 0;
            this.gMapControl1.Zoom = 0D;
            this.gMapControl1.OnMapClick += new GMap.NET.WindowsForms.MapClick(this.gMapControl1_OnMapClick);
            this.gMapControl1.OnMarkerDoubleClick += new GMap.NET.WindowsForms.MarkerDoubleClick(this.gMapControl1_OnMarkerDoubleClick);
            this.gMapControl1.Load += new System.EventHandler(this.gMapControl1_Load_1);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
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
            this.panel1.Location = new System.Drawing.Point(9, 8);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(141, 649);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.maxFerTextBox);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.lengSignificanceTextBox);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.iterationCountTextBox);
            this.panel2.Controls.Add(this.ferStartTextBox);
            this.panel2.Controls.Add(this.evaporationTextBox);
            this.panel2.Controls.Add(this.ferAddConstTextBox);
            this.panel2.Controls.Add(this.minFerTextBox);
            this.panel2.Location = new System.Drawing.Point(-1, 485);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(141, 164);
            this.panel2.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(69, 25);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "maxFer";
            // 
            // maxFerTextBox
            // 
            this.maxFerTextBox.Location = new System.Drawing.Point(2, 23);
            this.maxFerTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.maxFerTextBox.Name = "maxFerTextBox";
            this.maxFerTextBox.Size = new System.Drawing.Size(68, 20);
            this.maxFerTextBox.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(2, 148);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 15);
            this.button1.TabIndex = 12;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(69, 129);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "lengSignificance";
            // 
            // lengSignificanceTextBox
            // 
            this.lengSignificanceTextBox.Location = new System.Drawing.Point(2, 127);
            this.lengSignificanceTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lengSignificanceTextBox.Name = "lengSignificanceTextBox";
            this.lengSignificanceTextBox.Size = new System.Drawing.Size(68, 20);
            this.lengSignificanceTextBox.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(69, 109);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "iterationCount";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(69, 88);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "ferStart";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(69, 67);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "evaporation";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(69, 46);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "ferAddConst";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 5);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "minFer";
            // 
            // iterationCountTextBox
            // 
            this.iterationCountTextBox.Location = new System.Drawing.Point(2, 107);
            this.iterationCountTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.iterationCountTextBox.Name = "iterationCountTextBox";
            this.iterationCountTextBox.Size = new System.Drawing.Size(68, 20);
            this.iterationCountTextBox.TabIndex = 4;
            // 
            // ferStartTextBox
            // 
            this.ferStartTextBox.Location = new System.Drawing.Point(2, 86);
            this.ferStartTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ferStartTextBox.Name = "ferStartTextBox";
            this.ferStartTextBox.Size = new System.Drawing.Size(68, 20);
            this.ferStartTextBox.TabIndex = 3;
            // 
            // evaporationTextBox
            // 
            this.evaporationTextBox.Location = new System.Drawing.Point(2, 65);
            this.evaporationTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.evaporationTextBox.Name = "evaporationTextBox";
            this.evaporationTextBox.Size = new System.Drawing.Size(68, 20);
            this.evaporationTextBox.TabIndex = 2;
            // 
            // ferAddConstTextBox
            // 
            this.ferAddConstTextBox.Location = new System.Drawing.Point(2, 44);
            this.ferAddConstTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ferAddConstTextBox.Name = "ferAddConstTextBox";
            this.ferAddConstTextBox.Size = new System.Drawing.Size(68, 20);
            this.ferAddConstTextBox.TabIndex = 1;
            // 
            // minFerTextBox
            // 
            this.minFerTextBox.Location = new System.Drawing.Point(2, 3);
            this.minFerTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.minFerTextBox.Name = "minFerTextBox";
            this.minFerTextBox.Size = new System.Drawing.Size(68, 20);
            this.minFerTextBox.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 402);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.MaximumSize = new System.Drawing.Size(133, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "label4";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Грузоподъемность:";
            // 
            // LoadCapacityNUD
            // 
            this.LoadCapacityNUD.Location = new System.Drawing.Point(2, 104);
            this.LoadCapacityNUD.Name = "LoadCapacityNUD";
            this.LoadCapacityNUD.Size = new System.Drawing.Size(135, 20);
            this.LoadCapacityNUD.TabIndex = 11;
            // 
            // storageButtonAdd
            // 
            this.storageButtonAdd.Location = new System.Drawing.Point(2, 65);
            this.storageButtonAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.storageButtonAdd.Name = "storageButtonAdd";
            this.storageButtonAdd.Size = new System.Drawing.Size(135, 21);
            this.storageButtonAdd.TabIndex = 10;
            this.storageButtonAdd.Text = "Добавить склад";
            this.storageButtonAdd.UseVisualStyleBackColor = true;
            this.storageButtonAdd.Click += new System.EventHandler(this.storageButtonAdd_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(2, 380);
            this.clearButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(135, 21);
            this.clearButton.TabIndex = 9;
            this.clearButton.Text = "Очистить";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(2, 40);
            this.addButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(135, 21);
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
            this.treeView1.Location = new System.Drawing.Point(2, 176);
            this.treeView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(136, 202);
            this.treeView1.TabIndex = 6;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.treeView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.treeView1_MouseDoubleClick);
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
            this.getPathButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.getPathButton.Name = "getPathButton";
            this.getPathButton.Size = new System.Drawing.Size(135, 21);
            this.getPathButton.TabIndex = 0;
            this.getPathButton.Text = "Посчитать";
            this.getPathButton.UseVisualStyleBackColor = true;
            this.getPathButton.Click += new System.EventHandler(this.getPathButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "label";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(2, 16);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(135, 23);
            this.progressBar1.TabIndex = 13;
            // 
            // loadPanel
            // 
            this.loadPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loadPanel.Controls.Add(this.label2);
            this.loadPanel.Controls.Add(this.progressBar1);
            this.loadPanel.Location = new System.Drawing.Point(9, 135);
            this.loadPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.loadPanel.Name = "loadPanel";
            this.loadPanel.Size = new System.Drawing.Size(141, 46);
            this.loadPanel.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 487);
            this.Controls.Add(this.loadPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gMapControl1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox lengSignificanceTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox iterationCountTextBox;
        private System.Windows.Forms.TextBox ferStartTextBox;
        private System.Windows.Forms.TextBox evaporationTextBox;
        private System.Windows.Forms.TextBox ferAddConstTextBox;
        private System.Windows.Forms.TextBox minFerTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox maxFerTextBox;
    }
}

