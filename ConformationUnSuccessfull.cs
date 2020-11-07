// Decompiled with JetBrains decompiler
// Type: ScreenShort.ConformationUnSuccessfull
// Assembly: ScreenShort, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 91E3C326-E9E8-4853-A16B-DACECCC63BDC
// Assembly location: C:\Users\samar\Downloads\ScreenShot3.0.0.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ScreenShort
{
  public class ConformationUnSuccessfull : Form
  {
    private IContainer components = (IContainer) null;
    private Button button1;
    private Label label1;
    private Timer timerUnSuccessfull;
    private RichTextBox rtbErrorMessage;
    private bool EnableTimer = true;
    private int n = 0;

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new Container();
      this.button1 = new Button();
      this.label1 = new Label();
      this.timerUnSuccessfull = new Timer(this.components);
      this.rtbErrorMessage = new RichTextBox();
      this.SuspendLayout();
      this.button1.BackColor = Color.White;
      this.button1.FlatStyle = FlatStyle.Popup;
      this.button1.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.button1.Location = new Point(83, 33);
      this.button1.Name = "button1";
      this.button1.Size = new Size(49, 20);
      this.button1.TabIndex = 4;
      this.button1.Text = "OK";
      this.button1.UseVisualStyleBackColor = false;
      this.button1.Click += new EventHandler(this.button1_Click);
      this.label1.AutoSize = true;
      this.label1.Font = new Font("MS Reference Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label1.ForeColor = Color.Red;
      this.label1.Location = new Point(9, 8);
      this.label1.Name = "label1";
      this.label1.Size = new Size(201, 20);
      this.label1.TabIndex = 3;
      this.label1.Text = "Ooops !!.. Not Saved";
      this.label1.Click += new EventHandler(this.label1_Click);
      this.timerUnSuccessfull.Tick += new EventHandler(this.timerUnSuccessfull_Tick);
      this.rtbErrorMessage.Font = new Font("Calibri", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.rtbErrorMessage.ForeColor = Color.Red;
      this.rtbErrorMessage.Location = new Point(2, 70);
      this.rtbErrorMessage.Name = "rtbErrorMessage";
      this.rtbErrorMessage.Size = new Size(217, 56);
      this.rtbErrorMessage.TabIndex = 5;
      this.rtbErrorMessage.Text = "";
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.White;
      this.ClientSize = new Size(221, 133);
      this.ControlBox = false;
      this.Controls.Add((Control) this.rtbErrorMessage);
      this.Controls.Add((Control) this.button1);
      this.Controls.Add((Control) this.label1);
      this.FormBorderStyle = FormBorderStyle.FixedSingle;
      this.Name = nameof (ConformationUnSuccessfull);
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Load += new EventHandler(this.ConformationUnSuccessfull_Load);
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    public ConformationUnSuccessfull()
    {
      this.InitializeComponent();
      this.Size = new Size(223, 70);
    }

    public ConformationUnSuccessfull(string Message)
    {
      this.InitializeComponent();
      this.rtbErrorMessage.Text = Message;
      this.EnableTimer = false;
    }

    private void button1_Click(object sender, EventArgs e) => this.Dispose();

    private void ConformationUnSuccessfull_Load(object sender, EventArgs e)
    {
      if (!this.EnableTimer)
        return;
      this.timerUnSuccessfull.Start();
    }

    private void timerUnSuccessfull_Tick(object sender, EventArgs e)
    {
      ++this.n;
      if (this.n <= 10)
        return;
      this.Dispose();
    }

    private void label1_Click(object sender, EventArgs e)
    {
    }
  }
}
