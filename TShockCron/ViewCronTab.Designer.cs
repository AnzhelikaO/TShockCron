﻿extern alias glwinforms;
using winforms = glwinforms.System.Windows.Forms;

namespace TShockCron
{
    partial class ViewCronTab
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
            this.dataCronTab = new winforms.DataGridView();
            this.btnReload = new winforms.Button();
            this.btnSave = new winforms.Button();
            this.tabRefresh = new winforms.Button();
            this.btnTest = new winforms.Button();
            this.lblOptions = new winforms.Label();
            this.lblSaveStatus = new winforms.Label();
            this.listSchedule = new winforms.ListView();
            this.colScheduledEvents = ((winforms.ColumnHeader)(new winforms.ColumnHeader()));
            this.cronOptions = new winforms.DataGridViewTextBoxColumn();
            this.cronCommand = new winforms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataCronTab)).BeginInit();
            this.SuspendLayout();
            // 
            // dataCronTab
            // 
            this.dataCronTab.BackgroundColor = System.Drawing.Color.White;
            this.dataCronTab.ColumnHeadersHeightSizeMode = winforms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCronTab.Columns.AddRange(new winforms.DataGridViewColumn[] {
            this.cronOptions,
            this.cronCommand});
            this.dataCronTab.Location = new System.Drawing.Point(12, 66);
            this.dataCronTab.MultiSelect = false;
            this.dataCronTab.Name = "dataCronTab";
            this.dataCronTab.SelectionMode = winforms.DataGridViewSelectionMode.FullRowSelect;
            this.dataCronTab.Size = new System.Drawing.Size(653, 273);
            this.dataCronTab.TabIndex = 0;
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(590, 28);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(75, 23);
            this.btnReload.TabIndex = 1;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Visible = false;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(328, 28);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tabRefresh
            // 
            this.tabRefresh.Image = global::TShockCron.Properties.Resources.refresh;
            this.tabRefresh.Location = new System.Drawing.Point(12, 24);
            this.tabRefresh.Name = "tabRefresh";
            this.tabRefresh.Size = new System.Drawing.Size(30, 30);
            this.tabRefresh.TabIndex = 11;
            this.tabRefresh.UseVisualStyleBackColor = true;
            this.tabRefresh.Click += new System.EventHandler(this.tabRefresh_Click);
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(253, 372);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(65, 23);
            this.btnTest.TabIndex = 12;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // lblOptions
            // 
            this.lblOptions.Location = new System.Drawing.Point(12, 349);
            this.lblOptions.Name = "lblOptions";
            this.lblOptions.Size = new System.Drawing.Size(653, 23);
            this.lblOptions.TabIndex = 13;
            this.lblOptions.Text = "Future Schedule Date/Times";
            this.lblOptions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSaveStatus
            // 
            this.lblSaveStatus.Location = new System.Drawing.Point(409, 33);
            this.lblSaveStatus.Name = "lblSaveStatus";
            this.lblSaveStatus.Size = new System.Drawing.Size(144, 13);
            this.lblSaveStatus.TabIndex = 14;
            // 
            // listSchedule
            // 
            this.listSchedule.BackColor = System.Drawing.Color.White;
            this.listSchedule.BorderStyle = winforms.BorderStyle.FixedSingle;
            this.listSchedule.Columns.AddRange(new winforms.ColumnHeader[] {
            this.colScheduledEvents});
            this.listSchedule.Location = new System.Drawing.Point(12, 372);
            this.listSchedule.MultiSelect = false;
            this.listSchedule.Name = "listSchedule";
            this.listSchedule.Size = new System.Drawing.Size(203, 176);
            this.listSchedule.TabIndex = 15;
            this.listSchedule.UseCompatibleStateImageBehavior = false;
            this.listSchedule.View = winforms.View.Details;
            // 
            // colScheduledEvents
            // 
            this.colScheduledEvents.Text = "Scheduled Events";
            this.colScheduledEvents.Width = 200;
            // 
            // cronOptions
            // 
            this.cronOptions.HeaderText = "Schedule Options";
            this.cronOptions.Name = "cronOptions";
            this.cronOptions.Width = 250;
            // 
            // cronCommand
            // 
            this.cronCommand.HeaderText = "Command";
            this.cronCommand.Name = "cronCommand";
            this.cronCommand.Width = 350;
            // 
            // ViewCronTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = winforms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(679, 571);
            this.Controls.Add(this.listSchedule);
            this.Controls.Add(this.lblSaveStatus);
            this.Controls.Add(this.lblOptions);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.tabRefresh);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.dataCronTab);
            this.Name = "ViewCronTab";
            this.Text = "Edit Crontab File";
            ((System.ComponentModel.ISupportInitialize)(this.dataCronTab)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private winforms.DataGridView dataCronTab;
        private winforms.Button btnReload;
        private winforms.Button btnSave;
        private winforms.Button tabRefresh;
        private winforms.Button btnTest;
        private winforms.Label lblOptions;
        private winforms.Label lblSaveStatus;
        private winforms.ListView listSchedule;
        private winforms.ColumnHeader colScheduledEvents;
        private winforms.DataGridViewTextBoxColumn cronOptions;
        private winforms.DataGridViewTextBoxColumn cronCommand;
    }
}