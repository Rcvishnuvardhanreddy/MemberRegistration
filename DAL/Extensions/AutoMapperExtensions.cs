//using AutoMapper;
//using Microsoft.Extensions.DependencyInjection;
//using System;
//using System.Collections.Generic;
//using System.Text;
//namespace VirtualTracker.EntityFramework.Extensions
//{
//    /// <summary>
//    /// AutoMapper Extensions class
//    /// </summary>
//    public static class AutoMapperExtensions
//    {
//        /// <summary>
//        /// The mapper
//        /// </summary>
//        public static IMapper _mapper;

//        /// <summary>
//        /// Configures the specified mapper.
//        /// </summary>
//        /// <param name="mapper">The mapper.</param>
//        public static void Configure(IMapper mapper)
//        {
//            _mapper = mapper;
//        }
//        /// <summary>
//        /// Maps to.
//        /// </summary>
//        /// <typeparam name="T"></typeparam>
//        /// <param name="src">The source.</param>
//        /// <returns>the destination object type</returns>
//        public static T MapTo<T>(this object src)
//        {
//            if (src == null)
//            {
//                return default(T);
//            }

//            return _mapper.Map<T>(src);
//        }

//        /// <summary>
//        /// Maps the collection.
//        /// </summary>
//        /// <typeparam name="TSource">The type of the source.</typeparam>
//        /// <typeparam name="TDestination">The type of the destination.</typeparam>
//        /// <param name="src">The source.</param>
//        /// <returns>the destination object type</returns>
//        public static IEnumerable<TDestination> MapCollection<TSource, TDestination>(this IEnumerable<TSource> src)
//        {
//            if (src == null)
//            {
//                return Array.Empty<TDestination>();
//            }

//            return _mapper.Map<IEnumerable<TSource>, IEnumerable<TDestination>>(src);
//        }
//    }
//}