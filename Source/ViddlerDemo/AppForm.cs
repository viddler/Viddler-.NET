using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Threading;

namespace ViddlerDemo
{
  public partial class AppForm : Form
  {
    #region Fields and constructor

    private string sessionId;

    private Thread uploadThread;

    private bool isCancel;

    public AppForm()
    {
      InitializeComponent();

      this.authPanel.ConnectButton.Click += new EventHandler(connectButton_Click);

      this.actionPanel.RefreshButton.Click += new EventHandler(refreshButton_Click);
      this.actionPanel.ShowButton.Click += new EventHandler(showButton_Click);
      this.actionPanel.UpdateButton.Click += new EventHandler(updateButton_Click);
      this.actionPanel.UploadButton.Click += new EventHandler(uploadButton_Click);
      this.actionPanel.RemoveButton.Click += new EventHandler(removeButton_Click);
      this.actionPanel.CancelUploadButton.Click += new EventHandler(cancelUploadButton_Click);
    }

    #endregion

    #region Common code

    private delegate void WriteOutputTextCallback(string text); 

    private void WriteOutputText(string text)
    {
      if (this.outputText.InvokeRequired)
      {
        WriteOutputTextCallback d = new WriteOutputTextCallback(WriteOutputText);
        this.Invoke(d, new object[] { text });
      }
      else
      {
        this.outputText.AppendText(text);
        this.outputText.SelectionStart = this.outputText.TextLength;
        this.outputText.ScrollToCaret();
      }
    }

    private Viddler.ViddlerService GetVidlerService()
    {
      Viddler.ViddlerService viddlerService = new Viddler.ViddlerService();
      viddlerService.BaseUrl = this.authPanel.UrlText.Text;
      viddlerService.SecureBaseUrl = this.authPanel.SecureUrlText.Text;
      viddlerService.ApiKey = this.authPanel.ApiKeyText.Text;

      if (!string.IsNullOrEmpty(this.sessionId))
      {
        viddlerService.SessionId = this.sessionId;
      }

      viddlerService.BeginRequest += new EventHandler<Viddler.ViddlerRequestEventArgs>(viddlerService_BeginRequest);
      viddlerService.EndRequest += new EventHandler<Viddler.ViddlerRequestEventArgs>(viddlerService_EndRequest);
      viddlerService.Error += new EventHandler<Viddler.ViddlerRequestErrorEventArgs>(viddlerService_Error);
      viddlerService.Uploading += new EventHandler<Viddler.ViddlerRequestUploadEventArgs>(viddlerService_Uploading);

      return viddlerService;
    }

    private void LoadVideoList(Viddler.ViddlerService viddlerService)
    {
      this.fileComboBox.Items.Clear();

      Viddler.Data.VideoList videoList = viddlerService.Videos.GetByUser();
      if (videoList != null && videoList.Items != null && videoList.Items.Count > 0)
      {
        foreach (Viddler.Data.Video video in videoList.Items)
        {
          this.fileComboBox.Items.Add(new VideoListItem(video));
        }

        if (this.fileComboBox.Items.Count > 0)
        {
          this.fileComboBox.SelectedIndex = 0;
          this.filePropertyGrid.SelectedObject = ((VideoListItem)this.fileComboBox.SelectedItem);
          this.actionPanel.ShowButton.Enabled = true;
          this.actionPanel.RemoveButton.Enabled = true;
          this.actionPanel.UpdateButton.Enabled = true;
          return;
        }
      }
      this.filePropertyGrid.SelectedObject = null;
      this.actionPanel.ShowButton.Enabled = false;
      this.actionPanel.RemoveButton.Enabled = false;
      this.actionPanel.UpdateButton.Enabled = false;
    }

    private void UploadVideoFile(object data)
    {
      Viddler.ViddlerService viddlerService = (Viddler.ViddlerService)((object[])data)[0];
      string fileName = (string)((object[])data)[1];

      this.actionPanel.SetUploadProgress(0, true);

      Viddler.Data.Video newVideo = viddlerService.Videos.Upload("Just uploaded", "test,sample", "Test file", false, fileName);

      this.actionPanel.SetUploadProgress(100, false);

      if (newVideo != null)
      {
        MessageBox.Show("The new video has been uploaded successfully.\r\nThe video will appear on the list, after it is encoded by the server.\r\n\r\nWait few minutes and then press \"Refresh\" button\r\nto update the video list.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
      }
      else
      {
        MessageBox.Show("The upload process has been aborted.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
      }
    }

    #endregion

    #region Viddler service events

    private void viddlerService_Uploading(object sender, Viddler.ViddlerRequestUploadEventArgs e)
    {
      this.actionPanel.SetUploadProgress((int)(e.BytesSent * this.actionPanel.ProgressBar.Maximum / e.TotalBytes), true);
      if (this.isCancel)
      {
        e.Cancel = true;
        this.isCancel = false;
        this.WriteOutputText("UPLOAD ABORTED\r\n------------------------------\r\n");
      }
    }

    private void viddlerService_Error(object sender, Viddler.ViddlerRequestErrorEventArgs e)
    {
      this.WriteOutputText("ERROR: ");
      this.WriteOutputText(e.ContractType.ToString());
      this.WriteOutputText("\r\n------------------------------\r\n");
      this.WriteOutputText(e.Exception.Message);
      this.WriteOutputText("\r\n------------------------------\r\n");
      //this.WriteOutputText(e.Exception.ToString());
      //this.WriteOutputText("\r\n------------------------------\r\n");
    }

    private void viddlerService_EndRequest(object sender, Viddler.ViddlerRequestEventArgs e)
    {
      this.WriteOutputText("END: ");
      this.WriteOutputText(e.ContractType.ToString());
      this.WriteOutputText("\r\n------------------------------\r\n");
    }

    private void viddlerService_BeginRequest(object sender, Viddler.ViddlerRequestEventArgs e)
    {
      this.WriteOutputText("BEGIN: ");
      this.WriteOutputText(e.ContractType.ToString());
      this.WriteOutputText("\r\n------------------------------\r\n");
    }

    #endregion

    #region Form events

    private void connectButton_Click(object sender, EventArgs e)
    {
      Viddler.ViddlerService viddlerService = this.GetVidlerService();

      viddlerService.Users.Auth(this.authPanel.UserNameText.Text, this.authPanel.PasswordText.Text);
      if (viddlerService.IsAuthenticated)
      {
        this.sessionId = viddlerService.SessionId;

        this.authPanel.Visible = false;
        this.actionPanel.Visible = true;
        this.fileComboBox.Enabled = true;
        this.filePropertyGrid.SelectedObject = new Viddler.Data.Video();

        this.LoadVideoList(viddlerService);
      }
    }

    private void fileComboBox_SelectedIndexChanged(object sender, EventArgs e)
    {
      this.filePropertyGrid.SelectedObject = ((VideoListItem)this.fileComboBox.SelectedItem);
    }

    private void showButton_Click(object sender, EventArgs e)
    {
      VideoListItem selectedItem = this.filePropertyGrid.SelectedObject as VideoListItem;
      if (selectedItem != null)
      {
        try
        {
          System.Diagnostics.Process.Start(selectedItem.Url.ToString());
        }
        catch { }
      }
    }

    private void updateButton_Click(object sender, EventArgs e)
    {
      Viddler.ViddlerService viddlerService = null;

      bool isUpdated = false;
      foreach (VideoListItem item in this.fileComboBox.Items)
      {
        if (item.IsChanged)
        {
          if (viddlerService == null)
          {
            viddlerService = this.GetVidlerService();
          }
          if (viddlerService.Videos.SetDetails(item.Id, item.Title, item.Description, null, null, null, null, null, null, null, null, null, null) != null)
          {
            item.IsChanged = false;
            isUpdated = true;
          }
        }
      }
      if (isUpdated)
      {
        this.LoadVideoList(viddlerService);
        MessageBox.Show("The videos have been updated successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
      }
    }

    private void removeButton_Click(object sender, EventArgs e)
    {
      VideoListItem selectedItem = this.filePropertyGrid.SelectedObject as VideoListItem;
      if (selectedItem != null)
      {
        if (MessageBox.Show("Are you sure you want to delete this video?", "Confirm delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
        {
          Viddler.ViddlerService viddlerService = this.GetVidlerService();

          if (viddlerService.Videos.Delete(selectedItem.Id))
          {
            this.LoadVideoList(viddlerService);
            MessageBox.Show("The video has been deleted successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
          }
        }
      }
    }

    private void uploadButton_Click(object sender, EventArgs e)
    {
      Viddler.ViddlerService viddlerService = this.GetVidlerService();

      if (this.uploadFileDialog.ShowDialog(this) == DialogResult.OK)
      {
        this.uploadThread = new Thread(UploadVideoFile);
        this.uploadThread.Start(new object[] { viddlerService, this.uploadFileDialog.FileName });
      }
    }

    private void refreshButton_Click(object sender, EventArgs e)
    {
      Viddler.ViddlerService viddlerService = this.GetVidlerService();

      this.LoadVideoList(viddlerService);
    }

    private void filePropertyGrid_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
    {
      ((VideoListItem)this.filePropertyGrid.SelectedObject).IsChanged = true;
    }

    private void cancelUploadButton_Click(object sender, EventArgs e)
    {
      this.isCancel = true;
    }

    private void AppForm_FormClosing(object sender, FormClosingEventArgs e)
    {
      foreach (VideoListItem item in this.fileComboBox.Items)
      {
        if (item.IsChanged)
        {
          e.Cancel = (MessageBox.Show("Some videos have been changed.\r\nDo you want to continue closing the application?", "Confirm closing", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel);
          break;
        }
      }
      if (!e.Cancel && this.uploadThread != null)
      {
        this.uploadThread.Abort();
      }
    }

    #endregion
  }
}
