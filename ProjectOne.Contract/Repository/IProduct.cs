using System;

namespace ProjectOne.Contract
{
    public interface IProduct
    {
        int Id { get; set; }
        string Title { get; set; }
        double Price { get; set; }
        DateTime CreateDate { get; set; }

    }
}