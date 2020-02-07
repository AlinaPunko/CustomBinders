using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using CustomBinders.Models;
using Microsoft.AspNetCore.Mvc;

namespace CustomBinders.Controllers
{
    public class PersonController : Controller
    {
        private List<Person> persons;

        public PersonController()
        {
            LoadsPersons();
        }

        private async void LoadsPersons()
        {
            using (FileStream fs = new FileStream("Persons.json", FileMode.OpenOrCreate))
            {
                persons = await JsonSerializer.DeserializeAsync<List<Person>>(fs);
            }
        }

        [Route("api/person/{id}")]
        public IActionResult GetPersonById(Guid id)
        {
            return Json(persons.Where(person => person.ID==id));
        }
    }
}