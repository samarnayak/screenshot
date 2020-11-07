// Decompiled with JetBrains decompiler
// Type: ScreenShort.UserRect
// Assembly: ScreenShort, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 91E3C326-E9E8-4853-A16B-DACECCC63BDC
// Assembly location: C:\Users\samar\Downloads\ScreenShot3.0.0.exe

using System;
using System.Drawing;
using System.Windows.Forms;

namespace ScreenShort
{
  public class UserRect
  {
    private static int c = 0;
    private PictureBox mPictureBox;
    public Rectangle rect;
    public bool allowDeformingDuringMovement = false;
    private bool mIsClick = false;
    private bool mMove = false;
    private int oldX;
    private bool _DoNotPaint = false;
    private int oldY;
    private int sizeNodeRect = 12;
    private Bitmap mBmp = (Bitmap) null;
    private UserRect.PosSizableRect nodeSelected = UserRect.PosSizableRect.None;
    private EditScreen EditScreenObj = (EditScreen) null;
    private int angle = 30;

    public Rectangle Rect
    {
      get => this.rect;
      set => this.rect = value;
    }

    public bool DoNotPaint
    {
      get => this._DoNotPaint;
      set => this._DoNotPaint = value;
    }

    public UserRect(EditScreen EditScreenObj)
    {
      this.EditScreenObj = EditScreenObj;
      this.mIsClick = false;
    }

    public void Draw(Graphics g)
    {
      g.DrawRectangle(new Pen(Color.Red, 2f), this.rect);
      foreach (UserRect.PosSizableRect p in Enum.GetValues(typeof (UserRect.PosSizableRect)))
        g.DrawRectangle(new Pen(Color.OrangeRed, 1f), this.GetRect(p));
    }

    public void SetBitmapFile(string filename) => this.mBmp = new Bitmap(filename);

    public void SetBitmap(Bitmap bmp) => this.mBmp = bmp;

    public void SetPictureBox(PictureBox p)
    {
      this.mPictureBox = p;
      this.mPictureBox.MouseDown += new MouseEventHandler(this.mPictureBox_MouseDown);
      this.mPictureBox.MouseUp += new MouseEventHandler(this.mPictureBox_MouseUp);
      this.mPictureBox.MouseMove += new MouseEventHandler(this.mPictureBox_MouseMove);
      this.mPictureBox.Paint += new PaintEventHandler(this.mPictureBox_Paint);
      this.mPictureBox.Invalidate();
    }

    private void mPictureBox_Paint(object sender, PaintEventArgs e)
    {
      try
      {
        if (this.DoNotPaint)
          return;
        this.Draw(e.Graphics);
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.Message);
      }
    }

    private void mPictureBox_MouseDown(object sender, MouseEventArgs e)
    {
      if (!LockGrant.GrantForExtension)
        return;
      this.mIsClick = true;
      this.nodeSelected = UserRect.PosSizableRect.None;
      this.nodeSelected = this.GetNodeSelectable(e.Location);
      if (this.rect.Contains(new Point(e.X, e.Y)))
        this.mMove = true;
      this.oldX = e.X;
      this.oldY = e.Y;
    }

    private void mPictureBox_MouseUp(object sender, MouseEventArgs e)
    {
      if (!LockGrant.GrantForExtension)
        return;
      this.mIsClick = false;
      this.mMove = false;
    }

    private void mPictureBox_MouseMove(object sender, MouseEventArgs e)
    {
      if (!LockGrant.GrantForExtension)
        return;
      this.ChangeCursor(e.Location);
      if (!this.mIsClick)
        return;
      Rectangle rect = this.rect;
      switch (this.nodeSelected)
      {
        case UserRect.PosSizableRect.UpMiddle:
          this.rect.Y += e.Y - this.oldY;
          this.rect.Height -= e.Y - this.oldY;
          break;
        case UserRect.PosSizableRect.LeftMiddle:
          this.rect.X += e.X - this.oldX;
          this.rect.Width -= e.X - this.oldX;
          break;
        case UserRect.PosSizableRect.LeftBottom:
          this.rect.Width -= e.X - this.oldX;
          this.rect.X += e.X - this.oldX;
          this.rect.Height += e.Y - this.oldY;
          break;
        case UserRect.PosSizableRect.LeftUp:
          this.rect.X += e.X - this.oldX;
          this.rect.Width -= e.X - this.oldX;
          this.rect.Y += e.Y - this.oldY;
          this.rect.Height -= e.Y - this.oldY;
          break;
        case UserRect.PosSizableRect.RightUp:
          this.rect.Width += e.X - this.oldX;
          this.rect.Y += e.Y - this.oldY;
          this.rect.Height -= e.Y - this.oldY;
          break;
        case UserRect.PosSizableRect.RightMiddle:
          this.rect.Width += e.X - this.oldX;
          break;
        case UserRect.PosSizableRect.RightBottom:
          this.rect.Width += e.X - this.oldX;
          this.rect.Height += e.Y - this.oldY;
          break;
        case UserRect.PosSizableRect.BottomMiddle:
          this.rect.Height += e.Y - this.oldY;
          break;
        default:
          if (this.mMove)
          {
            this.rect.X = this.rect.X + e.X - this.oldX;
            this.rect.Y = this.rect.Y + e.Y - this.oldY;
            break;
          }
          break;
      }
      this.oldX = e.X;
      this.oldY = e.Y;
      if (this.rect.Width < 5 || this.rect.Height < 5)
        this.rect = rect;
      this.TestIfRectInsideArea();
      this.mPictureBox.Invalidate();
    }

    private void TestIfRectInsideArea()
    {
      if (this.rect.X < 0)
        this.rect.X = 0;
      if (this.rect.Y < 0)
        this.rect.Y = 0;
      if (this.rect.Width <= 0)
        this.rect.Width = 1;
      if (this.rect.Height <= 0)
        this.rect.Height = 1;
      if (this.rect.X + this.rect.Width > this.mPictureBox.Width)
      {
        this.rect.Width = this.mPictureBox.Width - this.rect.X - 1;
        if (!this.allowDeformingDuringMovement)
          this.mIsClick = false;
      }
      if (this.rect.Y + this.rect.Height <= this.mPictureBox.Height)
        return;
      this.rect.Height = this.mPictureBox.Height - this.rect.Y - 1;
      if (!this.allowDeformingDuringMovement)
        this.mIsClick = false;
    }

    private Rectangle CreateRectSizableNode(int x, int y) => new Rectangle(x - this.sizeNodeRect / 2, y - this.sizeNodeRect / 2, this.sizeNodeRect, this.sizeNodeRect);

    private Rectangle GetRect(UserRect.PosSizableRect p)
    {
      switch (p)
      {
        case UserRect.PosSizableRect.UpMiddle:
          return this.CreateRectSizableNode(this.rect.X + this.rect.Width / 2, this.rect.Y);
        case UserRect.PosSizableRect.LeftMiddle:
          return this.CreateRectSizableNode(this.rect.X, this.rect.Y + this.rect.Height / 2);
        case UserRect.PosSizableRect.LeftBottom:
          return this.CreateRectSizableNode(this.rect.X, this.rect.Y + this.rect.Height);
        case UserRect.PosSizableRect.LeftUp:
          return this.CreateRectSizableNode(this.rect.X, this.rect.Y);
        case UserRect.PosSizableRect.RightUp:
          return this.CreateRectSizableNode(this.rect.X + this.rect.Width, this.rect.Y);
        case UserRect.PosSizableRect.RightMiddle:
          return this.CreateRectSizableNode(this.rect.X + this.rect.Width, this.rect.Y + this.rect.Height / 2);
        case UserRect.PosSizableRect.RightBottom:
          return this.CreateRectSizableNode(this.rect.X + this.rect.Width, this.rect.Y + this.rect.Height);
        case UserRect.PosSizableRect.BottomMiddle:
          return this.CreateRectSizableNode(this.rect.X + this.rect.Width / 2, this.rect.Y + this.rect.Height);
        default:
          return new Rectangle();
      }
    }

    private UserRect.PosSizableRect GetNodeSelectable(Point p)
    {
      foreach (UserRect.PosSizableRect p1 in Enum.GetValues(typeof (UserRect.PosSizableRect)))
      {
        if (this.GetRect(p1).Contains(p))
          return p1;
      }
      return UserRect.PosSizableRect.None;
    }

    private void ChangeCursor(Point p) => this.mPictureBox.Cursor = this.GetCursor(this.GetNodeSelectable(p));

    private Cursor GetCursor(UserRect.PosSizableRect p)
    {
      switch (p)
      {
        case UserRect.PosSizableRect.UpMiddle:
          return Cursors.SizeNS;
        case UserRect.PosSizableRect.LeftMiddle:
          return Cursors.SizeWE;
        case UserRect.PosSizableRect.LeftBottom:
          return Cursors.SizeNESW;
        case UserRect.PosSizableRect.LeftUp:
          return Cursors.SizeNWSE;
        case UserRect.PosSizableRect.RightUp:
          return Cursors.SizeNESW;
        case UserRect.PosSizableRect.RightMiddle:
          return Cursors.SizeWE;
        case UserRect.PosSizableRect.RightBottom:
          return Cursors.SizeNWSE;
        case UserRect.PosSizableRect.BottomMiddle:
          return Cursors.SizeNS;
        default:
          return Cursors.Default;
      }
    }

    private enum PosSizableRect
    {
      UpMiddle,
      LeftMiddle,
      LeftBottom,
      LeftUp,
      RightUp,
      RightMiddle,
      RightBottom,
      BottomMiddle,
      None,
    }
  }
}
