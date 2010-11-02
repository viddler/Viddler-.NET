using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace ViddlerDemo
{
  public partial class ActionPanel : UserControl
  {
    public ActionPanel()
    {
      InitializeComponent();
    }

    private delegate void SetUploadProgressCallback(int progress, bool isUpload);

    internal void SetUploadProgress(int progress, bool isUpload)
    {
      if (this.InvokeRequired)
      {
        SetUploadProgressCallback d = new SetUploadProgressCallback(SetUploadProgress);
        this.Invoke(d, new object[] { progress, isUpload });
      }
      else
      {
        this.UploadButton.Enabled = !isUpload;
        this.CancelUploadButton.Visible = isUpload;
        this.ProgressBar.Visible = isUpload;
        this.ProgressBar.Value = Math.Min(progress, 100);
        if (isUpload)
        {
          this.ProgressLabel.Text = string.Concat(progress, "% completed");
        }
        else
        {
          this.ProgressLabel.Text = string.Empty;
        }
      }
    }
  }
}
