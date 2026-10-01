using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MoveShip : MonoBehaviour
{
    public KeyCode left;
    public KeyCode right;
    public KeyCode up;
    public float moveSpeed = 5f;
    public float rotationSpeed = 50f;

    public Rigidbody2D myRigid;
    void Start()
    {
        //get Rigidbody2D component attatched to this GameObject
        myRigid = this.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        //rotate left
        if (Input.GetKey(left))
        {
            this.transform.Rotate(new Vector3(0f, 0f, 50f) * Time.deltaTime);
        }
        //rotate right
        if (Input.GetKey(right))
        {
            this.transform.Rotate(new Vector3(0f, 0f, -50f) * Time.deltaTime);
        }
    }

    void FixedUpdate()
    {
        if (Input.GetKey(up))
        {
            myRigid.AddForce(this.transform.up * moveSpeed);
        }
    }
}
