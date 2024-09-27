using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grappin : MonoBehaviour
{
    public int compteur=0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Destroy(this.gameObject.GetComponent<FixedJoint>());
        }
    }

    void OnCollisionEnter(Collision Collision)
    {
        if (Collision.gameObject.GetComponent<ArticulationBody>() != null)
        {
            FixedJoint joint = this.gameObject.AddComponent<FixedJoint>();
            joint.connectedArticulationBody = Collision.articulationBody;
            compteur++;
            Debug.Log($"Nombre de cube(s) en stock : {compteur}");
        }
    }
}
