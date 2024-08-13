using DG.Tweening;
using UnityEngine;

[RequireComponent(typeof(Renderer))]
public class ColorChanger : MonoBehaviour
{
    [SerializeField] private float _duration = 2f;
    [SerializeField] private int _loopCount = -1;
    
    private Renderer _renderer;
    private Color _targetColor;
    
    private void Awake() 
    {
        _renderer = GetComponent<Renderer>();
        _targetColor = Random.ColorHSV();
    }
    
    private void Start() => _renderer.material.DOColor(_targetColor, _duration).SetLoops(_loopCount, LoopType.Yoyo);
}