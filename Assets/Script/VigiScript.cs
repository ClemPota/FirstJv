using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class VigiScript : MonoBehaviour
{

    [SerializeField]
    private GameObject PrefabBullet;

    [SerializeField]
    private Transform StartPositionBullet1;

    [SerializeField]
    private Transform StartPositionBullet2;

    [SerializeField]
    private float BulletSpeed;

    [SerializeField]
    private Transform Target;

    private float t = 0;

    // Start is called before the first frame update
    void Start()
    {
        GotoTarget();
    }

    // Update is called once per frame
    void Update()
    {
        GotoTarget();
    }

    private void GotoTarget()
    {
      
            t += Time.deltaTime;
            GetComponent<NavMeshAgent>().SetDestination(Target.position);

            float Speed = Vector3.Magnitude(GetComponent<NavMeshAgent>().velocity);
            //GetComponentInChildren<Animator>().SetFloat("Speed", Speed); 

            if (gameObject.name == "VigiShooter" && t > 0.5)
            {
                GameObject bullet1 = Instantiate(PrefabBullet);
                GameObject bullet2 = Instantiate(PrefabBullet);
                bullet1.transform.position = StartPositionBullet1.position;
                bullet2.transform.position = StartPositionBullet2.position;
                if (bullet1.GetComponent<Rigidbody>())
                    bullet1.GetComponent<Rigidbody>().AddForce(transform.forward * BulletSpeed);
                if (bullet2.GetComponent<Rigidbody>())
                    bullet2.GetComponent<Rigidbody>().AddForce(transform.forward * BulletSpeed);

                t = 0;
            }

            if (GetComponent<NavMeshAgent>().remainingDistance < 4)
            {
                Debug.Log("Attack");
                //GetComponentInChildren<Animator>().SetTrigger("Attack");
            }
        
        
    }
}
