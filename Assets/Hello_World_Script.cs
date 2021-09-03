using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hello_World_Script : MonoBehaviour
{

    public Text newText;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            newText.text = "Hello, my name is William Burke!";
        }

        if (Input.GetKeyDown("escape"))
        {
            Application.Quit();
        }
    }
}
