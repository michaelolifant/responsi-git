using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bow : MonoBehaviour
{
    [SerializeField] private GameObject arrow;
    private Vector3 myPos;
    private Quaternion myRot;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            transform.GetPositionAndRotation(out myPos, out myRot);
            GameObject shot = Instantiate(arrow, myPos, myRot);
            Vector3 force = new Vector3(0, 0, 30);
            shot.GetComponent<Rigidbody>().AddRelativeForce(force, ForceMode.Impulse);
        }
    }

}
