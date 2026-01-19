using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;
namespace Napominalka
{
    public static class SaveLoader
    {
        public static void SaveTasks(List<TaskItem> tasks, string filePath = "tasks.json")
        {
            try
            {
                string json = JsonSerializer.Serialize(tasks);
                File.WriteAllText(filePath, json);
                MessageBox.Show("Задачи успешно сохранены!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Sosi");
            }
        }
    }
}
