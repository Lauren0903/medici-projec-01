using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowerMove3 : MonoBehaviour
{
    [SerializeField] private GameObject Follower1;
    [SerializeField] private float speed = 8f;
    public GameObject target;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        target = GameObject.Find("Follower1");

        Vector3 lookDirection = target.transform.position;
        lookDirection.y = transform.position.y;
        transform.LookAt(lookDirection);

        float distance = Vector3.Distance(target.transform.position, transform.position);
        if (distance < 10 && distance > 2)
        {
            transform.position = Vector3.MoveTowards(transform.position, Follower1.transform.position, speed * Time.deltaTime);
            return;
        }
    }
}
