using System;
using System.Collections.Generic;
public class PromptGenerator
{
    public List<string> _prompts;
    public PromptGenerator()
    {
        _prompts = new List<string>
        {
            "What's on your mind?",
            "How are you feeling and why?",
            "Did you learn anything today worthy of noting?",
            "What are you looking forward to?",
            "How are your children and/or grandchildren doing?",
            "Write 10 things you are grateful for?",
            "Have you done any good today?",
            "Were you able to finish anything on your to-do list?",
            "Brain storm here today!"
        };
    }
    public string GetRandomPrompt()
    {
        return "";
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}
