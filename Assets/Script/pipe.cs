using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipe : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed=100;
    public play p;
    
    //bool gp = true;

    // Start is called before the first frame update
    void Start()
    {

        rb.AddForce(Vector2.left*speed, ForceMode2D.Force);

    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log(col.name);
        if (col.name == "Square" )
        {


            p = FindObjectOfType<play>();
            p.NewPol();
            Destroy(this.gameObject);
        }
        
    }

    
}
