namespace Bai6
{
    public interface IThinking
    {
        public void thinking_behavior();
    }
    public interface Intelligent
    {
        public void intelligent_behavior();
    }
    public interface Iability : IThinking, Intelligent
    {

    }
    public class Mamal
    {
        protected string characteristics;
        public void Set(string characteristics)
        {
            this.characteristics = characteristics;
        }
        public string Get()
        {
            return this.characteristics;
        } 
    }
    public class Whale: Mamal
    {
        public Whale()
        {

        }
    }
    public class Human : Mamal, Iability
    {
        public Human()
        {

        }
        public void intelligent_behavior()
        {

        }
        public void thinking_behavior()
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}