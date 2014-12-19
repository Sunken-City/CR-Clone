using UnityEngine;
using System.Collections;

public class StandardBullet : MonoBehaviour
{

    public float speed = 0.001f;
    //This angle should be in degrees, not radians.
    public float angle = 0f;
    public float damage = 10f;
    public float lifeSpan = 5f;

    private Rigidbody bullet;
    private float spawnTime;

    // Use this for initialization
    void Start()
    {
        spawnTime = Time.time;
        bullet = this.GetComponent<Rigidbody>();
        bullet.velocity = (bullet.transform.forward * speed);
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time - spawnTime > lifeSpan)
        {
            Destroy(this.gameObject);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        Destroy(this.gameObject);
    }
}
