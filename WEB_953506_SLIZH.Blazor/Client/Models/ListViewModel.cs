using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace WEB_953506_SLIZH.Blazor.Client.Models
{
    public class ListViewModel
    {
        [JsonPropertyName("playerId")]
        public int PlayerId { get; set; }
        [JsonPropertyName("nickname")]
        public string NickName { get; set; }
    }

    public class DetailViewModel
    {
        [JsonPropertyName("nickname")]
        public string NickName { get; set; }
        [JsonPropertyName("team")]
        public string Team { get; set; }
        [JsonPropertyName("cost")]
        public int Cost { get; set; }
        [JsonPropertyName("photo")]
        public string Photo { get; set; }
    }
}
