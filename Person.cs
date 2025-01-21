abstract class Person
{
    // Конструктор класса, отвечает за инициализацию начального состояния
    public Person(string name, int age)
    {
        this.Name = name;
        this.Age = age;

    }

    // Автосвойства, чаще всего используются
    // Заменяют сразу объявление полей и свойства доступа и установки значений
    public string Name { get; protected set; }
    public int Age { get;  protected set; }

    public override string ToString()
    {
        return $"Имя: {this.Name} возраст: {this.Age}";
    }

}
