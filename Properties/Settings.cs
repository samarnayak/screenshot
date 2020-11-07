// Decompiled with JetBrains decompiler
// Type: ScreenShort.Properties.Settings
// Assembly: ScreenShort, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 91E3C326-E9E8-4853-A16B-DACECCC63BDC
// Assembly location: C:\Users\samar\Downloads\ScreenShot3.0.0.exe

using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace ScreenShort.Properties
{
  [GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
  [CompilerGenerated]
  internal sealed class Settings : ApplicationSettingsBase
  {
    private static Settings defaultInstance = (Settings) SettingsBase.Synchronized((SettingsBase) new Settings());

    public static Settings Default
    {
      get
      {
        Settings defaultInstance = Settings.defaultInstance;
        return defaultInstance;
      }
    }

    [UserScopedSetting]
    [DebuggerNonUserCode]
    [DefaultSettingValue("False")]
    public bool SaveToClipboard
    {
      get => (bool) this[nameof (SaveToClipboard)];
      set => this[nameof (SaveToClipboard)] = (object) value;
    }

    [DebuggerNonUserCode]
    [UserScopedSetting]
    [DefaultSettingValue("300")]
    public int SleepTime
    {
      get => (int) this[nameof (SleepTime)];
      set => this[nameof (SleepTime)] = (object) value;
    }

    [DefaultSettingValue("3")]
    [DebuggerNonUserCode]
    [UserScopedSetting]
    public int PenWidth
    {
      get => (int) this[nameof (PenWidth)];
      set => this[nameof (PenWidth)] = (object) value;
    }
  }
}
