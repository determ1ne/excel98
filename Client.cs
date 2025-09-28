using RestSharp;
using RestSharp.Authenticators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel98.Models;

namespace Excel98
{
    internal class Client
    {
        private Models.Boards.Data[] boardData;
        private RestClient c;
        private Dictionary<long, string> boardIdToName = new Dictionary<long, string>();

        public Client()
        {
            var opts = new RestClientOptions("https://api.cc98.org");
            c = new RestClient(opts);
            c.AddDefaultHeader("User-Agent", "Excel98/0.1");
            Globals.ThisAddIn.OnActiveUserChanged += ActiveUserChanged;
        }

        ~Client()
        {
            Globals.ThisAddIn.OnActiveUserChanged -= ActiveUserChanged;
        }

        private void ActiveUserChanged(object sender, string e)
        {
            c.AddDefaultHeader("Authorization", e);
        }

        public async Task<Models.ConfigIndex.Data> GetConfigIndex()
        {
            var request = new RestRequest("config/index");
            return await GetAsync<Models.ConfigIndex.Data>(request);
        }

        public async Task<Models.NewTopics.Data[]> GetNewTopics(int from = 0, int size = 20)
        {
            var request = new RestRequest($"topic/new?from={from}&size={size}");
            return await GetAsync<Models.NewTopics.Data[]>(request);
        }

        public async Task<Models.BoardPost.Data[]> GetBoardTopics(int boardId, int from = 0, int size = 20)
        {
            var request = new RestRequest($"board/{boardId}/topic?from={from}&size={size}");
            return await GetAsync<Models.BoardPost.Data[]>(request);
        }

        public async Task<Models.Boards.Data[]> GetBoards()
        {
            if (boardData != null) return boardData;
            var request = new RestRequest("/Board/all");
            boardData = await GetAsync<Models.Boards.Data[]>(request);
            foreach (var d in boardData)
            {
                foreach (var b in d.Boards)
                {
                    boardIdToName[b.Id] = b.Name;
                }
            }
            return boardData;
        }

        public string GetBoardName(int id)
        {
            if (boardIdToName.TryGetValue(id, out var name)) return name;
            return string.Empty;
        }

        public async Task<Models.PostData.Data> GetPostData(int postId)
        {
            return await GetAsync<Models.PostData.Data>(new RestRequest($"/topic/{postId}"));
        }

        public async Task<Models.TopicPost.Data[]> GetTopicPosts(int topicId, int from = 0, int size = 10)
        {
            return await GetAsync<Models.TopicPost.Data[]>(
                new RestRequest($"/Topic/{topicId}/post?from={from}&size={size}"));
        }

        public async Task<T> GetAsync<T>(RestRequest request, CancellationToken token = default(CancellationToken))
        {
            try
            {
                return await c.GetAsync<T>(request, token);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Excel98");
                return default(T);
            }
        }
    }
}
