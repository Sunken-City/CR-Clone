using UnityEngine;
using System.Collections;

public class StandardBullet : MonoBehaviour
{

    public float speed = 50f;
    //This angle should be in degrees, not radians.
    public float angle = 0f;
    public float damage = 10f;

    // Use this for initialization
    void Start()
    {
        gameObject.rigidbody.velocity = new Vector3(transform.forward.x * speed, getYVelocity(), 0.0f);
    }

    // Update is called once per frame
    void Update()
    {

    }

}
