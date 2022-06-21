namespace GroupWindowsApp
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
            this.addFunds = new System.Windows.Forms.Button();
            this.pantsType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pantsColor = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pantsSize = new System.Windows.Forms.ComboBox();
            this.productOffer = new System.Windows.Forms.GroupBox();
            this.productPrice = new System.Windows.Forms.TextBox();
            this.productDescriptor = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnAddKart = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.kartMenu = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.totalPrice = new System.Windows.Forms.TextBox();
            this.btnPurchase = new System.Windows.Forms.Button();
            this.btnKartBack = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.productsInKart = new System.Windows.Forms.ListBox();
            this.productSelection = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.funds = new System.Windows.Forms.TextBox();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.btnKart = new System.Windows.Forms.Button();
            this.FundsBox = new System.Windows.Forms.GroupBox();
            this.fundsAdded = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnFundsBack = new System.Windows.Forms.Button();
            this.backToStoreSelect = new System.Windows.Forms.Button();
            this.productOffer.SuspendLayout();
            this.kartMenu.SuspendLayout();
            this.productSelection.SuspendLayout();
            this.FundsBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // addFunds
            // 
            this.addFunds.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addFunds.Location = new System.Drawing.Point(488, 376);
            this.addFunds.Name = "addFunds";
            this.addFunds.Size = new System.Drawing.Size(91, 28);
            this.addFunds.TabIndex = 0;
            this.addFunds.Text = "Add funds";
            this.addFunds.UseVisualStyleBackColor = true;
            this.addFunds.Click += new System.EventHandler(this.addFunds_Click);
            // 
            // pantsType
            // 
            this.pantsType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pantsType.FormattingEnabled = true;
            this.pantsType.Items.AddRange(new object[] {
            "Jeans",
            "Khakis",
            "Shorts",
            "Sweatpants"});
            this.pantsType.Location = new System.Drawing.Point(10, 74);
            this.pantsType.MaxDropDownItems = 5;
            this.pantsType.Name = "pantsType";
            this.pantsType.Size = new System.Drawing.Size(121, 28);
            this.pantsType.TabIndex = 2;
            this.pantsType.SelectedIndexChanged += new System.EventHandler(this.pantsType_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "What type of pants are you looking for?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "What color do you want?";
            // 
            // pantsColor
            // 
            this.pantsColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pantsColor.FormattingEnabled = true;
            this.pantsColor.Items.AddRange(new object[] {
            "Blue",
            "Brown",
            "Black",
            "Red"});
            this.pantsColor.Location = new System.Drawing.Point(10, 151);
            this.pantsColor.MaxDropDownItems = 5;
            this.pantsColor.Name = "pantsColor";
            this.pantsColor.Size = new System.Drawing.Size(121, 28);
            this.pantsColor.TabIndex = 5;
            this.pantsColor.SelectedIndexChanged += new System.EventHandler(this.pantsColor_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(236, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "What general size do you need?";
            // 
            // pantsSize
            // 
            this.pantsSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pantsSize.FormattingEnabled = true;
            this.pantsSize.Items.AddRange(new object[] {
            "XSmall",
            "Small",
            "Medium",
            "Large",
            "XLarge"});
            this.pantsSize.Location = new System.Drawing.Point(10, 229);
            this.pantsSize.MaxDropDownItems = 5;
            this.pantsSize.Name = "pantsSize";
            this.pantsSize.Size = new System.Drawing.Size(121, 28);
            this.pantsSize.TabIndex = 7;
            this.pantsSize.SelectedIndexChanged += new System.EventHandler(this.pantsSize_SelectedIndexChanged);
            // 
            // productOffer
            // 
            this.productOffer.Controls.Add(this.productPrice);
            this.productOffer.Controls.Add(this.productDescriptor);
            this.productOffer.Controls.Add(this.btnBack);
            this.productOffer.Controls.Add(this.btnAddKart);
            this.productOffer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productOffer.Location = new System.Drawing.Point(392, 192);
            this.productOffer.Name = "productOffer";
            this.productOffer.Size = new System.Drawing.Size(359, 178);
            this.productOffer.TabIndex = 8;
            this.productOffer.TabStop = false;
            this.productOffer.Text = "Are these the pants you wanted?";
            this.productOffer.Visible = false;
            // 
            // productPrice
            // 
            this.productPrice.Location = new System.Drawing.Point(253, 112);
            this.productPrice.Name = "productPrice";
            this.productPrice.ReadOnly = true;
            this.productPrice.Size = new System.Drawing.Size(100, 26);
            this.productPrice.TabIndex = 5;
            this.productPrice.Text = "$0.00";
            this.productPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // productDescriptor
            // 
            this.productDescriptor.Location = new System.Drawing.Point(122, 25);
            this.productDescriptor.Multiline = true;
            this.productDescriptor.Name = "productDescriptor";
            this.productDescriptor.ReadOnly = true;
            this.productDescriptor.Size = new System.Drawing.Size(231, 81);
            this.productDescriptor.TabIndex = 4;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(122, 143);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 28);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnAddKart
            // 
            this.btnAddKart.Location = new System.Drawing.Point(257, 144);
            this.btnAddKart.Name = "btnAddKart";
            this.btnAddKart.Size = new System.Drawing.Size(96, 28);
            this.btnAddKart.TabIndex = 2;
            this.btnAddKart.Text = "Add to kart";
            this.btnAddKart.UseVisualStyleBackColor = true;
            this.btnAddKart.Click += new System.EventHandler(this.btnAddKart_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(239, 228);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 28);
            this.btnNext.TabIndex = 9;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // kartMenu
            // 
            this.kartMenu.Controls.Add(this.label6);
            this.kartMenu.Controls.Add(this.totalPrice);
            this.kartMenu.Controls.Add(this.btnPurchase);
            this.kartMenu.Controls.Add(this.btnKartBack);
            this.kartMenu.Controls.Add(this.btnRemove);
            this.kartMenu.Controls.Add(this.productsInKart);
            this.kartMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kartMenu.Location = new System.Drawing.Point(341, 53);
            this.kartMenu.Name = "kartMenu";
            this.kartMenu.Size = new System.Drawing.Size(416, 133);
            this.kartMenu.TabIndex = 11;
            this.kartMenu.TabStop = false;
            this.kartMenu.Text = "Kart";
            this.kartMenu.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(224, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Total: ";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // totalPrice
            // 
            this.totalPrice.Location = new System.Drawing.Point(228, 101);
            this.totalPrice.Name = "totalPrice";
            this.totalPrice.ReadOnly = true;
            this.totalPrice.Size = new System.Drawing.Size(100, 26);
            this.totalPrice.TabIndex = 4;
            this.totalPrice.Text = "$0.00";
            this.totalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnPurchase
            // 
            this.btnPurchase.Location = new System.Drawing.Point(326, 65);
            this.btnPurchase.Name = "btnPurchase";
            this.btnPurchase.Size = new System.Drawing.Size(84, 28);
            this.btnPurchase.TabIndex = 3;
            this.btnPurchase.Text = "Purchase";
            this.btnPurchase.UseVisualStyleBackColor = true;
            this.btnPurchase.Visible = false;
            this.btnPurchase.Click += new System.EventHandler(this.btnPurchase_Click);
            // 
            // btnKartBack
            // 
            this.btnKartBack.Location = new System.Drawing.Point(335, 99);
            this.btnKartBack.Name = "btnKartBack";
            this.btnKartBack.Size = new System.Drawing.Size(75, 28);
            this.btnKartBack.TabIndex = 2;
            this.btnKartBack.Text = "Back";
            this.btnKartBack.UseVisualStyleBackColor = true;
            this.btnKartBack.Click += new System.EventHandler(this.btnKartBack_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(267, 31);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(143, 28);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "Remove from kart";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // productsInKart
            // 
            this.productsInKart.FormattingEnabled = true;
            this.productsInKart.ItemHeight = 20;
            this.productsInKart.Location = new System.Drawing.Point(6, 23);
            this.productsInKart.Name = "productsInKart";
            this.productsInKart.Size = new System.Drawing.Size(216, 104);
            this.productsInKart.TabIndex = 0;
            this.productsInKart.SelectedIndexChanged += new System.EventHandler(this.productsInKart_SelectedIndexChanged);
            // 
            // productSelection
            // 
            this.productSelection.Controls.Add(this.btnNext);
            this.productSelection.Controls.Add(this.pantsSize);
            this.productSelection.Controls.Add(this.label3);
            this.productSelection.Controls.Add(this.label1);
            this.productSelection.Controls.Add(this.label2);
            this.productSelection.Controls.Add(this.pantsColor);
            this.productSelection.Controls.Add(this.pantsType);
            this.productSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productSelection.Location = new System.Drawing.Point(12, 53);
            this.productSelection.Name = "productSelection";
            this.productSelection.Size = new System.Drawing.Size(323, 262);
            this.productSelection.TabIndex = 12;
            this.productSelection.TabStop = false;
            this.productSelection.Text = "Please answer each question using the dropdown menus below";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Berlin Sans FB", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(219, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(283, 30);
            this.label4.TabIndex = 13;
            this.label4.Text = "Mr. T-Pants\' Pants Store";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(517, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Current Balance:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // funds
            // 
            this.funds.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.funds.Location = new System.Drawing.Point(651, 19);
            this.funds.Name = "funds";
            this.funds.ReadOnly = true;
            this.funds.Size = new System.Drawing.Size(100, 26);
            this.funds.TabIndex = 15;
            this.funds.Text = "$0.00";
            this.funds.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.funds.TextChanged += new System.EventHandler(this.funds_TextChanged);
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckOut.Location = new System.Drawing.Point(666, 376);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(85, 28);
            this.btnCheckOut.TabIndex = 16;
            this.btnCheckOut.Text = "Checkout";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // btnKart
            // 
            this.btnKart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKart.Location = new System.Drawing.Point(585, 376);
            this.btnKart.Name = "btnKart";
            this.btnKart.Size = new System.Drawing.Size(75, 28);
            this.btnKart.TabIndex = 17;
            this.btnKart.Text = "Kart";
            this.btnKart.UseVisualStyleBackColor = true;
            this.btnKart.Click += new System.EventHandler(this.btnKart_Click);
            // 
            // FundsBox
            // 
            this.FundsBox.Controls.Add(this.fundsAdded);
            this.FundsBox.Controls.Add(this.label7);
            this.FundsBox.Controls.Add(this.btnAdd);
            this.FundsBox.Controls.Add(this.btnFundsBack);
            this.FundsBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FundsBox.Location = new System.Drawing.Point(12, 321);
            this.FundsBox.Name = "FundsBox";
            this.FundsBox.Size = new System.Drawing.Size(372, 86);
            this.FundsBox.TabIndex = 18;
            this.FundsBox.TabStop = false;
            this.FundsBox.Text = "Add funds";
            this.FundsBox.Visible = false;
            // 
            // fundsAdded
            // 
            this.fundsAdded.Location = new System.Drawing.Point(266, 19);
            this.fundsAdded.Name = "fundsAdded";
            this.fundsAdded.Size = new System.Drawing.Size(100, 26);
            this.fundsAdded.TabIndex = 3;
            this.fundsAdded.Text = "0.00";
            this.fundsAdded.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.fundsAdded.TextChanged += new System.EventHandler(this.fundsAdded_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(254, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Enter the amount you\'d like to add:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(291, 52);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 28);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add funds";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnFundsBack
            // 
            this.btnFundsBack.Location = new System.Drawing.Point(6, 52);
            this.btnFundsBack.Name = "btnFundsBack";
            this.btnFundsBack.Size = new System.Drawing.Size(75, 28);
            this.btnFundsBack.TabIndex = 0;
            this.btnFundsBack.Text = "Back";
            this.btnFundsBack.UseVisualStyleBackColor = true;
            this.btnFundsBack.Click += new System.EventHandler(this.btnFundsBack_Click);
            // 
            // backToStoreSelect
            // 
            this.backToStoreSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backToStoreSelect.Location = new System.Drawing.Point(12, 12);
            this.backToStoreSelect.Name = "backToStoreSelect";
            this.backToStoreSelect.Size = new System.Drawing.Size(158, 28);
            this.backToStoreSelect.TabIndex = 19;
            this.backToStoreSelect.Text = "Back to store select";
            this.backToStoreSelect.UseVisualStyleBackColor = true;
            this.backToStoreSelect.Click += new System.EventHandler(this.backToStoreSelect_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 416);
            this.Controls.Add(this.backToStoreSelect);
            this.Controls.Add(this.FundsBox);
            this.Controls.Add(this.btnKart);
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.funds);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.productSelection);
            this.Controls.Add(this.kartMenu);
            this.Controls.Add(this.productOffer);
            this.Controls.Add(this.addFunds);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.productOffer.ResumeLayout(false);
            this.productOffer.PerformLayout();
            this.kartMenu.ResumeLayout(false);
            this.kartMenu.PerformLayout();
            this.productSelection.ResumeLayout(false);
            this.productSelection.PerformLayout();
            this.FundsBox.ResumeLayout(false);
            this.FundsBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addFunds;
        private System.Windows.Forms.ComboBox pantsType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox pantsColor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox pantsSize;
        private System.Windows.Forms.GroupBox productOffer;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnAddKart;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.GroupBox kartMenu;
        private System.Windows.Forms.TextBox productPrice;
        private System.Windows.Forms.TextBox productDescriptor;
        private System.Windows.Forms.Button btnKartBack;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.ListBox productsInKart;
        private System.Windows.Forms.GroupBox productSelection;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox totalPrice;
        private System.Windows.Forms.Button btnPurchase;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox funds;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.Button btnKart;
        private System.Windows.Forms.GroupBox FundsBox;
        private System.Windows.Forms.TextBox fundsAdded;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnFundsBack;
        private System.Windows.Forms.Button backToStoreSelect;
    }
}

