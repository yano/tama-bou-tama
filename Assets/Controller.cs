using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using AdvancedInspector;

public class Controller : MonoBehaviour {

    bool direction = true;

    bool sphere = true;

    [SerializeField]
    GameObject sphereParent;
    [SerializeField]
    GameObject sphereChild;

    Rigidbody rbParent;
    Rigidbody rbChild;

    [SerializeField]
    MeshRenderer cylinderParent;
    [SerializeField]
    MeshRenderer cylinderChild;


    [SerializeField]
    GameObject panel;

    // Use this for initialization
    void Start () {
        rbParent = sphereParent.GetComponent<Rigidbody>();
        rbChild = sphereChild.GetComponent<Rigidbody>();

        ChangeDirection();

        sphereChild.layer = 0; //Default           
        rbChild.mass = 1.0f;
        cylinderChild.enabled = true;

        sphereParent.layer = 8; //NoCollide            
        rbParent.mass = 0.01f;
        cylinderParent.enabled = false;
    }

    // Update is called once per frame
    void Update ()
    {
        if (sphereParent.transform.position.y < -20)
        {
            rbChild.isKinematic = true;
            rbParent.isKinematic = true;

            panel.SetActive(true);
        }

        if (Input.GetMouseButtonUp(0))
        {
            //print("左ボタンが押されている");
            ChangeSphere();
        }
    }

    //[Inspect]
    void ChangeDirection()
    {
        if (direction)
        {
            Vector3 newGravity = new Vector3(3.0f, -9.8f);
            Physics.gravity = newGravity;
        }
        else
        {
            Vector3 newGravity = new Vector3(-3.0f, -9.8f);
            Physics.gravity = newGravity;
        }
        direction = !direction;
    }

    //[Inspect]
    void ChangeSphere()
    {
        if (sphere)
        {
            sphereChild.layer = 0; //Default           
            rbChild.mass = 1.0f;
            cylinderChild.enabled = true;
            //rbChild.isKinematic = false;
            //rbChild.useGravity = true;

            sphereParent.layer = 8; //NoCollide            
            rbParent.mass = 0.01f;
            cylinderParent.enabled = false;
            //rbParent.isKinematic = true;
            //rbParent.useGravity = false;
        }
        else
        {
            sphereParent.layer = 0; //Default
            rbParent.mass = 1.0f;
            cylinderParent.enabled = true;
            //rbParent.isKinematic = false;
            //rbParent.useGravity = true;

            sphereChild.layer = 8; //NoCollide
            rbChild.mass = 0.01f;
            cylinderChild.enabled = false;
            //rbChild.isKinematic = true;
            //rbChild.useGravity = false;
        }

        sphere = !sphere;
    }
}
