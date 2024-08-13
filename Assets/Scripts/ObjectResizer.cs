using DG.Tweening;
using UnityEngine;

public class ObjectResizer : MonoBehaviour
{
    [SerializeField] private float _duration = 2f;
    [SerializeField] private float _scale = 2f;
    [SerializeField] private int _loopCount = -1;
    
    private void Start() => transform.DOScale(_scale, _duration).SetLoops(_loopCount, LoopType.Yoyo);
}
