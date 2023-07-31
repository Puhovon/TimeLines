using UnityEngine;

public class ScriptableObjects : MonoBehaviour
{
    
    
    public void ChangeScale() {
        transform.localScale.Scale(new Vector3(2,2,2));
        GetImpulse();
    }

    private void GetImpulse()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.AddForce(transform.forward * 10, ForceMode.Impulse);
    }

    public void DestroyObj()
    {
        Destroy(gameObject);
    }
}
