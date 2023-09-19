using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    public Player player;
    private PlayerHealth playerHealth;

    private int dieAnimationId;
    enum State
    {
        isRunning
    }
    Animator anim;
    private void Awake()
    {
        anim = GetComponent<Animator>();
    }
    private void OnEnable()
    {
        Time.timeScale = 1f;
        dieAnimationId = Animator.StringToHash("Die");
        playerHealth = GetComponent<PlayerHealth>();
        PlayerHealth.OnDying += Die;
    }
    private void OnDisable()
    {
        //Unsubscribe
        PlayerHealth.OnDying -= Die;
    }
    private void Die()
    {
        anim.Play(dieAnimationId);
        Time.timeScale = 0;
        if (transform.childCount > 1)
        {
            Destroy(transform.GetChild(1).gameObject);
        }
        SceneManager.LoadScene(0);
    }

    private void Update()
    {
        Running();
    }

    private void Running()
    {
        bool isRunning = player.isRunning;
        anim.SetBool(State.isRunning.ToString(), isRunning);
    }
}


