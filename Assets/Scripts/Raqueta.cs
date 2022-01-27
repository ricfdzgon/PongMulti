using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raqueta : MonoBehaviour
{
    [SerializeField] private float velocidad = 30.0f;
    public string eje;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Capto el valor del eje vertical de la raqueta
        float v = Input.GetAxisRaw(eje);
        //Modifico la velocidad de la raqueta
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, v * velocidad);
    }
}
