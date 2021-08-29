using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    private int i;
    public GameObject blue;
    public GameObject red;

    private int number;

    public Renderer rend;
    // Start is called before the first frame update
    void Start()
    {
        i = 3;
        
        blue = GameObject.FindGameObjectWithTag("Blue");
        red = GameObject.FindGameObjectWithTag("Red");
        number = Random.Range(200, 251);
        
        rend = blue.GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        ++i;
        Debug.Log(this.gameObject.name + ":" + i);

        if (i == 100)
        {
            red.SetActive(false);
        }

        if (i == number)
        {
            rend.enabled = false;
        }
        
    }
}
