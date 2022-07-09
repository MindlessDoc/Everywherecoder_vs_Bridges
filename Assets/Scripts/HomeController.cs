using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomeController : MonoBehaviour
{
    [SerializeField] private MouseEvent _mouseEvent;
    [SerializeField] private GameObject _endMouseEventMessage;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (_mouseEvent != null && _mouseEvent.getActiveEvent())
        {
            Instantiate(_endMouseEventMessage, new Vector2(0, 0), Quaternion.identity);
            _mouseEvent.DestroyMouseEvent();;
        }
    }
}
