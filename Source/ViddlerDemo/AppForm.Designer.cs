namespace ViddlerDemo
{
  partial class AppForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppForm));
      this.horizontalSplitContainer = new System.Windows.Forms.SplitContainer();
      this.verticalSplitContainer = new System.Windows.Forms.SplitContainer();
      this.filePropertyGrid = new System.Windows.Forms.PropertyGrid();
      this.filePropertyLabel = new System.Windows.Forms.Label();
      this.fileComboBox = new System.Windows.Forms.ComboBox();
      this.filesLabel = new System.Windows.Forms.Label();
      this.actionPanel = new ViddlerDemo.ActionPanel();
      this.authPanel = new ViddlerDemo.AuthPanel();
      this.outputText = new System.Windows.Forms.RichTextBox();
      this.uploadFileDialog = new System.Windows.Forms.OpenFileDialog();
      this.horizontalSplitContainer.Panel1.SuspendLayout();
      this.horizontalSplitContainer.Panel2.SuspendLayout();
      this.horizontalSplitContainer.SuspendLayout();
      this.verticalSplitContainer.Panel1.SuspendLayout();
      this.verticalSplitContainer.Panel2.SuspendLayout();
      this.verticalSplitContainer.SuspendLayout();
      this.SuspendLayout();
      // 
      // horizontalSplitContainer
      // 
      this.horizontalSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
      this.horizontalSplitContainer.Location = new System.Drawing.Point(0, 0);
      this.horizontalSplitContainer.Name = "horizontalSplitContainer";
      this.horizontalSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
      // 
      // horizontalSplitContainer.Panel1
      // 
      this.horizontalSplitContainer.Panel1.Controls.Add(this.verticalSplitContainer);
      this.horizontalSplitContainer.Panel1MinSize = 400;
      // 
      // horizontalSplitContainer.Panel2
      // 
      this.horizontalSplitContainer.Panel2.Controls.Add(this.outputText);
      this.horizontalSplitContainer.Panel2.Padding = new System.Windows.Forms.Padding(10);
      this.horizontalSplitContainer.Panel2MinSize = 100;
      this.horizontalSplitContainer.Size = new System.Drawing.Size(792, 571);
      this.horizontalSplitContainer.SplitterDistance = 431;
      this.horizontalSplitContainer.SplitterIncrement = 50;
      this.horizontalSplitContainer.SplitterWidth = 10;
      this.horizontalSplitContainer.TabIndex = 1;
      // 
      // verticalSplitContainer
      // 
      this.verticalSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
      this.verticalSplitContainer.Location = new System.Drawing.Point(0, 0);
      this.verticalSplitContainer.Margin = new System.Windows.Forms.Padding(0);
      this.verticalSplitContainer.Name = "verticalSplitContainer";
      // 
      // verticalSplitContainer.Panel1
      // 
      this.verticalSplitContainer.Panel1.Controls.Add(this.filePropertyGrid);
      this.verticalSplitContainer.Panel1.Controls.Add(this.filePropertyLabel);
      this.verticalSplitContainer.Panel1.Controls.Add(this.fileComboBox);
      this.verticalSplitContainer.Panel1.Controls.Add(this.filesLabel);
      this.verticalSplitContainer.Panel1.Padding = new System.Windows.Forms.Padding(10);
      // 
      // verticalSplitContainer.Panel2
      // 
      this.verticalSplitContainer.Panel2.Controls.Add(this.actionPanel);
      this.verticalSplitContainer.Panel2.Controls.Add(this.authPanel);
      this.verticalSplitContainer.Panel2.Padding = new System.Windows.Forms.Padding(10);
      this.verticalSplitContainer.Size = new System.Drawing.Size(792, 431);
      this.verticalSplitContainer.SplitterDistance = 399;
      this.verticalSplitContainer.SplitterWidth = 10;
      this.verticalSplitContainer.TabIndex = 0;
      // 
      // filePropertyGrid
      // 
      this.filePropertyGrid.CausesValidation = false;
      this.filePropertyGrid.CommandsVisibleIfAvailable = false;
      this.filePropertyGrid.Dock = System.Windows.Forms.DockStyle.Fill;
      this.filePropertyGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.filePropertyGrid.Location = new System.Drawing.Point(10, 78);
      this.filePropertyGrid.Margin = new System.Windows.Forms.Padding(0);
      this.filePropertyGrid.Name = "filePropertyGrid";
      this.filePropertyGrid.Size = new System.Drawing.Size(379, 343);
      this.filePropertyGrid.TabIndex = 1;
      this.filePropertyGrid.ToolbarVisible = false;
      this.filePropertyGrid.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.filePropertyGrid_PropertyValueChanged);
      // 
      // filePropertyLabel
      // 
      this.filePropertyLabel.Dock = System.Windows.Forms.DockStyle.Top;
      this.filePropertyLabel.Location = new System.Drawing.Point(10, 56);
      this.filePropertyLabel.Name = "filePropertyLabel";
      this.filePropertyLabel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
      this.filePropertyLabel.Size = new System.Drawing.Size(379, 22);
      this.filePropertyLabel.TabIndex = 19;
      this.filePropertyLabel.Text = "Video item properties:";
      // 
      // fileComboBox
      // 
      this.fileComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
      this.fileComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
      this.fileComboBox.Dock = System.Windows.Forms.DockStyle.Top;
      this.fileComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.fileComboBox.Enabled = false;
      this.fileComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.fileComboBox.Location = new System.Drawing.Point(10, 32);
      this.fileComboBox.Name = "fileComboBox";
      this.fileComboBox.Size = new System.Drawing.Size(379, 24);
      this.fileComboBox.TabIndex = 0;
      this.fileComboBox.SelectedIndexChanged += new System.EventHandler(this.fileComboBox_SelectedIndexChanged);
      // 
      // filesLabel
      // 
      this.filesLabel.Dock = System.Windows.Forms.DockStyle.Top;
      this.filesLabel.Location = new System.Drawing.Point(10, 10);
      this.filesLabel.Name = "filesLabel";
      this.filesLabel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
      this.filesLabel.Size = new System.Drawing.Size(379, 22);
      this.filesLabel.TabIndex = 18;
      this.filesLabel.Text = "Select video item:";
      // 
      // actionPanel
      // 
      this.actionPanel.Dock = System.Windows.Forms.DockStyle.Top;
      this.actionPanel.Location = new System.Drawing.Point(10, 350);
      this.actionPanel.Name = "actionPanel";
      this.actionPanel.Padding = new System.Windows.Forms.Padding(0, 68, 0, 0);
      this.actionPanel.Size = new System.Drawing.Size(363, 380);
      this.actionPanel.TabIndex = 22;
      this.actionPanel.Visible = false;
      // 
      // authPanel
      // 
      this.authPanel.Dock = System.Windows.Forms.DockStyle.Top;
      this.authPanel.Location = new System.Drawing.Point(10, 10);
      this.authPanel.Name = "authPanel";
      this.authPanel.Padding = new System.Windows.Forms.Padding(0, 46, 0, 0);
      this.authPanel.Size = new System.Drawing.Size(363, 340);
      this.authPanel.TabIndex = 21;
      // 
      // outputText
      // 
      this.outputText.BackColor = System.Drawing.SystemColors.Window;
      this.outputText.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.outputText.Dock = System.Windows.Forms.DockStyle.Fill;
      this.outputText.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.outputText.Location = new System.Drawing.Point(10, 10);
      this.outputText.Margin = new System.Windows.Forms.Padding(0);
      this.outputText.Name = "outputText";
      this.outputText.ReadOnly = true;
      this.outputText.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
      this.outputText.Size = new System.Drawing.Size(772, 110);
      this.outputText.TabIndex = 13;
      this.outputText.Text = "";
      // 
      // uploadFileDialog
      // 
      this.uploadFileDialog.Filter = "Video files|*.mpg;*.mpeg;*.mov;*.avi;*.wmv;*.flv;*.rmvb;*.rv|All Files (*.*)|*.*";
      this.uploadFileDialog.ReadOnlyChecked = true;
      this.uploadFileDialog.Title = "Select a video file";
      // 
      // AppForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(792, 571);
      this.Controls.Add(this.horizontalSplitContainer);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "AppForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Viddler API 2.0 for Microsoft .NET - Demo";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AppForm_FormClosing);
      this.horizontalSplitContainer.Panel1.ResumeLayout(false);
      this.horizontalSplitContainer.Panel2.ResumeLayout(false);
      this.horizontalSplitContainer.ResumeLayout(false);
      this.verticalSplitContainer.Panel1.ResumeLayout(false);
      this.verticalSplitContainer.Panel2.ResumeLayout(false);
      this.verticalSplitContainer.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.SplitContainer horizontalSplitContainer;
    private System.Windows.Forms.RichTextBox outputText;
    private System.Windows.Forms.SplitContainer verticalSplitContainer;
    private System.Windows.Forms.ComboBox fileComboBox;
    private System.Windows.Forms.PropertyGrid filePropertyGrid;
    private System.Windows.Forms.Label filePropertyLabel;
    private System.Windows.Forms.Label filesLabel;
    private System.Windows.Forms.OpenFileDialog uploadFileDialog;
    private AuthPanel authPanel;
    private ActionPanel actionPanel;
  }
}

