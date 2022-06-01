namespace Luftborn.Models
{
    public class Department: BaseModel
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [MaxLength(100)]
        public string DeptName { get; set; } = string.Empty;
    }
}
