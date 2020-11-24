using System;
using System.Collections.Generic;
using MiniBlog.DTO;

namespace MiniBlog
{
    public class ArticleStoreWhichWillReplaceInFuture
    {
        static ArticleStoreWhichWillReplaceInFuture()
        {
            Init();
        }

        public static List<Article> Articles { get; private set; }

        /// <summary>
        /// This is for test only, please help resolve!
        /// </summary>
        public static void Init()
        {
            Articles = new List<Article>();
            Articles.Add(new Article(null, "Happy new year", "Happy 2021 new year"));
            Articles.Add(new Article(null, "Happy Halloween", "Halloween is coming"));
        }
    }
}