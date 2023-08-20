using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class play : MonoBehaviour

{
    Vector3 dir;
    //pipe p;
    public float f = 5f;
    public float gravity = -9.8f;
    public GameObject pu;
    public GameObject pd;
    //List<GameObject> l;



    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            dir = Vector3.up * f;
            //when provoked, the overall direction element(which only had gravity) gets a small boost upwards.

        }
        else if(Input.touchCount > 0 && Input.GetTouch(0).phase== TouchPhase.Began )
            dir = Vector3.up * f;

        dir.y += gravity * Time.deltaTime;
        //this maintains a constant gravity on bird independent of frame-rate
        transform.position += dir * Time.deltaTime;
        //actual change in position, two time timeDeltaTime as gravity has second squared.


    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Finish")
        {

            
            //SceneManager.LoadScene(2);

            
            
        }
    }

     public void NewPol()
    {
        
        int a=Random.Range(1, 3);
        if (a == 1)
        {
            Instantiate(pu);
        }
        else
        {
            Instantiate(pd);
        }
        
    }
}
