using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    [SerializeField, Range(0, 10)]
    public int health = 3;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider c){
      if(c.gameObject.tag == "players"){
        c.gameObject.transform.GetChild(0).GetComponent<Attack>().health--;
        if(c.gameObject.transform.GetChild(0).GetComponent<Attack>().health == 0){
          Destroy(c.gameObject);
        }
      }
    }
}
