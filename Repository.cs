class Repository: IRepository
{
    private Person[] storage;
    // прописываем конструктор явно
    // задаем максимальное значение массива
    private int count;
    private int index = 0;
    public Repository(int count)
    {
        // this обращение к контекcту класса(задано выше), count - значение,  которое передает пользователь (аргумент конструктора).
        this.count = count;
        this.storage = new Person[count];
    }

    // пишем свойство для получения доступа к index, ниже несколько примеров как можно
    // третья запись - синтаксический сахар через лямбду

    // public int Index {get{return index;}}
    // public int Index {get=> index;}
    public int Index => index;

    public void Append(params Person[] people)
    {
        foreach (var person in people)
        {
            if (index >= count) return;
            storage[index] = person;
            index++;
        }
    }

    public Person GetById(int id)
    {
        if (id < 0 || id >= index)
        {
            return new NullPerson();
        };
        return storage[id];
    }

}