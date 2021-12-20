using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEffects : MonoBehaviour
{
    [SerializeField] private GameObject Player;

    private void Update()
    {
        transform.position = Player.transform.position;
    }
}
