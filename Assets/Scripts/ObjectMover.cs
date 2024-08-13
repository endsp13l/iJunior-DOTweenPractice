using DG.Tweening;
using UnityEngine;

public class ObjectMover : MonoBehaviour
{
    [SerializeField] private float _duration = 2f;
    [SerializeField] private float _offset = 2f;
    [SerializeField] private int _loopCount = -1;

    private void Start() => transform.DOLocalMoveY(_offset, _duration).SetLoops(_loopCount, LoopType.Yoyo);
}