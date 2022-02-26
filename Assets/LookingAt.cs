using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookingAt : MonoBehaviour
{
    public LayerMask mask; 

    public GameObject interactIcon;

    private void Start()
    {
        interactIcon.SetActive(false);
    }

    private void Update()
    {
        if(Physics.Raycast(transform.position, transform.forward, out var hit, 5, mask)) //4th Mathf.Infinity (default)
        {
            var obj = hit.collider.gameObject;
    
            Debug.Log($"looking at {obj.name}", this);
            interactIcon.SetActive(true);
        }
        else
        {
            interactIcon.SetActive(false);
        }
        Debug.Log($"Transform position: {transform.position}; Transform forward: {transform.forward}");
    }
}
