// Decompiled with JetBrains decompiler
// Type: AirNotesInstaller.Properties.Resources
// Assembly: AirNotesInstaller, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 63192E7E-C764-438D-B659-BFF65ECEF4C8
// Assembly location: C:\Users\Arturo\Downloads\AirNotesInstaller.exe

using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace AirNotesInstaller.Properties
{
  [GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
  [DebuggerNonUserCode]
  [CompilerGenerated]
  internal class Resources
  {
    private static ResourceManager resourceMan;
    private static CultureInfo resourceCulture;

    internal Resources()
    {
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static ResourceManager ResourceManager
    {
      get
      {
        if (AirNotesInstaller.Properties.Resources.resourceMan == null)
          AirNotesInstaller.Properties.Resources.resourceMan = new ResourceManager("AirNotesInstaller.Properties.Resources", typeof (AirNotesInstaller.Properties.Resources).Assembly);
        return AirNotesInstaller.Properties.Resources.resourceMan;
      }
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static CultureInfo Culture
    {
      get => AirNotesInstaller.Properties.Resources.resourceCulture;
      set => AirNotesInstaller.Properties.Resources.resourceCulture = value;
    }

    internal static byte[] _7z => (byte[]) AirNotesInstaller.Properties.Resources.ResourceManager.GetObject(nameof (_7z), AirNotesInstaller.Properties.Resources.resourceCulture);

    internal static byte[] _7z1 => (byte[]) AirNotesInstaller.Properties.Resources.ResourceManager.GetObject(nameof (_7z1), AirNotesInstaller.Properties.Resources.resourceCulture);

    internal static byte[] AirNotesPackage => (byte[]) AirNotesInstaller.Properties.Resources.ResourceManager.GetObject(nameof (AirNotesPackage), AirNotesInstaller.Properties.Resources.resourceCulture);

    internal static Bitmap AirNotesBar => (Bitmap) AirNotesInstaller.Properties.Resources.ResourceManager.GetObject(nameof (AirNotesBar), AirNotesInstaller.Properties.Resources.resourceCulture);

    internal static Icon output_onlinepngtools__1__t6u_icon => (Icon) AirNotesInstaller.Properties.Resources.ResourceManager.GetObject(nameof (output_onlinepngtools__1__t6u_icon), AirNotesInstaller.Properties.Resources.resourceCulture);
  }
}
