using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Falling_Platform : MonoBehaviour
{

    public float fallingTime;

    private TargetJoint2D joint;
    private BoxCollider2D coll;
    // Start is called before the first frame update
    void Start()
    {
        joint = GetComponent<TargetJoint2D>();
        coll = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Invoke("Falling",fallingTime);
            
        }
    }

    void Falling()
    {
        joint.enabled = false;
        coll.isTrigger = true;
        Destroy(gameObject, 1f);
    }
}
