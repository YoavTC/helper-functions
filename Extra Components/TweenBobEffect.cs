public class TweenSBobEffect : MonoBehaviour
{
    [SerializeField] private Vector2 bobDirection;
    [SerializeField] private float duration;
    [SerializeField] private bool loop;
    [SerializeField] private LoopType loopType;
    [SerializeField] private bool ignoreTimeScale;

    public void DoEffect()
    {
        if (transform != null)
        {
            transform.DOKill(true);
            transform.DOMove(transform.position + bobDirection, duration)
            
                .SetLoops(loop ? -1 : 0, loopType)
                .SetUpdate(ignoreTimeScale);
        }
    }
}