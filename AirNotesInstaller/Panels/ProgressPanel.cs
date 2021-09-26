// Decompiled with JetBrains decompiler
// Type: AirNotesInstaller.Panels.ProgressPanel
// Assembly: AirNotesInstaller, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 63192E7E-C764-438D-B659-BFF65ECEF4C8
// Assembly location: C:\Users\Arturo\Downloads\AirNotesInstaller.exe

using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace AirNotesInstaller.Panels
{
  public class ProgressPanel : UserControl
  {
    private IContainer components;
    private Panel panel1;
    private Label label2;
    private Label label1;
    private ProgressBar progressBar1;
    private Panel panel2;
    private Label label4;
    private Label text;

    public ProgressPanel() => this.InitializeComponent();

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
      this.progressBar1 = new ProgressBar();
      this.panel2 = new Panel();
      this.text = new Label();
      this.label4 = new Label();
      this.panel1.SuspendLayout();
      this.panel2.SuspendLayout();
      this.SuspendLayout();
      this.panel1.BackColor = SystemColors.ControlLightLight;
      this.panel1.BorderStyle = BorderStyle.FixedSingle;
      this.panel1.Controls.Add((Control) this.label2);
      this.panel1.Controls.Add((Control) this.label1);
      this.panel1.Location = new Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new Size(510, 62);
      this.panel1.TabIndex = 2;
      this.label2.Location = new Point(217, 32);
      this.label2.Name = "label2";
      this.label2.Size = new Size(274, 17);
      this.label2.TabIndex = 1;
      this.label2.Text = "Please wait while the installation is performed";
      this.label1.AutoSize = true;
      this.label1.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label1.Location = new Point(217, 15);
      this.label1.Name = "label1";
      this.label1.Size = new Size(118, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Program installation";
      this.progressBar1.Location = new Point(50, 93);
      this.progressBar1.Name = "progressBar1";
      this.progressBar1.Size = new Size(394, 23);
      this.progressBar1.TabIndex = 3;
      this.panel2.BackColor = SystemColors.ControlLightLight;
      this.panel2.BorderStyle = BorderStyle.FixedSingle;
      this.panel2.Controls.Add((Control) this.text);
      this.panel2.Controls.Add((Control) this.label4);
      this.panel2.Location = new Point(50, 122);
      this.panel2.Name = "panel2";
      this.panel2.Size = new Size(394, 193);
      this.panel2.TabIndex = 5;
      this.text.AutoSize = true;
      this.text.Location = new Point(13, 12);
      this.text.MaximumSize = new Size(340, 0);
      this.text.Name = "text";
      this.text.Size = new Size(0, 13);
      this.text.TabIndex = 1;
      this.label4.AutoSize = true;
      this.label4.Location = new Point(13, 12);
      this.label4.MaximumSize = new Size(350, 0);
      this.label4.Name = "label4";
      this.label4.Size = new Size(0, 13);
      this.label4.TabIndex = 0;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = SystemColors.Control;
      this.Controls.Add((Control) this.panel2);
      this.Controls.Add((Control) this.progressBar1);
      this.Controls.Add((Control) this.panel1);
      this.Name = nameof (ProgressPanel);
      this.Size = new Size(500, 342);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.panel2.ResumeLayout(false);
      this.panel2.PerformLayout();
      this.ResumeLayout(false);
    }
  }
}
