using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NecromindLibrary.models
{
    /// <summary>
    /// Base class for any character
    /// </summary>
    public class CharacterModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<ItemModel> Items { get; set; }
    }
}
