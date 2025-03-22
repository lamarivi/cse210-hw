using System;

class Scripture
{
   private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public void HideRandomWords(int numToHide)
    {
        Random rand = new Random();
        var wordsToHide = _words.Where(w => !w.IsHidden).ToList();
        foreach (var word in wordsToHide.OrderBy(_ => rand.Next()).Take(numToHide))
        {
            word.Hide();
        }
    }

    public string GetDisplayText()
    {
        string referenceText = _reference.GetDisplayText();
        string wordsText = string.Join(" ", _words.Select(w => w.GetDisplayText()));
        return $"{referenceText}\n{wordsText}";
    }
}
