using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PullingJump : MonoBehaviour
{

    private bool isCanJump;

    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb=gameObject.GetComponent<Rigidbody>();
    }
    private Vector3 clickPosition;
    [SerializeField]
    private float jumpPower = 10;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            clickPosition = Input.mousePosition;
        }
        if (isCanJump&&Input.GetMouseButtonUp(0))
        {
            Vector3 dist = clickPosition - Input.mousePosition;

            if (dist.sqrMagnitude==0) { return; }

            rb.velocity = dist.normalized*jumpPower;
        }
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        //Debug.Log("è’ìÀÇµÇΩ");
    }

    private void OnCollisionStay(Collision collision)
    {
        //Debug.Log("è’ìÀÇµÇΩ");
        isCanJump = true;
    }

    private void OnCollisionExit(Collision collision)
    {
        //Debug.Log("è’ìÀÇµÇΩ");
        isCanJump = false;
    }
}
