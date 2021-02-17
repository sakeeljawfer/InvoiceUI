
namespace InvoiceUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ItemsBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.customerBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.materialRaisedButton2 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.invoicebtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.sellpriceBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.unitBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.shelfBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.catagoryBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.employeeBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.usernmTxt = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.costTxt = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.costLbl = new MaterialSkin.Controls.MaterialLabel();
            this.priceTxt = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.itemcodeLbl = new MaterialSkin.Controls.MaterialLabel();
            this.itemcodeTxt = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.CatagoryTxt = new MaterialSkin.Controls.MaterialLabel();
            this.materialSingleLineTextField1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.ItemNameLbl = new MaterialSkin.Controls.MaterialLabel();
            this.ItemNameTxt = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.ShelfLbl = new MaterialSkin.Controls.MaterialLabel();
            this.shelfIdTxt = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.itemUnitLbl = new MaterialSkin.Controls.MaterialLabel();
            this.itemUnitTxt = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.itemBarcodeLbl = new MaterialSkin.Controls.MaterialLabel();
            this.itemBarcodeTxt = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.userNmLbl = new MaterialSkin.Controls.MaterialLabel();
            this.priceLbl = new MaterialSkin.Controls.MaterialLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.itemCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dicount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.cstmraddrsTxt = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.cstmrmailTxt = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.cutmrConLbl = new MaterialSkin.Controls.MaterialLabel();
            this.cstmrTxt = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.custmrLbl = new MaterialSkin.Controls.MaterialLabel();
            this.cstmrconctTxt = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.cutmraddrsLbl = new MaterialSkin.Controls.MaterialLabel();
            this.addCustmrBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton2 = new MaterialSkin.Controls.MaterialFlatButton();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // ItemsBtn
            // 
            this.ItemsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ItemsBtn.Depth = 0;
            this.ItemsBtn.Location = new System.Drawing.Point(3, 3);
            this.ItemsBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.ItemsBtn.Name = "ItemsBtn";
            this.ItemsBtn.Primary = true;
            this.ItemsBtn.Size = new System.Drawing.Size(97, 33);
            this.ItemsBtn.TabIndex = 5;
            this.ItemsBtn.Text = "Items";
            this.ItemsBtn.UseVisualStyleBackColor = true;
            // 
            // customerBtn
            // 
            this.customerBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customerBtn.Depth = 0;
            this.customerBtn.Location = new System.Drawing.Point(209, 3);
            this.customerBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.customerBtn.Name = "customerBtn";
            this.customerBtn.Primary = true;
            this.customerBtn.Size = new System.Drawing.Size(97, 33);
            this.customerBtn.TabIndex = 4;
            this.customerBtn.Text = "Customer";
            this.customerBtn.UseVisualStyleBackColor = true;
            this.customerBtn.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 9;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.materialRaisedButton2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.invoicebtn, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.sellpriceBtn, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.unitBtn, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.shelfBtn, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.ItemsBtn, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.customerBtn, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.catagoryBtn, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.employeeBtn, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1038, 39);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // materialRaisedButton2
            // 
            this.materialRaisedButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialRaisedButton2.Depth = 0;
            this.materialRaisedButton2.Location = new System.Drawing.Point(106, 3);
            this.materialRaisedButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton2.Name = "materialRaisedButton2";
            this.materialRaisedButton2.Primary = true;
            this.materialRaisedButton2.Size = new System.Drawing.Size(97, 33);
            this.materialRaisedButton2.TabIndex = 12;
            this.materialRaisedButton2.Text = "Employee";
            this.materialRaisedButton2.UseVisualStyleBackColor = true;
            // 
            // invoicebtn
            // 
            this.invoicebtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.invoicebtn.Depth = 0;
            this.invoicebtn.Location = new System.Drawing.Point(827, 3);
            this.invoicebtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.invoicebtn.Name = "invoicebtn";
            this.invoicebtn.Primary = true;
            this.invoicebtn.Size = new System.Drawing.Size(208, 33);
            this.invoicebtn.TabIndex = 10;
            this.invoicebtn.Text = "Invoice";
            this.invoicebtn.UseVisualStyleBackColor = true;
            // 
            // sellpriceBtn
            // 
            this.sellpriceBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sellpriceBtn.Depth = 0;
            this.sellpriceBtn.Location = new System.Drawing.Point(724, 3);
            this.sellpriceBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.sellpriceBtn.Name = "sellpriceBtn";
            this.sellpriceBtn.Primary = true;
            this.sellpriceBtn.Size = new System.Drawing.Size(97, 33);
            this.sellpriceBtn.TabIndex = 11;
            this.sellpriceBtn.Text = "SellPrice";
            this.sellpriceBtn.UseVisualStyleBackColor = true;
            // 
            // unitBtn
            // 
            this.unitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.unitBtn.Depth = 0;
            this.unitBtn.Location = new System.Drawing.Point(621, 3);
            this.unitBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.unitBtn.Name = "unitBtn";
            this.unitBtn.Primary = true;
            this.unitBtn.Size = new System.Drawing.Size(97, 33);
            this.unitBtn.TabIndex = 9;
            this.unitBtn.Text = "Unit";
            this.unitBtn.UseVisualStyleBackColor = true;
            // 
            // shelfBtn
            // 
            this.shelfBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.shelfBtn.Depth = 0;
            this.shelfBtn.Location = new System.Drawing.Point(518, 3);
            this.shelfBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.shelfBtn.Name = "shelfBtn";
            this.shelfBtn.Primary = true;
            this.shelfBtn.Size = new System.Drawing.Size(97, 33);
            this.shelfBtn.TabIndex = 10;
            this.shelfBtn.Text = "Shelf";
            this.shelfBtn.UseVisualStyleBackColor = true;
            // 
            // catagoryBtn
            // 
            this.catagoryBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.catagoryBtn.Depth = 0;
            this.catagoryBtn.Location = new System.Drawing.Point(415, 3);
            this.catagoryBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.catagoryBtn.Name = "catagoryBtn";
            this.catagoryBtn.Primary = true;
            this.catagoryBtn.Size = new System.Drawing.Size(97, 33);
            this.catagoryBtn.TabIndex = 7;
            this.catagoryBtn.Text = "Catagory";
            this.catagoryBtn.UseVisualStyleBackColor = true;
            // 
            // employeeBtn
            // 
            this.employeeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.employeeBtn.Depth = 0;
            this.employeeBtn.Location = new System.Drawing.Point(312, 3);
            this.employeeBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.employeeBtn.Name = "employeeBtn";
            this.employeeBtn.Primary = true;
            this.employeeBtn.Size = new System.Drawing.Size(97, 33);
            this.employeeBtn.TabIndex = 8;
            this.employeeBtn.Text = "Employee";
            this.employeeBtn.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.62547F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.37453F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.dataGridView1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 39);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1038, 515);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel3.Controls.Add(this.usernmTxt, 1, 7);
            this.tableLayoutPanel3.Controls.Add(this.costTxt, 3, 6);
            this.tableLayoutPanel3.Controls.Add(this.costLbl, 2, 6);
            this.tableLayoutPanel3.Controls.Add(this.priceTxt, 1, 6);
            this.tableLayoutPanel3.Controls.Add(this.itemcodeLbl, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.itemcodeTxt, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.CatagoryTxt, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.materialSingleLineTextField1, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.ItemNameLbl, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.ItemNameTxt, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.ShelfLbl, 2, 2);
            this.tableLayoutPanel3.Controls.Add(this.shelfIdTxt, 3, 2);
            this.tableLayoutPanel3.Controls.Add(this.itemUnitLbl, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.itemUnitTxt, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.itemBarcodeLbl, 2, 4);
            this.tableLayoutPanel3.Controls.Add(this.itemBarcodeTxt, 3, 4);
            this.tableLayoutPanel3.Controls.Add(this.userNmLbl, 0, 7);
            this.tableLayoutPanel3.Controls.Add(this.priceLbl, 0, 6);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 8;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(509, 251);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // usernmTxt
            // 
            this.usernmTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.usernmTxt.Depth = 0;
            this.usernmTxt.Hint = "";
            this.usernmTxt.Location = new System.Drawing.Point(104, 220);
            this.usernmTxt.MouseState = MaterialSkin.MouseState.HOVER;
            this.usernmTxt.Name = "usernmTxt";
            this.usernmTxt.PasswordChar = '\0';
            this.usernmTxt.SelectedText = "";
            this.usernmTxt.SelectionLength = 0;
            this.usernmTxt.SelectionStart = 0;
            this.usernmTxt.Size = new System.Drawing.Size(146, 23);
            this.usernmTxt.TabIndex = 6;
            this.usernmTxt.UseSystemPasswordChar = false;
            // 
            // costTxt
            // 
            this.costTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.costTxt.Depth = 0;
            this.costTxt.Hint = "";
            this.costTxt.Location = new System.Drawing.Point(357, 189);
            this.costTxt.MouseState = MaterialSkin.MouseState.HOVER;
            this.costTxt.Name = "costTxt";
            this.costTxt.PasswordChar = '\0';
            this.costTxt.SelectedText = "";
            this.costTxt.SelectionLength = 0;
            this.costTxt.SelectionStart = 0;
            this.costTxt.Size = new System.Drawing.Size(149, 23);
            this.costTxt.TabIndex = 4;
            this.costTxt.UseSystemPasswordChar = false;
            // 
            // costLbl
            // 
            this.costLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.costLbl.AutoSize = true;
            this.costLbl.Depth = 0;
            this.costLbl.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.costLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.costLbl.Location = new System.Drawing.Point(256, 186);
            this.costLbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.costLbl.Name = "costLbl";
            this.costLbl.Size = new System.Drawing.Size(95, 31);
            this.costLbl.TabIndex = 3;
            this.costLbl.Text = "Cost ";
            // 
            // priceTxt
            // 
            this.priceTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.priceTxt.Depth = 0;
            this.priceTxt.Hint = "";
            this.priceTxt.Location = new System.Drawing.Point(104, 189);
            this.priceTxt.MouseState = MaterialSkin.MouseState.HOVER;
            this.priceTxt.Name = "priceTxt";
            this.priceTxt.PasswordChar = '\0';
            this.priceTxt.SelectedText = "";
            this.priceTxt.SelectionLength = 0;
            this.priceTxt.SelectionStart = 0;
            this.priceTxt.Size = new System.Drawing.Size(146, 23);
            this.priceTxt.TabIndex = 2;
            this.priceTxt.UseSystemPasswordChar = false;
            // 
            // itemcodeLbl
            // 
            this.itemcodeLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.itemcodeLbl.AutoSize = true;
            this.itemcodeLbl.Depth = 0;
            this.itemcodeLbl.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.itemcodeLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.itemcodeLbl.Location = new System.Drawing.Point(3, 0);
            this.itemcodeLbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.itemcodeLbl.Name = "itemcodeLbl";
            this.itemcodeLbl.Size = new System.Drawing.Size(95, 31);
            this.itemcodeLbl.TabIndex = 1;
            this.itemcodeLbl.Text = "Item Code";
            this.itemcodeLbl.Click += new System.EventHandler(this.materialLabel1_Click);
            // 
            // itemcodeTxt
            // 
            this.itemcodeTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.itemcodeTxt.Depth = 0;
            this.itemcodeTxt.Hint = "Item Code";
            this.itemcodeTxt.Location = new System.Drawing.Point(104, 3);
            this.itemcodeTxt.MouseState = MaterialSkin.MouseState.HOVER;
            this.itemcodeTxt.Name = "itemcodeTxt";
            this.itemcodeTxt.PasswordChar = '\0';
            this.itemcodeTxt.SelectedText = "";
            this.itemcodeTxt.SelectionLength = 0;
            this.itemcodeTxt.SelectionStart = 0;
            this.itemcodeTxt.Size = new System.Drawing.Size(146, 23);
            this.itemcodeTxt.TabIndex = 2;
            this.itemcodeTxt.UseSystemPasswordChar = false;
            // 
            // CatagoryTxt
            // 
            this.CatagoryTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CatagoryTxt.AutoSize = true;
            this.CatagoryTxt.Depth = 0;
            this.CatagoryTxt.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CatagoryTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CatagoryTxt.Location = new System.Drawing.Point(256, 0);
            this.CatagoryTxt.MouseState = MaterialSkin.MouseState.HOVER;
            this.CatagoryTxt.Name = "CatagoryTxt";
            this.CatagoryTxt.Size = new System.Drawing.Size(95, 31);
            this.CatagoryTxt.TabIndex = 3;
            this.CatagoryTxt.Text = "Catagory";
            // 
            // materialSingleLineTextField1
            // 
            this.materialSingleLineTextField1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialSingleLineTextField1.Depth = 0;
            this.materialSingleLineTextField1.Hint = "Catagory";
            this.materialSingleLineTextField1.Location = new System.Drawing.Point(357, 3);
            this.materialSingleLineTextField1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField1.Name = "materialSingleLineTextField1";
            this.materialSingleLineTextField1.PasswordChar = '\0';
            this.materialSingleLineTextField1.SelectedText = "";
            this.materialSingleLineTextField1.SelectionLength = 0;
            this.materialSingleLineTextField1.SelectionStart = 0;
            this.materialSingleLineTextField1.Size = new System.Drawing.Size(149, 23);
            this.materialSingleLineTextField1.TabIndex = 4;
            this.materialSingleLineTextField1.UseSystemPasswordChar = false;
            // 
            // ItemNameLbl
            // 
            this.ItemNameLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ItemNameLbl.AutoSize = true;
            this.ItemNameLbl.Depth = 0;
            this.ItemNameLbl.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ItemNameLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ItemNameLbl.Location = new System.Drawing.Point(3, 62);
            this.ItemNameLbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.ItemNameLbl.Name = "ItemNameLbl";
            this.ItemNameLbl.Size = new System.Drawing.Size(95, 31);
            this.ItemNameLbl.TabIndex = 5;
            this.ItemNameLbl.Text = "Item Name";
            // 
            // ItemNameTxt
            // 
            this.ItemNameTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ItemNameTxt.Depth = 0;
            this.ItemNameTxt.Hint = "Item Name";
            this.ItemNameTxt.Location = new System.Drawing.Point(104, 65);
            this.ItemNameTxt.MouseState = MaterialSkin.MouseState.HOVER;
            this.ItemNameTxt.Name = "ItemNameTxt";
            this.ItemNameTxt.PasswordChar = '\0';
            this.ItemNameTxt.SelectedText = "";
            this.ItemNameTxt.SelectionLength = 0;
            this.ItemNameTxt.SelectionStart = 0;
            this.ItemNameTxt.Size = new System.Drawing.Size(146, 23);
            this.ItemNameTxt.TabIndex = 6;
            this.ItemNameTxt.UseSystemPasswordChar = false;
            // 
            // ShelfLbl
            // 
            this.ShelfLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ShelfLbl.AutoSize = true;
            this.ShelfLbl.Depth = 0;
            this.ShelfLbl.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ShelfLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ShelfLbl.Location = new System.Drawing.Point(256, 62);
            this.ShelfLbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.ShelfLbl.Name = "ShelfLbl";
            this.ShelfLbl.Size = new System.Drawing.Size(95, 31);
            this.ShelfLbl.TabIndex = 7;
            this.ShelfLbl.Text = "Shelf ID";
            // 
            // shelfIdTxt
            // 
            this.shelfIdTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.shelfIdTxt.Depth = 0;
            this.shelfIdTxt.Hint = "Shelf ID";
            this.shelfIdTxt.Location = new System.Drawing.Point(357, 65);
            this.shelfIdTxt.MouseState = MaterialSkin.MouseState.HOVER;
            this.shelfIdTxt.Name = "shelfIdTxt";
            this.shelfIdTxt.PasswordChar = '\0';
            this.shelfIdTxt.SelectedText = "";
            this.shelfIdTxt.SelectionLength = 0;
            this.shelfIdTxt.SelectionStart = 0;
            this.shelfIdTxt.Size = new System.Drawing.Size(149, 23);
            this.shelfIdTxt.TabIndex = 8;
            this.shelfIdTxt.UseSystemPasswordChar = false;
            // 
            // itemUnitLbl
            // 
            this.itemUnitLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.itemUnitLbl.AutoSize = true;
            this.itemUnitLbl.Depth = 0;
            this.itemUnitLbl.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.itemUnitLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.itemUnitLbl.Location = new System.Drawing.Point(3, 124);
            this.itemUnitLbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.itemUnitLbl.Name = "itemUnitLbl";
            this.itemUnitLbl.Size = new System.Drawing.Size(95, 31);
            this.itemUnitLbl.TabIndex = 9;
            this.itemUnitLbl.Text = "Item Unit";
            // 
            // itemUnitTxt
            // 
            this.itemUnitTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.itemUnitTxt.Depth = 0;
            this.itemUnitTxt.Hint = "Item Unit";
            this.itemUnitTxt.Location = new System.Drawing.Point(104, 127);
            this.itemUnitTxt.MouseState = MaterialSkin.MouseState.HOVER;
            this.itemUnitTxt.Name = "itemUnitTxt";
            this.itemUnitTxt.PasswordChar = '\0';
            this.itemUnitTxt.SelectedText = "";
            this.itemUnitTxt.SelectionLength = 0;
            this.itemUnitTxt.SelectionStart = 0;
            this.itemUnitTxt.Size = new System.Drawing.Size(146, 23);
            this.itemUnitTxt.TabIndex = 10;
            this.itemUnitTxt.UseSystemPasswordChar = false;
            // 
            // itemBarcodeLbl
            // 
            this.itemBarcodeLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.itemBarcodeLbl.AutoSize = true;
            this.itemBarcodeLbl.Depth = 0;
            this.itemBarcodeLbl.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.itemBarcodeLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.itemBarcodeLbl.Location = new System.Drawing.Point(256, 124);
            this.itemBarcodeLbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.itemBarcodeLbl.Name = "itemBarcodeLbl";
            this.itemBarcodeLbl.Size = new System.Drawing.Size(95, 31);
            this.itemBarcodeLbl.TabIndex = 11;
            this.itemBarcodeLbl.Text = "Item Barcode";
            // 
            // itemBarcodeTxt
            // 
            this.itemBarcodeTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.itemBarcodeTxt.Depth = 0;
            this.itemBarcodeTxt.Hint = "Item Barcode";
            this.itemBarcodeTxt.Location = new System.Drawing.Point(357, 127);
            this.itemBarcodeTxt.MouseState = MaterialSkin.MouseState.HOVER;
            this.itemBarcodeTxt.Name = "itemBarcodeTxt";
            this.itemBarcodeTxt.PasswordChar = '\0';
            this.itemBarcodeTxt.SelectedText = "";
            this.itemBarcodeTxt.SelectionLength = 0;
            this.itemBarcodeTxt.SelectionStart = 0;
            this.itemBarcodeTxt.Size = new System.Drawing.Size(149, 23);
            this.itemBarcodeTxt.TabIndex = 12;
            this.itemBarcodeTxt.UseSystemPasswordChar = false;
            // 
            // userNmLbl
            // 
            this.userNmLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userNmLbl.AutoSize = true;
            this.userNmLbl.Depth = 0;
            this.userNmLbl.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userNmLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.userNmLbl.Location = new System.Drawing.Point(3, 217);
            this.userNmLbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.userNmLbl.Name = "userNmLbl";
            this.userNmLbl.Size = new System.Drawing.Size(95, 34);
            this.userNmLbl.TabIndex = 5;
            this.userNmLbl.Text = "User Name";
            // 
            // priceLbl
            // 
            this.priceLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.priceLbl.AutoSize = true;
            this.priceLbl.Depth = 0;
            this.priceLbl.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.priceLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.priceLbl.Location = new System.Drawing.Point(3, 186);
            this.priceLbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.priceLbl.Name = "priceLbl";
            this.priceLbl.Size = new System.Drawing.Size(95, 31);
            this.priceLbl.TabIndex = 1;
            this.priceLbl.Text = "Price";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemCode,
            this.itemName,
            this.qty,
            this.dicount,
            this.price,
            this.total});
            this.dataGridView1.Location = new System.Drawing.Point(3, 260);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(509, 252);
            this.dataGridView1.TabIndex = 1;
            // 
            // itemCode
            // 
            this.itemCode.HeaderText = "ItemCode";
            this.itemCode.Name = "itemCode";
            // 
            // itemName
            // 
            this.itemName.HeaderText = "ItemName";
            this.itemName.Name = "itemName";
            // 
            // qty
            // 
            this.qty.HeaderText = "Qty";
            this.qty.Name = "qty";
            // 
            // dicount
            // 
            this.dicount.HeaderText = "Discount";
            this.dicount.Name = "dicount";
            // 
            // price
            // 
            this.price.HeaderText = "Price";
            this.price.Name = "price";
            // 
            // total
            // 
            this.total.HeaderText = "Total";
            this.total.Name = "total";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.cstmraddrsTxt, 1, 3);
            this.tableLayoutPanel4.Controls.Add(this.materialLabel1, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.cstmrmailTxt, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.cutmrConLbl, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.cstmrTxt, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.custmrLbl, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.cstmrconctTxt, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.cutmraddrsLbl, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.addCustmrBtn, 1, 4);
            this.tableLayoutPanel4.Controls.Add(this.materialLabel2, 0, 4);
            this.tableLayoutPanel4.Controls.Add(this.dateTimePicker1, 0, 5);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(518, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 6;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(517, 251);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // cstmraddrsTxt
            // 
            this.cstmraddrsTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cstmraddrsTxt.Depth = 0;
            this.cstmraddrsTxt.Hint = "";
            this.cstmraddrsTxt.Location = new System.Drawing.Point(261, 78);
            this.cstmraddrsTxt.MouseState = MaterialSkin.MouseState.HOVER;
            this.cstmraddrsTxt.Name = "cstmraddrsTxt";
            this.cstmraddrsTxt.PasswordChar = '\0';
            this.cstmraddrsTxt.SelectedText = "";
            this.cstmraddrsTxt.SelectionLength = 0;
            this.cstmraddrsTxt.SelectionStart = 0;
            this.cstmraddrsTxt.Size = new System.Drawing.Size(253, 23);
            this.cstmraddrsTxt.TabIndex = 19;
            this.cstmraddrsTxt.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(3, 50);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(252, 25);
            this.materialLabel1.TabIndex = 18;
            this.materialLabel1.Text = "Customer E-Mail";
            // 
            // cstmrmailTxt
            // 
            this.cstmrmailTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cstmrmailTxt.Depth = 0;
            this.cstmrmailTxt.Hint = "";
            this.cstmrmailTxt.Location = new System.Drawing.Point(261, 53);
            this.cstmrmailTxt.MouseState = MaterialSkin.MouseState.HOVER;
            this.cstmrmailTxt.Name = "cstmrmailTxt";
            this.cstmrmailTxt.PasswordChar = '\0';
            this.cstmrmailTxt.SelectedText = "";
            this.cstmrmailTxt.SelectionLength = 0;
            this.cstmrmailTxt.SelectionStart = 0;
            this.cstmrmailTxt.Size = new System.Drawing.Size(253, 23);
            this.cstmrmailTxt.TabIndex = 17;
            this.cstmrmailTxt.UseSystemPasswordChar = false;
            // 
            // cutmrConLbl
            // 
            this.cutmrConLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cutmrConLbl.AutoSize = true;
            this.cutmrConLbl.Depth = 0;
            this.cutmrConLbl.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cutmrConLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cutmrConLbl.Location = new System.Drawing.Point(3, 25);
            this.cutmrConLbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.cutmrConLbl.Name = "cutmrConLbl";
            this.cutmrConLbl.Size = new System.Drawing.Size(252, 25);
            this.cutmrConLbl.TabIndex = 14;
            this.cutmrConLbl.Text = "Customer Contact";
            // 
            // cstmrTxt
            // 
            this.cstmrTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cstmrTxt.Depth = 0;
            this.cstmrTxt.Hint = "";
            this.cstmrTxt.Location = new System.Drawing.Point(261, 3);
            this.cstmrTxt.MouseState = MaterialSkin.MouseState.HOVER;
            this.cstmrTxt.Name = "cstmrTxt";
            this.cstmrTxt.PasswordChar = '\0';
            this.cstmrTxt.SelectedText = "";
            this.cstmrTxt.SelectionLength = 0;
            this.cstmrTxt.SelectionStart = 0;
            this.cstmrTxt.Size = new System.Drawing.Size(253, 23);
            this.cstmrTxt.TabIndex = 13;
            this.cstmrTxt.UseSystemPasswordChar = false;
            // 
            // custmrLbl
            // 
            this.custmrLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.custmrLbl.AutoSize = true;
            this.custmrLbl.Depth = 0;
            this.custmrLbl.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.custmrLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.custmrLbl.Location = new System.Drawing.Point(3, 0);
            this.custmrLbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.custmrLbl.Name = "custmrLbl";
            this.custmrLbl.Size = new System.Drawing.Size(252, 25);
            this.custmrLbl.TabIndex = 13;
            this.custmrLbl.Text = "Customer Name";
            // 
            // cstmrconctTxt
            // 
            this.cstmrconctTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cstmrconctTxt.Depth = 0;
            this.cstmrconctTxt.Hint = "";
            this.cstmrconctTxt.Location = new System.Drawing.Point(261, 28);
            this.cstmrconctTxt.MouseState = MaterialSkin.MouseState.HOVER;
            this.cstmrconctTxt.Name = "cstmrconctTxt";
            this.cstmrconctTxt.PasswordChar = '\0';
            this.cstmrconctTxt.SelectedText = "";
            this.cstmrconctTxt.SelectionLength = 0;
            this.cstmrconctTxt.SelectionStart = 0;
            this.cstmrconctTxt.Size = new System.Drawing.Size(253, 23);
            this.cstmrconctTxt.TabIndex = 16;
            this.cstmrconctTxt.UseSystemPasswordChar = false;
            // 
            // cutmraddrsLbl
            // 
            this.cutmraddrsLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cutmraddrsLbl.AutoSize = true;
            this.cutmraddrsLbl.Depth = 0;
            this.cutmraddrsLbl.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cutmraddrsLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cutmraddrsLbl.Location = new System.Drawing.Point(3, 75);
            this.cutmraddrsLbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.cutmraddrsLbl.Name = "cutmraddrsLbl";
            this.cutmraddrsLbl.Size = new System.Drawing.Size(252, 25);
            this.cutmraddrsLbl.TabIndex = 15;
            this.cutmraddrsLbl.Text = "Customer Address";
            // 
            // addCustmrBtn
            // 
            this.addCustmrBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addCustmrBtn.AutoSize = true;
            this.addCustmrBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addCustmrBtn.Depth = 0;
            this.addCustmrBtn.Location = new System.Drawing.Point(262, 106);
            this.addCustmrBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.addCustmrBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.addCustmrBtn.Name = "addCustmrBtn";
            this.addCustmrBtn.Primary = false;
            this.addCustmrBtn.Size = new System.Drawing.Size(251, 38);
            this.addCustmrBtn.TabIndex = 22;
            this.addCustmrBtn.Text = "ADD CUSTOMER";
            this.addCustmrBtn.UseVisualStyleBackColor = true;
            // 
            // materialLabel2
            // 
            this.materialLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.materialLabel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(3, 100);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(252, 50);
            this.materialLabel2.TabIndex = 23;
            this.materialLabel2.Text = "Welcome to Our Customers";
            this.materialLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePicker1.Location = new System.Drawing.Point(3, 153);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(252, 23);
            this.dateTimePicker1.TabIndex = 24;
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Location = new System.Drawing.Point(0, 0);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(172, 36);
            this.materialFlatButton1.TabIndex = 0;
            this.materialFlatButton1.Text = "materialFlatButton1";
            // 
            // materialFlatButton2
            // 
            this.materialFlatButton2.AutoSize = true;
            this.materialFlatButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton2.Depth = 0;
            this.materialFlatButton2.Location = new System.Drawing.Point(0, 0);
            this.materialFlatButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton2.Name = "materialFlatButton2";
            this.materialFlatButton2.Primary = false;
            this.materialFlatButton2.Size = new System.Drawing.Size(172, 36);
            this.materialFlatButton2.TabIndex = 0;
            this.materialFlatButton2.Text = "materialFlatButton2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel5.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 554);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialRaisedButton customerBtn;
        private MaterialSkin.Controls.MaterialRaisedButton ItemsBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MaterialSkin.Controls.MaterialRaisedButton shelfBtn;
        private MaterialSkin.Controls.MaterialRaisedButton catagoryBtn;
        private MaterialSkin.Controls.MaterialRaisedButton employeeBtn;
        private MaterialSkin.Controls.MaterialRaisedButton unitBtn;
        private MaterialSkin.Controls.MaterialRaisedButton invoicebtn;
        private MaterialSkin.Controls.MaterialRaisedButton sellpriceBtn;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private MaterialSkin.Controls.MaterialLabel itemcodeLbl;
        private MaterialSkin.Controls.MaterialSingleLineTextField itemcodeTxt;
        private MaterialSkin.Controls.MaterialLabel priceLbl;
        private MaterialSkin.Controls.MaterialSingleLineTextField priceTxt;
        private MaterialSkin.Controls.MaterialLabel costLbl;
        private MaterialSkin.Controls.MaterialSingleLineTextField costTxt;
        private MaterialSkin.Controls.MaterialLabel userNmLbl;
        private MaterialSkin.Controls.MaterialSingleLineTextField usernmTxt;
        private MaterialSkin.Controls.MaterialLabel CatagoryTxt;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField1;
        private MaterialSkin.Controls.MaterialLabel ItemNameLbl;
        private MaterialSkin.Controls.MaterialSingleLineTextField ItemNameTxt;
        private MaterialSkin.Controls.MaterialLabel ShelfLbl;
        private MaterialSkin.Controls.MaterialSingleLineTextField shelfIdTxt;
        private MaterialSkin.Controls.MaterialLabel itemUnitLbl;
        private MaterialSkin.Controls.MaterialSingleLineTextField itemUnitTxt;
        private MaterialSkin.Controls.MaterialLabel itemBarcodeLbl;
        private MaterialSkin.Controls.MaterialSingleLineTextField itemBarcodeTxt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn dicount;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private MaterialSkin.Controls.MaterialSingleLineTextField cstmraddrsTxt;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField cstmrmailTxt;
        private MaterialSkin.Controls.MaterialLabel cutmrConLbl;
        private MaterialSkin.Controls.MaterialSingleLineTextField cstmrTxt;
        private MaterialSkin.Controls.MaterialLabel custmrLbl;
        private MaterialSkin.Controls.MaterialSingleLineTextField cstmrconctTxt;
        private MaterialSkin.Controls.MaterialLabel cutmraddrsLbl;
        private MaterialSkin.Controls.MaterialFlatButton addCustmrBtn;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

