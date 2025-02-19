using System.Collections;
using UnityEngine;

public class UnRagdoll : MonoBehaviour
{
    public Transform feet;
    Animator animator;

    public void Start()
    {
        animator = GetComponent<Animator>();
        StartCoroutine(WaitAndUnragdoll());
    }

    IEnumerator WaitAndUnragdoll()
    {
        yield return new WaitForSeconds(5f);
        DoUnRagdoll();
    }

    public void DoUnRagdoll()
    {
        transform.position = feet.position;
        GetComponent<Rigidbody>().linearVelocity = Vector3.zero;
        animator.enabled = true;
    }
}
