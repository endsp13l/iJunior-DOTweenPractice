using DG.Tweening;
using UnityEngine;

public class ObjectMover : Looper
{
    [SerializeField] private float _offset = 2f;
    
    private void Start() => transform.DOLocalMoveY(_offset, _duration).SetLoops(_loopCount, LoopType.Yoyo);
}