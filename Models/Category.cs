using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Category
    {
        private Category()
        {

        }
        public Category(string name)
        {
            this.Name = name;
        }

        [RequiredAttribute]
        [StringLengthAttribute(50)]
        public string Name { get; set; }
    }

    public class Task
    {
        private Task()
        {

        }
        public Task(string description, Category Category)
        {
            this.Description = description;
            this.Category = Category;

        }
        public int Id { get; set; }
        [RequiredAttribute]
        [StringLengthAttribute(500)]
        public string Description { get; set; }
        public bool IsComplete { get; set; }
        public Category Category { get; set; }
        public void MarkComplete()
        {
            IsComplete = true;
        }
        public void MarkInComplete()
        {
            IsComplete = false;
        }
    }
}