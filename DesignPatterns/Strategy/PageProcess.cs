namespace DesignPatterns.Strategy
{
    public class PageProcess<Tinput, Tdata, Tformat>
    {
        private ILoadingStrategy<Tinput, Tdata> Loader { get; set; }

        private IFormatingStrategy<Tdata, Tformat> Formatter { get; set; }

        private IPrintingStrategy<Tformat> Printer { get; set; }

        public PageProcess(ILoadingStrategy<Tinput, Tdata> loader, IFormatingStrategy<Tdata, Tformat> formatter, IPrintingStrategy<Tformat> printer)
        {
            Loader = loader;
            Formatter = formatter;
            Printer = printer;
        }

        public void StartProcess(Tinput values)
        {
            Tdata data = Loader.Load(values);

            Tformat result = Formatter.Format(data);

            Printer.Print(result);
        }
    }
}
