using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowerMove : MonoBehaviour
{
    [SerializeField] private GameObject Player;
    [SerializeField] private float speed = 8f;
    public GameObject target;

    
    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        target = GameObject.Find("Player");

        Vector3 lookDirection = target.transform.position;
        lookDirection.y = transform.position.y;
        transform.LookAt(lookDirection);

        float distance = Vector3.Distance(target.transform.position, transform.position);
        if (distance < 10 && distance > 2)
        {
            transform.position = Vector3.MoveTowards(transform.position, Player.transform.position, speed * Time.deltaTime);
            return;
        }
    }
}
