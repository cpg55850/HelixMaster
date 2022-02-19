using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationLevel : MonoBehaviour
{
    public float sensitivity = 0.8f;
    private Vector3 mouse_reference;
    private Vector3 mouse_offset;
    private Vector3 rotation;

    private bool isRotating;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isRotating)
        {
            mouse_offset = Input.mousePosition - mouse_reference;
            rotation.y = -(mouse_offset.x + mouse_offset.y) * sensitivity;

            float sum = mouse_offset.x + mouse_offset.y;
            Debug.Log("MouseOffsetX: " + mouse_offset.x + " MouseOffsetY: " + mouse_offset.y + ", Sum: " + sum);
            transform.Rotate(rotation);

            mouse_reference = Input.mousePosition;
        }
    }

    private void OnMouseDown()
    {
        isRotating = true;
        mouse_reference = Input.mousePosition;
    }

    private void OnMouseUp()
    {
        isRotating = false;
    }
}
