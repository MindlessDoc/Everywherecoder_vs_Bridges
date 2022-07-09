using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseController : MonoBehaviour
{
    [SerializeField] private GameObject[] _pauseObjects;

    private bool[] _states;

    public void Pause()
    {
        for (int i = 0; i < _pauseObjects.Length; i++)
        {
            _states[i] = _pauseObjects[i].activeSelf;
            _pauseObjects[i].SetActive(false);
        }
    }
    
    public void Continue()
    {
        for (int i = 0; i < _pauseObjects.Length; i++)
        {
            _pauseObjects[i].SetActive(_states[i]);
        }
    }
}
