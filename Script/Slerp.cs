using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlerpSIuir : MonoBehaviour
{
    public Transform goal;
    public float speed;
    public float accuracy;
    public float radius;
    public float factorslerp;

    // Start is called before the first frame update
    void Start()
    {
        transform.LookAt(goal);

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 goalPositionAtSelfHeight = new Vector3(goal.position.x, transform.position.y, goal.position.z);
        if (Vector3.Distance(transform.position, goalPositionAtSelfHeight) > radius)
        {
            Quaternion DesiredRotation = Quaternion.LookRotation(goalPositionAtSelfHeight - transform.position, Vector3.up);
            transform.rotation = Quaternion.Slerp(transform.rotation, DesiredRotation, factorslerp);
            transform.Translate(speed * Time.deltaTime * Vector3.forward);
        }
    }
}
