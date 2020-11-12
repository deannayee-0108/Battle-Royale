using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Attack : MonoBehaviour
{
    [SerializeField, Range(0, 10)]
    public int health = 3;
    private int startHealth;
    private Vector3 spawnPoint;
    [SerializeField]
    private TextMeshPro textMeshPro;

    // Start is called before the first frame update
    void Start()
    {
      spawnPoint = this.transform.position;
      startHealth = health;
    }

    void reSpawn(){
      if(health == 0){
        health = startHealth;
      }
    }
    public void reSpawn(GameObject dead) {
        dead.transform.GetChild(0).GetComponent<Attack>().reSpawn();
        dead.transform.position = spawnPoint;
   }

    // Update is called once per frame
    void Update()
    {
        textMeshPro.text = "Health: " + health;
    }

    void OnTriggerEnter(Collider c){
      if(c.gameObject.tag == "players"){
        c.gameObject.transform.GetChild(0).GetComponent<Attack>().health--;
            StartCoroutine("swing");
        if(c.gameObject.transform.GetChild(0).GetComponent<Attack>().health == 0){
          reSpawn(c.gameObject);
        }
      }
    }

    
}
