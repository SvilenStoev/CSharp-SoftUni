using System.ComponentModel.DataAnnotations;
using VaporStore.Data.Models.Enums;

namespace VaporStore.DataProcessor.Dto.Import
{
    public class CardJsonInputModel
    {
        [Required]
        [RegularExpression(@"\d{4}\s\d{4}\s\d{4}\s\d{4}")]
        public string Number { get; set; }

        [Required]
        [RegularExpression("[0-9]{3}")]
        public string CVC { get; set; }

        [Required]
        public CardType? Type { get; set; }
    }

}
