using System.ComponentModel.DataAnnotations;

namespace BasicDbHandling.Models
{
    public class Category
    {
        [Key]   //PK

        public int Id { get; set; }
        [Required] // NotNull

        public string Name { get; set; }
        public int DisplayOrder { get; set; }
        public DateTime PostDate { get; set; } = DateTime.Now; //기본적으로 생성되는 현재 날짜
    }
}
