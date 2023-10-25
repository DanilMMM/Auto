class Program
{
    static void Main()
    {
        Auto myCar = new Auto("ABC123", 100, 9);

        myCar.Info();
        myCar.Zapravka();
        myCar.Drive(100); 
       
        
    }
}