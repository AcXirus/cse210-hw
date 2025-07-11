public class PromptGenerator
{
    //-------Make a list with prompts--------//
    public List<string> _prompts = new List<string>();
    Random random = new Random();

    public PromptGenerator()
    {
        _prompts.Add("How are you feeling?");
        _prompts.Add("What's on your mind today?");
        _prompts.Add("How has your day been so far?");
        _prompts.Add("Is there something exciting happening today?");
        _prompts.Add("How is your family doing?");
        _prompts.Add("Did something nice happen with your family recently?");
        _prompts.Add("Is there something you'd like to change about your daily routine?");
        _prompts.Add("What's something you're grateful for today?");
        _prompts.Add("Did you take time to rest today?");
        _prompts.Add("What's been the best part of your week?");
        _prompts.Add("Did you finish everything you planned for today?");
        _prompts.Add("Is there something important you still need to do today?");
        _prompts.Add("What is something you must not forget tomorrow?");
        _prompts.Add("What did you do today that made you smile?");
        _prompts.Add("What could you have done differently today?");

    }

    //---------get a random Propmt-------//
    public string GetRandomPrompt()
    {
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}