// Decompiled with JetBrains decompiler
// Type: ScreenShort.UserChoice
// Assembly: ScreenShort, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 91E3C326-E9E8-4853-A16B-DACECCC63BDC
// Assembly location: C:\Users\samar\Downloads\ScreenShot3.0.0.exe

using ScreenShort.Properties;
using System;

namespace ScreenShort
{
  public class UserChoice
  {
    private int _SleepTime = 0;
    private bool _SaveToClipboard = true;
    private int _PenWidth = 0;

    //sleep time
    public int SleepTime
    {
      get => this._SleepTime;
      set => this._SleepTime = value;
    }

    public int PenWidth
    {
      get => this._PenWidth;
      set => this._PenWidth = value;
    }

    public bool SaveToClipboard
    {
      get => this._SaveToClipboard;
      set => this._SaveToClipboard = value;
    }

    public UserChoice(int SleepTime, bool SaveToClipboard, int PenWidth)
    {
      this.SleepTime = SleepTime;
      this.SaveToClipboard = SaveToClipboard;
      this.PenWidth = PenWidth;
    }

    public bool SaveToResource()
    {
      try
      {
        Settings.Default.SleepTime = this.SleepTime;
        Settings.Default.SaveToClipboard = this.SaveToClipboard;
        Settings.Default.PenWidth = this.PenWidth;
        ScreenShortClass.SaveSettingValueToFile();
        return true;
      }
      catch (Exception ex)
      {
        return false;
      }
    }
  }
}
