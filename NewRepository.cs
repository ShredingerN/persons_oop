class NewRepository : IRepository
{
    public List<Person> collect;
    public int Index => collect.Count;
    public NewRepository()
    {
        collect = new List<Person>();
    }
    public void Append(params Person[] people)
    {
        foreach (var item in people)
        {
            collect.Add(item);
        }
    }

    public Person GetById(int id)
    {
        return collect[id];
    }
}