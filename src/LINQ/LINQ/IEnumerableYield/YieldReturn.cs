using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.IEnumerableYield
{
    [MemoryDiagnoser]
    public class YieldReturn
    {
        [Benchmark]
        public void WithoutYield()
        {
            var people = GetPeople(1000);
            foreach (var person in people)
            {
                if (person.Id < 1000)
                {
                    Console.WriteLine($"Id: {person.Id}, Name: {person.Name}");
                }
                else
                {
                    break;
                }
            }
        }

        public IEnumerable<Person> GetPeople(int count)
        {
            List<Person> list = new List<Person>();
            for (int i = 0; i < count; i++)
            {
                list.Add(new Person()
                {
                    Id = i,
                    Name = $"Name {i}",
                });
            }
            return list;
        }

        [Benchmark]
        public void WithYield()
        {
            var people = GetPeopleYield(1000);
            foreach (var person in people)
            {
                if (person.Id < 1000)
                {
                    Console.WriteLine($"Id: {person.Id}, Name: {person.Name}");
                }
                else
                {
                    break;
                }
            }
        }

        public IEnumerable<Person> GetPeopleYield(int count)
        {
            for (int i = 0; i < count; i++)
            {
                yield return new Person()
                {
                    Id = i,
                    Name = $"Name {i}",
                };
            }
        }
    }
}
