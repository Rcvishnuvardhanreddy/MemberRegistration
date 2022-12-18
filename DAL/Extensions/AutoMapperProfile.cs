//using AutoMapper;
//using ShortURL.DAL.Models;
//using System;
//using System.Collections.Generic;
//using System.Text;
//using DBEntities = ShortURL.DAL.Entities;

//namespace ShortURL.EntityFramework
//{
//    /// <summary>
//    /// Auto Mapper Profile Class
//    /// </summary>
//    /// <seealso cref="AutoMapper.Profile" />
//    public class AutoMapperProfile : Profile
//    {
//        /// <summary>
//        /// Initializes a new instance of the <see cref="AutoMapperProfile"/> class.
//        /// </summary>
//        public AutoMapperProfile()
//        {
//            CreateMap<DBEntities.UrlMapper, ShortenRequest>()
//                .ForMember(dest => dest.Url, opt => opt.MapFrom(src => src.ActualUrl))
//                .ForMember(dest => dest.DateCreated, opt => opt.MapFrom(src => src.DateCreated.ToString()))
//                .ReverseMap()
//                    .ForMember(dest => dest.ActualUrl, opt => opt.MapFrom(src => src.Url))
//                    .ForMember(dest => dest.DateCreated, opt => opt.MapFrom(src => DateTime.UtcNow));

//            CreateMap<DBEntities.UsersEntity, User>()
//                .ForMember(dest => dest.CreatedDate, opt => opt.MapFrom(src => src.DateCreated.ToString()))
//                .ReverseMap()
//                    .ForMember(dest => dest.DateCreated, opt => opt.MapFrom(src => DateTime.UtcNow));

//            CreateMap<DBEntities.FeedbackEntity, Feedback>()
//                .ReverseMap()
//                    .ForMember(dest => dest.DateCreated, opt => opt.MapFrom(src => DateTime.UtcNow));
//        }
//    }
//}

