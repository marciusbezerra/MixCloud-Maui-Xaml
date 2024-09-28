
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;

namespace MixCloud_App.Models
{

    public partial class MixCloudResult
    {
        [JsonPropertyName("data")]
        public ObservableCollection<Datum> Data { get; set; }

        [JsonPropertyName("paging")]
        public Paging Paging { get; set; }
    }

    public partial class Datum
    {
        [JsonPropertyName("key")]
        public string Key { get; set; }

        [JsonPropertyName("url")]
        public Uri Url { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("created_time")]
        public DateTimeOffset CreatedTime { get; set; }

        [JsonPropertyName("updated_time")]
        public DateTimeOffset UpdatedTime { get; set; }

        [JsonPropertyName("play_count")]
        public long PlayCount { get; set; }

        [JsonPropertyName("favorite_count")]
        public long FavoriteCount { get; set; }

        [JsonPropertyName("comment_count")]
        public long CommentCount { get; set; }

        [JsonPropertyName("listener_count")]
        public long ListenerCount { get; set; }

        [JsonPropertyName("repost_count")]
        public long RepostCount { get; set; }

        [JsonPropertyName("pictures")]
        public Pictures Pictures { get; set; }

        [JsonPropertyName("slug")]
        public string Slug { get; set; }

        [JsonPropertyName("user")]
        public User User { get; set; }

        [JsonPropertyName("audio_length")]
        public long AudioLength { get; set; }
    }

    public partial class Pictures
    {

        [JsonPropertyName("large")]
        public Uri Large { get; set; }

    }

    public partial class Tag
    {
        [JsonPropertyName("key")]
        public string Key { get; set; }

        [JsonPropertyName("url")]
        public Uri Url { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }

    public partial class User
    {
        [JsonPropertyName("key")]
        public string Key { get; set; }

        [JsonPropertyName("url")]
        public Uri Url { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("username")]
        public string Username { get; set; }

        [JsonPropertyName("pictures")]
        public Pictures Pictures { get; set; }
    }

    public partial class Paging
    {
        [JsonPropertyName("next")]
        public Uri Next { get; set; }
    }
}
