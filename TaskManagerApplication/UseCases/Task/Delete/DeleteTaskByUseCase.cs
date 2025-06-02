using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.Application.UseCases.Task.Delete
{
    public class DeleteTaskByUseCase
    {

        public void Execute(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("Invalid pet ID.");
            }
            // Here you would typically delete the pet from a database or another data source.
            // For demonstration purposes, we will just simulate the deletion.
            Console.WriteLine($"Pet with ID {id} has been deleted successfully.");
        }
    }
}
