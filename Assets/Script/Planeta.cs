using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planeta : MonoBehaviour
{
    public float velocidad = 20.0f;
    public int flag = -1;
    public GameObject text;
    public TextMesh tm;

    // Start is called before the first frame update
    void Start()
    {
        text = GameObject.FindGameObjectWithTag("Texto");
        tm = text.GetComponent<TextMesh>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            tm.text = "Izquierda";
            tm.color = Color.blue;
            flag = 1;
        }
        if (flag == 1)
        {
            transform.Rotate(0, velocidad * Time.deltaTime, 0);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            tm.text = "Derecha";
            tm.color = Color.green;
            flag = 0;
        }
        if (flag == 0)
        {
            transform.Rotate(0, velocidad * Time.deltaTime * -1, 0);
        }

    }
}
