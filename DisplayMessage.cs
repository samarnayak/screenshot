// Decompiled with JetBrains decompiler
// Type: ScreenShort.DisplayMessage
// Assembly: ScreenShort, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 91E3C326-E9E8-4853-A16B-DACECCC63BDC
// Assembly location: C:\Users\samar\Downloads\ScreenShot3.0.0.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ScreenShort
{
  public class DisplayMessage : Form
  {
    private int count = 0;
    private IContainer components = (IContainer) null;
    private Button btnOK;
    private Label lblMessageOne;
    private Label label1;
    private PictureBox pictureBox1;
    private Label label2;
    private Timer timer1;

    public DisplayMessage()
    {
      this.InitializeComponent();
      this.timer1.Start();
    }

    private void btnOK_Click(object sender, EventArgs e) => this.Dispose();

    private void timer1_Tick(object sender, EventArgs e)
    {
      ++this.count;
      if (this.count != 3)
        return;
      this.Dispose();
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new Container();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (DisplayMessage));
      this.btnOK = new Button();
      this.lblMessageOne = new Label();
      this.label1 = new Label();
      this.pictureBox1 = new PictureBox();
      this.label2 = new Label();
      this.timer1 = new Timer(this.components);
      ((ISupportInitialize) this.pictureBox1).BeginInit();
      this.SuspendLayout();
      this.btnOK.FlatStyle = FlatStyle.Popup;
      this.btnOK.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnOK.Location = new Point(145, 68);
      this.btnOK.Name = "btnOK";
      this.btnOK.Size = new Size(86, 33);
      this.btnOK.TabIndex = 0;
      this.btnOK.Text = "OK";
      this.btnOK.UseVisualStyleBackColor = true;
      this.btnOK.Click += new EventHandler(this.btnOK_Click);
      this.lblMessageOne.AutoSize = true;
      this.lblMessageOne.Font = new Font("Microsoft Sans Serif", 15.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblMessageOne.Location = new Point(16, 9);
      this.lblMessageOne.Name = "lblMessageOne";
      this.lblMessageOne.Size = new Size(344, 25);
      this.lblMessageOne.TabIndex = 1;
      this.lblMessageOne.Text = "Please select an Rectangular Area";
      this.label1.AutoSize = true;
      this.label1.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label1.Location = new Point(5, 44);
      this.label1.Name = "label1";
      this.label1.Size = new Size(64, 20);
      this.label1.TabIndex = 2;
      this.label1.Text = "Click on";
      this.pictureBox1.BackgroundImage = (Image) componentResourceManager.GetObject("pictureBox1.BackgroundImage");
      this.pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox1.Location = new Point(71, 40);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new Size(34, 31);
      this.pictureBox1.TabIndex = 3;
      this.pictureBox1.TabStop = false;
      this.label2.AutoSize = true;
      this.label2.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label2.Location = new Point(107, 44);
      this.label2.Name = "label2";
      this.label2.Size = new Size(266, 20);
      this.label2.TabIndex = 4;
      this.label2.Text = "Then use mouse to draw a rectangle";
      this.timer1.Interval = 1000;
      this.timer1.Tick += new EventHandler(this.timer1_Tick);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(381, 108);
      this.ControlBox = false;
      this.Controls.Add((Control) this.label2);
      this.Controls.Add((Control) this.pictureBox1);
      this.Controls.Add((Control) this.label1);
      this.Controls.Add((Control) this.lblMessageOne);
      this.Controls.Add((Control) this.btnOK);
      this.FormBorderStyle = FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = nameof (DisplayMessage);
      this.StartPosition = FormStartPosition.CenterScreen;
      ((ISupportInitialize) this.pictureBox1).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
