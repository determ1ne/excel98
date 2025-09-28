using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace Excel98
{
    internal class Views
    {
        private Excel.Application Application;
        public Client client = new Client();

        public Views(Excel.Application app)
        {
            Application = app;
        }

        private Excel.Worksheet CreateEmptySheet(string name)
        {
            var wb = Application.ActiveWorkbook;
            var sh = (Excel.Worksheet)wb.Sheets.Add();

            for (int i = 0; i < 10; ++i)
            {
                try
                {
                    if (i == 0)
                    {
                        sh.Name = name;
                    }
                    else
                    {
                        sh.Name = name + $"({i})";
                    }
                    return sh;
                }
                catch (Exception)
                {
                    // just continue
                }
            }

            for (int i = 0; i < 100; ++i)
            {
                try
                {
                    sh.Name = "Excel98Page" + $"({i})";
                }
                catch (Exception)
                {
                    // just continue
                }
                return sh;
            }

            throw new Exception("cannot create new sheet");
        }

        private Excel.Worksheet GetActiveOrCreateSheet(string name)
        {
            try
            {
                return Application.ActiveSheet;
            }
            catch (Exception)
            {
                return CreateEmptySheet(name);
            }
        }

        public async void CreateHomePage()
        {
            var data = await client.GetConfigIndex();

            var sh = CreateEmptySheet("98主页");
            sh.SetSheet("A1", "CC98论坛");
            sh.SetLink("C1", "版面列表", "?cc98=forumList");
            sh.SetLink("D1", "新帖", "?cc98=newTopics");
            sh.SetLink("G1", "关闭", "?cc98=close");

            sh.SetSheet("B3", "热门话题");
            sh.SetBold("B3");

            for (int i = 0; i < data.HotTopic.Length; ++i)
            {
                var topic = data.HotTopic[i];
                sh.SetLink($"B{i + 4}", topic.Title, $"?cc98=topic&topicId={topic.Id}&page=0&sze=10");
            }
        }

        public async void CreateBoardListPage()
        {
            var data = await client.GetBoards();

            var sh = CreateEmptySheet("版面列表");
            sh.SetSheet("A1", "CC98论坛");
            sh.SetLink("C1", "版面列表", "?cc98=forumList");
            sh.SetLink("D1", "新帖", "?cc98=newTopics");
            sh.SetLink("G1", "关闭", "?cc98=close");

            var sheetNo = 2;
            foreach (var d in data)
            {
                ++sheetNo;
                sh.SetSheet($"B{sheetNo + 1}", d.Name);
                sh.SetBold($"B{sheetNo + 1}");
                ++sheetNo;
                for (int i = 0; i < d.Boards.Length; ++i)
                {
                    var board = d.Boards[i];
                    var offset = i % 6;
                    if (offset == 0) ++sheetNo;
                    var col = (char)('B' + offset);

                    sh.SetLink($"{col}{sheetNo}", board.Name, $"?cc98=board&boardId={board.Id}&page=0&size=10");
                }
            }

            var colEnd = (char)('B' + 6);
            sh.Columns[$"B:{colEnd}"].AutoFit();
        }

        public void CreateNewTopicsPage()
        {
            FillNewTopicsPage(true);
        }

        public async void FillNewTopicsPage(bool newPage = false, int page = 0, int size = 10)
        {
            page = Math.Max(page, 0);
            size = InMinMax(size, 1, 50);
            var data = await client.GetNewTopics(page * size, size);
            if (data == null) return;

            Excel.Worksheet sh;
            if (newPage)
            {
                sh = CreateEmptySheet("最新主题");
            } else
            {
                sh = GetActiveOrCreateSheet("最新主题");
                sh.Cells.Clear();
            }

            sh.SetSheet("A1", "CC98论坛");
            sh.SetLink("C1", "版面列表", "?cc98=forumList");
            sh.SetLink("D1", "新帖", "?cc98=newTopics");
            sh.SetLink("G1", "关闭", "?cc98=close");

            var previousPage = Math.Max(page - 1, 0);
            sh.SetSheet("B3", $"第{page+1}页");
            sh.SetLink("C3", "上一页", $"?cc98=newTopics&newPage=false&page={previousPage}&size={size}");
            sh.SetLink("D3", "下一页", $"?cc98=newTopics&newPage=false&page={page+1}&size={size}");

            int sheetNo = 4;
            for (int i = 0; i < data.Length; ++i)
            {
                ++sheetNo;
                sh.SetLink($"B{sheetNo}", data[i].Title, $"?cc98=topic&topicId={data[i].Id}&page={page}&sze={size}");
                sh.SetBold($"B{sheetNo}");
                sh.SetSheet($"B{++sheetNo}", data[i].UserName);
                sh.SetSheet($"B{++sheetNo}", $"发帖时间：{data[i].Time.ToShortTimeString()}");
                sh.SetSheet($"B{++sheetNo}", $"最后回复：{data[i].LastPostUser}");
                ++sheetNo;
            }

            sh.SetLink($"C{++sheetNo}", "上一页", $"?cc98=newTopics&newPage=false&page={previousPage}&size={size}");
            sh.SetLink($"D{sheetNo}", "下一页", $"?cc98=newTopics&newPage=false&page={page+1}&size={size}");
        }

        public async void FillBoardTopicsPage(int boardId, bool newPage = false, int page = 0, int size = 10)
        {
            page = Math.Max(page, 0);
            size = InMinMax(size, 1, 50);
            var data = await client.GetBoardTopics(boardId, page * size, size);
            if (data == null) return;

            Excel.Worksheet sh;
            if (newPage)
            {
                sh = CreateEmptySheet("最新主题");
            } else
            {
                sh = GetActiveOrCreateSheet("最新主题");
                sh.Cells.Clear();
            }

            sh.SetSheet("A1", "CC98论坛");
            sh.SetLink("C1", "版面列表", "?cc98=forumList");
            sh.SetLink("D1", "新帖", "?cc98=newTopics");
            sh.SetLink("G1", "关闭", "?cc98=close");

            var previousPage = Math.Max(page - 1, 0);
            sh.SetSheet("B3", client.GetBoardName(boardId));
            sh.SetBold("B3");
            sh.SetSheet("B4", $"第{page+1}页");
            sh.SetLink("C4", "上一页", $"?cc98=board&boardId={boardId}&newPage=false&page={previousPage}&size={size}");
            sh.SetLink("D4", "下一页", $"?cc98=board&boardId={boardId}&newPage=false&page={page+1}&size={size}");

            int sheetNo = 5;
            for (int i = 0; i < data.Length; ++i)
            {
                ++sheetNo;
                sh.SetLink($"B{sheetNo}", data[i].Title, $"?cc98=topic&topicId={data[i].Id}&page={page}&sze={size}");
                sh.SetBold($"B{sheetNo}");
                sh.SetSheet($"B{++sheetNo}", data[i].UserName);
                sh.SetSheet($"B{++sheetNo}", $"发帖时间：{data[i].Time.ToShortTimeString()}");
                sh.SetSheet($"B{++sheetNo}", $"最后回复：{data[i].LastPostUser}");
                ++sheetNo;
            }

            sh.SetLink($"C{++sheetNo}", "上一页", $"?cc98=board&boardId={boardId}&newPage=false&page={previousPage}&size={size}");
            sh.SetLink($"D{sheetNo}", "下一页", $"?cc98=board&boardId={boardId}&newPage=false&page={page+1}&size={size}");
        }

        public async void FillTopicPostPage(int topicId, bool newPage = false, int page = 0, int size = 10)
        {
            page = Math.Max(page, 0);
            size = InMinMax(size, 1, 50);
            var postData = await client.GetPostData(topicId);
            var topicPosts = await client.GetTopicPosts(topicId, page * size, size);
            if (postData == null || topicPosts == null) return;

            var title = postData.Title;
            if (title.Length > 12)
            {
                title = title.Substring(0, 12) + "…";
            }
            Excel.Worksheet sh;
            if (newPage)
            {
                sh = CreateEmptySheet(title);
            } else
            {
                sh = GetActiveOrCreateSheet(title);
                sh.Cells.Clear();
            }

            sh.SetSheet("A1", "CC98论坛");
            sh.SetLink("C1", "版面列表", "?cc98=forumList");
            sh.SetLink("D1", "新帖", "?cc98=newTopics");
            sh.SetLink("G1", "关闭", "?cc98=close");

            var previousPage = Math.Max(page - 1, 0);
            sh.SetSheet("B3", $"第{page+1}页");
            sh.SetLink("C3", "上一页", $"?cc98=topic&newPage=false&topicId={topicId}&page={previousPage}&size={size}");
            sh.SetLink("D3", "下一页", $"?cc98=topic&newPage=false&topicId={topicId}&page={page+1}&size={size}");

            sh.Columns["C:C"].ColumnWidth = 80.0;

            int sheetNo = 4;
            for (int i = 0; i < topicPosts.Length; ++i)
            {
                var post = topicPosts[i];

                sh.SetSheet($"B{sheetNo}", post.UserName);
                sh.SetSheet($"B{sheetNo + 1}", $"{post.Floor}楼");
                sh.SetSheet($"C{sheetNo}", post.Content);
                sh.Range[$"C{sheetNo}"].WrapText = true;
                sh.Rows[$"{sheetNo}"].AutoFit();
                sheetNo += 2;
            }

            sh.SetLink($"C{++sheetNo}", "上一页", $"?cc98=topic&newPage=false&topicId={topicId}&page={previousPage}&size={size}");
            sh.SetLink($"D{sheetNo}", "下一页", $"?cc98=topic&newPage=false&topicId={topicId}&page={page+1}&size={size}");
        }

        private int InMinMax(int v, int min, int max)
        {
            if (v < min) return min;
            if (v > max) return max;
            return v;
        }
    }

    public static class WorkSheetExtensions
    {
        public static void SetSheet(this Excel.Worksheet sheet, string cellId, string content)
        {
            sheet.Range[cellId].FormulaR1C1 = content;
        }

        public static void SetLink(this Excel.Worksheet sheet, string cellId, string content, string url)
        {
            sheet.Hyperlinks.Add(
                sheet.Range[cellId],
                url,
                TextToDisplay: content);
        }

        public static void SetBold(this Excel.Worksheet sheet, string range)
        {
            sheet.Range[range].Font.Bold = true;
        }
    }

    public static class MiscExtensions
    {
        public static string ToShortTimeString(this DateTimeOffset date)
        {
            return date.ToString("t");
        }
    }
}
