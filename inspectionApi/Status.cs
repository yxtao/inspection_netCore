using System.ComponentModel.DataAnnotations;

namespace inspectionApi
{
    public class Status
    {
        public int Id { get; set; }

        [StringLength(20)]
        public string SatusOption { get; set; } = string.Empty;
    }
}
