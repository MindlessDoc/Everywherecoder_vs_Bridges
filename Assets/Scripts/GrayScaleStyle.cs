using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrayScaleStyle : MonoBehaviour
{
    [SerializeField] private Material _material;
    [SerializeField] private Shader _shader;

    [SerializeField] private GameObject _rain;
    
    // Start is called before the first frame update
    void Start()
    {
        _material = new Material(_shader);
        Instantiate(_rain, new Vector2(0, 0), Quaternion.identity);
    }

    private void OnRenderImage(RenderTexture source, RenderTexture destination)
    {
        Graphics.Blit(source, destination, _material);
    }
}
