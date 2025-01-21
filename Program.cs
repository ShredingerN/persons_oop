Teacher person1 = new("Masik", 23, "Russian");
Student person2 = new("Tazik", 24, "555");
Student student = new("Yang", 19, "Michigan");
Employee employee = new("Tom", 50, 120000);
Teacher teacher = new("Jon", 45, "Math");

Repository repository = new Repository(10);
repository.Append(person1, person2, student, teacher, employee);

Printer printer= new();
printer.Print(repository);