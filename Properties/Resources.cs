// Decompiled with JetBrains decompiler
// Type: ScreenShort.Properties.Resources
// Assembly: ScreenShort, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 91E3C326-E9E8-4853-A16B-DACECCC63BDC
// Assembly location: C:\Users\samar\Downloads\ScreenShot3.0.0.exe

using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace ScreenShort.Properties
{
  [GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
  [CompilerGenerated]
  [DebuggerNonUserCode]
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
        if (ScreenShort.Properties.Resources.resourceMan == null)
          ScreenShort.Properties.Resources.resourceMan = new ResourceManager("ScreenShort.Properties.Resources", typeof (ScreenShort.Properties.Resources).Assembly);
        return ScreenShort.Properties.Resources.resourceMan;
      }
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static CultureInfo Culture
    {
      get => ScreenShort.Properties.Resources.resourceCulture;
      set => ScreenShort.Properties.Resources.resourceCulture = value;
    }
  }
}
