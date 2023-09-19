using System.Collections;
using UnityEngine;


public class SlimeFireTrail : Enemy
{
    public GameObject fireToSpawn;
    public float spawnCooldownSec;

    private Animator animator;
    private string isRunning = "isRunning";

    private bool canSpawnFire = false;
    // Start is called before the first frame update
    private new void Start()
    {
        base.Start();
        canSpawnFire = true;
        animator = GetComponentInChildren<Animator>();
        animator.SetBool(isRunning, true);
        StartCoroutine(spawnFireTrail());
    }
    private new void Update()
    {
        base.Update();
        DisableMovement();
    }
    private void DisableMovement()
    {

    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        // if (other.gameObject.layer == LayerMask.NameToLayer("LimitBound"))
        // {
        //     canSpawnFire = false;
        // }
        if (other.gameObject.CompareTag("TreeOfLife"))
        {
            animator.SetBool(isRunning, false);
            canSpawnFire = false;
        }
    }
    private void OnCollisionExit2D(Collision2D other)
    {
        // if (other.gameObject.layer == LayerMask.NameToLayer("LimitBound"))
        // {
        //     canSpawnFire = true;
        // }
    }
    IEnumerator spawnFireTrail()
    {

        while (true)
        {
            if (canSpawnFire)
            {
                GameObject spawnedFire = Instantiate(fireToSpawn, transform.position, Quaternion.identity);
                spawnedFire.SetActive(true);
            }
            yield return new WaitForSeconds(spawnCooldownSec);
        }
    }
}

