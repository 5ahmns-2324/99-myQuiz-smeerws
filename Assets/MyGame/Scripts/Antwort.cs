using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Antwort : MonoBehaviour
{
    private string antwortText;
    private bool valid;

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

    public bool IsValid()
    {
        return valid;
    }

    //Parameter wird Instanzvariable zugewiesen
    public void SetValid(bool valid)
    {
        this.valid = valid;
    }



    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
