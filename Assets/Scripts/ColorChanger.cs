using DG.Tweening;
using UnityEngine;

[RequireComponent(typeof(Renderer))]
public class ColorChanger : Looper
{
    private Renderer _renderer;
    private Color _targetColor;
    
    private void Awake() 
    {
        _renderer = GetComponent<Renderer>();
        _targetColor = Random.ColorHSV();
    }
    
    private void Start() => _renderer.material.DOColor(_targetColor, _duration).SetLoops(_loopCount, LoopType.Yoyo);
}