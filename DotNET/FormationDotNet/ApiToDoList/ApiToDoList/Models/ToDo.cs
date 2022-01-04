using System;
namespace ApiToDoList.Models
{
    public class ToDo
    {
        private int id;
        private string name;
        private bool isDone;
        private bool isEdited;
        public ToDo()
        {
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public bool IsDone { get => isDone; set => isDone = value; }
        public bool IsEdited { get => isEdited; set => isEdited = value; }
    }
}
