using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalController : MonoBehaviour
{
    [SerializeField] private GameObject _winMessagePrefab;

    void OnTriggerEnter2D(Collider2D other)
    {
        Time.timeScale = 0;
        Instantiate(_winMessagePrefab, new Vector2(0, 0), Quaternion.identity);
    }
}
