// Decompiled with JetBrains decompiler
// Type: ScreenShort.LockGrant
// Assembly: ScreenShort, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 91E3C326-E9E8-4853-A16B-DACECCC63BDC
// Assembly location: C:\Users\samar\Downloads\ScreenShot3.0.0.exe

namespace ScreenShort
{
  public class LockGrant
  {
    private static bool _GrantForRectangle = false;
    private static bool _GrantForExtension = false;

    public static bool GrantForRectangle
    {
      get => LockGrant._GrantForRectangle;
      set => LockGrant._GrantForRectangle = value;
    }

    public static bool GrantForExtension
    {
      get => LockGrant._GrantForExtension;
      set => LockGrant._GrantForExtension = value;
    }
  }
}
