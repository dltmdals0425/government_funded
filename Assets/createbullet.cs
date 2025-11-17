using Unity.VisualScripting;
using UnityEngine;

public class createbullet : MonoBehaviour
{
    [SerializeField] private float speed;

    // Update is called once per frame
    void Update()
    {

        transform.position += transform.up * speed * Time.deltaTime;

    }
}
