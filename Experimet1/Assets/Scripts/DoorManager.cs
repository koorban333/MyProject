using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorManager : MonoBehaviour
{
    public GameObject Canvas;
    public GameObject Door;

    private Animator _anim;

    private bool _canOpenDoor;
    private bool _doorIsOpened;

    private void Start()
    {
        _anim = Door.GetComponent<Animator>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && _canOpenDoor && _doorIsOpened)
        {
            _anim.SetTrigger("Close");

            _doorIsOpened = false;
        }

        else if (Input.GetKeyDown(KeyCode.E) && _canOpenDoor && !_doorIsOpened)
        {
            _anim.SetTrigger("Open");

            _doorIsOpened = true;
        }

    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Canvas.SetActive(true);

            _canOpenDoor = true;
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Canvas.SetActive(false);

            _canOpenDoor = false;
        }
    }
}
