// Decompiled with JetBrains decompiler
// Type: ScreenShort.ScreenCapture
// Assembly: ScreenShort, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 91E3C326-E9E8-4853-A16B-DACECCC63BDC
// Assembly location: C:\Users\samar\Downloads\ScreenShot3.0.0.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ScreenShort
{
  public class ScreenCapture : Form
  {
    private bool PerformMove = false;
    private int DiffX = 0;
    private int DiffY = 0;
    private IContainer components = (IContainer) null;
    private SaveFileDialog saveFileDialogImage;
    private PictureBox pictureBox1;
    private PictureBox pictureBox2;
    private PictureBox pictureBox3;
    private PictureBox pictureBox4;
    private PictureBox pictureBox5;

    public ScreenCapture() => this.InitializeComponent();

    private void btnTakeScreenShort_Click(object sender, EventArgs e)
    {
    }

    private void pictureBox2_Click(object sender, EventArgs e) => this.WindowState = FormWindowState.Minimized;

    private void pictureBox1_Click(object sender, EventArgs e) => this.Dispose();

    private void ScreenCapture_MouseDown(object sender, MouseEventArgs e)
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

    private void ScreenCapture_MouseMove(object sender, MouseEventArgs e)
    {
      if (!this.PerformMove)
        return;
      this.Location = new Point(Cursor.Position.X - this.DiffX, Cursor.Position.Y - this.DiffY);
    }

    private void ScreenCapture_MouseUp(object sender, MouseEventArgs e) => this.PerformMove = false;

    private void pictureBox5_Click(object sender, EventArgs e)
    {
      string ErrorMsg = string.Empty;
      if (!ScreenShortClass.CaptureScreenShort((Form) this, this.saveFileDialogImage, out ErrorMsg))
      {
        int num = (int) new ConformationUnSuccessfull().ShowDialog();
      }
      else if (!ErrorMsg.Contains("ok"))
        new ConformationSucess().Show();
    }

    private void pictureBox4_Click(object sender, EventArgs e)
    {
      int num = (int) new UserChoiceScreen().ShowDialog();
    }

    private void pictureBox3_Click(object sender, EventArgs e)
    {
    }

    private void ScreenCapture_Load(object sender, EventArgs e) => ScreenShortClass.LoadFromFile();

    private void ScreenCapture_KeyDown(object sender, KeyEventArgs e)
    {
    }

    private void ScreenCapture_ChangeUICues(object sender, UICuesEventArgs e)
    {
    }

    private void ScreenCapture_Click(object sender, EventArgs e)
    {
    }

    private void ScreenCapture_Enter(object sender, EventArgs e)
    {
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (ScreenCapture));
      this.saveFileDialogImage = new SaveFileDialog();
      this.pictureBox1 = new PictureBox();
      this.pictureBox2 = new PictureBox();
      this.pictureBox3 = new PictureBox();
      this.pictureBox4 = new PictureBox();
      this.pictureBox5 = new PictureBox();
      ((ISupportInitialize) this.pictureBox1).BeginInit();
      ((ISupportInitialize) this.pictureBox2).BeginInit();
      ((ISupportInitialize) this.pictureBox3).BeginInit();
      ((ISupportInitialize) this.pictureBox4).BeginInit();
      ((ISupportInitialize) this.pictureBox5).BeginInit();
      this.SuspendLayout();
      componentResourceManager.ApplyResources((object) this.saveFileDialogImage, "saveFileDialogImage");
      componentResourceManager.ApplyResources((object) this.pictureBox1, "pictureBox1");
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.TabStop = false;
      this.pictureBox1.Click += new EventHandler(this.pictureBox1_Click);
      componentResourceManager.ApplyResources((object) this.pictureBox2, "pictureBox2");
      this.pictureBox2.Name = "pictureBox2";
      this.pictureBox2.TabStop = false;
      this.pictureBox2.Click += new EventHandler(this.pictureBox2_Click);
      componentResourceManager.ApplyResources((object) this.pictureBox3, "pictureBox3");
      this.pictureBox3.Name = "pictureBox3";
      this.pictureBox3.TabStop = false;
      this.pictureBox3.Click += new EventHandler(this.pictureBox3_Click);
      componentResourceManager.ApplyResources((object) this.pictureBox4, "pictureBox4");
      this.pictureBox4.Name = "pictureBox4";
      this.pictureBox4.TabStop = false;
      this.pictureBox4.Click += new EventHandler(this.pictureBox4_Click);
      this.pictureBox5.BorderStyle = BorderStyle.FixedSingle;
      componentResourceManager.ApplyResources((object) this.pictureBox5, "pictureBox5");
      this.pictureBox5.Name = "pictureBox5";
      this.pictureBox5.TabStop = false;
      this.pictureBox5.Click += new EventHandler(this.pictureBox5_Click);
      componentResourceManager.ApplyResources((object) this, "$this");
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.White;
      this.ControlBox = false;
      this.Controls.Add((Control) this.pictureBox3);
      this.Controls.Add((Control) this.pictureBox5);
      this.Controls.Add((Control) this.pictureBox4);
      this.Controls.Add((Control) this.pictureBox2);
      this.Controls.Add((Control) this.pictureBox1);
      this.ForeColor = Color.ForestGreen;
      this.FormBorderStyle = FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = nameof (ScreenCapture);
      this.Load += new EventHandler(this.ScreenCapture_Load);
      this.Click += new EventHandler(this.ScreenCapture_Click);
      this.Enter += new EventHandler(this.ScreenCapture_Enter);
      this.KeyDown += new KeyEventHandler(this.ScreenCapture_KeyDown);
      this.MouseDown += new MouseEventHandler(this.ScreenCapture_MouseDown);
      this.MouseMove += new MouseEventHandler(this.ScreenCapture_MouseMove);
      this.MouseUp += new MouseEventHandler(this.ScreenCapture_MouseUp);
      this.ChangeUICues += new UICuesEventHandler(this.ScreenCapture_ChangeUICues);
      ((ISupportInitialize) this.pictureBox1).EndInit();
      ((ISupportInitialize) this.pictureBox2).EndInit();
      ((ISupportInitialize) this.pictureBox3).EndInit();
      ((ISupportInitialize) this.pictureBox4).EndInit();
      ((ISupportInitialize) this.pictureBox5).EndInit();
      this.ResumeLayout(false);
    }
  }
}
