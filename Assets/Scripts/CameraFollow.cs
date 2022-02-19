using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private Transform target;
    private float distance = 7.6f;
    private float height = 2.5f;
    public float damping = 1.1f;
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 wantedPosition;
        wantedPosition = target.TransformPoint(0f, height, -distance);

        transform.position = Vector3.Lerp(transform.position, wantedPosition, Time.deltaTime * damping);
    }
}
