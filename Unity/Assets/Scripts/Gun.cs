using UnityEngine;
using System.Collections;

public class Gun : MonoBehaviour
{
    public Transform bullet;
    public float spawnDistance = 0.5f;
    public float timeBetweenShooting = 0.5f;
    public float timeBetweenShots = 0.1f;
    public int numberOfShots = 1;

    private float lastShotFiredTime;
    
    // Use this for initialization
    void Start()
    {
        lastShotFiredTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if ((Time.time - lastShotFiredTime) > timeBetweenShooting && Input.GetMouseButton(0))
        {
            lastShotFiredTime = Time.time;
            StartCoroutine(fireShot(numberOfShots));
        }
    }

    IEnumerator fireShot(int shotsToFire)
    {
        int shotsFired = 0;
        while (shotsFired != shotsToFire)
        {
            Instantiate(bullet, transform.position + spawnDistance * transform.forward, this.transform.rotation);
            yield return new WaitForSeconds(timeBetweenShots);
            shotsFired++;
        }
    }
}
