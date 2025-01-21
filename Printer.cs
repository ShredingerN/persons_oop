class Printer
{
    //метод принимает репозиторий на вход
    public void Print(Repository repository)
    {
        // получаем количество записей в репо
        int max = repository.Index;
        for (int i = 0; i < max; i++)
        {
            Person temp = repository.GetPersonById(i);
            Console.WriteLine(temp.ToString());
        }
    }
}