using System;
using System.Collections.Generic;
using System.Linq;
using JsonData;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Collections to work with
            List<Artist> Artists = MusicStore.GetData().AllArtists;
            List<Group> Groups = MusicStore.GetData().AllGroups;

            //========================================================
            //Solve all of the prompts below using various LINQ queries
            //========================================================

            //There is only one artist in this collection from Mount Vernon, what is their name and age?
            Artist mountArtist = Artists.FirstOrDefault(art => art.Hometown == "Mount Vernon");
            System.Console.WriteLine(mountArtist.ArtistName);
            System.Console.WriteLine(mountArtist.Age);
            System.Console.WriteLine("************************");

            //Who is the youngest artist in our collection of artists?
            int youngestAge = Artists.Min(art => art.Age);
            Artist youngestArtist = Artists.FirstOrDefault(art => art.Age == youngestAge);
            System.Console.WriteLine(youngestArtist.ArtistName + " is " + youngestAge + " years old.");
            System.Console.WriteLine("************************");

            //Display all artists with 'William' somewhere in their real name
            var allWilliam = Artists.Where(art => art.RealName.Contains("William"));
            foreach (var artist in allWilliam)
                System.Console.WriteLine(artist.RealName);
            System.Console.WriteLine("************************");

            //Display the 3 oldest artist from Atlanta
            var atlArtists = Artists
            .Where(art => art.Hometown == "Atlanta")
            .OrderByDescending(art => art.Age)
            .Take(3);
            foreach(var artist in atlArtists)
                System.Console.WriteLine(artist.ArtistName);
            System.Console.WriteLine("************************");

            //Display all groups with names less than 8 characters in length.
            var shortNames = Groups.Where(g => g.GroupName.Length < 8);
            foreach (var group in shortNames)
                Console.WriteLine(group.GroupName);
            Console.WriteLine("*************************************");

            //(Optional) Display the Group Name of all groups that have members that are not from New York City
            var groupJoin = Groups
            .Join(Artists,
            (g => g.Id),
            (a => a.GroupId),
            (joinedGroup, joinedArtist) =>
            {
                joinedGroup.Members.Add(joinedArtist);
                return joinedGroup;
            })
            .Distinct()
            .ToList();
            var notNYC = groupJoin.Where(gj => gj.Members.Any(m => m.Hometown != "New York CIty")).ToList();
            foreach (var group in notNYC)
                System.Console.WriteLine(group.GroupName);
            Console.WriteLine("*************************************");

            //(Optional) Display the artist names of all members of the group 'Wu-Tang Clan'
	        // Console.WriteLine(Groups.Count);
            var clanJoin = Artists
            .Join(Groups,
            (a => a.GroupId),
            (g => g.Id),
            (joinedArtist, joinedGroup) =>
            {
                return joinedArtist;
            })
            .ToList();
            var clanArtists = clanJoin.Where(cj => cj.Group.GroupName == "Wu-Tang Clan");
            foreach (var artist in clanArtists)
                System.Console.WriteLine(artist.ArtistName);
        }
    }
}
