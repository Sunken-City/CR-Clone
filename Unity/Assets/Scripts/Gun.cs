using UnityEngine;
using System.Collections;

public class Gun : MonoBehaviour
{
    public Transform bullet;
    public float spawnDistance = 0.5f;
    public float timeBetweenShots = 0.5f;

    private float lastShotFiredTime;
    
    // Use this for initialization
    void Start()
    {
        lastShotFiredTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if ((Time.time - lastShotFiredTime) > timeBetweenShots && Input.GetMouseButton(0))
        {
            Instantiate(bullet, transform.position + spawnDistance * transform.forward, this.transform.rotation);
            lastShotFiredTime = Time.time;
        }
    }
}
