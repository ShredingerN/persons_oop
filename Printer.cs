class Printer
{
    //метод принимает репозиторий на вход
    public void Print(IRepository repository)
    {
        // получаем количество записей в репо
        int max = repository.Index;
        for (int i = 0; i < max; i++)
        {
            Person temp = repository.GetById(i);
            Console.WriteLine(temp.ToString());
        }
    }
}