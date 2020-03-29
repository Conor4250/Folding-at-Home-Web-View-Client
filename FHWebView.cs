using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;

namespace FHWebViewer
{
    public partial class FHWebView : Form
    {
        private ChromiumWebBrowser webView;

        public FHWebView()
        {
            InitializeComponent();
            InitializeChromium();
        }

        private void FHWebView_Load(object sender, EventArgs e)
        {

        }

        private void InitializeChromium()
        {
            CefSettings settings = new CefSettings();

            // Initizlie cef with provided settins. 
            Cef.Initialize(settings);
           
            webView = new ChromiumWebBrowser("https://client.foldingathome.org/");
            this.Controls.Add(webView);
            webView.Dock = DockStyle.Fill;
        }
    }
}
