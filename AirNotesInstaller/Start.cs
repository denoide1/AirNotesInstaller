// Decompiled with JetBrains decompiler
// Type: AirNotesInstaller.Start
// Assembly: AirNotesInstaller, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 63192E7E-C764-438D-B659-BFF65ECEF4C8
// Assembly location: C:\Users\Arturo\Downloads\AirNotesInstaller.exe

using AirNotesInstaller.Properties;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace AirNotesInstaller
{
  public class Start : UserControl
  {
    private IContainer components;
    private Panel panel1;
    private Label label3;
    private Label label2;
    private Label label1;
    private PictureBox pictureBox1;

    public Start() => this.InitializeComponent();

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Start));
      this.panel1 = new Panel();
      this.label3 = new Label();
      this.label2 = new Label();
      this.label1 = new Label();
      this.pictureBox1 = new PictureBox();
      this.panel1.SuspendLayout();
      ((ISupportInitialize) this.pictureBox1).BeginInit();
      this.SuspendLayout();
      this.panel1.BackColor = SystemColors.ControlLightLight;
      this.panel1.Controls.Add((Control) this.label3);
      this.panel1.Controls.Add((Control) this.label2);
      this.panel1.Controls.Add((Control) this.label1);
      this.panel1.Controls.Add((Control) this.pictureBox1);
      this.panel1.Location = new Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new Size(500, 342);
      this.panel1.TabIndex = 1;
      this.label3.Location = new Point(193, 83);
      this.label3.Name = "label3";
      this.label3.Size = new Size(289, 186);
      this.label3.TabIndex = 3;
      this.label3.Text = componentResourceManager.GetString("label3.Text");
      this.label2.AutoSize = true;
      this.label2.Font = new Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label2.Location = new Point(193, 83);
      this.label2.Name = "label2";
      this.label2.Size = new Size(0, 15);
      this.label2.TabIndex = 2;
      this.label1.AutoSize = true;
      this.label1.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label1.Location = new Point(192, 37);
      this.label1.Name = "label1";
      this.label1.Size = new Size(270, 19);
      this.label1.TabIndex = 1;
      this.label1.Text = "Installation of AirNotes v1.0";
      this.pictureBox1.Image = (Image) Resources.AirNotesBar;
      this.pictureBox1.InitialImage = (Image) Resources.AirNotesBar;
      this.pictureBox1.Location = new Point(0, -14);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new Size(159, 353);
      this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
      this.pictureBox1.TabIndex = 0;
      this.pictureBox1.TabStop = false;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.Controls.Add((Control) this.panel1);
      this.Name = nameof (Start);
      this.Size = new Size(500, 342);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      ((ISupportInitialize) this.pictureBox1).EndInit();
      this.ResumeLayout(false);
    }
  }
}
