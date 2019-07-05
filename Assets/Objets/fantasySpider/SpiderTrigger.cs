using System.Collections;
using UnityEngine;

public class SpiderTrigger : MonoBehaviour
{
    public float speed = 1.0f;
    private Transform target, enemy;
    private bool entered = false;
    // private Animation anim;

    private void Awake() {
        enemy = GameObject.FindGameObjectsWithTag("Enemy")[0].transform;
        target = GameObject.FindGameObjectsWithTag("Player")[0].transform;
        // anim = GetComponent<Animator>();
    }

    private void Update() {
        if(entered)
        {
            float step =  speed * Time.deltaTime; // calculate distance to move
            enemy.position = Vector3.MoveTowards(this.enemy.position, this.target.position, step);  

            // if (Vector3.Distance(enemy.position, target.position) < 0.001f)
            // {
            //     GameObject.FindGameObjectsWithTag("Enemy")[0].animation = this.Animations[3];
            // }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Enter"); // Debug-Only purpose
        entered = true;
    }
}
