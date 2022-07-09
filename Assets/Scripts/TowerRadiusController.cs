using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TowerRadiusController : MonoBehaviour
{
    [SerializeField] private CommonBridgeContoller _contoller;

    void OnTriggerEnter2D(Collider2D other) {
        _contoller.Activate();
    }

    void OnTriggerExit2D(Collider2D other) {
        _contoller.Deactivate();
    }
}
