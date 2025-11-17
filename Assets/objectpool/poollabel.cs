using UnityEngine;
using UnityEngine.Pool;

public class poollabel : MonoBehaviour
{
    private objectpool ownerPool;

    public void Create(objectpool parent)//부모 설정
    {
        ownerPool=parent;
        gameObject.SetActive(false);
    }
    public void ReturnPush()
    {
        ownerPool.Push(this);
    }
}
