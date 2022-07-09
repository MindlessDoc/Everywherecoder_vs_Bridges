using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MouseEvent : MonoBehaviour
{
    [SerializeField] private GameObject _itSelfObject;
    [SerializeField] private GameObject _mouseEventMessagePrefab;

    private bool active;

    private GameObject _curMouseEventMessage;
    
    void Start()
    {
        active = false;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Time.timeScale = 0;
        active = true;
        _curMouseEventMessage = Instantiate(_mouseEventMessagePrefab, new Vector2(0, 0), Quaternion.identity);
    }

    void OnTriggerExit2D(Collider2D other) {
        Time.timeScale = 1;
        Destroy(_curMouseEventMessage);
    }

    public void DestroyMouseEvent()
    {
        Destroy(_itSelfObject);
    }

    public bool getActiveEvent()
    {
        return active;
    }
}
