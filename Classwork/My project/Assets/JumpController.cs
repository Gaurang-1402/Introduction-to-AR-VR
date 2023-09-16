using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpController : MonoBehaviour
{
    public Rigidbody2D rigidBody;
    // Start is called before the first frame update
    void Start()
    {

        gameObject.name = "Jatayu";
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rigidBody.velocity = new Vector2(0, 5);
        }
        // transform.Rotate(new Vector3(0, 0, 90));
    }
}
