using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portkitomb : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float turnSpeed = 50f;
    public bool enter = false;

    void Update()
    {
        if (enter && transform.rotation.x < 0.65)
        {
            transform.Rotate(Vector3.right, turnSpeed * Time.deltaTime);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            enter = true;
        }
    }
}
