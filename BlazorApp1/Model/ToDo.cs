namespace BlazorApp1.Model
{
    public class ToDo
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public bool? IsDone { get; set; }
        public string? Description { get; set; }

        static public int idhelper = 0;

        public ToDo ()
        {
            Id = idhelper;
            idhelper++;
        }
    }




    
}
