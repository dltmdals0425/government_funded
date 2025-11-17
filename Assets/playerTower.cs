using UnityEngine;

public class playerTower : MonoBehaviour
{
    [SerializeField] private GameObject projecttile;
    [SerializeField] private Transform fireTrans;
    private objectpool projectilePool;
    private void Awake()
    {
        GameObject obj = GameObject.Find("projectile");
        if (!obj.TryGetComponent<objectpool>(out projectilePool))
        { Debug.Log("playerTower.cs - Pool 참조 실패"); }
    }
 
        
  

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f, 0f, -Input.GetAxis("Horizontal"));
        if (Input.GetKeyDown(KeyCode.Space))
        { 
            GameObject obj = projectilePool.Pop();
            obj.transform.position = fireTrans.position;
            obj.transform.rotation = transform.rotation;
            Vector3 dir = fireTrans.position -transform.position;
            obj.GetComponent<projectile>().setmovedir(dir.normalized);
        }
    }
}
