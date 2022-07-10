using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DLCController : MonoBehaviour
{
    [SerializeField] private Button _button;
    [SerializeField] private GameObject _style;

    [SerializeField] private PlayerControl _playerController;
    [SerializeField] private CoolPlayerController _coolPlayerController;

    [SerializeField] private GameObject _player;
    [SerializeField] private GameObject _coolPlayer;

    private bool _active = false;
    
    void Start()
    {
        _button.onClick.AddListener(OnClick);
    }
    
    void OnClick()
    {
        _active = !_active;
        if (_active)
        {
            _coolPlayerController.setPosition(_playerController.GetPosition());
            _player.SetActive(false);
            _coolPlayer.SetActive(true);
        }
        else
        {
            _playerController.setPosition(_coolPlayerController.GetPosition());
            _coolPlayer.SetActive(false);
            _player.SetActive(true);
        }
        _style.SetActive(_active);
    }
}
