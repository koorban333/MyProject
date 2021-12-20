using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stateMachine : MonoBehaviour
{
    [SerializeField] private GameObject _firstScreen;
    [SerializeField] private GameObject[] gameObjects;

    private GameObject _currentScreen;

    private void Start()
    {
        _firstScreen.SetActive(true);
        _currentScreen = _firstScreen;
    }

    public void ChangeState(GameObject state)
    {
        if (_currentScreen != null)
        {
            _currentScreen.SetActive(false);
            state.SetActive(true);

            _currentScreen = state;
        }

    }

}
