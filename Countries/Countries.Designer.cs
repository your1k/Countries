
namespace Countries
{
    partial class Countries
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Countries));
            this.cbCountries = new System.Windows.Forms.ComboBox();
            this.lInfo = new System.Windows.Forms.Label();
            this.pbFlag = new System.Windows.Forms.PictureBox();
            this.Panel = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pbFlag)).BeginInit();
            this.Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbCountries
            // 
            this.cbCountries.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbCountries.DisplayMember = "Name";
            this.cbCountries.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCountries.FormattingEnabled = true;
            this.cbCountries.Location = new System.Drawing.Point(127, 4);
            this.cbCountries.Name = "cbCountries";
            this.cbCountries.Size = new System.Drawing.Size(300, 21);
            this.cbCountries.TabIndex = 0;
            this.cbCountries.SelectedValueChanged += new System.EventHandler(this.cbCountries_SelectedValueChanged);
            // 
            // lInfo
            // 
            this.lInfo.AutoSize = true;
            this.lInfo.Location = new System.Drawing.Point(3, 378);
            this.lInfo.Name = "lInfo";
            this.lInfo.Size = new System.Drawing.Size(0, 13);
            this.lInfo.TabIndex = 2;
            // 
            // pbFlag
            // 
            this.pbFlag.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbFlag.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbFlag.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbFlag.Location = new System.Drawing.Point(3, 33);
            this.pbFlag.Name = "pbFlag";
            this.pbFlag.Size = new System.Drawing.Size(549, 342);
            this.pbFlag.TabIndex = 3;
            this.pbFlag.TabStop = false;
            // 
            // Panel
            // 
            this.Panel.ColumnCount = 1;
            this.Panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Panel.Controls.Add(this.cbCountries, 0, 0);
            this.Panel.Controls.Add(this.lInfo, 0, 2);
            this.Panel.Controls.Add(this.pbFlag, 0, 1);
            this.Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel.Location = new System.Drawing.Point(0, 0);
            this.Panel.Name = "Panel";
            this.Panel.RowCount = 3;
            this.Panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.Panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.Panel.Size = new System.Drawing.Size(555, 428);
            this.Panel.TabIndex = 4;
            // 
            // Countries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 428);
            this.Controls.Add(this.Panel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Countries";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Countries";
            ((System.ComponentModel.ISupportInitialize)(this.pbFlag)).EndInit();
            this.Panel.ResumeLayout(false);
            this.Panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbCountries;
        private System.Windows.Forms.Label lInfo;
        private System.Windows.Forms.PictureBox pbFlag;
        private System.Windows.Forms.TableLayoutPanel Panel;
    }
}

