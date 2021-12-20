using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    private Animator anim;

    private bool _canOpenDoor;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && _canOpenDoor)
        {
            Debug.Log("E");
            anim.SetTrigger("OpenDoor");
        }

    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Door"))
        {
            _canOpenDoor = true;
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Door"))
        {
            _canOpenDoor = false;
        }
    }
}
