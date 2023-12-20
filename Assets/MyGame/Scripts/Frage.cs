using UnityEngine;

public class Frage
{
    //Instanzvariable deklarieren
    [SerializeField] private string fragenText;
    private Antwort[] antworten;

    //Konstruktor
    public Frage()
    {
        Debug.Log("Erstelle Frage");
    }

    public void SetFrageText(string fragetxt)
    {
        fragenText = fragetxt;
    }

    public string GetFrageText()
    {
        return fragenText;
    }

    public void SetAntworten(Antwort[] antworten)
    {
        this.antworten = antworten;
    }

    public void PrintAllAntworten()
    {
        foreach(Antwort aw in antworten)
        {
            Debug.Log(aw.GetAntwortText());
        }
    }

    public void RandomizeAntworten()
    {
        int i = Random.Range(0,antworten.Length);

        int[] order = new int[3];
        
        //erstes Element im Array
        order[0] = i;

        i = Random.Range(0, antworten.Length);

        //zweites Element im Array
        while(order[0] == i)
        {
            i = Random.Range(0, antworten.Length);
        }

        order[1] = i;

        //drittes Element im Array
        i = Random.Range(0, antworten.Length);

        while(order[0] == i || order[1] == i)
        {
            i = Random.Range(0, antworten.Length);
        }
        
        order[2] = i;

        //Ausgabe 
        foreach(int index in order)
        {
            Debug.Log("order" + index);
        }
    }
}
