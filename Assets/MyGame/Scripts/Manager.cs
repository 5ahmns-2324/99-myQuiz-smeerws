using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    //zum Testen
    string frage1Text = "Frage1";
    string frage2Text = "Frage2";
    string frage3Text = "Frage3";

    //Deklaration des Array vom Datentyp Frage
    private Frage[] meineFragen;

    // Start is called before the first frame update
    void Start()
    {
        //Testen
        //Frage  1 und Antworten Setup
        Frage frage1 = new Frage();
        frage1.SetFrageText(frage1Text);

        Antwort a1 = new Antwort();
        a1.SetAntwortText("f1a1");
        Antwort a2 = new Antwort();
        a2.SetAntwortText("f1a2");
        Antwort a3 = new Antwort();
        a3.SetAntwortText("f1a3");

        Antwort[] antwortenF1 = new Antwort[3] { a1, a2, a3 };
        frage1.SetAntworten(antwortenF1);
        frage1.PrintAllAntworten();

        //Frage  2 und Antworten Setup
        Frage frage2 = new Frage();
        frage2.SetFrageText(frage2Text);

        Antwort[] antwortenF2 = new Antwort[3];
        //Antwortobjeke generieren und in Array speichern.
        for(int i = 0; i < antwortenF2.Length; i++)
        {
            antwortenF2[i] = new Antwort();
        }

        antwortenF2[0].SetAntwortText("f2a1");
        antwortenF2[1].SetAntwortText("f2a2");
        antwortenF2[2].SetAntwortText("f2a3");
        frage2.SetAntworten(antwortenF2);
        frage2.PrintAllAntworten();
        frage2.RandomizeAntworten();


        Frage frage3 = new Frage();
        frage3.SetFrageText(frage3Text);

        meineFragen = new Frage[3]{frage1,frage2,frage3};

        //Debug.Log("++++++++++++++++++++++++++++++++");
        ////100x auführen
        //for(int i = 0; i < 100; i++)
        //{
        //    Debug.Log(meineFragen[Random.Range(0, 3)].GetFrageText());
        //}

        //////Durchlaufen eines bestehenden Array
        //foreach (Frage mf in meineFragen)
        //{
        //    mf.GetFrageText();
        //}

        //Debug.Log(meineFragen[Random.Range(0, 2)].GetFrageText());
        //Debug.Log(meineFragen[Random.Range(0, 2)].GetFrageText());
        //Debug.Log(meineFragen[Random.Range(0, 2)].GetFrageText());

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
