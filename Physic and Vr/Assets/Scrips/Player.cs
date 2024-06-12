using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
[RequireComponent (typeof(MeshRenderer))]

public class Player : MonoBehaviour
{
    [SerializeField] private float _force = 10f;
    private Rigidbody _rb;
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F))
        {
            
            Vector3 force = transform.forward * _force;
            _rb.AddForce(force, ForceMode.VelocityChange);
        }    
    }
    private void OnCollisionEnter(Collision other)
    {
        Debug.Log("Player collider with" + other.gameObject.name);
        Debug.Log("Player collider with force " + other.impulse);
        Debug.Log("Palyer collider with relative velocity" + other.relativeVelocity);
    }
}
