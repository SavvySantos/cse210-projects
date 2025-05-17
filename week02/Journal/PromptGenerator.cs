public class PromptGenerator
{
   public List<string>_prompts = new List<string>();
   public Random random = new Random();
   public string _prompt;
 public string GetRandomPrompt()
 {
   List<string>_prompts = new List<string>()
        {
         "What are you most grateful for today? ",
         "What three things made you happy today? ",
         "What are your biggest goals and what steps can you take to achieve them? ",
         "What are three things you learned today? ",
         "What was the best piece of advice you received today? ",
         "What exciting plans do you have coming up? ",
         "Who made you smile today and why? ",
         "What are five things you love about yourself today? ",
         "Who inspired you today and why? ",
         "Write down something funny that happened today. "
        };
        Random random = new Random();
        int index = random.Next(_prompts.Count);
      return _prompts[index];
 }
}