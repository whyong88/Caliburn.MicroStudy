namespace WpfApp1.Messages
{
    public class SimpleMessage
    {
        public SimpleMessage(string text)
        {
            Text = text;
        }

        public string Text { get; }
    }
}