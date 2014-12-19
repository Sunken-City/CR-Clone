using UnityEngine;
using System.Collections;

public class Gun : MonoBehaviour
{
    public Transform bullet;
    public float spawnDistance = 3.0f;
    
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            Instantiate(bullet, transform.position + spawnDistance * transform.forward, transform.rotation);
        }
    }
}
