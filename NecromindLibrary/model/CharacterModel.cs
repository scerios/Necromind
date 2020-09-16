using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NecromindLibrary.model
{
    /// <summary>
    /// Base class for any character.
    /// </summary>
    public class CharacterModel
    {
        /// <summary>
        /// ID of character.
        /// </summary>
        [Column("id")]
        public int Id { get; set; }
        /// <summary>
        /// Name of character.
        /// </summary>
        [Column("name")]
        public string Name { get; set; }
        /// <summary>
        /// List of items the character might own.
        /// </summary>
        [Column("item_ids")]
        public string ItemIds { get; set; }
    }
}
