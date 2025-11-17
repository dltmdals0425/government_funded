using System.Collections.Generic;
using System.Reflection.Emit;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;
//대상 오브젝트를 관리하는 역할.
//게임 시작되면 미리 오브젝트 생성하고,
//오브젝트 필요할때 활성화 해서 스폰
//반환 받기
public class objectpool : MonoBehaviour
{
    [SerializeField] private poollabel poolObj;//대상이 되는 오브젝트
    [SerializeField] private int allocateCount;//1번에 생성하는 오브젝트의 숫자
    private Stack<poollabel> poolStack = new Stack<poollabel> ();
    private void Awake()
    {
        //미리 필요한 갯수만큼 오브젝트 생성.
    }
    public void allocate()
    {
        for (int i = 0; i > allocateCount; ++i)
        {
            poollabel label = Instantiate(poolObj, this.transform);
            label.Create(this);
            poolStack.Push(label);
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject Pop()
    { 
        if (poolStack.Count <1) 
            allocate();
    poollabel obj = poolStack.Pop();
        obj.gameObject.SetActive(true);
        return obj.gameObject;
    }
    public void Push(poollabel label)
    {
        label.gameObject.SetActive(false);
        poolStack.Push(label);
    }
}
