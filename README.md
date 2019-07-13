# Product

The task of the interview, given to me by a teacher at the computer academy
STEP. I completed it in two hours and received a 12/12 evaluation.

The text of the task is as follows:

```
A product has two characteristics: view and type of product.

Write a program in C#, which, depending on the choice of these characteristics,
will implement the rounding of the entered weight. Rounding can be of two
types: mathematical and rounding up, and taking into account up to 1, 2 or 3
decimal places.
```

## Examples

```C#
internal class Program
{
    private static void Main(string[] args)
    {
        Models.Product product = new Models.Product
        {
            View = new View
            {
                // ...
                RoundMode = RoundMode.Greater
            },
            Type = new Models.Type
            {
                // ...
                RoundMode = RoundMode.Math
            },
            
            Weight = 3.14M
        };
        
        Console.WriteLine(product.Weight);
    }
}
```

**Output: 3**

```C#
internal class Program
{
    private static void Main(string[] args)
    {
        Models.Product product = new Models.Product
        {
            View = new View
            {
                // ...
                RoundMode = RoundMode.Greater
            },
            Type = new Models.Type
            {
                // ...
                RoundMode = RoundMode.Greater
            },
            
            Weight = 3.14M
        };
        
        Console.WriteLine(product.Weight);
    }
}
```

**Output: 3.14**

## License

The repository is licensed by [Apache-2.0](https://github.com/liannoi/product/blob/master/LICENSE).
