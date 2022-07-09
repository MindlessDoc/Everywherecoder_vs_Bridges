using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BridgeController : MonoBehaviour
{
    [SerializeField] private bool _closed;
    [SerializeField] private GameObject _closedObject;
    [SerializeField] private GameObject _openedObject;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateState()
    {
        if (_closed)
        {
            _openedObject.SetActive(false);
            _closedObject.SetActive(true);
        }
        else
        {
            _openedObject.SetActive(true);
            _closedObject.SetActive(false);
        }

        _closed = !_closed;
    }

    public bool isClosed()
    {
        return _closed;
    }
}
