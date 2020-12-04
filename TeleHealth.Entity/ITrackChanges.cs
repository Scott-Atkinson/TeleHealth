using System;

namespace TeleHealth.Entity
{
    interface ITrackChanges
    {
        public DateTime CreatedDate { get; set; }

        public DateTime? UpdatedDate { get; set; }
    }
}
