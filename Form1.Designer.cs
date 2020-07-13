namespace Grocery_Store_Simulator
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Heading_Text = new System.Windows.Forms.TextBox();
            this.Main_screen = new System.Windows.Forms.DataGridView();
            this.Items_view_btn = new System.Windows.Forms.Button();
            this.Specs_view_btn = new System.Windows.Forms.Button();
            this.Cart_empty_btn = new System.Windows.Forms.Button();
            this.Cart_view_btn = new System.Windows.Forms.Button();
            this.Qty = new System.Windows.Forms.Label();
            this.Cart_total_lbl = new System.Windows.Forms.Label();
            this.CartTotal = new System.Windows.Forms.TextBox();
            this.Grand_total = new System.Windows.Forms.Label();
            this.GrandTotal = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.Item_add_btn = new System.Windows.Forms.Button();
            this.Item_removefromcart = new System.Windows.Forms.Button();
            this.Discount_label = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.DiscountApply_btn = new System.Windows.Forms.Button();
            this.Qty_1item_lbl = new System.Windows.Forms.Label();
            this.Qty_1item = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.messageBox = new System.Windows.Forms.TextBox();
            this.Qty_to_add_or_remove = new System.Windows.Forms.NumericUpDown();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Main_screen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Qty_to_add_or_remove)).BeginInit();
            this.SuspendLayout();
            // 
            // Heading_Text
            // 
            this.Heading_Text.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Heading_Text.BackColor = System.Drawing.Color.DarkGreen;
            this.Heading_Text.Cursor = System.Windows.Forms.Cursors.Default;
            this.Heading_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Heading_Text.ForeColor = System.Drawing.SystemColors.Window;
            this.Heading_Text.Location = new System.Drawing.Point(188, 3);
            this.Heading_Text.Name = "Heading_Text";
            this.Heading_Text.ReadOnly = true;
            this.Heading_Text.Size = new System.Drawing.Size(421, 35);
            this.Heading_Text.TabIndex = 2;
            this.Heading_Text.Text = "GROCERY STORE SIMULATOR";
            this.Heading_Text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Heading_Text.TextChanged += new System.EventHandler(this.Heading_Text_TextChanged);
            // 
            // Main_screen
            // 
            this.Main_screen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Main_screen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Main_screen.DefaultCellStyle = dataGridViewCellStyle4;
            this.Main_screen.Location = new System.Drawing.Point(310, 92);
            this.Main_screen.Name = "Main_screen";
            this.Main_screen.Size = new System.Drawing.Size(463, 241);
            this.Main_screen.TabIndex = 1;
            this.Main_screen.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Main_screen_CellClick);
            this.Main_screen.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Main_screen_RowHeaderMouseClick);
            // 
            // Items_view_btn
            // 
            this.Items_view_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Items_view_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Items_view_btn.Location = new System.Drawing.Point(310, 339);
            this.Items_view_btn.Name = "Items_view_btn";
            this.Items_view_btn.Size = new System.Drawing.Size(225, 36);
            this.Items_view_btn.TabIndex = 2;
            this.Items_view_btn.Text = "View All Items";
            this.Items_view_btn.UseVisualStyleBackColor = false;
            this.Items_view_btn.Click += new System.EventHandler(this.Items_view_btn_Click);
            // 
            // Specs_view_btn
            // 
            this.Specs_view_btn.BackColor = System.Drawing.Color.YellowGreen;
            this.Specs_view_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Specs_view_btn.Location = new System.Drawing.Point(310, 390);
            this.Specs_view_btn.Name = "Specs_view_btn";
            this.Specs_view_btn.Size = new System.Drawing.Size(225, 36);
            this.Specs_view_btn.TabIndex = 6;
            this.Specs_view_btn.Text = "View Specifications";
            this.Specs_view_btn.UseVisualStyleBackColor = false;
            // 
            // Cart_empty_btn
            // 
            this.Cart_empty_btn.BackColor = System.Drawing.Color.LightCoral;
            this.Cart_empty_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cart_empty_btn.Location = new System.Drawing.Point(548, 390);
            this.Cart_empty_btn.Name = "Cart_empty_btn";
            this.Cart_empty_btn.Size = new System.Drawing.Size(225, 36);
            this.Cart_empty_btn.TabIndex = 8;
            this.Cart_empty_btn.Text = "Reset Your Cart";
            this.Cart_empty_btn.UseVisualStyleBackColor = false;
            // 
            // Cart_view_btn
            // 
            this.Cart_view_btn.BackColor = System.Drawing.Color.Aqua;
            this.Cart_view_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cart_view_btn.Location = new System.Drawing.Point(548, 339);
            this.Cart_view_btn.Name = "Cart_view_btn";
            this.Cart_view_btn.Size = new System.Drawing.Size(225, 36);
            this.Cart_view_btn.TabIndex = 7;
            this.Cart_view_btn.Text = "View Your Cart";
            this.Cart_view_btn.UseVisualStyleBackColor = false;
            this.Cart_view_btn.Click += new System.EventHandler(this.Cart_view_btn_Click);
            // 
            // Qty
            // 
            this.Qty.AutoSize = true;
            this.Qty.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Qty.Location = new System.Drawing.Point(64, 95);
            this.Qty.Name = "Qty";
            this.Qty.Size = new System.Drawing.Size(152, 18);
            this.Qty.TabIndex = 10;
            this.Qty.Text = "Qty to add/remove:";
            // 
            // Cart_total_lbl
            // 
            this.Cart_total_lbl.AutoSize = true;
            this.Cart_total_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cart_total_lbl.Location = new System.Drawing.Point(48, 267);
            this.Cart_total_lbl.Name = "Cart_total_lbl";
            this.Cart_total_lbl.Size = new System.Drawing.Size(88, 18);
            this.Cart_total_lbl.TabIndex = 12;
            this.Cart_total_lbl.Text = "Cart Total:";
            // 
            // CartTotal
            // 
            this.CartTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CartTotal.Location = new System.Drawing.Point(156, 266);
            this.CartTotal.Name = "CartTotal";
            this.CartTotal.ReadOnly = true;
            this.CartTotal.Size = new System.Drawing.Size(133, 24);
            this.CartTotal.TabIndex = 11;
            // 
            // Grand_total
            // 
            this.Grand_total.AutoSize = true;
            this.Grand_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grand_total.Location = new System.Drawing.Point(39, 328);
            this.Grand_total.Name = "Grand_total";
            this.Grand_total.Size = new System.Drawing.Size(97, 18);
            this.Grand_total.TabIndex = 16;
            this.Grand_total.Text = "Grand total:";
            // 
            // GrandTotal
            // 
            this.GrandTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrandTotal.Location = new System.Drawing.Point(158, 325);
            this.GrandTotal.Name = "GrandTotal";
            this.GrandTotal.ReadOnly = true;
            this.GrandTotal.Size = new System.Drawing.Size(133, 24);
            this.GrandTotal.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightCoral;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(51, 366);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(238, 60);
            this.button1.TabIndex = 17;
            this.button1.Text = "Proceed to Checkout...";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.Honeydew;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(137, 266);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(13, 20);
            this.textBox4.TabIndex = 18;
            this.textBox4.Text = "$";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.Honeydew;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(142, 324);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(13, 22);
            this.textBox6.TabIndex = 20;
            this.textBox6.Text = "$";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Item_add_btn
            // 
            this.Item_add_btn.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.Item_add_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Item_add_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Item_add_btn.Location = new System.Drawing.Point(203, 152);
            this.Item_add_btn.Name = "Item_add_btn";
            this.Item_add_btn.Size = new System.Drawing.Size(86, 21);
            this.Item_add_btn.TabIndex = 21;
            this.Item_add_btn.Text = "Add To Cart";
            this.Item_add_btn.UseVisualStyleBackColor = false;
            this.Item_add_btn.Click += new System.EventHandler(this.Item_add_btn_Click);
            // 
            // Item_removefromcart
            // 
            this.Item_removefromcart.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.Item_removefromcart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Item_removefromcart.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Item_removefromcart.Location = new System.Drawing.Point(169, 179);
            this.Item_removefromcart.Name = "Item_removefromcart";
            this.Item_removefromcart.Size = new System.Drawing.Size(120, 21);
            this.Item_removefromcart.TabIndex = 22;
            this.Item_removefromcart.Text = "Remove from Cart";
            this.Item_removefromcart.UseVisualStyleBackColor = false;
            this.Item_removefromcart.Click += new System.EventHandler(this.Item_removefromcart_Click);
            // 
            // Discount_label
            // 
            this.Discount_label.AutoSize = true;
            this.Discount_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Discount_label.Location = new System.Drawing.Point(34, 297);
            this.Discount_label.Name = "Discount_label";
            this.Discount_label.Size = new System.Drawing.Size(102, 15);
            this.Discount_label.TabIndex = 24;
            this.Discount_label.Text = "Discount code:";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(144, 297);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(87, 21);
            this.textBox2.TabIndex = 23;
            // 
            // DiscountApply_btn
            // 
            this.DiscountApply_btn.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.DiscountApply_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiscountApply_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.DiscountApply_btn.Location = new System.Drawing.Point(237, 296);
            this.DiscountApply_btn.Name = "DiscountApply_btn";
            this.DiscountApply_btn.Size = new System.Drawing.Size(54, 22);
            this.DiscountApply_btn.TabIndex = 25;
            this.DiscountApply_btn.Text = "Apply";
            this.DiscountApply_btn.UseVisualStyleBackColor = false;
            // 
            // Qty_1item_lbl
            // 
            this.Qty_1item_lbl.AutoSize = true;
            this.Qty_1item_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Qty_1item_lbl.Location = new System.Drawing.Point(30, 125);
            this.Qty_1item_lbl.Name = "Qty_1item_lbl";
            this.Qty_1item_lbl.Size = new System.Drawing.Size(186, 18);
            this.Qty_1item_lbl.TabIndex = 27;
            this.Qty_1item_lbl.Text = "Qty in cart for this item:";
            this.Qty_1item_lbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // Qty_1item
            // 
            this.Qty_1item.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Qty_1item.Location = new System.Drawing.Point(222, 122);
            this.Qty_1item.Name = "Qty_1item";
            this.Qty_1item.ReadOnly = true;
            this.Qty_1item.Size = new System.Drawing.Size(69, 24);
            this.Qty_1item.TabIndex = 26;
            this.Qty_1item.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Qty_1item.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 29;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // messageBox
            // 
            this.messageBox.BackColor = System.Drawing.Color.SeaShell;
            this.messageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.messageBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.messageBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageBox.Location = new System.Drawing.Point(412, 59);
            this.messageBox.Name = "messageBox";
            this.messageBox.ReadOnly = true;
            this.messageBox.Size = new System.Drawing.Size(271, 24);
            this.messageBox.TabIndex = 30;
            this.messageBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Qty_to_add_or_remove
            // 
            this.Qty_to_add_or_remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Qty_to_add_or_remove.Location = new System.Drawing.Point(222, 93);
            this.Qty_to_add_or_remove.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.Qty_to_add_or_remove.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Qty_to_add_or_remove.Name = "Qty_to_add_or_remove";
            this.Qty_to_add_or_remove.Size = new System.Drawing.Size(69, 24);
            this.Qty_to_add_or_remove.TabIndex = 31;
            this.Qty_to_add_or_remove.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Qty_to_add_or_remove.ValueChanged += new System.EventHandler(this.Qty_to_add_or_remove_ValueChanged);
            // 
            // Form1
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Qty_to_add_or_remove);
            this.Controls.Add(this.messageBox);
            this.Controls.Add(this.Qty_1item_lbl);
            this.Controls.Add(this.Qty_1item);
            this.Controls.Add(this.DiscountApply_btn);
            this.Controls.Add(this.Discount_label);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Item_removefromcart);
            this.Controls.Add(this.Item_add_btn);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Grand_total);
            this.Controls.Add(this.GrandTotal);
            this.Controls.Add(this.Cart_total_lbl);
            this.Controls.Add(this.CartTotal);
            this.Controls.Add(this.Qty);
            this.Controls.Add(this.Cart_empty_btn);
            this.Controls.Add(this.Cart_view_btn);
            this.Controls.Add(this.Specs_view_btn);
            this.Controls.Add(this.Items_view_btn);
            this.Controls.Add(this.Main_screen);
            this.Controls.Add(this.Heading_Text);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Grocery Store Simulator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Main_screen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Qty_to_add_or_remove)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Heading_Text;
        private System.Windows.Forms.DataGridView Main_screen;
        private System.Windows.Forms.Button Items_view_btn;
        private System.Windows.Forms.Button Specs_view_btn;
        private System.Windows.Forms.Button Cart_empty_btn;
        private System.Windows.Forms.Button Cart_view_btn;
        private System.Windows.Forms.Label Qty;
        private System.Windows.Forms.Label Cart_total_lbl;
        private System.Windows.Forms.TextBox CartTotal;
        private System.Windows.Forms.Label Grand_total;
        private System.Windows.Forms.TextBox GrandTotal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button Item_add_btn;
        private System.Windows.Forms.Button Item_removefromcart;
        private System.Windows.Forms.Label Discount_label;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button DiscountApply_btn;
        private System.Windows.Forms.Label Qty_1item_lbl;
        private System.Windows.Forms.TextBox Qty_1item;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TextBox messageBox;
        private System.Windows.Forms.NumericUpDown Qty_to_add_or_remove;
        private System.Windows.Forms.Timer timer1;
    }
}

