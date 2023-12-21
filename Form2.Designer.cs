
namespace lab67
{
    partial class Form2
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
            System.Windows.Forms.Label txtDoctorNameLabel;
            System.Windows.Forms.Label txtSpecialistLabel;
            System.Windows.Forms.Label datDoctorWorkLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.hOSPITALDataSet = new lab67.HOSPITALDataSet();
            this.tblDoctorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblDoctorTableAdapter = new lab67.HOSPITALDataSetTableAdapters.tblDoctorTableAdapter();
            this.tableAdapterManager = new lab67.HOSPITALDataSetTableAdapters.TableAdapterManager();
            this.tblDoctorBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.tblDoctorBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.txtDoctorNameTextBox = new System.Windows.Forms.TextBox();
            this.txtSpecialistTextBox = new System.Windows.Forms.TextBox();
            this.datDoctorWorkDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            txtDoctorNameLabel = new System.Windows.Forms.Label();
            txtSpecialistLabel = new System.Windows.Forms.Label();
            datDoctorWorkLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hOSPITALDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDoctorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDoctorBindingNavigator)).BeginInit();
            this.tblDoctorBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDoctorNameLabel
            // 
            txtDoctorNameLabel.AutoSize = true;
            txtDoctorNameLabel.Location = new System.Drawing.Point(27, 64);
            txtDoctorNameLabel.Name = "txtDoctorNameLabel";
            txtDoctorNameLabel.Size = new System.Drawing.Size(103, 17);
            txtDoctorNameLabel.TabIndex = 3;
            txtDoctorNameLabel.Text = "ФИО Доктора";
            txtDoctorNameLabel.Click += new System.EventHandler(this.txtDoctorNameLabel_Click);
            // 
            // txtSpecialistLabel
            // 
            txtSpecialistLabel.AutoSize = true;
            txtSpecialistLabel.Location = new System.Drawing.Point(27, 92);
            txtSpecialistLabel.Name = "txtSpecialistLabel";
            txtSpecialistLabel.Size = new System.Drawing.Size(109, 17);
            txtSpecialistLabel.TabIndex = 5;
            txtSpecialistLabel.Text = "Специальность";
            // 
            // datDoctorWorkLabel
            // 
            datDoctorWorkLabel.AutoSize = true;
            datDoctorWorkLabel.Location = new System.Drawing.Point(27, 121);
            datDoctorWorkLabel.Name = "datDoctorWorkLabel";
            datDoctorWorkLabel.Size = new System.Drawing.Size(165, 17);
            datDoctorWorkLabel.TabIndex = 7;
            datDoctorWorkLabel.Text = "Дата приема на работу";
            datDoctorWorkLabel.Click += new System.EventHandler(this.datDoctorWorkLabel_Click);
            // 
            // hOSPITALDataSet
            // 
            this.hOSPITALDataSet.DataSetName = "HOSPITALDataSet";
            this.hOSPITALDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblDoctorBindingSource
            // 
            this.tblDoctorBindingSource.DataMember = "tblDoctor";
            this.tblDoctorBindingSource.DataSource = this.hOSPITALDataSet;
            // 
            // tblDoctorTableAdapter
            // 
            this.tblDoctorTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tblDoctorTableAdapter = this.tblDoctorTableAdapter;
            this.tableAdapterManager.tblDrugTableAdapter = null;
            this.tableAdapterManager.tblPatientTableAdapter = null;
            this.tableAdapterManager.tblReceptionTableAdapter = null;
            this.tableAdapterManager.tblRecipeTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = lab67.HOSPITALDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tblDoctorBindingNavigator
            // 
            this.tblDoctorBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tblDoctorBindingNavigator.BindingSource = this.tblDoctorBindingSource;
            this.tblDoctorBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tblDoctorBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tblDoctorBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tblDoctorBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tblDoctorBindingNavigatorSaveItem});
            this.tblDoctorBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tblDoctorBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tblDoctorBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tblDoctorBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tblDoctorBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tblDoctorBindingNavigator.Name = "tblDoctorBindingNavigator";
            this.tblDoctorBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tblDoctorBindingNavigator.Size = new System.Drawing.Size(818, 31);
            this.tblDoctorBindingNavigator.TabIndex = 0;
            this.tblDoctorBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 28);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
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
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // tblDoctorBindingNavigatorSaveItem
            // 
            this.tblDoctorBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tblDoctorBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tblDoctorBindingNavigatorSaveItem.Image")));
            this.tblDoctorBindingNavigatorSaveItem.Name = "tblDoctorBindingNavigatorSaveItem";
            this.tblDoctorBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 28);
            this.tblDoctorBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.tblDoctorBindingNavigatorSaveItem.Click += new System.EventHandler(this.tblDoctorBindingNavigatorSaveItem_Click);
            // 
            // txtDoctorNameTextBox
            // 
            this.txtDoctorNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblDoctorBindingSource, "txtDoctorName", true));
            this.txtDoctorNameTextBox.Location = new System.Drawing.Point(198, 61);
            this.txtDoctorNameTextBox.Name = "txtDoctorNameTextBox";
            this.txtDoctorNameTextBox.Size = new System.Drawing.Size(200, 22);
            this.txtDoctorNameTextBox.TabIndex = 4;
            // 
            // txtSpecialistTextBox
            // 
            this.txtSpecialistTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblDoctorBindingSource, "txtSpecialist", true));
            this.txtSpecialistTextBox.Location = new System.Drawing.Point(198, 89);
            this.txtSpecialistTextBox.Name = "txtSpecialistTextBox";
            this.txtSpecialistTextBox.Size = new System.Drawing.Size(200, 22);
            this.txtSpecialistTextBox.TabIndex = 6;
            // 
            // datDoctorWorkDateTimePicker
            // 
            this.datDoctorWorkDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tblDoctorBindingSource, "datDoctorWork", true));
            this.datDoctorWorkDateTimePicker.Location = new System.Drawing.Point(198, 121);
            this.datDoctorWorkDateTimePicker.Name = "datDoctorWorkDateTimePicker";
            this.datDoctorWorkDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.datDoctorWorkDateTimePicker.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(42, 284);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Отмена";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(181, 284);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(359, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Выход из формы";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(txtDoctorNameLabel);
            this.Controls.Add(this.txtDoctorNameTextBox);
            this.Controls.Add(txtSpecialistLabel);
            this.Controls.Add(this.txtSpecialistTextBox);
            this.Controls.Add(datDoctorWorkLabel);
            this.Controls.Add(this.datDoctorWorkDateTimePicker);
            this.Controls.Add(this.tblDoctorBindingNavigator);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hOSPITALDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDoctorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDoctorBindingNavigator)).EndInit();
            this.tblDoctorBindingNavigator.ResumeLayout(false);
            this.tblDoctorBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HOSPITALDataSet hOSPITALDataSet;
        private System.Windows.Forms.BindingSource tblDoctorBindingSource;
        private HOSPITALDataSetTableAdapters.tblDoctorTableAdapter tblDoctorTableAdapter;
        private HOSPITALDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tblDoctorBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tblDoctorBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox txtDoctorNameTextBox;
        private System.Windows.Forms.TextBox txtSpecialistTextBox;
        private System.Windows.Forms.DateTimePicker datDoctorWorkDateTimePicker;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}