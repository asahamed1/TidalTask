using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GoogleMapsTask.Core.Entities
{
  public class UserLocation
    {
        [Key]
        public long Id { get; set; }
        [Required]
        public double latitude { get; set; }
        [Required]
        public double longitude { get; set; }
        // hint
        //should be referance to user table (but user table is not scoped in the task)
        public long? UserId { get; set; }

    }
}
