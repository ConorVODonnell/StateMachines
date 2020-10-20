using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewTestScript : MonoBehaviour
{
    public enum EName
    {
        Jen,
        Marc,
        Jose,
        Jessica
    }

    public EName ename = EName.Marc;

    public string name;

    private void Start()
    {
        switch(name)
        {
            case "Jen": Debug.Log("My name is James."); break;
            case "Marc": Debug.Log("My name is Marc."); break;
            case "Jose": Debug.Log("My name is Jose."); break;
            default: Debug.Log("I don't recognize you."); break;
        }
    }

    
}
