// Decompiled with JetBrains decompiler
// Type: ScreenShort.ScreenShortClass
// Assembly: ScreenShort, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 91E3C326-E9E8-4853-A16B-DACECCC63BDC
// Assembly location: C:\Users\samar\Downloads\ScreenShot3.0.0.exe

using ScreenShort.Properties;
using System;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace ScreenShort
{
  internal class ScreenShortClass
  {
    public static bool SetSettingValueFromFile()
    {
      StreamReader streamReader = (StreamReader) null;
      try
      {
        string path = Path.Combine("C:\\Users", Environment.UserName, "AppData\\Local\\ScreenShot", "Save.txt");
        if (!File.Exists(path))
          return false;
        streamReader = new StreamReader(path);
        string str = streamReader.ReadLine();
        streamReader.Close();
        if (str == null)
        {
          ScreenShortClass.SaveSettingValueToFile();
          return true;
        }
        string[] strArray = str.Split("|".ToCharArray());
        if (strArray.Length != 3)
          return false;
        Settings.Default.SleepTime = Convert.ToInt32(strArray[0]);
        Settings.Default.SaveToClipboard = Convert.ToBoolean(strArray[1]);
        Settings.Default.PenWidth = Convert.ToInt32(strArray[2]);
        return true;
      }
      catch (Exception ex)
      {
        streamReader?.Close();
        return false;
      }
    }

    public static bool SaveSettingValueToFile()
    {
      string path = Path.Combine("C:\\Users", Environment.UserName, "AppData\\Local\\ScreenShot", "Save.txt");
      StreamWriter streamWriter1 = (StreamWriter) null;
      try
      {
        if (File.Exists(path))
        {
          streamWriter1 = new StreamWriter(path);
          streamWriter1.WriteLine(Settings.Default.SleepTime.ToString() + "|" + Settings.Default.SaveToClipboard.ToString() + "|" + Settings.Default.PenWidth.ToString());
          streamWriter1.Close();
        }
        else
        {
          streamWriter1 = new StreamWriter((Stream) File.Create(path));
          StreamWriter streamWriter2 = streamWriter1;
          string[] strArray1 = new string[5];
          string[] strArray2 = strArray1;
          int num = Settings.Default.SleepTime;
          string str1 = num.ToString();
          strArray2[0] = str1;
          strArray1[1] = "|";
          strArray1[2] = Settings.Default.SaveToClipboard.ToString();
          strArray1[3] = "|";
          string[] strArray3 = strArray1;
          num = Settings.Default.PenWidth;
          string str2 = num.ToString();
          strArray3[4] = str2;
          string str3 = string.Concat(strArray1);
          streamWriter2.WriteLine(str3);
          streamWriter1.Close();
        }
        return true;
      }
      catch (Exception ex)
      {
        streamWriter1?.Close();
        return false;
      }
    }

    public static bool LoadFromFile()
    {
      try
      {
        string str = Path.Combine("C:\\Users", Environment.UserName, "AppData\\Local", "ScreenShot");
        Directory.CreateDirectory(str);
        if (File.Exists(Path.Combine(str, "Save.txt")))
          ScreenShortClass.SetSettingValueFromFile();
        else
          ScreenShortClass.SaveSettingValueToFile();
        return true;
      }
      catch (Exception ex)
      {
        return false;
      }
    }

    public static bool CaptureScreenShort(
      Form myForm,
      SaveFileDialog saveFileImage,
      out string ErrorMsg)
    {
      ErrorMsg = "";
      try
      {

                Rectangle bounds = Screen.GetBounds(Point.Empty);
                Bitmap memoryImage = new Bitmap(bounds.Width, bounds.Height);
        Graphics graphics = Graphics.FromImage(memoryImage);
        graphics.CopyFromScreen(new Point(bounds.Left, bounds.Top), Point.Empty, bounds.Size);

        /*
        Rectangle bounds = Screen.PrimaryScreen.Bounds;
        int height = bounds.Height;
        bounds = Screen.PrimaryScreen.Bounds;
        int width = bounds.Width;
        Bitmap memoryImage = new Bitmap(width, height);
        Graphics graphics = Graphics.FromImage((Image) memoryImage);
        */
        myForm.WindowState = FormWindowState.Minimized;
        do
          ;
        while (myForm.WindowState != FormWindowState.Minimized);
        Thread.Sleep(Settings.Default.SleepTime);
        //graphics.CopyFromScreen(0, 0, 0, 0, new Size(width, height));
        graphics.CopyFromScreen(Point.Empty, Point.Empty, bounds.Size);
        myForm.WindowState = FormWindowState.Normal;
        if (Settings.Default.SaveToClipboard)
        {
          Clipboard.SetImage((Image) memoryImage);
        }
        else
        {
          int num = (int) new EditScreen(memoryImage).ShowDialog();
          ErrorMsg = "ok";
        }
        ErrorMsg += "non";
        return true;
      }
      catch (Exception ex)
      {
        saveFileImage.FileName = string.Empty;
        ErrorMsg = "imp:" + ex.Message;
        return false;
      }
    }
  }
}
