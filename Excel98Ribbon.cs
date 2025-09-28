using Microsoft.Office.Tools.Ribbon;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excel98
{
    public partial class Excel98Ribbon
    {
        private void Excel98Ribbon_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void btnCreateHomepage_Click(object sender, RibbonControlEventArgs e)
        {
            Globals.ThisAddIn.CreateHomePage();
        }

        private void btnSetUser_Click(object sender, RibbonControlEventArgs e)
        {
            var token = Interaction.InputBox("暂时只支持以Bearer开头的token登录", "Excel98");
            Globals.ThisAddIn.ActiveUserCreds = token;
        }

        private void btnCreateNewTopics_Click(object sender, RibbonControlEventArgs e)
        {
            Globals.ThisAddIn.CreateNewTopicsPage();
        }

        private void btnCreateForumList_Click(object sender, RibbonControlEventArgs e)
        {
            Globals.ThisAddIn.CreateBoardListPage();
        }
    }
}
