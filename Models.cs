using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excel98.Models
{
#pragma warning disable CS8618
#pragma warning disable CS8601
#pragma warning disable CS8603
    namespace ConfigIndex
    {
        using System;
        using System.Collections.Generic;

        using System.Text.Json;
        using System.Text.Json.Serialization;
        using System.Globalization;

        public partial class Data
        {
            [JsonPropertyName("announcement")]
            public string Announcement { get; set; }

            [JsonPropertyName("todayTopicCount")]
            public long TodayTopicCount { get; set; }

            [JsonPropertyName("todayCount")]
            public long TodayCount { get; set; }

            [JsonPropertyName("topicCount")]
            public long TopicCount { get; set; }

            [JsonPropertyName("postCount")]
            public long PostCount { get; set; }

            [JsonPropertyName("userCount")]
            public long UserCount { get; set; }

            [JsonPropertyName("lastUserName")]
            public string LastUserName { get; set; }

            [JsonPropertyName("onlineUserCount")]
            public long OnlineUserCount { get; set; }

            [JsonPropertyName("recommendationReading")]
            public RecommendationFunction[] RecommendationReading { get; set; }

            [JsonPropertyName("hotTopic")]
            public HotTopic[] HotTopic { get; set; }

            [JsonPropertyName("manualHotTopic")]
            public HotTopic[] ManualHotTopic { get; set; }

            [JsonPropertyName("recommendationFunction")]
            public RecommendationFunction[] RecommendationFunction { get; set; }

            [JsonPropertyName("schoolNews")]
            public RecommendationFunction[] SchoolNews { get; set; }

            [JsonPropertyName("specialOffer")]
            public RecommendationFunction[] SpecialOffer { get; set; }

            [JsonPropertyName("schoolEvent")]
            public Academic[] SchoolEvent { get; set; }

            [JsonPropertyName("academics")]
            public Academic[] Academics { get; set; }

            [JsonPropertyName("study")]
            public Emotion[] Study { get; set; }

            [JsonPropertyName("emotion")]
            public Emotion[] Emotion { get; set; }

            [JsonPropertyName("fleaMarket")]
            public Emotion[] FleaMarket { get; set; }

            [JsonPropertyName("partTimeJob")]
            public Emotion[] PartTimeJob { get; set; }

            [JsonPropertyName("fullTimeJob")]
            public Emotion[] FullTimeJob { get; set; }

            [JsonPropertyName("lastUpdateTime")]
            public DateTimeOffset LastUpdateTime { get; set; }
        }

        public partial class Academic
        {
            [JsonPropertyName("id")]
            public long Id { get; set; }

            [JsonPropertyName("boardId")]
            public long BoardId { get; set; }

            [JsonPropertyName("title")]
            public string Title { get; set; }

            [JsonPropertyName("time")]
            public DateTimeOffset Time { get; set; }

            [JsonPropertyName("userId")]
            public long? UserId { get; set; }

            [JsonPropertyName("userName")]
            public string UserName { get; set; }

            [JsonPropertyName("userInfo")]
            public object UserInfo { get; set; }

            [JsonPropertyName("isAnonymous")]
            public bool IsAnonymous { get; set; }

            [JsonPropertyName("disableHot")]
            public bool DisableHot { get; set; }

            [JsonPropertyName("lastPostTime")]
            public DateTimeOffset LastPostTime { get; set; }

            [JsonPropertyName("state")]
            public long State { get; set; }

            [JsonPropertyName("type")]
            public long Type { get; set; }

            [JsonPropertyName("replyCount")]
            public long ReplyCount { get; set; }

            [JsonPropertyName("hitCount")]
            public long HitCount { get; set; }

            [JsonPropertyName("totalVoteUserCount")]
            public long TotalVoteUserCount { get; set; }

            [JsonPropertyName("lastPostUser")]
            public string LastPostUser { get; set; }

            [JsonPropertyName("lastPostContent")]
            public string LastPostContent { get; set; }

            [JsonPropertyName("topState")]
            public long TopState { get; set; }

            [JsonPropertyName("bestState")]
            public long BestState { get; set; }

            [JsonPropertyName("isVote")]
            public bool IsVote { get; set; }

            [JsonPropertyName("isPosterOnly")]
            public bool IsPosterOnly { get; set; }

            [JsonPropertyName("allowedViewerState")]
            public long AllowedViewerState { get; set; }

            [JsonPropertyName("dislikeCount")]
            public long DislikeCount { get; set; }

            [JsonPropertyName("likeCount")]
            public long LikeCount { get; set; }

            [JsonPropertyName("highlightInfo")]
            public object HighlightInfo { get; set; }

            [JsonPropertyName("tag1")]
            public long Tag1 { get; set; }

            [JsonPropertyName("tag2")]
            public long Tag2 { get; set; }

            [JsonPropertyName("isInternalOnly")]
            public bool IsInternalOnly { get; set; }

            [JsonPropertyName("notifyPoster")]
            public bool NotifyPoster { get; set; }

            [JsonPropertyName("isMe")]
            public bool IsMe { get; set; }

            [JsonPropertyName("todayCount")]
            public long TodayCount { get; set; }

            [JsonPropertyName("allowHotReply")]
            public bool AllowHotReply { get; set; }

            [JsonPropertyName("contentType")]
            public long ContentType { get; set; }

            [JsonPropertyName("favoriteCount")]
            public long FavoriteCount { get; set; }

            [JsonPropertyName("topicAuthorPermissions")]
            public object[] TopicAuthorPermissions { get; set; }

            [JsonPropertyName("mediaContent")]
            public object MediaContent { get; set; }

            [JsonPropertyName("specialStyle")]
            public long SpecialStyle { get; set; }

            [JsonPropertyName("notifyAllReplierCountByLZ")]
            public long NotifyAllReplierCountByLz { get; set; }

            [JsonPropertyName("lastNotifyAllReplierFloorByLZ")]
            public long LastNotifyAllReplierFloorByLz { get; set; }

            [JsonPropertyName("canNotifyAllReplier")]
            public bool CanNotifyAllReplier { get; set; }

            [JsonPropertyName("notifyAllReplierPostIds")]
            public object[] NotifyAllReplierPostIds { get; set; }

            [JsonPropertyName("isHotTopic")]
            public bool IsHotTopic { get; set; }

            [JsonPropertyName("lotteryTopicDetail")]
            public object LotteryTopicDetail { get; set; }
        }

        public partial class Emotion
        {
            [JsonPropertyName("id")]
            public long Id { get; set; }

            [JsonPropertyName("boardId")]
            public long BoardId { get; set; }

            [JsonPropertyName("title")]
            public string Title { get; set; }

            [JsonPropertyName("state")]
            public long State { get; set; }

            [JsonPropertyName("type")]
            public long Type { get; set; }

            [JsonPropertyName("isInternalOnly")]
            public bool IsInternalOnly { get; set; }

            [JsonPropertyName("isVote")]
            public bool IsVote { get; set; }

            [JsonPropertyName("contentType")]
            public long ContentType { get; set; }
        }

        public partial class HotTopic
        {
            [JsonPropertyName("id")]
            public long Id { get; set; }

            [JsonPropertyName("title")]
            public string Title { get; set; }

            [JsonPropertyName("boardId")]
            public long BoardId { get; set; }

            [JsonPropertyName("boardName")]
            public string BoardName { get; set; }

            [JsonPropertyName("participantCount")]
            public long ParticipantCount { get; set; }

            [JsonPropertyName("replyCount")]
            public long ReplyCount { get; set; }

            [JsonPropertyName("hitCount")]
            public long HitCount { get; set; }

            [JsonPropertyName("authorName")]
            public string AuthorName { get; set; }

            [JsonPropertyName("authorUserId")]
            public long? AuthorUserId { get; set; }

            [JsonPropertyName("createTime")]
            public DateTimeOffset CreateTime { get; set; }

            [JsonPropertyName("type")]
            public long Type { get; set; }

            [JsonPropertyName("isAnonymous")]
            public bool IsAnonymous { get; set; }

            [JsonPropertyName("hotTopicType")]
            public long HotTopicType { get; set; }
        }

        public partial class RecommendationFunction
        {
            [JsonPropertyName("id")]
            public long Id { get; set; }

            [JsonPropertyName("type")]
            public long Type { get; set; }

            [JsonPropertyName("title")]
            public string Title { get; set; }

            [JsonPropertyName("content")]
            public string Content { get; set; }

            [JsonPropertyName("url")]
            public string Url { get; set; }

            [JsonPropertyName("imageUrl")]
            public Uri ImageUrl { get; set; }

            [JsonPropertyName("enable")]
            public bool Enable { get; set; }

            [JsonPropertyName("time")]
            public DateTimeOffset Time { get; set; }

            [JsonPropertyName("orderWeight")]
            public long OrderWeight { get; set; }

            [JsonPropertyName("expiredTime")]
            public DateTimeOffset? ExpiredTime { get; set; }
        }
    }

    namespace NewTopics
    {
        using System;
        using System.Collections.Generic;

        using System.Text.Json;
        using System.Text.Json.Serialization;
        using System.Globalization;

        public partial class Data
        {
            [JsonPropertyName("id")]
            public long Id { get; set; }

            [JsonPropertyName("boardId")]
            public long BoardId { get; set; }

            [JsonPropertyName("title")]
            public string Title { get; set; }

            [JsonPropertyName("time")]
            public DateTimeOffset Time { get; set; }

            [JsonPropertyName("userId")]
            public long? UserId { get; set; }

            [JsonPropertyName("userName")]
            public string UserName { get; set; }

            [JsonPropertyName("userInfo")]
            public object UserInfo { get; set; }

            [JsonPropertyName("isAnonymous")]
            public bool IsAnonymous { get; set; }

            [JsonPropertyName("disableHot")]
            public bool DisableHot { get; set; }

            [JsonPropertyName("lastPostTime")]
            public DateTimeOffset LastPostTime { get; set; }

            [JsonPropertyName("state")]
            public long State { get; set; }

            [JsonPropertyName("type")]
            public long Type { get; set; }

            [JsonPropertyName("replyCount")]
            public long ReplyCount { get; set; }

            [JsonPropertyName("hitCount")]
            public long HitCount { get; set; }

            [JsonPropertyName("totalVoteUserCount")]
            public long TotalVoteUserCount { get; set; }

            [JsonPropertyName("lastPostUser")]
            public string LastPostUser { get; set; }

            [JsonPropertyName("lastPostContent")]
            public string LastPostContent { get; set; }

            [JsonPropertyName("topState")]
            public long TopState { get; set; }

            [JsonPropertyName("bestState")]
            public long BestState { get; set; }

            [JsonPropertyName("isVote")]
            public bool IsVote { get; set; }

            [JsonPropertyName("isPosterOnly")]
            public bool IsPosterOnly { get; set; }

            [JsonPropertyName("allowedViewerState")]
            public long AllowedViewerState { get; set; }

            [JsonPropertyName("dislikeCount")]
            public long DislikeCount { get; set; }

            [JsonPropertyName("likeCount")]
            public long LikeCount { get; set; }

            [JsonPropertyName("highlightInfo")]
            public object HighlightInfo { get; set; }

            [JsonPropertyName("tag1")]
            public long Tag1 { get; set; }

            [JsonPropertyName("tag2")]
            public long Tag2 { get; set; }

            [JsonPropertyName("isInternalOnly")]
            public bool IsInternalOnly { get; set; }

            [JsonPropertyName("notifyPoster")]
            public bool NotifyPoster { get; set; }

            [JsonPropertyName("isMe")]
            public bool IsMe { get; set; }

            [JsonPropertyName("todayCount")]
            public long TodayCount { get; set; }

            [JsonPropertyName("allowHotReply")]
            public bool AllowHotReply { get; set; }

            [JsonPropertyName("contentType")]
            public long ContentType { get; set; }

            [JsonPropertyName("favoriteCount")]
            public long FavoriteCount { get; set; }

            [JsonPropertyName("topicAuthorPermissions")]
            public object[] TopicAuthorPermissions { get; set; }

            [JsonPropertyName("mediaContent")]
            public MediaContent MediaContent { get; set; }

            [JsonPropertyName("specialStyle")]
            public long SpecialStyle { get; set; }

            [JsonPropertyName("notifyAllReplierCountByLZ")]
            public long NotifyAllReplierCountByLz { get; set; }

            [JsonPropertyName("lastNotifyAllReplierFloorByLZ")]
            public long LastNotifyAllReplierFloorByLz { get; set; }

            [JsonPropertyName("canNotifyAllReplier")]
            public bool CanNotifyAllReplier { get; set; }

            [JsonPropertyName("notifyAllReplierPostIds")]
            public object[] NotifyAllReplierPostIds { get; set; }

            [JsonPropertyName("isHotTopic")]
            public bool IsHotTopic { get; set; }

            [JsonPropertyName("lotteryTopicDetail")]
            public object LotteryTopicDetail { get; set; }
        }

        public partial class MediaContent
        {
            [JsonPropertyName("thumbnail")]
            public Uri[] Thumbnail { get; set; }

            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            [JsonPropertyName("video")]
            public Uri Video { get; set; }

            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            [JsonPropertyName("duration")]
            public long? Duration { get; set; }

            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            [JsonPropertyName("width")]
            public long? Width { get; set; }

            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            [JsonPropertyName("height")]
            public long? Height { get; set; }
        }
    }

    namespace Boards
    {
        using System;
        using System.Collections.Generic;

        using System.Text.Json;
        using System.Text.Json.Serialization;
        using System.Globalization;

        public partial class Data
        {
            [JsonPropertyName("id")]
            public long Id { get; set; }

            [JsonPropertyName("name")]
            public string Name { get; set; }

            [JsonPropertyName("order")]
            public long Order { get; set; }

            [JsonPropertyName("masters")]
            public string[] Masters { get; set; }

            [JsonPropertyName("boards")]
            public Board[] Boards { get; set; }
        }

        public partial class Board
        {
            [JsonPropertyName("id")]
            public long Id { get; set; }

            [JsonPropertyName("name")]
            public string Name { get; set; }

            [JsonPropertyName("boardMasters")]
            public string[] BoardMasters { get; set; }

            [JsonPropertyName("topicCount")]
            public long TopicCount { get; set; }

            [JsonPropertyName("postCount")]
            public long PostCount { get; set; }

            [JsonPropertyName("todayCount")]
            public long TodayCount { get; set; }

            [JsonPropertyName("description")]
            public string Description { get; set; }

            [JsonPropertyName("anonymousState")]
            public long AnonymousState { get; set; }

            [JsonPropertyName("showShareTip")]
            public bool ShowShareTip { get; set; }

            [JsonPropertyName("canVote")]
            public bool CanVote { get; set; }
        }
    }

    namespace PostData
    {
        using System;
        using System.Collections.Generic;

        using System.Text.Json;
        using System.Text.Json.Serialization;
        using System.Globalization;

        public partial class Data
        {
            [JsonPropertyName("id")]
            public long Id { get; set; }

            [JsonPropertyName("boardId")]
            public long BoardId { get; set; }

            [JsonPropertyName("title")]
            public string Title { get; set; }

            [JsonPropertyName("time")]
            public DateTimeOffset Time { get; set; }

            [JsonPropertyName("userId")]
            public long? UserId { get; set; }

            [JsonPropertyName("userName")]
            public string UserName { get; set; }

            [JsonPropertyName("userInfo")]
            public object UserInfo { get; set; }

            [JsonPropertyName("isAnonymous")]
            public bool IsAnonymous { get; set; }

            [JsonPropertyName("disableHot")]
            public bool DisableHot { get; set; }

            [JsonPropertyName("lastPostTime")]
            public DateTimeOffset LastPostTime { get; set; }

            [JsonPropertyName("state")]
            public long State { get; set; }

            [JsonPropertyName("type")]
            public long Type { get; set; }

            [JsonPropertyName("replyCount")]
            public long ReplyCount { get; set; }

            [JsonPropertyName("hitCount")]
            public long HitCount { get; set; }

            [JsonPropertyName("totalVoteUserCount")]
            public long TotalVoteUserCount { get; set; }

            [JsonPropertyName("lastPostUser")]
            public string LastPostUser { get; set; }

            [JsonPropertyName("lastPostContent")]
            public string LastPostContent { get; set; }

            [JsonPropertyName("topState")]
            public long TopState { get; set; }

            [JsonPropertyName("bestState")]
            public long BestState { get; set; }

            [JsonPropertyName("isVote")]
            public bool IsVote { get; set; }

            [JsonPropertyName("isPosterOnly")]
            public bool IsPosterOnly { get; set; }

            [JsonPropertyName("allowedViewerState")]
            public long AllowedViewerState { get; set; }

            [JsonPropertyName("dislikeCount")]
            public long DislikeCount { get; set; }

            [JsonPropertyName("likeCount")]
            public long LikeCount { get; set; }

            [JsonPropertyName("highlightInfo")]
            public object HighlightInfo { get; set; }

            [JsonPropertyName("tag1")]
            public long Tag1 { get; set; }

            [JsonPropertyName("tag2")]
            public long Tag2 { get; set; }

            [JsonPropertyName("isInternalOnly")]
            public bool IsInternalOnly { get; set; }

            [JsonPropertyName("notifyPoster")]
            public bool NotifyPoster { get; set; }

            [JsonPropertyName("isMe")]
            public bool IsMe { get; set; }

            [JsonPropertyName("todayCount")]
            public long TodayCount { get; set; }

            [JsonPropertyName("allowHotReply")]
            public bool AllowHotReply { get; set; }

            [JsonPropertyName("contentType")]
            public long ContentType { get; set; }

            [JsonPropertyName("favoriteCount")]
            public long FavoriteCount { get; set; }

            [JsonPropertyName("topicAuthorPermissions")]
            public object[] TopicAuthorPermissions { get; set; }

            [JsonPropertyName("mediaContent")]
            public MediaContent MediaContent { get; set; }

            [JsonPropertyName("specialStyle")]
            public long SpecialStyle { get; set; }

            [JsonPropertyName("notifyAllReplierCountByLZ")]
            public long NotifyAllReplierCountByLz { get; set; }

            [JsonPropertyName("lastNotifyAllReplierFloorByLZ")]
            public long LastNotifyAllReplierFloorByLz { get; set; }

            [JsonPropertyName("canNotifyAllReplier")]
            public bool CanNotifyAllReplier { get; set; }

            [JsonPropertyName("notifyAllReplierPostIds")]
            public object[] NotifyAllReplierPostIds { get; set; }

            [JsonPropertyName("isHotTopic")]
            public bool IsHotTopic { get; set; }

            [JsonPropertyName("lotteryTopicDetail")]
            public object LotteryTopicDetail { get; set; }
        }

        public partial class MediaContent
        {
            [JsonPropertyName("thumbnail")]
            public Uri[] Thumbnail { get; set; }
        }
    }

    namespace TopicPost
    {
        using System;
        using System.Collections.Generic;

        using System.Text.Json;
        using System.Text.Json.Serialization;
        using System.Globalization;

        public partial class Data
        {
            [JsonPropertyName("id")]
            public long Id { get; set; }

            [JsonPropertyName("parentId")]
            public long ParentId { get; set; }

            [JsonPropertyName("boardId")]
            public long BoardId { get; set; }

            [JsonPropertyName("userName")]
            public string UserName { get; set; }

            [JsonPropertyName("userId")]
            public long? UserId { get; set; }

            [JsonPropertyName("title")]
            public string Title { get; set; }

            [JsonPropertyName("content")]
            public string Content { get; set; }

            [JsonPropertyName("time")]
            public DateTimeOffset Time { get; set; }

            [JsonPropertyName("topicId")]
            public long TopicId { get; set; }

            [JsonPropertyName("ip")]
            public string Ip { get; set; }

            [JsonPropertyName("state")]
            public long State { get; set; }

            [JsonPropertyName("isAnonymous")]
            public bool IsAnonymous { get; set; }

            [JsonPropertyName("floor")]
            public long Floor { get; set; }

            [JsonPropertyName("count")]
            public long Count { get; set; }

            [JsonPropertyName("allowedViewers")]
            public object AllowedViewers { get; set; }

            [JsonPropertyName("isAllowedOnly")]
            public bool IsAllowedOnly { get; set; }

            [JsonPropertyName("contentType")]
            public long ContentType { get; set; }

            [JsonPropertyName("lastUpdateTime")]
            public object LastUpdateTime { get; set; }

            [JsonPropertyName("lastUpdateAuthor")]
            public object LastUpdateAuthor { get; set; }

            [JsonPropertyName("isDeleted")]
            public bool IsDeleted { get; set; }

            [JsonPropertyName("likeCount")]
            public long LikeCount { get; set; }

            [JsonPropertyName("dislikeCount")]
            public long DislikeCount { get; set; }

            [JsonPropertyName("isLZ")]
            public bool IsLz { get; set; }

            [JsonPropertyName("likeState")]
            public long LikeState { get; set; }

            [JsonPropertyName("awards")]
            public object[] Awards { get; set; }

            [JsonPropertyName("isMe")]
            public bool IsMe { get; set; }
        }
    }

    namespace BoardPost
    {
        using System;
        using System.Collections.Generic;

        using System.Text.Json;
        using System.Text.Json.Serialization;
        using System.Globalization;

        public partial class Data
        {
            [JsonPropertyName("id")]
            public long Id { get; set; }

            [JsonPropertyName("boardId")]
            public long BoardId { get; set; }

            [JsonPropertyName("title")]
            public string Title { get; set; }

            [JsonPropertyName("time")]
            public DateTimeOffset Time { get; set; }

            [JsonPropertyName("userId")]
            public long? UserId { get; set; }

            [JsonPropertyName("userName")]
            public string UserName { get; set; }

            [JsonPropertyName("userInfo")]
            public object UserInfo { get; set; }

            [JsonPropertyName("isAnonymous")]
            public bool IsAnonymous { get; set; }

            [JsonPropertyName("disableHot")]
            public bool DisableHot { get; set; }

            [JsonPropertyName("lastPostTime")]
            public DateTimeOffset LastPostTime { get; set; }

            [JsonPropertyName("state")]
            public long State { get; set; }

            [JsonPropertyName("type")]
            public long Type { get; set; }

            [JsonPropertyName("replyCount")]
            public long ReplyCount { get; set; }

            [JsonPropertyName("hitCount")]
            public long HitCount { get; set; }

            [JsonPropertyName("totalVoteUserCount")]
            public long TotalVoteUserCount { get; set; }

            [JsonPropertyName("lastPostUser")]
            public string LastPostUser { get; set; }

            [JsonPropertyName("lastPostContent")]
            public string LastPostContent { get; set; }

            [JsonPropertyName("topState")]
            public long TopState { get; set; }

            [JsonPropertyName("bestState")]
            public long BestState { get; set; }

            [JsonPropertyName("isVote")]
            public bool IsVote { get; set; }

            [JsonPropertyName("isPosterOnly")]
            public bool IsPosterOnly { get; set; }

            [JsonPropertyName("allowedViewerState")]
            public long AllowedViewerState { get; set; }

            [JsonPropertyName("dislikeCount")]
            public long DislikeCount { get; set; }

            [JsonPropertyName("likeCount")]
            public long LikeCount { get; set; }

            [JsonPropertyName("highlightInfo")]
            public object HighlightInfo { get; set; }

            [JsonPropertyName("tag1")]
            public long Tag1 { get; set; }

            [JsonPropertyName("tag2")]
            public long Tag2 { get; set; }

            [JsonPropertyName("isInternalOnly")]
            public bool IsInternalOnly { get; set; }

            [JsonPropertyName("notifyPoster")]
            public bool NotifyPoster { get; set; }

            [JsonPropertyName("isMe")]
            public bool IsMe { get; set; }

            [JsonPropertyName("todayCount")]
            public long TodayCount { get; set; }

            [JsonPropertyName("allowHotReply")]
            public bool AllowHotReply { get; set; }

            [JsonPropertyName("contentType")]
            public long ContentType { get; set; }

            [JsonPropertyName("favoriteCount")]
            public long FavoriteCount { get; set; }

            [JsonPropertyName("topicAuthorPermissions")]
            public object[] TopicAuthorPermissions { get; set; }

            [JsonPropertyName("mediaContent")]
            public MediaContent MediaContent { get; set; }

            [JsonPropertyName("specialStyle")]
            public long SpecialStyle { get; set; }

            [JsonPropertyName("notifyAllReplierCountByLZ")]
            public long NotifyAllReplierCountByLz { get; set; }

            [JsonPropertyName("lastNotifyAllReplierFloorByLZ")]
            public long LastNotifyAllReplierFloorByLz { get; set; }

            [JsonPropertyName("canNotifyAllReplier")]
            public bool CanNotifyAllReplier { get; set; }

            [JsonPropertyName("notifyAllReplierPostIds")]
            public object[] NotifyAllReplierPostIds { get; set; }

            [JsonPropertyName("isHotTopic")]
            public bool IsHotTopic { get; set; }

            [JsonPropertyName("lotteryTopicDetail")]
            public object LotteryTopicDetail { get; set; }
        }

        public partial class MediaContent
        {
            [JsonPropertyName("thumbnail")]
            public Uri[] Thumbnail { get; set; }
        }
    }


#pragma warning restore CS8618
#pragma warning restore CS8601
#pragma warning restore CS8603
}
