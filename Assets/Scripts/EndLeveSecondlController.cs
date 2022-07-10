using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Content;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndLeveSecondlController : MonoBehaviour
{
    [SerializeField] private GameObject _umbrella;
    
    [SerializeField] private GameObject _endLevelMessagePrefab;
    [SerializeField] private GameObject _failEndLevelMessagePrefab;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (_umbrella.activeSelf)
        {
            Instantiate(_endLevelMessagePrefab, new Vector2(0, 0), Quaternion.identity);
        }
        else
        {
            if (Random.Range(1, 3) == 1)
            {
                Instantiate(_failEndLevelMessagePrefab, new Vector2(0, 0), Quaternion.identity);
                _failEndLevelMessagePrefab.GetComponentInChildren<Button>().onClick.AddListener(OnClickFail);
            }
            else
            {
                Instantiate(_endLevelMessagePrefab, new Vector2(0, 0), Quaternion.identity);
                _endLevelMessagePrefab.GetComponentInChildren<Button>().onClick.AddListener(OnClickSucc);
            }
        }
    }

    public void OnClickFail()
    {
        Debug.Log("LoadScene 1");
        SceneManager.LoadScene(1);
    }
    
    public void OnClickSucc()
    {
        SceneManager.LoadScene(0);
    }
}
