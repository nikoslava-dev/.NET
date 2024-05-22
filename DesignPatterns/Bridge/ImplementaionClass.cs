namespace DesignPatterns.Bridge
{
    public class ImplementaionClass
    {
        public void RunProcess()
        {
            // sending email via webservice
            Sender sender = new EmailSender(new WebService());
            sender.Send();

            // sending email via api
            sender.SetBridge(new APIService());
            sender.Send();


            // sending sms via webservice
            sender = new SMSSender(new WebService());
            sender.Send();

            // sending sms via api
            sender.SetBridge(new APIService());
            sender.Send();
        }
    }
}
