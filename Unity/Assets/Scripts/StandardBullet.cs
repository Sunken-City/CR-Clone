using UnityEngine;
using System.Collections;

public class StandardBullet : MonoBehaviour
{

    public float speed = 1f;
    //This angle should be in degrees, not radians.
    public float angle = 0f;
    public float damage = 10f;

    private Rigidbody bullet;

    // Use this for initialization
    void Start()
    {
        bullet = this.GetComponent<Rigidbody>();
        bullet.velocity = (bullet.transform.forward * speed);
    }

    // Update is called once per frame
    void Update()
    {

    }

}
