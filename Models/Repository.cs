﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DersBlogPorjesi.Models
{
    public static class Repository
    {
        public static List<Article> AllArticles()
        {
            var articles = new List<Article>
            {
                new Article {ID=1,Header="HTML",Content="Lorem ipsum dolor sit amet, consectetur adipisicing elit. Pariatur magnam vel deserunt facilis quae inventore doloribus molestias harum cumque corrupti facere omnis ducimus culpa illo quo repellat, blanditiis maxime? At nam corrupti quas nemo tenetur voluptatem temporibus! Consectetur laudantium, aut rerum labore omnis, iusto harum illo modi cumque ea qui neque!"},
                new Article {ID=2,Header="CSS",Content="Lorem ipsum dolor sit amet, consectetur adipisicing elit. Pariatur magnam vel deserunt facilis quae inventore doloribus molestias harum cumque corrupti facere omnis ducimus culpa illo quo repellat, blanditiis maxime? At nam corrupti quas nemo tenetur voluptatem temporibus! Consectetur laudantium, aut rerum labore omnis, iusto harum illo modi cumque ea qui neque!"},
                new Article {ID=3,Header="Bootstrap",Content="Lorem ipsum dolor sit amet, consectetur adipisicing elit. Pariatur magnam vel deserunt facilis quae inventore doloribus molestias harum cumque corrupti facere omnis ducimus culpa illo quo repellat, blanditiis maxime? At nam corrupti quas nemo tenetur voluptatem temporibus! Consectetur laudantium, aut rerum labore omnis, iusto harum illo modi cumque ea qui neque!"},
                new Article {ID=4,Header="Web ve Mobil",Content="Lorem ipsum dolor sit amet, consectetur adipisicing elit. Pariatur magnam vel deserunt facilis quae inventore doloribus molestias harum cumque corrupti facere omnis ducimus culpa illo quo repellat, blanditiis maxime? At nam corrupti quas nemo tenetur voluptatem temporibus! Consectetur laudantium, aut rerum labore omnis, iusto harum illo modi cumque ea qui neque!"},
                new Article {ID=5,Header="PHP",Content="Lorem ipsum dolor sit amet, consectetur adipisicing elit. Pariatur magnam vel deserunt facilis quae inventore doloribus molestias harum cumque corrupti facere omnis ducimus culpa illo quo repellat, blanditiis maxime? At nam corrupti quas nemo tenetur voluptatem temporibus! Consectetur laudantium, aut rerum labore omnis, iusto harum illo modi cumque ea qui neque!"},
                new Article {ID=6,Header="Java",Content="Lorem ipsum dolor sit amet, consectetur adipisicing elit. Pariatur magnam vel deserunt facilis quae inventore doloribus molestias harum cumque corrupti facere omnis ducimus culpa illo quo repellat, blanditiis maxime? At nam corrupti quas nemo tenetur voluptatem temporibus! Consectetur laudantium, aut rerum labore omnis, iusto harum illo modi cumque ea qui neque!"},
            };
            return articles;
        }
    }
}
