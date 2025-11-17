using UnityEngine;
using static UnityEngine.UI.Image;
using UnityEngine.UIElements;

public class bulletfire : MonoBehaviour
{
   
    [SerializeField] private GameObject bullet;
    public Transform bulletTransform;
    private Vector3 spawnPos; 
    void Awake()
    {
        
    }

    void Update()
    {//rata
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0f, 0f, 1f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0f, 0f, -1f);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            spawnPos = bulletTransform.position;
            GameObject clone = Instantiate(bullet, spawnPos, transform.rotation);
        }
    }
}
