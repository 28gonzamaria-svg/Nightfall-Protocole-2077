using UnityEngine;

public class RagdollController : MonoBehaviour
{
    public Rigidbody[] rigidbodies;
    public Collider[] colliders;
    public Animator animator;

    void Start()
    {
        SetRagdoll(false);
    }

    public void SetRagdoll(bool isRagdoll)
    {
        foreach (Rigidbody rb in rigidbodies)
            rb.isKinematic = !isRagdoll;

        foreach (Collider col in colliders)
            col.enabled = isRagdoll;

        animator.enabled = !isRagdoll;
    }

    public void ActivateRagdoll(Vector3 force, Vector3 point)
    {
        SetRagdoll(true);

        foreach (Rigidbody rb in rigidbodies)
        {
            rb.AddExplosionForce(force.magnitude, point, 5f, 1f, ForceMode.Impulse);
        }
    }
}