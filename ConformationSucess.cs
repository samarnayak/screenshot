// Decompiled with JetBrains decompiler
// Type: ScreenShort.ConformationSucess
// Assembly: ScreenShort, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 91E3C326-E9E8-4853-A16B-DACECCC63BDC
// Assembly location: C:\Users\samar\Downloads\ScreenShot3.0.0.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ScreenShort
{
  public class ConformationSucess : Form
  {
    private int n = 0;
    private IContainer components = (IContainer) null;
    private Label lblMessage;
    private Button button1;
    private Timer timerSucess;

    public ConformationSucess() => this.InitializeComponent();

    public ConformationSucess(string Message)
    {
      this.InitializeComponent();
      this.lblMessage.Text = Message;
    }

    private void timerSucess_Tick(object sender, EventArgs e)
    {
      ++this.n;
      if (this.n <= 10)
        return;
      this.Dispose();
    }

    private void ConformationSucess_Load(object sender, EventArgs e) => this.timerSucess.Start();

    private void button1_Click(object sender, EventArgs e) => this.Dispose();

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new Container();
      this.lblMessage = new Label();
      this.button1 = new Button();
      this.timerSucess = new Timer(this.components);
      this.SuspendLayout();
      this.lblMessage.AutoSize = true;
      this.lblMessage.Font = new Font("Arial Rounded MT Bold", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblMessage.ForeColor = Color.ForestGreen;
      this.lblMessage.Location = new Point(2, 2);
      this.lblMessage.Name = "lblMessage";
      this.lblMessage.Size = new Size(129, 22);
      this.lblMessage.TabIndex = 1;
      this.lblMessage.Text = "Image Saved";
      this.button1.BackColor = Color.White;
      this.button1.FlatStyle = FlatStyle.Popup;
      this.button1.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.button1.Location = new Point(33, 28);
      this.button1.Name = "button1";
      this.button1.Size = new Size(66, 21);
      this.button1.TabIndex = 2;
      this.button1.Text = "OK";
      this.button1.UseVisualStyleBackColor = false;
      this.button1.Click += new EventHandler(this.button1_Click);
      this.timerSucess.Tick += new EventHandler(this.timerSucess_Tick);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.White;
      this.ClientSize = new Size(146, 54);
      this.ControlBox = false;
      this.Controls.Add((Control) this.button1);
      this.Controls.Add((Control) this.lblMessage);
      this.FormBorderStyle = FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = nameof (ConformationSucess);
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Load += new EventHandler(this.ConformationSucess_Load);
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
