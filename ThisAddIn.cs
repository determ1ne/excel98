using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Excel = Microsoft.Office.Interop.Excel;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Tools.Excel;
using System.Windows.Forms;
using System.Web;

namespace Excel98
{
    public partial class ThisAddIn
    {
        public string ActiveUserCreds
        {
            get => _activeUserCreds;
            set
            {
                _activeUserCreds = value;
                OnActiveUserChanged(this, _activeUserCreds);
                SaveConfig();
            }
        }

        public event EventHandler<string> OnActiveUserChanged;
        private string _activeUserCreds = "";
        private List<string> activeWorkbooks = new List<string>();
        private Views views;
        private bool hyperlinkCallbackRegistered = false;

        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            views = new Views(this.Application);
            LoadConfig();
        }

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
        }

        public void RegisterHyperlinkCallback()
        {
            if (hyperlinkCallbackRegistered) return;
            try
            {
                Application.SheetFollowHyperlink += SheetFollowHyperlink;
                hyperlinkCallbackRegistered = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SheetFollowHyperlink(object Sh, Excel.Hyperlink Target)
        {
            var address = Target.Address;
            if (!address.StartsWith("?cc98=")) return;

            var query = HttpUtility.ParseQueryString(address);

            var action = query["cc98"];
            var newPage = query["newPage"] != "false";
            var topicId = IntParse(query["topicId"]);
            var boardId = IntParse(query["boardId"]);
            var page = IntParse(query["page"]);
            var size = IntParse(query["size"], 10);
            switch (action)
            {
                case "close":
                    var x = Application.DisplayAlerts;
                    Application.DisplayAlerts = false;
                    ((Excel.Worksheet)Sh).Delete();
                    Application.DisplayAlerts = x;
                    break;
                case "newTopics":
                    views.FillNewTopicsPage(newPage, page, size);
                    break;
                case "forumList":
                    views.CreateBoardListPage();
                    break;
                case "topic":
                    views.FillTopicPostPage(topicId, newPage, page, size);
                    break;
                case "board":
                    views.FillBoardTopicsPage(boardId, newPage, page, size);
                    break;
            }
        }

        private int IntParse(string s, int defaultValue = 0)
        {
            if (int.TryParse(s, out var result))
            {
                return result;
            }

            return defaultValue;
        }

        public void CreateHomePage()
        {
            try
            {
                RegisterHyperlinkCallback();
                views.CreateHomePage();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void CreateNewTopicsPage()
        {
            try
            {
                RegisterHyperlinkCallback();
                views.CreateNewTopicsPage();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void CreateBoardListPage()
        {
            try
            {
                RegisterHyperlinkCallback();
                views.CreateBoardListPage();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SaveConfig()
        {
            // only save ActiveUserCreds for now
            var path = GetConfigPath();
            File.WriteAllText(path, ActiveUserCreds);
        }

        private void LoadConfig()
        {
            try
            {
                ActiveUserCreds = File.ReadAllText(GetConfigPath());
            }
            catch (Exception)
            {
                // just ignore
            }
        }

        private string GetConfigPath()
        {
            var folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                "Excel98");
            Directory.CreateDirectory(folderPath);
            return Path.Combine(folderPath, "creds.txt");
        }

        #region VSTO generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }

        #endregion
    }
}
