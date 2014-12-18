using UnityEngine;
using System.Collections;

public class StandardBullet : MonoBehaviour
{

    public float speed = 50f;
    //This angle should be in degrees, not radians.
    public float angle = 0f;
    public float damage = 10f;

    private Rigidbody bullet;

    // Use this for initialization
    void Start()
    {
        bullet = this.GetComponent<Rigidbody>();
        bullet.velocity = new Vector3(bullet.velocity.x * speed, bullet.velocity.y, bullet.velocity.z);
    }

    // Update is called once per frame
    void Update()
    {

    }

}
