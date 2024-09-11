using System;
using System.Windows.Documents;
using System.Collections.Generic;
using System.Windows.Media.Imaging;

namespace Marathone.Data
{
    public class Item
    {
        public string Name { get; }

        public BitmapImage Image { get; } 

        public string Discription { get; }

        public Item(string name, Uri source, string discription)
        {
            Name = name;
            Image = new BitmapImage(source);
            Discription = discription;
        }
    }

    public static class Items
    {
        public static List<Item> SpeedItems = new List<Item>()
        {
            new Item("Гепард", new Uri("Speed/Человек.jpg", UriKind.Relative), "При скорости гепарда в 110 километров в час, он промежит марафон за полчаса."),
            new Item("Улитка", new Uri("Speed/ylitkf.jpg", UriKind.Relative), "При скорости улитки в 1 сантиметр в секунду, она пройдет марафон за 47 дней"),
            new Item("Человек", new Uri("Speed/human.jpg", UriKind.Relative), "Марафонец любитель пробегает марафон за 3-4 часа")
        };

        public static List<Item> DistantionItems = new List<Item>()
        {
            new Item("Телефон", new Uri("Distanation/telephone.jpg", UriKind.Relative), "Длина телефона составляет 12 сантиметров, что значит что понадобиться 350 000 тысяч таких телефонов, чтобы той же достичь длины"),
            new Item("Поле", new Uri("Distanation/pole.jpg", UriKind.Relative), "Ровно 420 футбольных полей нужно что бы достич длины в 42 километра")
        };
    }
}
