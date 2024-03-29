﻿using RestAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace RestAPI.Services.Implementations {
    public class PersonService : IPersonService {

        private volatile int count;

        public Person Create(Person person) {
           return person;
        }

        public void Delete(long id) {
            
        }

        public List<Person> FindAll() {
            List<Person> persons = new List<Person>();
            for(int i = 0; i < 10; i++) {
                Person person = MockPerson(i);
                persons.Add(person);
            }
            return persons;
        }

        public Person FindById(long id) {
            return new Person {
                Id = IncrementAndGet(),
                FirstName = "Raphael",
                LastName = "Silva",
                Adress = "Belo Horizonte",
                Gender = "Male"
            };
        }

        private long IncrementAndGet() {
            return Interlocked.Increment(ref count);
        }

        public Person Update(Person person) {
            return person;
        }

        private Person MockPerson(int i) {
            return new Person {
                Id = i,
                FirstName = "Raphael",
                LastName = "Silva",
                Adress = "Belo Horizonte",
                Gender = "Male"
            };
        }
    }
}
