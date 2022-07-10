using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndRainEventController : MonoBehaviour
{
    [SerializeField] private GameObject _umbrellaPlayer;
    [SerializeField] private GameObject _umbrellaSuperPlayer;
    
    [SerializeField] private SimpleRainEventCreator _simpleRainEventCreator;
    [SerializeField] private GameObject _selfObject;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (_simpleRainEventCreator.getActive())
        {
            _umbrellaPlayer.SetActive(true);
            _umbrellaSuperPlayer.SetActive(true);
            Destroy(_selfObject);
        }
    }
}
