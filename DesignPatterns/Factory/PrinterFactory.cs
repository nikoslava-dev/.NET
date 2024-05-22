namespace DesignPatterns.Factory
{
    public static class PrinterFactory
    {
        public static IPrinter Get(PrinterTypes type)
        {
            switch (type)
            {
                case PrinterTypes.Console:
                    return new ConsolePrinter();
                    break;
                case PrinterTypes.HTML:
                    return new HTMLPrinter();
                    break;
                case PrinterTypes.File:
                    return new FilePrinter();
                    break;
                default:
                case PrinterTypes.None:
                    return null;
                    break;
            }
        }
    }
}
