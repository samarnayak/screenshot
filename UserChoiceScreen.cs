// Decompiled with JetBrains decompiler
// Type: ScreenShort.UserChoiceScreen
// Assembly: ScreenShort, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 91E3C326-E9E8-4853-A16B-DACECCC63BDC
// Assembly location: C:\Users\samar\Downloads\ScreenShot3.0.0.exe

using ScreenShort.Properties;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ScreenShort
{
  public class UserChoiceScreen : Form
  {
    private bool PerformMove = false;
    private int DiffX = 0;
    private int DiffY = 0;
    private UserChoice UserOb = (UserChoice) null;
    private IContainer components = (IContainer) null;
    private PictureBox pictureBox1;
    private CheckBox chkSaveToClipboard;
    private Label label4;
    private Label label5;
    private TrackBar tbSleepTime;
    private Label lblSleepTime;
    private Label label1;
    private ComboBox cmbPenWidth;

    public UserChoiceScreen() => this.InitializeComponent();

    private void btnSave_Click(object sender, EventArgs e)
    {
      try
      {
        this.UserOb.SleepTime = this.tbSleepTime.Value;
        this.UserOb.SaveToClipboard = this.chkSaveToClipboard.Checked;
        this.UserOb.PenWidth = int.Parse(this.cmbPenWidth.Text);
        this.UserOb.SaveToResource();
        this.Dispose();
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show(ex.Message + "**** no data saved ****");
        this.Dispose();
      }
    }

    private void btnCancel_Click(object sender, EventArgs e) => this.Dispose();

    private void UserChoiceScreen_Load(object sender, EventArgs e)
    {
      this.UserOb = new UserChoice(Settings.Default.SleepTime, Settings.Default.SaveToClipboard, Settings.Default.PenWidth);
      this.tbSleepTime.Value = this.UserOb.SleepTime;
      this.lblSleepTime.Text = this.tbSleepTime.Value.ToString();
      this.chkSaveToClipboard.Checked = this.UserOb.SaveToClipboard;
      this.cmbPenWidth.Text = this.UserOb.PenWidth.ToString();
    }

    private void UserChoiceScreen_MouseDown(object sender, MouseEventArgs e)
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

    private void UserChoiceScreen_MouseMove(object sender, MouseEventArgs e)
    {
      if (!this.PerformMove)
        return;
      this.Location = new Point(Cursor.Position.X - this.DiffX, Cursor.Position.Y - this.DiffY);
    }

    private void UserChoiceScreen_MouseUp(object sender, MouseEventArgs e) => this.PerformMove = false;

    private void tbSleepTime_Scroll(object sender, EventArgs e) => this.lblSleepTime.Text = this.tbSleepTime.Value.ToString();

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (UserChoiceScreen));
      this.pictureBox1 = new PictureBox();
      this.chkSaveToClipboard = new CheckBox();
      this.label4 = new Label();
      this.label5 = new Label();
      this.tbSleepTime = new TrackBar();
      this.lblSleepTime = new Label();
      this.label1 = new Label();
      this.cmbPenWidth = new ComboBox();
      Button button1 = new Button();
      Button button2 = new Button();
      ((ISupportInitialize) this.pictureBox1).BeginInit();
      this.tbSleepTime.BeginInit();
      this.SuspendLayout();
      button1.BackColor = Color.White;
      button1.FlatStyle = FlatStyle.Popup;
      button1.Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      button1.Location = new Point(209, 164);
      button1.Name = "btnSave";
      button1.Size = new Size(71, 29);
      button1.TabIndex = 0;
      button1.Text = "Save";
      button1.UseVisualStyleBackColor = false;
      button1.Click += new EventHandler(this.btnSave_Click);
      button2.BackColor = Color.White;
      button2.FlatStyle = FlatStyle.Popup;
      button2.Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      button2.Location = new Point(300, 164);
      button2.Name = "btnCancel";
      button2.Size = new Size(72, 29);
      button2.TabIndex = 5;
      button2.Text = "Cancel";
      button2.UseVisualStyleBackColor = false;
      button2.Click += new EventHandler(this.btnCancel_Click);
      this.pictureBox1.Image = (Image) componentResourceManager.GetObject("pictureBox1.Image");
      this.pictureBox1.ImeMode = ImeMode.NoControl;
      this.pictureBox1.Location = new Point(2, 2);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new Size(36, 33);
      this.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
      this.pictureBox1.TabIndex = 6;
      this.pictureBox1.TabStop = false;
      this.chkSaveToClipboard.AutoSize = true;
      this.chkSaveToClipboard.Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.chkSaveToClipboard.Location = new Point(46, 44);
      this.chkSaveToClipboard.Name = "chkSaveToClipboard";
      this.chkSaveToClipboard.Size = new Size(288, 20);
      this.chkSaveToClipboard.TabIndex = 18;
      this.chkSaveToClipboard.Text = "Save Image to Clipboard (Use Clt+ V to save)";
      this.chkSaveToClipboard.UseVisualStyleBackColor = true;
      this.label4.AutoSize = true;
      this.label4.Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label4.Location = new Point(43, 86);
      this.label4.Name = "label4";
      this.label4.Size = new Size(73, 16);
      this.label4.TabIndex = 15;
      this.label4.Text = "Sleep Time";
      this.label5.AutoSize = true;
      this.label5.Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label5.Location = new Point(321, 86);
      this.label5.Name = "label5";
      this.label5.Size = new Size(26, 16);
      this.label5.TabIndex = 17;
      this.label5.Text = "ms";
      this.tbSleepTime.Location = new Point(112, 86);
      this.tbSleepTime.Maximum = 5000;
      this.tbSleepTime.Minimum = 100;
      this.tbSleepTime.Name = "tbSleepTime";
      this.tbSleepTime.Size = new Size(179, 45);
      this.tbSleepTime.TabIndex = 19;
      this.tbSleepTime.Value = 100;
      this.tbSleepTime.Scroll += new EventHandler(this.tbSleepTime_Scroll);
      this.lblSleepTime.AutoSize = true;
      this.lblSleepTime.Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblSleepTime.Location = new Point(289, 86);
      this.lblSleepTime.Name = "lblSleepTime";
      this.lblSleepTime.Size = new Size(0, 16);
      this.lblSleepTime.TabIndex = 20;
      this.label1.AutoSize = true;
      this.label1.Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label1.Location = new Point(48, 125);
      this.label1.Name = "label1";
      this.label1.Size = new Size(69, 16);
      this.label1.TabIndex = 21;
      this.label1.Text = "Pen Width";
      this.cmbPenWidth.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbPenWidth.FlatStyle = FlatStyle.System;
      this.cmbPenWidth.FormattingEnabled = true;
      this.cmbPenWidth.Items.AddRange(new object[7]
      {
        (object) "2",
        (object) "3",
        (object) "4",
        (object) "5",
        (object) "6",
        (object) "7",
        (object) "8"
      });
      this.cmbPenWidth.Location = new Point(123, 124);
      this.cmbPenWidth.Name = "cmbPenWidth";
      this.cmbPenWidth.Size = new Size(40, 21);
      this.cmbPenWidth.TabIndex = 22;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = SystemColors.ButtonFace;
      this.ClientSize = new Size(394, 199);
      this.ControlBox = false;
      this.Controls.Add((Control) this.cmbPenWidth);
      this.Controls.Add((Control) this.label1);
      this.Controls.Add((Control) this.lblSleepTime);
      this.Controls.Add((Control) this.tbSleepTime);
      this.Controls.Add((Control) this.chkSaveToClipboard);
      this.Controls.Add((Control) this.label5);
      this.Controls.Add((Control) this.label4);
      this.Controls.Add((Control) this.pictureBox1);
      this.Controls.Add((Control) button2);
      this.Controls.Add((Control) button1);
      this.FormBorderStyle = FormBorderStyle.FixedSingle;
      this.Name = nameof (UserChoiceScreen);
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterParent;
      this.Load += new EventHandler(this.UserChoiceScreen_Load);
      this.MouseDown += new MouseEventHandler(this.UserChoiceScreen_MouseDown);
      this.MouseMove += new MouseEventHandler(this.UserChoiceScreen_MouseMove);
      this.MouseUp += new MouseEventHandler(this.UserChoiceScreen_MouseUp);
      ((ISupportInitialize) this.pictureBox1).EndInit();
      this.tbSleepTime.EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
