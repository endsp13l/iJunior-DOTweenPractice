using DG.Tweening;
using UnityEngine;

public class ObjectResizer : Looper
{
    [SerializeField] private float _scale = 2f;
    
    private void Start() => transform.DOScale(_scale, _duration).SetLoops(_loopCount, LoopType.Yoyo);
}
