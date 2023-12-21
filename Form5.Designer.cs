
namespace lab67
{
    partial class Form5
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
            System.Windows.Forms.Label intDoctorIdLabel;
            System.Windows.Forms.Label intPatientIdLabel;
            System.Windows.Forms.Label datReceptionDateLabel;
            System.Windows.Forms.Label txtReceptionTimeLabel;
            System.Windows.Forms.Label txtReceptionRoomLabel;
            System.Windows.Forms.Label txtReceptionResultLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            System.Windows.Forms.Label label1;
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.hOSPITALDataSet = new lab67.HOSPITALDataSet();
            this.tblReceptionTableAdapter = new lab67.HOSPITALDataSetTableAdapters.tblReceptionTableAdapter();
            this.tableAdapterManager = new lab67.HOSPITALDataSetTableAdapters.TableAdapterManager();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox4 = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.tblReceptionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblReceptionBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tblReceptionBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.intDoctorIdTextBox = new System.Windows.Forms.TextBox();
            this.intPatientIdTextBox = new System.Windows.Forms.TextBox();
            this.datReceptionDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.txtReceptionTimeTextBox = new System.Windows.Forms.TextBox();
            this.txtReceptionRoomTextBox = new System.Windows.Forms.TextBox();
            this.txtReceptionResultTextBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            intDoctorIdLabel = new System.Windows.Forms.Label();
            intPatientIdLabel = new System.Windows.Forms.Label();
            datReceptionDateLabel = new System.Windows.Forms.Label();
            txtReceptionTimeLabel = new System.Windows.Forms.Label();
            txtReceptionRoomLabel = new System.Windows.Forms.Label();
            txtReceptionResultLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hOSPITALDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblReceptionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblReceptionBindingNavigator)).BeginInit();
            this.tblReceptionBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // intDoctorIdLabel
            // 
            intDoctorIdLabel.AutoSize = true;
            intDoctorIdLabel.Location = new System.Drawing.Point(220, 47);
            intDoctorIdLabel.Name = "intDoctorIdLabel";
            intDoctorIdLabel.Size = new System.Drawing.Size(103, 17);
            intDoctorIdLabel.TabIndex = 24;
            intDoctorIdLabel.Text = "ФИО Доктора";
            // 
            // intPatientIdLabel
            // 
            intPatientIdLabel.AutoSize = true;
            intPatientIdLabel.Location = new System.Drawing.Point(218, 138);
            intPatientIdLabel.Name = "intPatientIdLabel";
            intPatientIdLabel.Size = new System.Drawing.Size(109, 17);
            intPatientIdLabel.TabIndex = 26;
            intPatientIdLabel.Text = "Специальность";
            // 
            // datReceptionDateLabel
            // 
            datReceptionDateLabel.AutoSize = true;
            datReceptionDateLabel.Location = new System.Drawing.Point(220, 253);
            datReceptionDateLabel.Name = "datReceptionDateLabel";
            datReceptionDateLabel.Size = new System.Drawing.Size(95, 17);
            datReceptionDateLabel.TabIndex = 28;
            datReceptionDateLabel.Text = "Дата приема";
            // 
            // txtReceptionTimeLabel
            // 
            txtReceptionTimeLabel.AutoSize = true;
            txtReceptionTimeLabel.Location = new System.Drawing.Point(220, 301);
            txtReceptionTimeLabel.Name = "txtReceptionTimeLabel";
            txtReceptionTimeLabel.Size = new System.Drawing.Size(103, 17);
            txtReceptionTimeLabel.TabIndex = 30;
            txtReceptionTimeLabel.Text = "Время приема";
            // 
            // txtReceptionRoomLabel
            // 
            txtReceptionRoomLabel.AutoSize = true;
            txtReceptionRoomLabel.Location = new System.Drawing.Point(218, 348);
            txtReceptionRoomLabel.Name = "txtReceptionRoomLabel";
            txtReceptionRoomLabel.Size = new System.Drawing.Size(64, 17);
            txtReceptionRoomLabel.TabIndex = 32;
            txtReceptionRoomLabel.Text = "Кабинет";
            // 
            // txtReceptionResultLabel
            // 
            txtReceptionResultLabel.AutoSize = true;
            txtReceptionResultLabel.Location = new System.Drawing.Point(218, 385);
            txtReceptionResultLabel.Name = "txtReceptionResultLabel";
            txtReceptionResultLabel.Size = new System.Drawing.Size(90, 17);
            txtReceptionResultLabel.TabIndex = 34;
            txtReceptionResultLabel.Text = "Заключение";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(355, 341);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(207, 24);
            this.comboBox2.TabIndex = 3;
            // 
            // hOSPITALDataSet
            // 
            this.hOSPITALDataSet.DataSetName = "HOSPITALDataSet";
            this.hOSPITALDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblReceptionTableAdapter
            // 
            this.tblReceptionTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tblDoctorTableAdapter = null;
            this.tableAdapterManager.tblDrugTableAdapter = null;
            this.tableAdapterManager.tblPatientTableAdapter = null;
            this.tableAdapterManager.tblReceptionTableAdapter = this.tblReceptionTableAdapter;
            this.tableAdapterManager.tblRecipeTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = lab67.HOSPITALDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // richTextBox3
            // 
            this.richTextBox3.Location = new System.Drawing.Point(514, 74);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(10, 10);
            this.richTextBox3.TabIndex = 16;
            this.richTextBox3.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(524, 434);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox4
            // 
            this.richTextBox4.Location = new System.Drawing.Point(514, 74);
            this.richTextBox4.Name = "richTextBox4";
            this.richTextBox4.Size = new System.Drawing.Size(10, 10);
            this.richTextBox4.TabIndex = 18;
            this.richTextBox4.Text = "";
            this.richTextBox4.TextChanged += new System.EventHandler(this.richTextBox4_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(685, 434);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 21;
            this.button2.Text = "Закрыть";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tblReceptionBindingSource
            // 
            this.tblReceptionBindingSource.DataMember = "tblReception";
            this.tblReceptionBindingSource.DataSource = this.hOSPITALDataSet;
            // 
            // tblReceptionBindingNavigator
            // 
            this.tblReceptionBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tblReceptionBindingNavigator.BindingSource = this.tblReceptionBindingSource;
            this.tblReceptionBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tblReceptionBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tblReceptionBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tblReceptionBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.tblReceptionBindingNavigatorSaveItem});
            this.tblReceptionBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tblReceptionBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tblReceptionBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tblReceptionBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tblReceptionBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tblReceptionBindingNavigator.Name = "tblReceptionBindingNavigator";
            this.tblReceptionBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tblReceptionBindingNavigator.Size = new System.Drawing.Size(800, 27);
            this.tblReceptionBindingNavigator.TabIndex = 22;
            this.tblReceptionBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 24);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            this.bindingNavigatorPositionItem.Click += new System.EventHandler(this.bindingNavigatorPositionItem_Click);
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // tblReceptionBindingNavigatorSaveItem
            // 
            this.tblReceptionBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tblReceptionBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tblReceptionBindingNavigatorSaveItem.Image")));
            this.tblReceptionBindingNavigatorSaveItem.Name = "tblReceptionBindingNavigatorSaveItem";
            this.tblReceptionBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.tblReceptionBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.tblReceptionBindingNavigatorSaveItem.Click += new System.EventHandler(this.tblReceptionBindingNavigatorSaveItem_Click_1);
            // 
            // intDoctorIdTextBox
            // 
            this.intDoctorIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblReceptionBindingSource, "intDoctorId", true));
            this.intDoctorIdTextBox.Location = new System.Drawing.Point(514, 64);
            this.intDoctorIdTextBox.Name = "intDoctorIdTextBox";
            this.intDoctorIdTextBox.Size = new System.Drawing.Size(10, 22);
            this.intDoctorIdTextBox.TabIndex = 25;
            // 
            // intPatientIdTextBox
            // 
            this.intPatientIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblReceptionBindingSource, "intPatientId", true));
            this.intPatientIdTextBox.Location = new System.Drawing.Point(514, 62);
            this.intPatientIdTextBox.Name = "intPatientIdTextBox";
            this.intPatientIdTextBox.Size = new System.Drawing.Size(10, 22);
            this.intPatientIdTextBox.TabIndex = 27;
            this.intPatientIdTextBox.TextChanged += new System.EventHandler(this.intPatientIdTextBox_TextChanged);
            // 
            // datReceptionDateDateTimePicker
            // 
            this.datReceptionDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tblReceptionBindingSource, "datReceptionDate", true));
            this.datReceptionDateDateTimePicker.Location = new System.Drawing.Point(355, 248);
            this.datReceptionDateDateTimePicker.Name = "datReceptionDateDateTimePicker";
            this.datReceptionDateDateTimePicker.Size = new System.Drawing.Size(207, 22);
            this.datReceptionDateDateTimePicker.TabIndex = 29;
            // 
            // txtReceptionTimeTextBox
            // 
            this.txtReceptionTimeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblReceptionBindingSource, "txtReceptionTime", true));
            this.txtReceptionTimeTextBox.Location = new System.Drawing.Point(355, 298);
            this.txtReceptionTimeTextBox.Name = "txtReceptionTimeTextBox";
            this.txtReceptionTimeTextBox.Size = new System.Drawing.Size(207, 22);
            this.txtReceptionTimeTextBox.TabIndex = 31;
            // 
            // txtReceptionRoomTextBox
            // 
            this.txtReceptionRoomTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblReceptionBindingSource, "txtReceptionRoom", true));
            this.txtReceptionRoomTextBox.Location = new System.Drawing.Point(514, 62);
            this.txtReceptionRoomTextBox.Name = "txtReceptionRoomTextBox";
            this.txtReceptionRoomTextBox.Size = new System.Drawing.Size(10, 22);
            this.txtReceptionRoomTextBox.TabIndex = 33;
            // 
            // txtReceptionResultTextBox
            // 
            this.txtReceptionResultTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblReceptionBindingSource, "txtReceptionResult", true));
            this.txtReceptionResultTextBox.Location = new System.Drawing.Point(355, 382);
            this.txtReceptionResultTextBox.Name = "txtReceptionResultTextBox";
            this.txtReceptionResultTextBox.Size = new System.Drawing.Size(207, 22);
            this.txtReceptionResultTextBox.TabIndex = 35;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(355, 197);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(207, 24);
            this.comboBox1.TabIndex = 36;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(355, 30);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(207, 62);
            this.richTextBox1.TabIndex = 37;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(355, 111);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(207, 57);
            this.richTextBox2.TabIndex = 38;
            this.richTextBox2.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(220, 200);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(65, 17);
            label1.TabIndex = 39;
            label1.Text = "Пациент";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 469);
            this.Controls.Add(label1);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(intDoctorIdLabel);
            this.Controls.Add(intPatientIdLabel);
            this.Controls.Add(datReceptionDateLabel);
            this.Controls.Add(this.datReceptionDateDateTimePicker);
            this.Controls.Add(txtReceptionTimeLabel);
            this.Controls.Add(this.txtReceptionTimeTextBox);
            this.Controls.Add(txtReceptionRoomLabel);
            this.Controls.Add(this.txtReceptionRoomTextBox);
            this.Controls.Add(txtReceptionResultLabel);
            this.Controls.Add(this.txtReceptionResultTextBox);
            this.Controls.Add(this.tblReceptionBindingNavigator);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.intDoctorIdTextBox);
            this.Controls.Add(this.intPatientIdTextBox);
            this.Controls.Add(this.richTextBox4);
            this.Controls.Add(this.richTextBox3);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hOSPITALDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblReceptionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblReceptionBindingNavigator)).EndInit();
            this.tblReceptionBindingNavigator.ResumeLayout(false);
            this.tblReceptionBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox2;
        private HOSPITALDataSet hOSPITALDataSet;
        private HOSPITALDataSetTableAdapters.tblReceptionTableAdapter tblReceptionTableAdapter;
        private HOSPITALDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource tblReceptionBindingSource;
        private System.Windows.Forms.BindingNavigator tblReceptionBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tblReceptionBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox intDoctorIdTextBox;
        private System.Windows.Forms.TextBox intPatientIdTextBox;
        private System.Windows.Forms.DateTimePicker datReceptionDateDateTimePicker;
        private System.Windows.Forms.TextBox txtReceptionTimeTextBox;
        private System.Windows.Forms.TextBox txtReceptionRoomTextBox;
        private System.Windows.Forms.TextBox txtReceptionResultTextBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
    }
}