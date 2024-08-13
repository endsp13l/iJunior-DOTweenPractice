using DG.Tweening;
using UnityEngine;

public class ObjectRotator : Looper
{
    [SerializeField] private Vector3 _rotationValue = new Vector3(0, 180, 0);
    
    private void Start() => transform.DORotate(_rotationValue, _duration).SetLoops(_loopCount, LoopType.Incremental)
        .SetEase(Ease.Linear);
}