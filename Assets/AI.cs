using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI : MonoBehaviour
{
    public GameObject[] enemies;
    public float maxDistance;
    public float speed;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
      rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        GameObject closest = null;
        float closestDistance = 0f;
        for(int i = 0; i < enemies.Length; i++){
            if(Vector3.Distance(enemies[i].transform.position, transform.position) <maxDistance){
              closest = enemies[i];
              closestDistance = Vector3.Distance(enemies[i].transform.position, transform.position);
            }
        }
        if(closest != null){
          transform.LookAt(closest.transform);
          rb.velocity = transform.forward * speed;
        }
    }

    
}
