using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NecromindLibrary.dtos
{
    public class HeroDTO
    {
        /// <summary>
        /// ID of hero. 
        /// </summary>
        [Column("id")]
        public int Id { get; set; }
        /// <summary>
        /// Name of hero.
        /// </summary>
        [Column("name")]
        public string Name { get; set; }
    }
}
