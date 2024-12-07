using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text.Json;
using System.Threading.Tasks;

namespace BlazorApp1.Model
{
    public class ToDoList
    {
        public List<ToDo>? ToDos { get; set; } = [];

        public ToDoList() 
        {
            ToDos = new List<ToDo>();
        }

        public async Task LoadFile(HttpClient http)
        {
            string json = await http.GetStringAsync("JsonInput.json");
            var options = new JsonSerializerOptions()
            {
                AllowTrailingCommas = true
            };
            if (json != null)
            {
                ToDoList root = JsonSerializer.Deserialize<ToDoList>(json, options);

                ToDos = root.ToDos;
            }
        }
    }

    
}
