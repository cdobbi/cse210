using System;
using System.Collections.Generic;
public class PromptGenerator
{
    private List<string> _prompts;
    public PromptGenerator()
    {
        _prompts = new List<string>
        {
            "What are you grateful for today?",
            "What are you feeling today, and why?",
            "What did you learn today?",
            "What are you looking forward to tomorrow?",
            "Who in your life are you grateful for and why?",
            "What in your life are you grateful for and why?",
            "What made you smile today?",
            "What are your goals for tomorrow?"
        };
    }
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}