// Decompiled with JetBrains decompiler
// Type: AirNotesInstaller.Panels.EndPanel
// Assembly: AirNotesInstaller, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 63192E7E-C764-438D-B659-BFF65ECEF4C8
// Assembly location: C:\Users\Arturo\Downloads\AirNotesInstaller.exe

using AirNotesInstaller.Classes;
using AirNotesInstaller.Properties;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace AirNotesInstaller.Panels
{
  public class EndPanel : UserControl
  {
    private InstallerCore installer;
    private Button exit;
    private IContainer components;
    private PictureBox pictureBox1;
    private Label label1;
    private Label label3;
    private CheckBox checkBox1;
    private CheckBox checkBox2;

    public EndPanel(InstallerCore inst, Button exit)
    {
      this.InitializeComponent();
      this.installer = inst;
      this.exit = exit;
      this.exit.Click += new EventHandler(this.Exit_Click);
    }

    private void Exit_Click(object sender, EventArgs e) => this.installer.doExtra();

    private void Label1_Click(object sender, EventArgs e)
    {
    }

    private void CheckBox1_CheckedChanged(object sender, EventArgs e) => this.installer.open = this.checkBox1.Checked;

    private void CheckBox2_CheckedChanged(object sender, EventArgs e) => this.installer.installWordModule = this.checkBox2.Checked;

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.pictureBox1 = new PictureBox();
      this.label1 = new Label();
      this.label3 = new Label();
      this.checkBox1 = new CheckBox();
      this.checkBox2 = new CheckBox();
      ((ISupportInitialize) this.pictureBox1).BeginInit();
      this.SuspendLayout();
      this.pictureBox1.Image = (Image) Resources.AirNotesBar;
      this.pictureBox1.InitialImage = (Image) Resources.AirNotesBar;
      this.pictureBox1.Location = new Point(0, 0);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new Size(159, 342);
      this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
      this.pictureBox1.TabIndex = 1;
      this.pictureBox1.TabStop = false;
      this.label1.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label1.Location = new Point(193, 40);
      this.label1.Name = "label1";
      this.label1.Size = new Size(273, 47);
      this.label1.TabIndex = 2;
      this.label1.Text = "Installation of AirNotes v1.0 completed";
      this.label1.Click += new EventHandler(this.Label1_Click);
      this.label3.Location = new Point(194, 98);
      this.label3.Name = "label3";
      this.label3.Size = new Size(272, 90);
      this.label3.TabIndex = 4;
      this.label3.Text = "AirNotes v1.0 has been successfully installed on your computer.\r\n\r\nSelect \"Close\" to exit the installer";
      this.checkBox1.AutoSize = true;
      this.checkBox1.Location = new Point(197, 191);
      this.checkBox1.Name = "checkBox1";
      this.checkBox1.Size = new Size(150, 17);
      this.checkBox1.TabIndex = 5;
      this.checkBox1.Text = "Run AirNotes v1.0";
      this.checkBox1.UseVisualStyleBackColor = true;
      this.checkBox1.CheckedChanged += new EventHandler(this.CheckBox1_CheckedChanged);
      this.checkBox2.AutoSize = true;
      this.checkBox2.Location = new Point(197, 214);
      this.checkBox2.Name = "checkBox2";
      this.checkBox2.Size = new Size(273, 17);
      this.checkBox2.TabIndex = 6;
      this.checkBox2.Text = "Install the AirNotes Module for Microsoft Office Word";
      this.checkBox2.UseVisualStyleBackColor = true;
      this.checkBox2.CheckedChanged += new EventHandler(this.CheckBox2_CheckedChanged);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.Controls.Add((Control) this.checkBox2);
      this.Controls.Add((Control) this.checkBox1);
      this.Controls.Add((Control) this.label3);
      this.Controls.Add((Control) this.label1);
      this.Controls.Add((Control) this.pictureBox1);
      this.Name = nameof (EndPanel);
      this.Size = new Size(500, 342);
      ((ISupportInitialize) this.pictureBox1).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
