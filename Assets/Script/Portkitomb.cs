using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portkitomb : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float turnSpeed = 50f;
    public bool enter = false;
    public bool enter2 = false;
    public GameObject camera = null;
    public BoxCollider doorCollider = null; 

    void Update()
    { 
        if (enter && transform.rotation.x < 0.45)
        {
            transform.Rotate(Vector3.right, turnSpeed * Time.deltaTime);
        }
        
        if (enter2){
            camera.transform.position= new Vector3(2.76f, 8.7f, 6.1f);
            camera.transform.localScale = new Vector3(0.1F, 0.1F, 0.1F);

            doorCollider.size = new Vector3(1.0F, 2.5F, 2.52F);
            doorCollider.center = new Vector3(-0.01F, 0.79F, 0.76F);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && enter2 && !enter)
        {
            enter = true;
        }

        if (other.gameObject.tag == "Player" && !enter2 && !enter)
        {
            enter2 = true;
        }
    }
}
