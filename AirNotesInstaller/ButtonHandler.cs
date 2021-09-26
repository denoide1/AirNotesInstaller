// Decompiled with JetBrains decompiler
// Type: AirNotesInstaller.ButtonHandler
// Assembly: AirNotesInstaller, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 63192E7E-C764-438D-B659-BFF65ECEF4C8
// Assembly location: C:\Users\Arturo\Downloads\AirNotesInstaller.exe

using System.Windows.Forms;

namespace AirNotesInstaller
{
  internal class ButtonHandler
  {
    private Button cancel;
    private Button next;
    private Button previous;

    public ButtonHandler(Button cancel, Button next, Button previous)
    {
      this.cancel = cancel;
      this.next = next;
      this.previous = previous;
    }

    public Button getCancel() => this.cancel;

    public Button getNext() => this.next;

    public Button getPrevious() => this.previous;
  }
}
