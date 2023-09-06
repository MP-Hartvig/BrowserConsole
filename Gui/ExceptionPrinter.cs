namespace BrowserConsole.Gui
{
    internal class ExceptionPrinter
    {
        public void PrintExceptions(Exception ex)
        {
            Console.WriteLine("\nException Caught!\n");
            Console.WriteLine("Message: \n{0}", ex.InnerException == null ? ex.Message : ex.InnerException.Message);
        }
    }
}
