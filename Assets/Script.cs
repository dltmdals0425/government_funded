using UnityEngine;

public class Script : MonoBehaviour
{
    [SerializeField] private float rotateSpeed;
    private Vector3 horinzontalRoatte;
    private Transform fireTrans;

    private void Awake()
    {
        fireTrans = transform.GetChild(1);
    }
    private void Update()
    {
        horinzontalRoatte = new Vector3(0f, 0f, -Input.GetAxis("Horizontal"));//-를 붙여준이유는 오른쪽으로 회전시켜주겠다 
        transform.Rotate(horinzontalRoatte * (rotateSpeed * Time.deltaTime));
        if (Input.GetKeyDown(KeyCode.Space))
        {
            RaycastHit2D hit = Physics2D.Raycast(fireTrans.position,fireTrans.TransformDirection(Vector2.up),20f);
            if (hit)
            {
                Debug.DrawRay(fireTrans.position,fireTrans.TransformDirection(Vector2.up)*20f, Color.red,2.0f);
                Debug.Log(hit.transform.name);
            
            }
        }
    }
}
