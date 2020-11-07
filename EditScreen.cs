// Decompiled with JetBrains decompiler
// Type: ScreenShort.EditScreen
// Assembly: ScreenShort, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 91E3C326-E9E8-4853-A16B-DACECCC63BDC
// Assembly location: C:\Users\samar\Downloads\ScreenShot3.0.0.exe

using ScreenShort.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ScreenShort
{
  public class EditScreen : Form
  {
    private IContainer components = (IContainer) null;
    private PictureBox pictureBox1;
    private PictureBox pbClose;
    private PictureBox pbMove;
    private PictureBox pbSave;
    private Panel pnIconContainer;
    private PictureBox pbCopy;
    private PictureBox pbMakeRectangle;
    private PictureBox pbIncrease;
    private PictureBox pbDecrease;
    private Panel pnIncreaseDecrease;
    private PictureBox pbPaint;
    private PictureBox pbCrop;
    private PictureBox pbBack;
    private PictureBox pbForward;
    private SaveFileDialog saveFileImage;
    private Rectangle rect;
    private UserRect UserRect;
    private Bitmap memoryImage;
    private Size s;
    private Graphics memoryGraphics;
    private int ScreenHeight = Screen.PrimaryScreen.WorkingArea.Height;
    private int ScreenWidth = Screen.PrimaryScreen.WorkingArea.Width;
    private Stack<Bitmap> ImgStackBack = new Stack<Bitmap>();
    private List<Bitmap> ImgLst = new List<Bitmap>();
    private int ptr = -1;
    private bool PerformMove = false;
    private int DiffX = 0;
    private int DiffY = 0;

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (EditScreen));
      this.pictureBox1 = new PictureBox();
      this.pbClose = new PictureBox();
      this.pbMove = new PictureBox();
      this.pbSave = new PictureBox();
      this.pnIconContainer = new Panel();
      this.pbForward = new PictureBox();
      this.pbCrop = new PictureBox();
      this.pbBack = new PictureBox();
      this.pbPaint = new PictureBox();
      this.pbMakeRectangle = new PictureBox();
      this.pbCopy = new PictureBox();
      this.pbIncrease = new PictureBox();
      this.pbDecrease = new PictureBox();
      this.pnIncreaseDecrease = new Panel();
      this.saveFileImage = new SaveFileDialog();
      ((ISupportInitialize) this.pictureBox1).BeginInit();
      ((ISupportInitialize) this.pbClose).BeginInit();
      ((ISupportInitialize) this.pbMove).BeginInit();
      ((ISupportInitialize) this.pbSave).BeginInit();
      this.pnIconContainer.SuspendLayout();
      ((ISupportInitialize) this.pbForward).BeginInit();
      ((ISupportInitialize) this.pbCrop).BeginInit();
      ((ISupportInitialize) this.pbBack).BeginInit();
      ((ISupportInitialize) this.pbPaint).BeginInit();
      ((ISupportInitialize) this.pbMakeRectangle).BeginInit();
      ((ISupportInitialize) this.pbCopy).BeginInit();
      ((ISupportInitialize) this.pbIncrease).BeginInit();
      ((ISupportInitialize) this.pbDecrease).BeginInit();
      this.pnIncreaseDecrease.SuspendLayout();
      this.SuspendLayout();
      this.pictureBox1.BackColor = SystemColors.AppWorkspace;
      this.pictureBox1.BackgroundImage = (Image) componentResourceManager.GetObject("pictureBox1.BackgroundImage");
      this.pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox1.ErrorImage = (Image) null;
      this.pictureBox1.Location = new Point(12, 12);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new Size(650, 435);
      this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
      this.pictureBox1.TabIndex = 0;
      this.pictureBox1.TabStop = false;
      this.pictureBox1.WaitOnLoad = true;
      this.pictureBox1.Click += new EventHandler(this.pictureBox1_Click);
      this.pictureBox1.MouseDown += new MouseEventHandler(this.pictureBox1_MouseDown);
      this.pictureBox1.MouseMove += new MouseEventHandler(this.pictureBox1_MouseMove);
      this.pictureBox1.MouseUp += new MouseEventHandler(this.pictureBox1_MouseUp);
      this.pictureBox1.Resize += new EventHandler(this.pictureBox1_Resize);
      this.pbClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.pbClose.BackgroundImage = (Image) componentResourceManager.GetObject("pbClose.BackgroundImage");
      this.pbClose.BackgroundImageLayout = ImageLayout.Zoom;
      this.pbClose.Location = new Point(326, 1);
      this.pbClose.Name = "pbClose";
      this.pbClose.Size = new Size(42, 23);
      this.pbClose.TabIndex = 5;
      this.pbClose.TabStop = false;
      this.pbClose.Click += new EventHandler(this.pbClose_Click);
      this.pbClose.MouseEnter += new EventHandler(this.pbClose_MouseEnter);
      this.pbClose.MouseLeave += new EventHandler(this.pbClose_MouseLeave);
      this.pbMove.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.pbMove.BackgroundImage = (Image) componentResourceManager.GetObject("pbMove.BackgroundImage");
      this.pbMove.BackgroundImageLayout = ImageLayout.Zoom;
      this.pbMove.Location = new Point(285, 1);
      this.pbMove.Name = "pbMove";
      this.pbMove.Size = new Size(41, 23);
      this.pbMove.TabIndex = 7;
      this.pbMove.TabStop = false;
      this.pbMove.Click += new EventHandler(this.pbMove_Click);
      this.pbMove.MouseDown += new MouseEventHandler(this.pbMove_MouseDown);
      this.pbMove.MouseEnter += new EventHandler(this.pbMove_MouseEnter);
      this.pbMove.MouseLeave += new EventHandler(this.pbMove_MouseLeave);
      this.pbMove.MouseMove += new MouseEventHandler(this.pbMove_MouseMove);
      this.pbMove.MouseUp += new MouseEventHandler(this.pbMove_MouseUp);
      this.pbSave.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.pbSave.BackgroundImage = (Image) componentResourceManager.GetObject("pbSave.BackgroundImage");
      this.pbSave.BackgroundImageLayout = ImageLayout.Zoom;
      this.pbSave.Location = new Point(247, 1);
      this.pbSave.Name = "pbSave";
      this.pbSave.Size = new Size(38, 23);
      this.pbSave.TabIndex = 8;
      this.pbSave.TabStop = false;
      this.pbSave.Click += new EventHandler(this.pbSave_Click);
      this.pbSave.MouseEnter += new EventHandler(this.pbSave_MouseEnter);
      this.pbSave.MouseLeave += new EventHandler(this.pbSave_MouseLeave);
      this.pnIconContainer.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.pnIconContainer.BackColor = Color.White;
      this.pnIconContainer.BackgroundImageLayout = ImageLayout.Zoom;
      this.pnIconContainer.BorderStyle = BorderStyle.FixedSingle;
      this.pnIconContainer.Controls.Add((Control) this.pbForward);
      this.pnIconContainer.Controls.Add((Control) this.pbCrop);
      this.pnIconContainer.Controls.Add((Control) this.pbBack);
      this.pnIconContainer.Controls.Add((Control) this.pbPaint);
      this.pnIconContainer.Controls.Add((Control) this.pbMakeRectangle);
      this.pnIconContainer.Controls.Add((Control) this.pbCopy);
      this.pnIconContainer.Controls.Add((Control) this.pbClose);
      this.pnIconContainer.Controls.Add((Control) this.pbMove);
      this.pnIconContainer.Controls.Add((Control) this.pbSave);
      this.pnIconContainer.Location = new Point(441, 0);
      this.pnIconContainer.Name = "pnIconContainer";
      this.pnIconContainer.Size = new Size(371, 27);
      this.pnIconContainer.TabIndex = 9;
      this.pbForward.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.pbForward.BackgroundImage = (Image) componentResourceManager.GetObject("pbForward.BackgroundImage");
      this.pbForward.BackgroundImageLayout = ImageLayout.Zoom;
      this.pbForward.Location = new Point(47, 1);
      this.pbForward.Name = "pbForward";
      this.pbForward.Size = new Size(40, 23);
      this.pbForward.TabIndex = 14;
      this.pbForward.TabStop = false;
      this.pbForward.Click += new EventHandler(this.pbForward_Click);
      this.pbForward.MouseEnter += new EventHandler(this.pbForward_MouseEnter);
      this.pbForward.MouseLeave += new EventHandler(this.pbForward_MouseLeave);
      this.pbCrop.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.pbCrop.BackgroundImage = (Image) componentResourceManager.GetObject("pbCrop.BackgroundImage");
      this.pbCrop.BackgroundImageLayout = ImageLayout.Zoom;
      this.pbCrop.Location = new Point(204, 1);
      this.pbCrop.Name = "pbCrop";
      this.pbCrop.Size = new Size(43, 24);
      this.pbCrop.TabIndex = 12;
      this.pbCrop.TabStop = false;
      this.pbCrop.Click += new EventHandler(this.pbCrop_Click_1);
      this.pbCrop.MouseEnter += new EventHandler(this.pbCrop_MouseEnter_1);
      this.pbCrop.MouseLeave += new EventHandler(this.pbCrop_MouseLeave_1);
      this.pbBack.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.pbBack.BackgroundImage = (Image) componentResourceManager.GetObject("pbBack.BackgroundImage");
      this.pbBack.BackgroundImageLayout = ImageLayout.Zoom;
      this.pbBack.Location = new Point(7, 1);
      this.pbBack.Name = "pbBack";
      this.pbBack.Size = new Size(40, 23);
      this.pbBack.TabIndex = 13;
      this.pbBack.TabStop = false;
      this.pbBack.Click += new EventHandler(this.pbBack_Click);
      this.pbBack.MouseEnter += new EventHandler(this.pbBack_MouseEnter);
      this.pbBack.MouseLeave += new EventHandler(this.pbBack_MouseLeave);
      this.pbBack.MouseHover += new EventHandler(this.pbBack_MouseHover);
      this.pbPaint.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.pbPaint.BackgroundImage = (Image) componentResourceManager.GetObject("pbPaint.BackgroundImage");
      this.pbPaint.BackgroundImageLayout = ImageLayout.Zoom;
      this.pbPaint.Location = new Point(86, 1);
      this.pbPaint.Name = "pbPaint";
      this.pbPaint.Size = new Size(40, 23);
      this.pbPaint.TabIndex = 11;
      this.pbPaint.TabStop = false;
      this.pbPaint.Click += new EventHandler(this.pbPaint_Click);
      this.pbPaint.MouseEnter += new EventHandler(this.pbPaint_MouseEnter);
      this.pbPaint.MouseLeave += new EventHandler(this.pbPaint_MouseLeave);
      this.pbMakeRectangle.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.pbMakeRectangle.BackgroundImage = (Image) componentResourceManager.GetObject("pbMakeRectangle.BackgroundImage");
      this.pbMakeRectangle.BackgroundImageLayout = ImageLayout.Zoom;
      this.pbMakeRectangle.Location = new Point(164, 1);
      this.pbMakeRectangle.Name = "pbMakeRectangle";
      this.pbMakeRectangle.Size = new Size(40, 23);
      this.pbMakeRectangle.TabIndex = 10;
      this.pbMakeRectangle.TabStop = false;
      this.pbMakeRectangle.Click += new EventHandler(this.pbMakeRectangle_Click);
      this.pbMakeRectangle.MouseDown += new MouseEventHandler(this.pbMakeRectangle_MouseDown);
      this.pbMakeRectangle.MouseEnter += new EventHandler(this.pbMakeRectangle_MouseEnter);
      this.pbMakeRectangle.MouseLeave += new EventHandler(this.pbMakeRectangle_MouseLeave);
      this.pbMakeRectangle.MouseUp += new MouseEventHandler(this.pbMakeRectangle_MouseUp);
      this.pbCopy.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.pbCopy.BackgroundImage = (Image) componentResourceManager.GetObject("pbCopy.BackgroundImage");
      this.pbCopy.BackgroundImageLayout = ImageLayout.Zoom;
      this.pbCopy.Location = new Point(126, 1);
      this.pbCopy.Name = "pbCopy";
      this.pbCopy.Size = new Size(38, 23);
      this.pbCopy.TabIndex = 9;
      this.pbCopy.TabStop = false;
      this.pbCopy.Click += new EventHandler(this.pbCopy_Click);
      this.pbCopy.MouseEnter += new EventHandler(this.pbCopy_MouseEnter);
      this.pbCopy.MouseLeave += new EventHandler(this.pbCopy_MouseLeave);
      this.pbIncrease.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      this.pbIncrease.BackgroundImage = (Image) componentResourceManager.GetObject("pbIncrease.BackgroundImage");
      this.pbIncrease.BackgroundImageLayout = ImageLayout.Stretch;
      this.pbIncrease.Location = new Point(38, 1);
      this.pbIncrease.Name = "pbIncrease";
      this.pbIncrease.Size = new Size(37, 23);
      this.pbIncrease.TabIndex = 11;
      this.pbIncrease.TabStop = false;
      this.pbIncrease.Click += new EventHandler(this.pbIncrease_Click);
      this.pbIncrease.MouseEnter += new EventHandler(this.pbIncrease_MouseEnter);
      this.pbIncrease.MouseLeave += new EventHandler(this.pbIncrease_MouseLeave);
      this.pbDecrease.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      this.pbDecrease.BackgroundImage = (Image) componentResourceManager.GetObject("pbDecrease.BackgroundImage");
      this.pbDecrease.BackgroundImageLayout = ImageLayout.Stretch;
      this.pbDecrease.Location = new Point(1, 1);
      this.pbDecrease.Name = "pbDecrease";
      this.pbDecrease.Size = new Size(34, 23);
      this.pbDecrease.TabIndex = 12;
      this.pbDecrease.TabStop = false;
      this.pbDecrease.Click += new EventHandler(this.pbDecrease_Click);
      this.pbDecrease.MouseEnter += new EventHandler(this.pbDecrease_MouseEnter);
      this.pbDecrease.MouseLeave += new EventHandler(this.pbDecrease_MouseLeave);
      this.pnIncreaseDecrease.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      this.pnIncreaseDecrease.BackColor = Color.White;
      this.pnIncreaseDecrease.BorderStyle = BorderStyle.FixedSingle;
      this.pnIncreaseDecrease.Controls.Add((Control) this.pbDecrease);
      this.pnIncreaseDecrease.Controls.Add((Control) this.pbIncrease);
      this.pnIncreaseDecrease.Location = new Point(728, 433);
      this.pnIncreaseDecrease.Name = "pnIncreaseDecrease";
      this.pnIncreaseDecrease.Size = new Size(80, 26);
      this.pnIncreaseDecrease.TabIndex = 11;
      this.saveFileImage.Filter = "jpg|*.jpg|bmp|*.bmp|png|*.png|gif|*.gif";
      this.saveFileImage.Title = "Save the image";
      this.AutoScaleMode = AutoScaleMode.Inherit;
      this.AutoScroll = true;
      this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
      this.BackColor = SystemColors.ControlDark;
      this.ClientSize = new Size(812, 459);
      this.ControlBox = false;
      this.Controls.Add((Control) this.pnIncreaseDecrease);
      this.Controls.Add((Control) this.pnIconContainer);
      this.Controls.Add((Control) this.pictureBox1);
      this.FormBorderStyle = FormBorderStyle.None;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = nameof (EditScreen);
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Load += new EventHandler(this.Form1_Load);
      this.Scroll += new ScrollEventHandler(this.EditScreen_Scroll);
      this.KeyDown += new KeyEventHandler(this.EditScreen_KeyDown);
      ((ISupportInitialize) this.pictureBox1).EndInit();
      ((ISupportInitialize) this.pbClose).EndInit();
      ((ISupportInitialize) this.pbMove).EndInit();
      ((ISupportInitialize) this.pbSave).EndInit();
      this.pnIconContainer.ResumeLayout(false);
      ((ISupportInitialize) this.pbForward).EndInit();
      ((ISupportInitialize) this.pbCrop).EndInit();
      ((ISupportInitialize) this.pbBack).EndInit();
      ((ISupportInitialize) this.pbPaint).EndInit();
      ((ISupportInitialize) this.pbMakeRectangle).EndInit();
      ((ISupportInitialize) this.pbCopy).EndInit();
      ((ISupportInitialize) this.pbIncrease).EndInit();
      ((ISupportInitialize) this.pbDecrease).EndInit();
      this.pnIncreaseDecrease.ResumeLayout(false);
      this.ResumeLayout(false);
    }

    public Panel IconContainer => this.pnIconContainer;

    public Panel IncreaseDreaseContainer => this.pnIncreaseDecrease;

    public EditScreen(Bitmap memoryImage)
    {
      try
      {
        this.ImgLst.Add(new Bitmap((Image) memoryImage));
        ++this.ptr;
        this.memoryImage = memoryImage;
        this.InitializeComponent();
        this.Size = new Size((int) ((double) this.ScreenWidth * 0.8), (int) ((double) this.ScreenHeight * 0.8));
        this.UserRect = new UserRect(this);
      }
      catch (Exception ex)
      {
        int num = (int) new ConformationUnSuccessfull(ex.Message).ShowDialog();
      }
    }

    private void pbClose_Click(object sender, EventArgs e) => this.Dispose();

    private void pictureBox1_Click(object sender, EventArgs e)
    {
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      try
      {
        this.UserRect.DoNotPaint = true;
        this.pictureBox1.BackgroundImage = (Image) this.memoryImage;
        PictureBox pictureBox1 = this.pictureBox1;
        Size size1 = this.memoryImage.Size;
        int width = (int) ((double) size1.Width * 0.7);
        size1 = this.memoryImage.Size;
        int height = (int) ((double) size1.Height * 0.7);
        Size size2 = new Size(width, height);
        pictureBox1.Size = size2;
        this.pnIconContainer.Location = new Point(this.Width - this.pnIconContainer.Width - 15, 0);
        this.pnIncreaseDecrease.Location = new Point(this.Width - this.pnIncreaseDecrease.Width - 20, this.Height - this.pnIncreaseDecrease.Height - 20);
      }
      catch (Exception ex)
      {
        int num = (int) new ConformationUnSuccessfull(ex.Message).ShowDialog();
      }
    }

    private void pbCrop_Click_1(object sender, EventArgs e)
    {
      try
      {
        if (this.UserRect.DoNotPaint)
        {
          int num = (int) new DisplayMessage().ShowDialog();
        }
        else
        {
          Rectangle rect1 = this.UserRect.Rect;
          ref Rectangle local = ref rect1;
          Rectangle rect2 = this.UserRect.Rect;
          int x = (int) ((double) rect2.X * ((double) this.memoryImage.Width / (double) this.pictureBox1.Width));
          rect2 = this.UserRect.Rect;
          int y = (int) ((double) rect2.Y * ((double) this.memoryImage.Height / (double) this.pictureBox1.Height));
          rect2 = this.UserRect.Rect;
          int width = (int) ((double) rect2.Width * ((double) this.memoryImage.Width / (double) this.pictureBox1.Width));
          rect2 = this.UserRect.Rect;
          int height = (int) ((double) rect2.Height * ((double) this.memoryImage.Height / (double) this.pictureBox1.Height));
          local = new Rectangle(x, y, width, height);
          this.memoryImage = this.memoryImage.Clone(rect1, this.memoryImage.PixelFormat);
          this.pictureBox1.BackgroundImage = (Image) this.memoryImage;
          this.pictureBox1.Size = this.memoryImage.Size;
          this.ImgLst.Insert(++this.ptr, new Bitmap((Image) this.memoryImage));
          this.UserRect.DoNotPaint = true;
          this.pictureBox1.Invalidate();
          this.pnIconContainer.Location = new Point(this.Width - this.pnIconContainer.Width - 15, 0);
          this.pnIncreaseDecrease.Location = new Point(this.Width - this.pnIncreaseDecrease.Width - 20, this.Height - this.pnIncreaseDecrease.Height - 20);
        }
      }
      catch (Exception ex)
      {
        int num = (int) new ConformationUnSuccessfull(ex.Message).ShowDialog();
      }
    }

    private void pbSave_Click(object sender, EventArgs e)
    {
      try
      {
        int num = (int) this.saveFileImage.ShowDialog();
        if (this.saveFileImage.FileName != "")
        {
          this.memoryImage.Save(this.saveFileImage.FileName);
          new ConformationSucess().Show();
        }
        else
          new ConformationUnSuccessfull().Show();
        this.saveFileImage.FileName = string.Empty;
      }
      catch (Exception ex)
      {
        int num = (int) new ConformationUnSuccessfull(ex.Message).ShowDialog();
      }
    }

    private void pbMove_Click(object sender, EventArgs e)
    {
    }

    private void pbMove_MouseDown(object sender, MouseEventArgs e)
    {
      this.PerformMove = true;
      Point point1 = Cursor.Position;
      int x1 = point1.X;
      point1 = this.Location;
      int x2 = point1.X;
      this.DiffX = x1 - x2;
      Point point2 = Cursor.Position;
      int y1 = point2.Y;
      point2 = this.Location;
      int y2 = point2.Y;
      this.DiffY = y1 - y2;
    }

    private void pbMove_MouseMove(object sender, MouseEventArgs e)
    {
      if (!this.PerformMove)
        return;
      this.Location = new Point(Cursor.Position.X - this.DiffX, Cursor.Position.Y - this.DiffY);
    }

    private void pbMove_MouseUp(object sender, MouseEventArgs e) => this.PerformMove = false;

    private void pbCopy_Click(object sender, EventArgs e)
    {
      try
      {
        Clipboard.SetImage((Image) this.memoryImage);
        new ConformationSucess("Image Copied").Show();
      }
      catch (Exception ex)
      {
        int num = (int) new ConformationUnSuccessfull(ex.Message).ShowDialog();
      }
    }

    private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
    {
      this.IconContainer.Visible = false;
      this.IncreaseDreaseContainer.Visible = false;
      if (!LockGrant.GrantForRectangle)
        return;
      this.pictureBox1.Cursor = Cursors.Cross;
      this.rect.X = e.X;
      this.rect.Y = e.Y;
      this.rect.Height = 0;
      this.rect.Width = 0;
    }

    private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
    {
      try
      {
        if (e.Button != MouseButtons.Left || !LockGrant.GrantForRectangle)
          return;
        this.pictureBox1.Cursor = Cursors.Cross;
        ControlPaint.DrawReversibleFrame(this.pictureBox1.RectangleToScreen(this.rect), Color.Black, FrameStyle.Dashed);
        if (e.X < this.rect.X)
        {
          this.rect.Height += Math.Abs(e.Y - this.rect.Y);
          this.rect.Width += Math.Abs(e.X - this.rect.X);
          this.rect.X = e.X;
          this.rect.Y = e.Y;
        }
        else
        {
          this.rect.Width = Math.Abs(e.X - this.rect.X);
          this.rect.Height = Math.Abs(e.Y - this.rect.Y);
        }
        ControlPaint.DrawReversibleFrame(this.pictureBox1.RectangleToScreen(this.rect), Color.Black, FrameStyle.Dashed);
      }
      catch (Exception ex)
      {
        int num = (int) new ConformationUnSuccessfull(ex.Message).ShowDialog();
      }
    }

    private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
    {
      try
      {
        this.IconContainer.Visible = true;
        this.IncreaseDreaseContainer.Visible = true;
        if (!LockGrant.GrantForRectangle)
          return;
        this.pictureBox1.CreateGraphics();
        Pen pen = new Pen(Color.Blue, 2f);
        ControlPaint.DrawReversibleFrame(this.pictureBox1.RectangleToScreen(this.rect), Color.Black, FrameStyle.Dashed);
        this.UserRect.Rect = this.rect;
        this.UserRect.SetPictureBox(this.pictureBox1);
        LockGrant.GrantForRectangle = false;
        LockGrant.GrantForExtension = true;
        this.pictureBox1.Cursor = Cursors.Default;
        this.UserRect.DoNotPaint = false;
      }
      catch (Exception ex)
      {
        int num = (int) new ConformationUnSuccessfull(ex.Message).ShowDialog();
      }
    }

    private void pbMakeRectangle_Click(object sender, EventArgs e)
    {
      LockGrant.GrantForRectangle = true;
      this.pbCrop.Enabled = true;
      this.pictureBox1.Cursor = Cursors.Cross;
      this.UserRect.DoNotPaint = true;
      this.pictureBox1.Invalidate();
    }

    private void pbMakeRectangle_MouseDown(object sender, MouseEventArgs e) => this.pbMakeRectangle.BackColor = Color.Blue;

    private void pbMakeRectangle_MouseUp(object sender, MouseEventArgs e) => this.pbMakeRectangle.BackColor = Color.White;

    private void pbDecrease_Click(object sender, EventArgs e)
    {
      try
      {
        PictureBox pictureBox1 = this.pictureBox1;
        Size size1 = this.pictureBox1.Size;
        int width = (int) ((double) size1.Width * (10.0 / 11.0));
        size1 = this.pictureBox1.Size;
        int height = (int) ((double) size1.Height * (10.0 / 11.0));
        Size size2 = new Size(width, height);
        pictureBox1.Size = size2;
        this.pnIconContainer.Location = new Point(this.Width - this.pnIconContainer.Width - 15, 0);
        this.pnIncreaseDecrease.Location = new Point(this.Width - this.pnIncreaseDecrease.Width - 20, this.Height - this.pnIncreaseDecrease.Height - 20);
      }
      catch (Exception ex)
      {
        int num = (int) new ConformationUnSuccessfull(ex.Message).ShowDialog();
      }
    }

    private void pbIncrease_Click(object sender, EventArgs e)
    {
      try
      {
        PictureBox pictureBox1 = this.pictureBox1;
        Size size1 = this.pictureBox1.Size;
        int width = (int) ((double) size1.Width * 1.1);
        size1 = this.pictureBox1.Size;
        int height = (int) ((double) size1.Height * 1.1);
        Size size2 = new Size(width, height);
        pictureBox1.Size = size2;
        this.pnIconContainer.Location = new Point(this.Width - this.pnIconContainer.Width - 15, 0);
        this.pnIncreaseDecrease.Location = new Point(this.Width - this.pnIncreaseDecrease.Width - 20, this.Height - this.pnIncreaseDecrease.Height - 20);
      }
      catch (Exception ex)
      {
        int num = (int) new ConformationUnSuccessfull(ex.Message).ShowDialog();
      }
    }

    private void pbPaint_Click(object sender, EventArgs e)
    {
      try
      {
        if (this.UserRect.DoNotPaint)
        {
          int num = (int) new DisplayMessage().ShowDialog();
        }
        else
        {
          Rectangle rect1 = this.UserRect.Rect;
          ref Rectangle local = ref rect1;
          Rectangle rect2 = this.UserRect.Rect;
          int x = (int) ((double) rect2.X * ((double) this.memoryImage.Width / (double) this.pictureBox1.Width));
          rect2 = this.UserRect.Rect;
          int y = (int) ((double) rect2.Y * ((double) this.memoryImage.Height / (double) this.pictureBox1.Height));
          rect2 = this.UserRect.Rect;
          int width = (int) ((double) rect2.Width * ((double) this.memoryImage.Width / (double) this.pictureBox1.Width));
          rect2 = this.UserRect.Rect;
          int height = (int) ((double) rect2.Height * ((double) this.memoryImage.Height / (double) this.pictureBox1.Height));
          local = new Rectangle(x, y, width, height);
          this.memoryGraphics = Graphics.FromImage((Image) this.memoryImage);
          this.memoryGraphics.DrawRectangle(new Pen(Color.Red, (float) Settings.Default.PenWidth), rect1);
          this.pictureBox1.BackgroundImage = (Image) this.memoryImage;
          this.ImgLst.Insert(++this.ptr, new Bitmap((Image) this.memoryImage));
          this.UserRect.DoNotPaint = true;
          this.pictureBox1.Invalidate();
        }
      }
      catch (Exception ex)
      {
        int num = (int) new ConformationUnSuccessfull(ex.Message).ShowDialog();
      }
    }

    private void pbPaint_MouseEnter(object sender, EventArgs e) => this.pbPaint.BackColor = Color.Blue;

    private void pbPaint_MouseLeave(object sender, EventArgs e) => this.pbPaint.BackColor = Color.White;

    private void pbCopy_MouseEnter(object sender, EventArgs e) => this.pbCopy.BackColor = Color.Blue;

    private void pbCopy_MouseLeave(object sender, EventArgs e) => this.pbCopy.BackColor = Color.White;

    private void pbMakeRectangle_MouseEnter(object sender, EventArgs e) => this.pbMakeRectangle.BackColor = Color.Blue;

    private void pbMakeRectangle_MouseLeave(object sender, EventArgs e) => this.pbMakeRectangle.BackColor = Color.White;

    private void pbCrop_MouseEnter_1(object sender, EventArgs e) => this.pbCrop.BackColor = Color.Blue;

    private void pbCrop_MouseLeave_1(object sender, EventArgs e) => this.pbCrop.BackColor = Color.White;

    private void pbSave_MouseEnter(object sender, EventArgs e) => this.pbSave.BackColor = Color.Blue;

    private void pbSave_MouseLeave(object sender, EventArgs e) => this.pbSave.BackColor = Color.White;

    private void pbMove_MouseEnter(object sender, EventArgs e) => this.pbMove.BackColor = Color.Blue;

    private void pbMove_MouseLeave(object sender, EventArgs e) => this.pbMove.BackColor = Color.White;

    private void pbClose_MouseEnter(object sender, EventArgs e) => this.pbClose.BackColor = Color.Blue;

    private void pbClose_MouseLeave(object sender, EventArgs e) => this.pbClose.BackColor = Color.White;

    private void pbDecrease_MouseEnter(object sender, EventArgs e) => this.pbDecrease.BackColor = Color.Blue;

    private void pbDecrease_MouseLeave(object sender, EventArgs e) => this.pbDecrease.BackColor = Color.White;

    private void pbIncrease_MouseEnter(object sender, EventArgs e) => this.pbIncrease.BackColor = Color.Blue;

    private void pbIncrease_MouseLeave(object sender, EventArgs e) => this.pbIncrease.BackColor = Color.White;

    private void EditScreen_Scroll(object sender, ScrollEventArgs e)
    {
      this.pnIconContainer.Location = new Point(this.Width - this.pnIconContainer.Width - 15, 0);
      this.pnIncreaseDecrease.Location = new Point(this.Width - this.pnIncreaseDecrease.Width - 20, this.Height - this.pnIncreaseDecrease.Height - 20);
    }

    private void pictureBox1_Resize(object sender, EventArgs e)
    {
      this.pnIconContainer.Location = new Point(this.Width - this.pnIconContainer.Width - 15, 0);
      this.pnIncreaseDecrease.Location = new Point(this.Width - this.pnIncreaseDecrease.Width - 20, this.Height - this.pnIncreaseDecrease.Height - 20);
    }

    private void pbBack_Click(object sender, EventArgs e)
    {
      try
      {
        if (this.ptr > 0)
        {
          this.memoryImage = this.ImgLst[--this.ptr];
          this.pictureBox1.BackgroundImage = (Image) this.memoryImage;
          this.pictureBox1.Size = this.memoryImage.Size;
        }
        this.pnIconContainer.Location = new Point(this.Width - this.pnIconContainer.Width - 15, 0);
        this.pnIncreaseDecrease.Location = new Point(this.Width - this.pnIncreaseDecrease.Width - 20, this.Height - this.pnIncreaseDecrease.Height - 20);
      }
      catch (Exception ex)
      {
        int num = (int) new ConformationUnSuccessfull(ex.Message).ShowDialog();
      }
    }

    private void pbForward_Click(object sender, EventArgs e)
    {
      try
      {
        if (this.ptr < this.ImgLst.Count - 1)
        {
          this.memoryImage = this.ImgLst[++this.ptr];
          this.pictureBox1.BackgroundImage = (Image) this.memoryImage;
          this.pictureBox1.Size = this.memoryImage.Size;
        }
        this.pnIconContainer.Location = new Point(this.Width - this.pnIconContainer.Width - 15, 0);
        this.pnIncreaseDecrease.Location = new Point(this.Width - this.pnIncreaseDecrease.Width - 20, this.Height - this.pnIncreaseDecrease.Height - 20);
      }
      catch (Exception ex)
      {
        int num = (int) new ConformationUnSuccessfull(ex.Message).ShowDialog();
      }
    }

    private void pbBack_MouseHover(object sender, EventArgs e)
    {
    }

    private void pbBack_MouseEnter(object sender, EventArgs e) => this.pbBack.BackColor = Color.Blue;

    private void pbBack_MouseLeave(object sender, EventArgs e) => this.pbBack.BackColor = Color.White;

    private void pbForward_MouseEnter(object sender, EventArgs e) => this.pbForward.BackColor = Color.Blue;

    private void pbForward_MouseLeave(object sender, EventArgs e) => this.pbForward.BackColor = Color.White;

    private void EditScreen_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.Control && e.KeyCode == Keys.C)
        this.pbCopy_Click(sender, (EventArgs) e);
      if (e.Control && e.KeyCode == Keys.S)
        this.pbSave_Click(sender, (EventArgs) e);
      if (e.Control && e.KeyCode == Keys.Z)
        this.pbBack_Click(sender, (EventArgs) e);
      if (e.Control && e.KeyCode == Keys.U)
        this.pbForward_Click(sender, (EventArgs) e);
      if (e.KeyCode == Keys.Up)
        this.pbIncrease_Click(sender, (EventArgs) e);
      if (e.KeyCode == Keys.Down)
        this.pbDecrease_Click(sender, (EventArgs) e);
      if (e.Control && e.KeyCode == Keys.X)
        this.CutAndCopy();
      if (!e.Control || e.KeyCode != Keys.P)
        return;
      this.pbPaint_Click(sender, (EventArgs) e);
    }

    public void CutAndCopy()
    {
      try
      {
        if (this.UserRect.DoNotPaint)
        {
          int num = (int) new DisplayMessage().ShowDialog();
        }
        else
        {
          Rectangle rect1 = this.UserRect.Rect;
          ref Rectangle local = ref rect1;
          Rectangle rect2 = this.UserRect.Rect;
          int x = (int) ((double) rect2.X * ((double) this.memoryImage.Width / (double) this.pictureBox1.Width));
          rect2 = this.UserRect.Rect;
          int y = (int) ((double) rect2.Y * ((double) this.memoryImage.Height / (double) this.pictureBox1.Height));
          rect2 = this.UserRect.Rect;
          int width = (int) ((double) rect2.Width * ((double) this.memoryImage.Width / (double) this.pictureBox1.Width));
          rect2 = this.UserRect.Rect;
          int height = (int) ((double) rect2.Height * ((double) this.memoryImage.Height / (double) this.pictureBox1.Height));
          local = new Rectangle(x, y, width, height);
          Clipboard.SetImage((Image) this.memoryImage.Clone(rect1, this.memoryImage.PixelFormat));
          this.memoryGraphics = Graphics.FromImage((Image) this.memoryImage);
          Pen pen = new Pen(Color.Black, 1f);
          pen.DashCap = DashCap.Round;
          pen.DashStyle = DashStyle.DashDot;
          this.memoryGraphics.FillRectangle((Brush) new SolidBrush(Color.White), rect1);
          this.memoryGraphics.DrawRectangle(pen, rect1);
          this.pictureBox1.BackgroundImage = (Image) this.memoryImage;
          this.ImgLst.Insert(++this.ptr, new Bitmap((Image) this.memoryImage));
          this.UserRect.DoNotPaint = true;
          this.pictureBox1.Invalidate();
          this.pnIconContainer.Location = new Point(this.Width - this.pnIconContainer.Width - 15, 0);
          this.pnIncreaseDecrease.Location = new Point(this.Width - this.pnIncreaseDecrease.Width - 20, this.Height - this.pnIncreaseDecrease.Height - 20);
          new ConformationSucess("Image Copied").Show();
        }
      }
      catch (Exception ex)
      {
        int num = (int) new ConformationUnSuccessfull(ex.Message).ShowDialog();
      }
    }
  }
}
