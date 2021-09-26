// Decompiled with JetBrains decompiler
// Type: AirNotesInstaller.FolderSelect
// Assembly: AirNotesInstaller, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 63192E7E-C764-438D-B659-BFF65ECEF4C8
// Assembly location: C:\Users\Arturo\Downloads\AirNotesInstaller.exe

using AirNotesInstaller.Classes;
using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace AirNotesInstaller
{
  public class FolderSelect : UserControl
  {
    private InstallerCore installerCore;
    private IContainer components;
    private Panel panel1;
    private Label label2;
    private Label label1;
    private Label label3;
    private TextBox textBox1;
    private Label label4;
    private Button button1;
    private CheckBox checkBox1;

    public FolderSelect(InstallerCore installer)
    {
      this.InitializeComponent();
      this.installerCore = installer;
      this.textBox1.Text = this.installerCore.currPath;
      this.checkCreateDir();
    }

    private void checkCreateDir() => this.installerCore.createDir = Directory.Exists(this.installerCore.currPath);

    private void Button1_Click(object sender, EventArgs e)
    {
      FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
      int num = (int) folderBrowserDialog.ShowDialog();
      if (!(folderBrowserDialog.SelectedPath != ""))
        return;
      this.installerCore.currPath = folderBrowserDialog.SelectedPath;
      this.textBox1.Text = folderBrowserDialog.SelectedPath;
    }

    private void TextBox1_TextChanged(object sender, EventArgs e)
    {
      this.installerCore.currPath = this.textBox1.Text.Trim();
      this.checkCreateDir();
    }

    private void CheckBox1_CheckedChanged(object sender, EventArgs e) => this.installerCore.link = this.checkBox1.Checked;

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.panel1 = new Panel();
      this.label2 = new Label();
      this.label1 = new Label();
      this.label3 = new Label();
      this.textBox1 = new TextBox();
      this.label4 = new Label();
      this.button1 = new Button();
      this.checkBox1 = new CheckBox();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      this.panel1.BackColor = SystemColors.ControlLightLight;
      this.panel1.BorderStyle = BorderStyle.FixedSingle;
      this.panel1.Controls.Add((Control) this.label2);
      this.panel1.Controls.Add((Control) this.label1);
      this.panel1.Location = new Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new Size(506, 62);
      this.panel1.TabIndex = 1;
      this.label2.Location = new Point(217, 32);
      this.label2.Name = "label2";
      this.label2.Size = new Size(274, 17);
      this.label2.TabIndex = 1;
      this.label2.Text = "Select the folder in which AirNotes will be installed ";
      this.label1.AutoSize = true;
      this.label1.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label1.Location = new Point(217, 15);
      this.label1.Name = "label1";
      this.label1.Size = new Size(144, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Select installation folder";
      this.label3.Location = new Point(45, 79);
      this.label3.Name = "label3";
      this.label3.Size = new Size(415, 54);
      this.label3.TabIndex = 2;
      this.label3.Text = "This procedure will install AirNotes in the selected folder. To select another folder, select \"Browse\" and choose another folder.\r\n\r\nTo proceed, select \"Next\"";
      this.textBox1.Location = new Point(45, 179);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new Size(334, 20);
      this.textBox1.TabIndex = 3;
      this.textBox1.TextChanged += new EventHandler(this.TextBox1_TextChanged);
      this.label4.AutoSize = true;
      this.label4.Location = new Point(45, 163);
      this.label4.Name = "label4";
      this.label4.Size = new Size(89, 13);
      this.label4.TabIndex = 4;
      this.label4.Text = "Destination folder";
      this.button1.Location = new Point(385, 175);
      this.button1.Name = "button1";
      this.button1.Size = new Size(75, 27);
      this.button1.TabIndex = 5;
      this.button1.Text = "Browse";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new EventHandler(this.Button1_Click);
      this.checkBox1.AutoSize = true;
      this.checkBox1.Location = new Point(45, 225);
      this.checkBox1.Name = "checkBox1";
      this.checkBox1.Size = new Size(312, 17);
      this.checkBox1.TabIndex = 6;
      this.checkBox1.Text = "Create shortcuts to the application (Desktop and Start Menu)";
      this.checkBox1.UseVisualStyleBackColor = true;
      this.checkBox1.CheckedChanged += new EventHandler(this.CheckBox1_CheckedChanged);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = SystemColors.Control;
      this.Controls.Add((Control) this.checkBox1);
      this.Controls.Add((Control) this.button1);
      this.Controls.Add((Control) this.label4);
      this.Controls.Add((Control) this.textBox1);
      this.Controls.Add((Control) this.label3);
      this.Controls.Add((Control) this.panel1);
      this.Name = nameof (FolderSelect);
      this.Size = new Size(506, 339);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
