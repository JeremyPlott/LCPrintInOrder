public class Foo
{

    public Foo()
    {

    }

    bool firstComplete = false;
    bool secondComplete = false;

    public void First(Action printFirst)
    {
        // printFirst() outputs "first". Do not change or remove this line.
        printFirst();
        firstComplete = true;
    }

    public void Second(Action printSecond)
    {
        while (!firstComplete)
        {
            System.Threading.Thread.Sleep(3);
        }
        // printSecond() outputs "second". Do not change or remove this line.
        printSecond();

        secondComplete = true;
    }

    public void Third(Action printThird)
    {
        while (!secondComplete)
        {
            System.Threading.Thread.Sleep(3);
        }
        // printThird() outputs "third". Do not change or remove this line.
        printThird();
    }
}