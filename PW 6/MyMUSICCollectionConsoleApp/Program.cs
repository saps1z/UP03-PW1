using System;
using System.Collections.Generic;

namespace MusicCollectionConsole
{
    interface IPlayable
    {
        void Play();
    }

    class Song : IPlayable
    {
        public string Artist { get; set; }
        public string Title { get; set; }
        public int Duration { get; set; }

        public void Play()
        {
            Console.WriteLine($"Сейчас играет: {Title} от {Artist}");
        }

        public override string ToString()
        {
            return $"{Title} от {Artist} ({Duration} сек.)";
        }
    }

    class Playlist : IPlayable
    {
        public string Title { get; set; }
        public List<Song> Songs { get; set; }

        public Playlist()
        {
            Songs = new List<Song>();
        }

        public void AddSong(Song song)
        {
            Songs.Add(song);
        }

        public void Play()
        {
            Console.WriteLine($"Плелист на данный момент: {Title}");

            foreach (Song song in Songs)
            {
                song.Play();
            }
        }

        public override string ToString()
        {
            return $"{Title} ({Songs.Count} композиций)";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Song song1 = new Song { Artist = "Queen", Title = "Bohemian Rhapsody", Duration = 355 };
            Song song2 = new Song { Artist = "The Beatles", Title = "Hey Jude", Duration = 431 };
            Song song3 = new Song { Artist = "Led Zeppelin", Title = "Stairway to Heaven", Duration = 482 };
            Song song4 = new Song { Artist = "Pink Floyd", Title = "Comfortably Numb", Duration = 384 };
            Song song5 = new Song { Artist = "The Rolling Stones", Title = "Satisfaction", Duration = 232 };

            Playlist playlist1 = new Playlist { Title = "Classic Rock" };
            playlist1.AddSong(song1);
            playlist1.AddSong(song2);
            playlist1.AddSong(song3);
            Playlist playlist2 = new Playlist { Title = "Best of Pink Floyd" };
            playlist2.AddSong(song4);
            Playlist playlist3 = new Playlist { Title = "Top 10 Songs of All Time" };
            playlist3.AddSong(song1);
            playlist3.AddSong(song2);
            playlist3.AddSong(song3);
            playlist3.AddSong(song4);
            playlist3.AddSong(song5);

            List<IPlayable> musicCollection = new List<IPlayable>();
            musicCollection.Add(song1);
            musicCollection.Add(song2);
            musicCollection.Add(song3);
            musicCollection.Add(song4);
            musicCollection.Add(song5);
            musicCollection.Add(playlist1);
            musicCollection.Add(playlist2);
            musicCollection.Add(playlist3);

            while (true)
            {
                Console.WriteLine("Выберите песню или плейлист для прослушивания:");

                for (int i = 0; i < musicCollection.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {musicCollection[i]}");
                }

                int choice;
                while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > musicCollection.Count)
                {
                    Console.WriteLine("Ошибка! Введите число между 1 и " + musicCollection.Count + ".");
                }

                Console.WriteLine();

                IPlayable selected = musicCollection[choice - 1];
                selected.Play();

                Console.WriteLine();
            }
        }
    }
}
