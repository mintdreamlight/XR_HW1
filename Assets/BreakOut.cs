using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.InputSystem;

public class BreakOut : MonoBehaviour
{
    public InputActionReference action;

    // Start is called before the first frame update
    void Start()
    {
        Vector3 targetPosition = new Vector3(0f, 0f, 20f);
        action.action.Enable();
        action.action.performed += (ctx) =>
        {
            if (transform.position == targetPosition)
            {
                transform.position = new Vector3(0f, 0f, 0f);
            } else
            {
                transform.position = targetPosition;
            }
            
        };
    }
}
