using UnityEngine;
[RequireComponent (typeof(CapsuleCollider2D))]
[RequireComponent(typeof(Rigidbody2D))]
public class projectile : poollabel
{
    private float moveSpeed = 8f;
    private bool isInit =false;
    private Vector3 moveDiretion;
    private void Awake()
    {
        if (TryGetComponent<CapsuleCollider2D>(out CapsuleCollider2D col))
        {
            col.isTrigger = true;
        }
        if (TryGetComponent<Rigidbody2D>(out Rigidbody2D rig))
        {
            rig.gravityScale = 0f;
        }
    }
    private void Update()
    {
        if (isInit)
            transform.position += moveDiretion * (moveSpeed * Time.deltaTime);
    }
    public void setmovedir(Vector3 newDir)
    { 
        moveDiretion = newDir;
        isInit = true;
    
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("destroyarea"))
        { /*Destroy(gameObject)*/;
            ReturnPush();
        }
    }
}
