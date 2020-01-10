using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{

    [SerializeField]
    private int Damage;

    [SerializeField]
    private float LifeTime;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, LifeTime);

        if(LifeTime <= 0)
        {
            Debug.Log("Balle inutile");
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
        Debug.Log(collision.gameObject);
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponentInParent<LifeScript>().UpdateLife(-Damage);
        }
        else if (collision.gameObject.tag == "Enemy")
        {
                collision.gameObject.GetComponentInParent<LifeScript>().UpdateLife(-Damage);
        }
    }
}
