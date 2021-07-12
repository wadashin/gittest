using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loop : MonoBehaviour
{
    public string b = "paipai no urami";

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("paipai ga arawareta");
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log(b + " harasade okubeki ka");
        }
    }
}
