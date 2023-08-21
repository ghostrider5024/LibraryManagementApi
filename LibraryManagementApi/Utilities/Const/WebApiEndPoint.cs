namespace LibraryManagementApi.Utilities.Const
{
    public static class WebApiEndPoint
    {
        private const string AreaName = "api";

        public static class Title
        {
            private const string BaseEndpoint = "~/" + AreaName + "/Title";
            public const string GetAllTitles = BaseEndpoint + "/get-all";
            public const string SearchTitles = BaseEndpoint + "/search";
            public const string CreateTitle = BaseEndpoint + "/create";
            public const string UpdateTitle = BaseEndpoint + "/update";
            public const string DeleteTitle = BaseEndpoint + "/delete";
        }

        public static class Album
        {
            private const string BaseEndpoint = "~/" + AreaName + "/Album";
            public const string GetAllAlbums = BaseEndpoint + "/get-all";
            public const string SearchAlbums = BaseEndpoint + "/search";
            public const string CreateAlbum = BaseEndpoint + "/create";
            public const string UpdateAlbum = BaseEndpoint + "/update";
            public const string DeleteAlbum = BaseEndpoint + "/delete";
        }

        public static class SongAlbum
        {
            private const string BaseEndpoint = "~/" + AreaName + "/SongAlbum";
            public const string GetAllSongAlbums = BaseEndpoint + "/get-all";
            public const string SearchSongAlbums = BaseEndpoint + "/search";
            public const string CreateSongAlbum = BaseEndpoint + "/create";
            public const string UpdateSongAlbum = BaseEndpoint + "/update";
            public const string DeleteSongAlbum = BaseEndpoint + "/delete";
        }

        public static class Home
        {
            private const string BaseEndpoint = "~/" + AreaName + "/Home";
            public const string GetHomePage = BaseEndpoint + "";
            public const string AddBanner = BaseEndpoint + "/banner";
            public const string AddRecommentAlbum = BaseEndpoint + "/recomment-album";
            public const string UpdateSongAlbum = BaseEndpoint + "/update";
            public const string DeleteSongAlbum = BaseEndpoint + "/delete";
        }



        public static class Upload
        {
            private const string BaseEndpoint = "~/" + AreaName + "/Upload";
            public const string UploadImage = BaseEndpoint + "/image/{id}";
            public const string UploadAudio = BaseEndpoint + "/audio/{id}";
        }
    }
}
