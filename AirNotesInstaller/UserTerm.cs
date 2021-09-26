// Decompiled with JetBrains decompiler
// Type: AirNotesInstaller.UserTerm
// Assembly: AirNotesInstaller, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 63192E7E-C764-438D-B659-BFF65ECEF4C8
// Assembly location: C:\Users\Arturo\Downloads\AirNotesInstaller.exe

using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace AirNotesInstaller
{
  public class UserTerm : UserControl
  {
    private IContainer components;
    private Panel panel1;
    private Label label2;
    private Label label1;
    private Label label3;
    private Panel panel2;
    private Label label5;
    private Label label4;

    public UserTerm() => this.InitializeComponent();

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (UserTerm));
      this.panel1 = new Panel();
      this.label2 = new Label();
      this.label1 = new Label();
      this.label3 = new Label();
      this.panel2 = new Panel();
      this.label5 = new Label();
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
      this.panel1.Size = new Size(506, 62);
      this.panel1.TabIndex = 0;
      this.label2.Location = new Point(217, 27);
      this.label2.Name = "label2";
      this.label2.Size = new Size(274, 32);
      this.label2.TabIndex = 1;
      this.label2.Text = "Read the terms of the license agreement before continuing with the installation of AirNotes.";
      this.label1.AutoSize = true;
      this.label1.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label1.Location = new Point(217, 12);
      this.label1.Name = "label1";
      this.label1.Size = new Size(114, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "License agreement";
      this.label3.AutoSize = true;
      this.label3.Location = new Point(32, 78);
      this.label3.Name = "label3";
      this.label3.Size = new Size(293, 13);
      this.label3.TabIndex = 1;
      this.label3.Text = "Press 'Page Down' to view the rest of the license agreement.\r\n";
      this.panel2.AutoScroll = true;
      this.panel2.BackColor = SystemColors.ControlLightLight;
      this.panel2.BorderStyle = BorderStyle.FixedSingle;
      this.panel2.Controls.Add((Control) this.label5);
      this.panel2.Location = new Point(35, 99);
      this.panel2.Name = "panel2";
      this.panel2.Size = new Size(445, 177);
      this.panel2.TabIndex = 2;
      this.label5.AutoSize = true;
      this.label5.Location = new Point(0, 12);
      this.label5.MaximumSize = new Size(400, 0);
      this.label5.Name = "label5";
      this.label5.Size = new Size(400, 2806);
      this.label5.TabIndex = 0;
      this.label5.Text = componentResourceManager.GetString("label5.Text");
      this.label5.UseCompatibleTextRendering = true;
      this.label4.Location = new Point(35, 288);
      this.label4.Name = "label4";
      this.label4.Size = new Size(445, 32);
      this.label4.TabIndex = 3;
      this.label4.Text = "If you accept all the terms of the license agreement, select \"I agree\" to continue. To continue with the installation it is necessary to accept the license agreement.";
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = SystemColors.Control;
      this.Controls.Add((Control) this.label4);
      this.Controls.Add((Control) this.panel2);
      this.Controls.Add((Control) this.label3);
      this.Controls.Add((Control) this.panel1);
      this.Name = nameof (UserTerm);
      this.Size = new Size(506, 339);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.panel2.ResumeLayout(false);
      this.panel2.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
