public class Antwort
{
    private string antwortText;
    private bool valid;

    //Konstruktor
    public Antwort() { }

    //Parameter wird Instanzvariable zugewiesen
    public void SetAntwortText(string antwortText)
    {
        this.antwortText = antwortText;
    }

    public string GetAntwortText()
    {
        return antwortText;
    }

    public bool IsCorrect()
    {
        return valid;
    }

    //Parameter wird Instanzvariable zugewiesen
    public void SetAntwortIsCorrect(bool valid)
    {
        this.valid = valid;
    }
}
