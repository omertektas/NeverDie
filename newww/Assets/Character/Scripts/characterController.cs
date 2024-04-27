using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterController : MonoBehaviour
{
    [SerializeField] private float characterSpeed;
    Animator anim;
    
    void Start()
    {
        anim = GetComponent<Animator>();
        
    }

    
    void Update()
    {
        moveFunction();
    }

    void moveFunction()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        anim.SetFloat("Horizontal", horizontal);
        anim.SetFloat("Vertical", vertical);
        this.gameObject.transform.Translate(horizontal*characterSpeed*Time.deltaTime,0,vertical*characterSpeed*Time.deltaTime);
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("tree"))
        {
            Debug.Log("collision true");
            collision.gameObject.SetActive(false);
        }
    }
}
