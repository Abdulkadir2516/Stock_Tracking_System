namespace Kasa
{
    partial class Stock_Durumu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stock_Durumu));
            groupBox2 = new GroupBox();
            dataGridView2 = new DataGridView();
            groupBox1 = new GroupBox();
            find_barcode = new TextBox();
            groupBox3 = new GroupBox();
            find_product = new TextBox();
            groupBox4 = new GroupBox();
            textBox1 = new TextBox();
            groupBox5 = new GroupBox();
            textBox2 = new TextBox();
            groupBox6 = new GroupBox();
            textBox3 = new TextBox();
            groupBox7 = new GroupBox();
            textBox4 = new TextBox();
            groupBox8 = new GroupBox();
            product_type = new ComboBox();
            groupBox9 = new GroupBox();
            supplier = new ComboBox();
            clear = new Label();
            filter = new Label();
            sum = new Label();
            refresh = new Label();
            label1 = new Label();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox7.SuspendLayout();
            groupBox8.SuspendLayout();
            groupBox9.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView2);
            groupBox2.Font = new Font("Segoe UI Semibold", 12F);
            groupBox2.Location = new Point(12, 144);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1354, 491);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "Stok Tablosu";
            // 
            // dataGridView2
            // 
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(13, 28);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.Size = new Size(1333, 457);
            dataGridView2.TabIndex = 1;
            dataGridView2.KeyDown += dataGridView2_KeyDown;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(find_barcode);
            groupBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            groupBox1.Location = new Point(25, 19);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(243, 56);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Barkod Ara";
            // 
            // find_barcode
            // 
            find_barcode.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            find_barcode.Location = new Point(6, 21);
            find_barcode.Name = "find_barcode";
            find_barcode.Size = new Size(231, 29);
            find_barcode.TabIndex = 0;
            find_barcode.TextChanged += find_barcode_TextChanged;
            find_barcode.KeyDown += find_barcode_KeyDown;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(find_product);
            groupBox3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            groupBox3.Location = new Point(274, 19);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(243, 56);
            groupBox3.TabIndex = 12;
            groupBox3.TabStop = false;
            groupBox3.Text = "Ürün Ara";
            // 
            // find_product
            // 
            find_product.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            find_product.Location = new Point(6, 21);
            find_product.Name = "find_product";
            find_product.Size = new Size(231, 29);
            find_product.TabIndex = 0;
            find_product.TextChanged += find_product_TextChanged;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(textBox1);
            groupBox4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            groupBox4.Location = new Point(25, 81);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(243, 56);
            groupBox4.TabIndex = 12;
            groupBox4.TabStop = false;
            groupBox4.Text = "Toplam Ürün Adeti";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            textBox1.Location = new Point(6, 21);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(231, 29);
            textBox1.TabIndex = 0;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(textBox2);
            groupBox5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            groupBox5.Location = new Point(274, 81);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(243, 56);
            groupBox5.TabIndex = 13;
            groupBox5.TabStop = false;
            groupBox5.Text = "Toplam Alış Fiyatı";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            textBox2.Location = new Point(6, 21);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(231, 29);
            textBox2.TabIndex = 0;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(textBox3);
            groupBox6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            groupBox6.Location = new Point(523, 82);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(243, 56);
            groupBox6.TabIndex = 14;
            groupBox6.TabStop = false;
            groupBox6.Text = "Toplam Satış Fiyatı";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            textBox3.Location = new Point(6, 21);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(231, 29);
            textBox3.TabIndex = 0;
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(textBox4);
            groupBox7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            groupBox7.Location = new Point(772, 82);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(243, 56);
            groupBox7.TabIndex = 15;
            groupBox7.TabStop = false;
            groupBox7.Text = "Toplam Kâr";
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            textBox4.Location = new Point(6, 21);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(231, 29);
            textBox4.TabIndex = 0;
            // 
            // groupBox8
            // 
            groupBox8.Controls.Add(product_type);
            groupBox8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            groupBox8.Location = new Point(523, 20);
            groupBox8.Name = "groupBox8";
            groupBox8.Size = new Size(243, 56);
            groupBox8.TabIndex = 13;
            groupBox8.TabStop = false;
            groupBox8.Text = "Ürün Cinsi";
            // 
            // product_type
            // 
            product_type.DropDownStyle = ComboBoxStyle.DropDownList;
            product_type.FormattingEnabled = true;
            product_type.ImeMode = ImeMode.NoControl;
            product_type.Location = new Point(6, 20);
            product_type.Name = "product_type";
            product_type.Size = new Size(231, 29);
            product_type.Sorted = true;
            product_type.TabIndex = 0;
            product_type.SelectedIndexChanged += product_type_SelectedIndexChanged;
            // 
            // groupBox9
            // 
            groupBox9.Controls.Add(supplier);
            groupBox9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            groupBox9.Location = new Point(772, 20);
            groupBox9.Name = "groupBox9";
            groupBox9.Size = new Size(243, 56);
            groupBox9.TabIndex = 14;
            groupBox9.TabStop = false;
            groupBox9.Text = "Tedarikçi";
            // 
            // supplier
            // 
            supplier.DropDownStyle = ComboBoxStyle.DropDownList;
            supplier.FormattingEnabled = true;
            supplier.Location = new Point(6, 20);
            supplier.Name = "supplier";
            supplier.Size = new Size(231, 29);
            supplier.TabIndex = 0;
            supplier.SelectedIndexChanged += supplier_SelectedIndexChanged;
            // 
            // clear
            // 
            clear.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            clear.Image = (Image)resources.GetObject("clear.Image");
            clear.ImageAlign = ContentAlignment.MiddleLeft;
            clear.Location = new Point(1020, 33);
            clear.Name = "clear";
            clear.Size = new Size(104, 37);
            clear.TabIndex = 16;
            clear.Text = "Temizle";
            clear.TextAlign = ContentAlignment.MiddleRight;
            clear.Click += clear_Click;
            // 
            // filter
            // 
            filter.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            filter.Image = (Image)resources.GetObject("filter.Image");
            filter.ImageAlign = ContentAlignment.MiddleLeft;
            filter.Location = new Point(1130, 35);
            filter.Name = "filter";
            filter.Size = new Size(104, 37);
            filter.TabIndex = 17;
            filter.Text = "Filtrele";
            filter.TextAlign = ContentAlignment.MiddleRight;
            filter.Click += filter_Click;
            // 
            // sum
            // 
            sum.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            sum.Image = (Image)resources.GetObject("sum.Image");
            sum.ImageAlign = ContentAlignment.MiddleLeft;
            sum.Location = new Point(1020, 95);
            sum.Name = "sum";
            sum.Size = new Size(104, 37);
            sum.TabIndex = 18;
            sum.Text = "Topla";
            sum.TextAlign = ContentAlignment.MiddleRight;
            sum.Click += sum_Click;
            // 
            // refresh
            // 
            refresh.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            refresh.Image = (Image)resources.GetObject("refresh.Image");
            refresh.ImageAlign = ContentAlignment.MiddleLeft;
            refresh.Location = new Point(1130, 94);
            refresh.Name = "refresh";
            refresh.Size = new Size(104, 37);
            refresh.TabIndex = 19;
            refresh.Text = "Yenile";
            refresh.TextAlign = ContentAlignment.MiddleRight;
            refresh.Click += refresh_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(1240, 35);
            label1.Name = "label1";
            label1.Size = new Size(109, 96);
            label1.TabIndex = 20;
            label1.Text = "Excel'e Aktar";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // Stock_Durumu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumTurquoise;
            ClientSize = new Size(1370, 681);
            Controls.Add(label1);
            Controls.Add(refresh);
            Controls.Add(sum);
            Controls.Add(filter);
            Controls.Add(clear);
            Controls.Add(groupBox9);
            Controls.Add(groupBox8);
            Controls.Add(groupBox7);
            Controls.Add(groupBox6);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Name = "Stock_Durumu";
            Text = "Stock_Durumu";
            WindowState = FormWindowState.Maximized;
            Load += Stock_Durumu_Load;
            Shown += Stock_Durumu_Shown;
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
            groupBox8.ResumeLayout(false);
            groupBox9.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private TextBox find_barcode;
        private GroupBox groupBox3;
        private TextBox find_product;
        private GroupBox groupBox4;
        private TextBox textBox1;
        private GroupBox groupBox5;
        private TextBox textBox2;
        private GroupBox groupBox6;
        private TextBox textBox3;
        private GroupBox groupBox7;
        private TextBox textBox4;
        private GroupBox groupBox8;
        private ComboBox product_type;
        private GroupBox groupBox9;
        private ComboBox supplier;
        private Label clear;
        private Label filter;
        private Label sum;
        private Label refresh;
        private DataGridView dataGridView2;
        private Label label1;
    }
}