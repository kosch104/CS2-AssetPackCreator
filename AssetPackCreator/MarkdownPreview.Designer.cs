﻿namespace AssetPackCreator
{
    partial class MarkdownPreview
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
            components = new System.ComponentModel.Container();
            webView = new Microsoft.Web.WebView2.WinForms.WebView2();
            markdownTimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)webView).BeginInit();
            SuspendLayout();
            // 
            // webView
            // 
            webView.AllowExternalDrop = true;
            webView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            webView.CreationProperties = null;
            webView.DefaultBackgroundColor = Color.White;
            webView.Location = new Point(12, 12);
            webView.Name = "webView";
            webView.Size = new Size(776, 526);
            webView.TabIndex = 0;
            webView.ZoomFactor = 1D;
            // 
            // markdownTimer
            // 
            markdownTimer.Interval = 1000;
            markdownTimer.Tick += markdownTimer_Tick;
            // 
            // MarkdownPreview
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 550);
            Controls.Add(webView);
            Name = "MarkdownPreview";
            Text = "Markdown Preview";
            Load += MarkdownPreview_Load;
            ((System.ComponentModel.ISupportInitialize)webView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 webView;
        private System.Windows.Forms.Timer markdownTimer;
    }
}