namespace DesignPatterns.Factory
{
    public class ImplementationClass
    {
        public void PrintFileContent()
        {
            IPrinter printer = PrinterFactory.Get(PrinterTypes.File);
            printer.Print(new FileContent());
        }
    }
}
