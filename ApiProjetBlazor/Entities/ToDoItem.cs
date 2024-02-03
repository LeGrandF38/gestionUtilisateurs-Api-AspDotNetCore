namespace ApiProjetBlazor.Entities
{
    public class ToDoItem
    {
        public int Id { get; set; }
        public required string Title { get; set; }
        public string Description { get; set; } = string.Empty; 
        public string DueDate { get; set; } 
        public bool IsCompleted { get; set; } = false;
       
    }
}
