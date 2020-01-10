using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootScript : MonoBehaviour
{
    [SerializeField]
    private GameObject PrefabBullet;

    [SerializeField]
    private Transform StartPositionBullet;

    [SerializeField]
    private float BulletSpeed;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && transform.parent.name != null)
        {
            GameObject bullet = Instantiate(PrefabBullet);
            bullet.transform.position = StartPositionBullet.position;
            if(bullet.GetComponent<Rigidbody>())
                bullet.GetComponent<Rigidbody>().AddForce(-transform.forward * BulletSpeed);
        }
        
    }


}
