using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Task2
{
    public class SongFolder
    {
        private Dictionary<string, string> playlist = new Dictionary<string, string>();
        private string playlistFilePath;

        public SongFolder(string playlistFilePath)
        {
            this.playlistFilePath = playlistFilePath;
            ReadFile(playlistFilePath);
        }

        private void ReadFile(string file)
        {
            var totalLinesRead = File.ReadLines(file);
            foreach (var lineRead in totalLinesRead)
            {
                string[] info = lineRead.Split(',');
                string songName = info[0].Trim();
                string songDuration = TimeSpan.Parse(info[1]).TotalSeconds.ToString();
                playlist.Add(songName, songDuration);
            }
        }

        public void Enqueue()
        {
            Console.WriteLine("Enter the song name you would like to add: ");
            string songName = Console.ReadLine().Trim();
            Console.WriteLine("Enter the duration of the song in minutes: ");
            int songDurationMin;
            while (!int.TryParse(Console.ReadLine(), out songDurationMin))
            {
                Console.WriteLine("Invalid input. Enter a valid duration in minutes: ");
            }
            Console.WriteLine("Enter the duration of the song in seconds: ");
            int songDurationSec;
            while (!int.TryParse(Console.ReadLine(), out songDurationSec))
            {
                Console.WriteLine("Invalid input. Enter a valid duration in seconds: ");
            }
            int totalSongDuration = songDurationMin * 60 + songDurationSec;

            playlist.Add(songName, totalSongDuration.ToString());
        }

        public void Remove()
        {
            Console.WriteLine("Enter the name of the song you would like to remove: ");
            string songName = Console.ReadLine().Trim();
            playlist.Remove(songName);
        }

        public void Load()
        {
            Console.WriteLine("Enter the playlist text file path: ");
            playlistFilePath = Console.ReadLine().Trim();
            if (File.Exists(playlistFilePath))
            {
                playlist.Clear();
                ReadFile(playlistFilePath);
                Console.WriteLine("Playlist loaded successfully.");
            }
            else
            {
                Console.WriteLine("File does not exist. Playlist not loaded.");
            }
        }

        public void Save()
        {
            Console.WriteLine("Enter the file path to save the playlist: ");
            string saveFilePath = Console.ReadLine().Trim();
            using (StreamWriter file = new StreamWriter(saveFilePath))
            {
                foreach (var entry in playlist)
                {
                    file.WriteLine("[Song Name: {0}, Duration: {1} seconds]", entry.Key, entry.Value);
                }
            }
            Console.WriteLine("Playlist saved successfully.");
        }

        public void Shuffle()
        {
            Random rand = new Random();
            playlist = playlist.OrderBy(x => rand.Next(0, playlist.Count)).ToDictionary(x => x.Key, x => x.Value);
            Console.WriteLine("The playlist is now shuffled.");
        }

        public void Display()
        {
            if (playlist.Count == 0)
            {
                Console.WriteLine("The playlist is empty.");
            }
            else
            {
                Console.WriteLine("Playlist:");
                foreach (var element in playlist)
                {
                    Console.WriteLine("[Song Name: {0}, Duration: {1} seconds]", element.Key, element.Value);
                }
            }
        }

        public void Count()
        {
            Console.WriteLine("There are {0} songs in the playlist.", playlist.Count);
        }

        public void Calculate()
        {
            int totalSeconds = playlist.Values.Sum(x => int.Parse(x));
            TimeSpan totalTime = TimeSpan.FromSeconds(totalSeconds);
            Console.WriteLine("The total duration of the playlist is: {0} hours, {1} minutes, {2} seconds.",
                totalTime.Hours, totalTime.Minutes, totalTime.Seconds);
        }

        public void Reset()
        {
            playlist.Clear();
            Console.WriteLine("The playlist is now empty.");
        }

        public void Empty()
        {
            if (playlist.Count != 0)
            {
                Console.WriteLine("The playlist is not empty.");
            }
            else
            {
                Console.WriteLine("The playlist is empty.");
            }
        }
    }

    class Task2
    {
        static void Main(string[] args)
        {
            SongFolder mp3 = new SongFolder("C:/Users/cposk/OneDrive/Desktop/Unit-16-Code-main/Task2U16/Task2/songs.txt");

            while (true)
            {
                Console.WriteLine("Available Commands: Enqueue, Remove, Load, Save, Shuffle, Display, Count, Calculate, Reset, Empty");
                Console.WriteLine("What command would you like to execute: ");
                string command = Console.ReadLine().ToLower();

                switch (command)
                {
                    case "enqueue":
                        mp3.Enqueue();
                        break;
                    case "remove":
                        mp3.Remove();
                        break;
                    case "load":
                        mp3.Load();
                        break;
                    case "save":
                        mp3.Save();
                        break;
                    case "shuffle":
                        mp3.Shuffle();
                        break;
                    case "display":
                        mp3.Display();
                        break;
                    case "count":
                        mp3.Count();
                        break;
                    case "calculate":
                        mp3.Calculate();
                        break;
                    case "reset":
                        mp3.Reset();
                        break;
                    case "empty":
                        mp3.Empty();
                        break;
                    case "exit":
                        return;
                    default:
                        Console.WriteLine("Invalid command. Please enter a valid command.");
                        break;
                }
            }
        }
    }
}