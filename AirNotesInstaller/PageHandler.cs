// Decompiled with JetBrains decompiler
// Type: AirNotesInstaller.PageHandler
// Assembly: AirNotesInstaller, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 63192E7E-C764-438D-B659-BFF65ECEF4C8
// Assembly location: C:\Users\Arturo\Downloads\AirNotesInstaller.exe

using AirNotesInstaller.Classes;
using AirNotesInstaller.Panels;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace AirNotesInstaller
{
  internal class PageHandler
  {
    private int curr;
    private int max;
    private Form1 baseF;
    private Control currPanel;
    private ButtonHandler btnHandler;
    private InstallerCore installer;
    private EventHandler h;

    public PageHandler(
      Form1 BaseF,
      int max,
      ButtonHandler buttonHandler,
      InstallerCore installer,
      EventHandler exit)
    {
      this.curr = 0;
      this.baseF = BaseF;
      this.max = max;
      this.btnHandler = buttonHandler;
      this.installer = installer;
      this.h = exit;
      this.managePage();
    }

    public ButtonHandler GetButtonHandler() => this.btnHandler;

    public void nextPage()
    {
      if (this.curr + 1 >= this.max)
        return;
      ++this.curr;
      this.managePage();
    }

    public void previousPage()
    {
      if (this.curr - 1 < 0)
        return;
      --this.curr;
      this.managePage();
    }

    private void managePage()
    {
      switch (this.curr)
      {
        case 0:
          this.showNextFragment("Start");
          break;
        case 1:
          this.showNextFragment("UserTerm");
          break;
        case 2:
          this.showNextFragment("FolderSelect");
          break;
        case 3:
          this.showNextFragment("ProgressPanel");
          break;
        case 4:
          this.showNextFragment("EndPanel");
          break;
      }
    }

    private void showNextFragment(string name)
    {
      this.baseF.Controls.Remove(this.currPanel);
      if (name == "Start")
      {
        this.currPanel = (Control) new Start();
        this.btnHandler.getPrevious().Visible = false;
        this.btnHandler.getNext().Text = "Next >";
        this.baseF.Controls.Add(this.currPanel);
        this.currPanel.Location = new Point(0, 0);
      }
      if (name == "UserTerm")
      {
        this.currPanel = (Control) new UserTerm();
        this.btnHandler.getPrevious().Visible = true;
        this.btnHandler.getNext().Text = "Accept";
        this.baseF.Controls.Add(this.currPanel);
        this.currPanel.Location = new Point(0, 0);
      }
      if (name == "FolderSelect")
      {
        this.currPanel = (Control) new FolderSelect(this.installer);
        this.btnHandler.getNext().Text = "Next >";
        this.baseF.Controls.Add(this.currPanel);
        this.currPanel.Location = new Point(0, 0);
      }
      if (name == "ProgressPanel")
      {
        ProgressPanel p = new ProgressPanel();
        this.currPanel = (Control) p;
        this.btnHandler.getNext().Visible = false;
        this.btnHandler.getPrevious().Visible = false;
        this.btnHandler.getCancel().Visible = false;
        this.baseF.Controls.Add(this.currPanel);
        this.currPanel.Location = new Point(0, 0);
        this.installer.startInstallation(p);
        this.showNextFragment("EndPanel");
      }
      if (!(name == "EndPanel"))
        return;
      this.btnHandler.getCancel().Click -= this.h;
      this.btnHandler.getCancel().Text = "Close";
      this.btnHandler.getCancel().Visible = true;
      this.currPanel = (Control) new EndPanel(this.installer, this.btnHandler.getCancel());
      this.baseF.Controls.Add(this.currPanel);
      this.currPanel.Location = new Point(0, 0);
    }
  }
}
