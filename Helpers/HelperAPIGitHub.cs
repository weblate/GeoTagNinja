﻿// <auto-generated />
//
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using geoTagNinja;
//
//    var gtnReleasesApiResponse = GtnReleasesApiResponse.FromJson(jsonString);

namespace geoTagNinja
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class GTNReleaseAPIResponse
    {
        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public Uri Url { get; set; }

        [JsonProperty("assets_url", NullValueHandling = NullValueHandling.Ignore)]
        public Uri AssetsUrl { get; set; }

        [JsonProperty("upload_url", NullValueHandling = NullValueHandling.Ignore)]
        public string UploadUrl { get; set; }

        [JsonProperty("html_url", NullValueHandling = NullValueHandling.Ignore)]
        public Uri HtmlUrl { get; set; }

        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public long? Id { get; set; }

        [JsonProperty("author", NullValueHandling = NullValueHandling.Ignore)]
        public Author Author { get; set; }

        [JsonProperty("node_id", NullValueHandling = NullValueHandling.Ignore)]
        public string NodeId { get; set; }

        [JsonProperty("tag_name", NullValueHandling = NullValueHandling.Ignore)]
        public string attribute { get; set; }

        [JsonProperty("target_commitish", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetCommitish { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("draft", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Draft { get; set; }

        [JsonProperty("prerelease", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Prerelease { get; set; }

        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? CreatedAt { get; set; }

        [JsonProperty("published_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime PublishedAt { get; set; }

        [JsonProperty("assets", NullValueHandling = NullValueHandling.Ignore)]
        public Asset[] Assets { get; set; }

        [JsonProperty("tarball_url", NullValueHandling = NullValueHandling.Ignore)]
        public Uri TarballUrl { get; set; }

        [JsonProperty("zipball_url", NullValueHandling = NullValueHandling.Ignore)]
        public Uri ZipballUrl { get; set; }

        [JsonProperty("body", NullValueHandling = NullValueHandling.Ignore)]
        public string Body { get; set; }
    }

    public partial class Asset
    {
        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public Uri Url { get; set; }

        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public long? Id { get; set; }

        [JsonProperty("node_id", NullValueHandling = NullValueHandling.Ignore)]
        public string NodeId { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("label")]
        public object Label { get; set; }

        [JsonProperty("uploader", NullValueHandling = NullValueHandling.Ignore)]
        public Author Uploader { get; set; }

        [JsonProperty("content_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ContentType { get; set; }

        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public string State { get; set; }

        [JsonProperty("size", NullValueHandling = NullValueHandling.Ignore)]
        public long? Size { get; set; }

        [JsonProperty("download_count", NullValueHandling = NullValueHandling.Ignore)]
        public long? DownloadCount { get; set; }

        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? CreatedAt { get; set; }

        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? UpdatedAt { get; set; }

        [JsonProperty("browser_download_url", NullValueHandling = NullValueHandling.Ignore)]
        public Uri BrowserDownloadUrl { get; set; }
    }

    public partial class Author
    {
        [JsonProperty("login", NullValueHandling = NullValueHandling.Ignore)]
        public string Login { get; set; }

        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public long? Id { get; set; }

        [JsonProperty("node_id", NullValueHandling = NullValueHandling.Ignore)]
        public string NodeId { get; set; }

        [JsonProperty("avatar_url", NullValueHandling = NullValueHandling.Ignore)]
        public Uri AvatarUrl { get; set; }

        [JsonProperty("gravatar_id", NullValueHandling = NullValueHandling.Ignore)]
        public string GravatarId { get; set; }

        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public Uri Url { get; set; }

        [JsonProperty("html_url", NullValueHandling = NullValueHandling.Ignore)]
        public Uri HtmlUrl { get; set; }

        [JsonProperty("followers_url", NullValueHandling = NullValueHandling.Ignore)]
        public Uri FollowersUrl { get; set; }

        [JsonProperty("following_url", NullValueHandling = NullValueHandling.Ignore)]
        public string FollowingUrl { get; set; }

        [JsonProperty("gists_url", NullValueHandling = NullValueHandling.Ignore)]
        public string GistsUrl { get; set; }

        [JsonProperty("starred_url", NullValueHandling = NullValueHandling.Ignore)]
        public string StarredUrl { get; set; }

        [JsonProperty("subscriptions_url", NullValueHandling = NullValueHandling.Ignore)]
        public Uri SubscriptionsUrl { get; set; }

        [JsonProperty("organizations_url", NullValueHandling = NullValueHandling.Ignore)]
        public Uri OrganizationsUrl { get; set; }

        [JsonProperty("repos_url", NullValueHandling = NullValueHandling.Ignore)]
        public Uri ReposUrl { get; set; }

        [JsonProperty("events_url", NullValueHandling = NullValueHandling.Ignore)]
        public string EventsUrl { get; set; }

        [JsonProperty("received_events_url", NullValueHandling = NullValueHandling.Ignore)]
        public Uri ReceivedEventsUrl { get; set; }

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        [JsonProperty("site_admin", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SiteAdmin { get; set; }
    }

    public partial class GTNReleaseAPIResponse
    {
        public static GTNReleaseAPIResponse[] FromJson(string json) => JsonConvert.DeserializeObject<GTNReleaseAPIResponse[]>(json, geoTagNinja.Converter.Settings);
    }

    //public static class Serialize
    //{
    //    public static string ToJson(this GtnReleasesApiResponse[] self) => JsonConvert.SerializeObject(self, geoTagNinja.Converter.Settings);
    //}
    //
    //internal static class Converter
    //{
    //    public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
    //    {
    //        MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
    //        DateParseHandling = DateParseHandling.None,
    //        Converters =
    //        {
    //            new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
    //        },
    //    };
    //}
}
