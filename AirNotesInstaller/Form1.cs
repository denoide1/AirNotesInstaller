// Decompiled with JetBrains decompiler
// Type: AirNotesInstaller.Form1
// Assembly: AirNotesInstaller, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 63192E7E-C764-438D-B659-BFF65ECEF4C8
// Assembly location: C:\Users\Arturo\Downloads\AirNotesInstaller.exe

using AirNotesInstaller.Classes;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace AirNotesInstaller
{
  public class Form1 : Form
  {
    private PageHandler handler;
    private InstallerCore installer;
    private ButtonHandler btnhandler;
    private IContainer components;
    private Panel panel2;
    private Button canc;
    private Button nxt;
    private Button bkt;

    public Form1()
    {
      this.InitializeComponent();
      this.installer = new InstallerCore();
      this.btnhandler = new ButtonHandler(this.canc, this.nxt, this.bkt);
      this.handler = new PageHandler(this, 5, this.btnhandler, this.installer, new EventHandler(this.exit));
      this.btnhandler.getCancel().Click += new EventHandler(this.exit);
    }

    private void Panel2_Paint(object sender, PaintEventArgs e)
    {
    }

    private void Button1_Click(object sender, EventArgs e) => this.handler.nextPage();

    private void Bkt_Click(object sender, EventArgs e) => this.handler.previousPage();

    private void exit(object sender, EventArgs e) => Application.Exit();

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Form1));
      this.panel2 = new Panel();
      this.bkt = new Button();
      this.canc = new Button();
      this.nxt = new Button();
      this.panel2.SuspendLayout();
      this.SuspendLayout();
      this.panel2.BackColor = SystemColors.Control;
      this.panel2.BorderStyle = BorderStyle.FixedSingle;
      this.panel2.Controls.Add((Control) this.bkt);
      this.panel2.Controls.Add((Control) this.canc);
      this.panel2.Controls.Add((Control) this.nxt);
      this.panel2.Location = new Point(-1, 335);
      this.panel2.Name = "panel2";
      this.panel2.Size = new Size(506, 46);
      this.panel2.TabIndex = 1;
      this.bkt.Location = new Point((int) byte.MaxValue, 10);
      this.bkt.Name = "bkt";
      this.bkt.Size = new Size(75, 23);
      this.bkt.TabIndex = 2;
      this.bkt.Text = "< Back";
      this.bkt.UseVisualStyleBackColor = true;
      this.bkt.Visible = false;
      this.bkt.Click += new EventHandler(this.Bkt_Click);
      this.canc.Location = new Point(417, 10);
      this.canc.Name = "canc";
      this.canc.Size = new Size(75, 23);
      this.canc.TabIndex = 1;
      this.canc.Text = "Cancel";
      this.canc.UseVisualStyleBackColor = true;
      this.nxt.Location = new Point(336, 10);
      this.nxt.Name = "nxt";
      this.nxt.Size = new Size(75, 23);
      this.nxt.TabIndex = 0;
      this.nxt.Text = "Next >";
      this.nxt.UseVisualStyleBackColor = true;
      this.nxt.Click += new EventHandler(this.Button1_Click);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = SystemColors.ControlLightLight;
      this.ClientSize = new Size(504, 381);
      this.Controls.Add((Control) this.panel2);
      this.FormBorderStyle = FormBorderStyle.FixedSingle;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.MaximizeBox = false;
      this.Name = nameof (Form1);
      this.SizeGripStyle = SizeGripStyle.Hide;
      this.Text = "Installation of AirNotes v1.0";
      this.TopMost = true;
      this.panel2.ResumeLayout(false);
      this.ResumeLayout(false);
    }
  }
}
