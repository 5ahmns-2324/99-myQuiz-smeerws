using UnityEngine;

public class Frage
{
    //Instanzvariable deklarieren
    private string fragenText;
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

    public Antwort[] ShuffleAntworten()
    {
        int i = Random.Range(0,antworten.Length);

        int[] order = new int[3];
        
        //erstes Element im Array
        order[0] = i;

        //zweites Element im Array
        do
        {
            i = Random.Range(0, antworten.Length);
        }
        while (order[0] == i);

        order[1] = i;

        //drittes Element im Array
        do
        {
            i = Random.Range(0, antworten.Length);
        }
        while (order[0] == i || order[1] == i);        
 
        order[2] = i;

        Antwort[] tmpAntworten = new Antwort[3];
        System.Array.Copy(antworten, tmpAntworten, 3);

        for(int j=0; j < antworten.Length; j++)
        {
            antworten[j] = tmpAntworten[order[j]];
            Debug.Log("----------"+j+" : "+ antworten[j].GetAntwortText());
        }

        //Ausgabe 
        foreach(int index in order)
        {
            Debug.Log(" neue order" + index);
        }

        return antworten;
    }
}
