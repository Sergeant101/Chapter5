using System.Collections.Generic;

namespace Packt.Shared
{
    public class Person: Object
    {
        public string? name;
        public DateTime DateOfBirth;
        public WordestOfTheAncientWorld FavoriteAncientWonder;
        public WordestOfTheAncientWorld BucketList;
        public List<Person> Children = new List<Person>();
    }
}
