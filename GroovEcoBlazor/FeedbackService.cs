using System.Collections.Generic;


public class FeedbackService

{
    private List<Feedback> feedbackList;
    
    public FeedbackService()
    {
        feedbackList = new List<Feedback>(); // Always initialized
    }

    public void AddFeedback(Feedback feedback)
    {
        if (feedbackList == null)
        {
            feedbackList = new List<Feedback>();
        }

        Console.WriteLine($"[DEBUG] Added: Name={feedback.Name}, Email={feedback.Email}, Comment={feedback.Comment}");
        
        feedbackList.Add(new Feedback
        {
            Name = feedback.Name,
            Email = feedback.Email,
            Comment = feedback.Comment
        });
    }

    public IEnumerable<Feedback> GetFeedback() => feedbackList;
}
