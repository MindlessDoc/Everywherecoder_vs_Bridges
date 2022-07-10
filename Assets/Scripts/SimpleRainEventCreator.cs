using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleRainEventCreator : MonoBehaviour
{
    [SerializeField] private GameObject _rain;
    [SerializeField] private GameObject _rainEventMessagePrefab;

    private GameObject _rainEventMessageInstance;
        
    private bool _active = false;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (!_active)
        {
            Time.timeScale = 0;
            _active = true;
            _rainEventMessageInstance = Instantiate(_rainEventMessagePrefab, new Vector2(0, 0), Quaternion.identity);
            Instantiate(_rain, new Vector2(0, 0), Quaternion.identity);
        }
    }
    
    void OnTriggerExit2D(Collider2D other) {
        Time.timeScale = 1;
        Destroy(_rainEventMessageInstance);
    }

    public bool getActive()
    {
        return _active;
    }
}
