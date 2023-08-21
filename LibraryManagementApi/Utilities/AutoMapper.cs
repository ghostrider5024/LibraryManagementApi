using AutoMapper;
using LibraryManagementApi.Repository.Entity;
using LibraryManagementApi.Service.Model.RequestModel;
using LibraryManagementApi.Service.Model.ResponseModel;

namespace LibraryManagementApi.Utilities
{
    public class AutoMapper : Profile
    {
        public AutoMapper()
        {
            MapTitle();
            
        }

        private void MapTitle()
        {
            //CreateMap<Song, SongResponse>()
            // //.ForMember(dest => dest.Artists, opt => opt.MapFrom(src => src.SongArtists.Select(sc => sc.ArtistId)))
            // //.ForMember(dest => dest.Playlists, opt => opt.MapFrom(src => src.SongPlaylists.Select(sc => sc.PlaylistId)))
            // .ReverseMap();
            CreateMap<TitleEntity, TitleRequest>().ReverseMap();
            CreateMap<TitleEntity, TitleResponse>().ReverseMap();

        }
    }
}
