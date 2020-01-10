using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerJumpScript : MonoBehaviour
{
    [SerializeField]
    private float JumpPower;

    private void OnTriggerEnter(Collider other)
    {
     if(other.gameObject.tag == "Player")
        {
            other.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, JumpPower, 0));
        }   
    }
}
