namespace OOP_Practice
{
    interface ISaturn
    {
        string Name { get; set; }
        string Description { get; set; }
        int Age { get; set; }
        int DistanceFromSolar { get; set; }

        void Info();
    }
}
