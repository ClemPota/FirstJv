using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponScript : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            for (int i = 0; i < transform.childCount; i++)
            {
               string child = other.transform.GetChild(i).gameObject.name;
                if(child == "armR" && other.transform.GetChild(i).gameObject.transform.childCount == 0)
                {
                    transform.SetParent(other.transform.GetChild(i));
                }
            }
        }
    }
}
