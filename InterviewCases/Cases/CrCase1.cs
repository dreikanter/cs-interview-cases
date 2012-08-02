using System.Collections.Generic;

namespace InterviewCases.Cases
{
    // Q: Review the code below. What's wrong and what could be fixed?

    //    Public class EmployeeList
    //    {
    //        Private List<string> _Names ;
    //        Private List<int> _ Salaries;
    //        Public void Add (string name, int salary)
    //        {
    //            _Names.Add(name);
    //            _Salaries.Add(salary);
    //        }
    //        Public void Remove (string name)
    //        {
    //            Int i =_Names.IndexOf(name);
    //            _Salaries.RemoveAt(i);
    //            _Names.RemoveAt(i);
    //        }
    //    }

    // A:

    // Fixed code

    public class EmployeeList
    {
        private readonly List<string> _names = new List<string>();

        private readonly List<int> _salaries = new List<int>();
        
        public void Add (string name, int salary)
        {
            _names.Add(name);
            _salaries.Add(salary);
        }
        
        public void Remove (string name)
        {
            int i = _names.IndexOf(name);
            _salaries.RemoveAt(i);
            _names.RemoveAt(i);
        }
    }

    // Better design

    public struct Employee
    {
        public string Name;
        public int Salary;
    }

    public class BetterEmployeeList : List<Employee>
    {
        public void Add(string name, int salary)
        {
            Add(new Employee {Name = name, Salary = salary});
        }

        public bool RemoveFirst(string name)
        {
            var index = FindIndex(item => item.Name == name);
            var gotIt = index > -1;

            if (gotIt)
            {
                RemoveAt(index);
            }

            return gotIt;
        }

        public void RemoveAll(string name)
        {
            while (RemoveFirst(name)) { }
        }
    }

    // Even better design

    public class IdentifiedEmployee
    {
        public int Id;

        public string Name;
        
        public int Salary;

        private static int _idCounter = 0;

        private static int GetNewId()
        {
            return _idCounter++;
        }

        public IdentifiedEmployee()
        {
            Id = GetNewId();
        }
    }

    public class IdentifiedEmployeeList : List<IdentifiedEmployee>
    {
        public void Add(string name, int salary)
        {
            Add(new IdentifiedEmployee { Name = name, Salary = salary });
        }

        public bool Remove(int id)
        {
            var index = FindIndex(item => item.Id == id);
            var gotIt = index > -1;
            
            if(gotIt)
            {
                RemoveAt(index);
            }

            return gotIt;
        }
    }
}
