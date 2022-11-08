// Что будет выведено? (Консольное приложение, .Net 6. )

using static System.Console;

IEnumerable<int> iterate(int startingValue)
{
    if (startingValue is 2 or 5)
    {
        throw new ArgumentException("Старт с двойки или пятерки не разрешён.");
    }
        
    while (true)
    {
        yield return startingValue++;
    }
}

try
{
    var fromOne = iterate(1);
    
    var fromTwo = iterate(2);
    
    var fromThree = iterate(3);
    WriteLine(
        string.Join(
            ',',
            fromThree.Take(4)));
    
    var fromFour = iterate(4);
    WriteLine(fromFour.Count());
}
catch {}