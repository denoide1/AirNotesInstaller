// Decompiled with JetBrains decompiler
// Type: AirNotesInstaller.Classes.InstallerCore
// Assembly: AirNotesInstaller, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 63192E7E-C764-438D-B659-BFF65ECEF4C8
// Assembly location: C:\Users\Arturo\Downloads\AirNotesInstaller.exe

using AirNotesInstaller.Panels;
using AirNotesInstaller.Properties;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using IWshRuntimeLibrary;
using System.Windows.Forms;

namespace AirNotesInstaller.Classes
{
  public class InstallerCore
  {
    public const string defPath = "C:\\Program Files\\AirNotes";
    public string currPath;
    public string appName = "AirNotes v1.0";
    public string shortcutName = "AirNotes";
    public string launcherName = "AirNotesLauncher";
    public bool link;
    public bool createDir;
    private int quantity = 20;
    public ProgressPanel panel;
    public bool open;
    public bool installWordModule;
    private ProgressBar bar1;
    private Label lab1;

    public InstallerCore() => this.currPath = "C:\\Program Files\\AirNotes";

    public void doExtra()
    {
      if (this.open)
        this.openProgram();
      if (this.installWordModule)
        this.openModule();
      Application.Exit();
    }

    private void openProgram()
    {
      Process process = new Process()
      {
        StartInfo = new ProcessStartInfo(this.currPath + "\\" + this.launcherName + ".exe")
      };
      process.StartInfo.WorkingDirectory = Path.GetDirectoryName(this.currPath + "\\" + this.launcherName + ".exe");
      process.StartInfo.RedirectStandardOutput = true;
      process.StartInfo.UseShellExecute = false;
      process.StartInfo.CreateNoWindow = true;
      process.Start();
    }

    private void openModule()
    {
      Process process = new Process()
      {
        StartInfo = new ProcessStartInfo(this.currPath + "\\wrappers\\WordWrapper\\WordAddIn\\WordAddInInstaller.exe")
      };
      process.StartInfo.WorkingDirectory = Path.GetDirectoryName(this.currPath + "\\wrappers\\WordWrapper\\WordAddIn\\WordAddInInstaller.exe");
      process.StartInfo.RedirectStandardOutput = true;
      process.StartInfo.UseShellExecute = false;
      process.StartInfo.CreateNoWindow = true;
      process.Start();
    }

    private void setCorrectQuantity()
    {
      if (!this.link)
        this.quantity = 25;
      this.bar1.Step = this.quantity;
    }

    private void createRef()
    {
      this.bar1 = (ProgressBar) this.panel.Controls["progressBar1"];
      this.lab1 = (Label) this.panel.Controls["panel2"].Controls["text"];
    }

    private bool createDirectory()
    {
      try
      {
        this.lab1.Text += "Prerequisites: creating the selected directory...\n";
        if (!this.createDir)
          Directory.CreateDirectory(this.currPath);
        return true;
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.Message);
        return false;
      }
    }

    private void copyExtractor()
    {
      this.lab1.Text += "Copying the extractor...\n";
      System.IO.File.WriteAllBytes(this.currPath + "\\7z.exe", Resources._7z1);
      System.IO.File.WriteAllBytes(this.currPath + "\\7z.dll", Resources._7z);
      this.performCustomStep();
    }

    private void performCustomStep() => this.bar1.PerformStep();

    private void copyZippedProgram()
    {
      this.lab1.Text += "Copying the compressed program...\n";
      System.IO.File.WriteAllBytes(this.currPath + "\\" + this.appName + ".rar", Resources.AirNotesPackage);
      this.performCustomStep();
    }

    private void deleteTempFiles()
    {
      this.lab1.Text += "Deleting temporary files...\n";
      System.IO.File.Delete(this.currPath + "\\7z.exe");
      System.IO.File.Delete(this.currPath + "\\7z.dll");
      System.IO.File.Delete(this.currPath + "\\" + this.appName + ".rar");
      this.performCustomStep();
    }

    public static byte[] IconToBytes(Icon icon)
    {
      using (MemoryStream memoryStream = new MemoryStream())
      {
        icon.Save((Stream) memoryStream);
        return memoryStream.ToArray();
      }
    }

    private void createLinks()
    {
      System.IO.File.WriteAllBytes(this.currPath + "\\AirNotes.ico", InstallerCore.IconToBytes(Resources.output_onlinepngtools__1__t6u_icon));
      this.lab1.Text += "Creating links...\n";
            // ISSUE: reference to a compiler-generated method
            // ISSUE: variable of a compiler-generated type
      IWshShortcut shortcut = ((IWshShell3)Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("72C24DD5-D70A-438B-8A42-98424B88AFB8")))).CreateShortcut(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\" + this.shortcutName + ".lnk") as IWshShortcut;
      shortcut.Arguments = "";
      shortcut.TargetPath = this.currPath + "\\" + this.launcherName + ".exe";
      shortcut.WindowStyle = 1;
      shortcut.Description = "AirNotes";
      shortcut.WorkingDirectory = this.currPath + "\\";
      shortcut.IconLocation = this.currPath + "\\AirNotes.ico";
      // ISSUE: reference to a compiler-generated method
      shortcut.Save();
      this.performCustomStep();
    }

    private void invokeExtractor()
    {
      this.lab1.Text += "Proceeding with the extraction...\n";
      Process process = new Process();
      process.Exited += new EventHandler(this.P_Exited);
      process.StartInfo = new ProcessStartInfo(this.currPath + "\\7z.exe", "x \"" + this.currPath + "\\" + this.appName + ".rar\" \"-o" + this.currPath + "\\\" -aoa");
      process.StartInfo.RedirectStandardOutput = true;
      process.StartInfo.UseShellExecute = false;
      process.StartInfo.CreateNoWindow = true;
      process.EnableRaisingEvents = true;
      process.Start();
      process.WaitForExit();
    }

    private void P_Exited(object sender, EventArgs e)
    {
      this.performCustomStep();
      this.deleteTempFiles();
      if (this.link)
        this.createLinks();
      this.lab1.Text += "Installation complete\n";
    }

    public void startInstallation(ProgressPanel p)
    {
      this.panel = p;
      this.createRef();
      this.setCorrectQuantity();
      if (!this.createDirectory())
        return;
      this.copyExtractor();
      this.copyZippedProgram();
      this.invokeExtractor();
    }
  }
}
