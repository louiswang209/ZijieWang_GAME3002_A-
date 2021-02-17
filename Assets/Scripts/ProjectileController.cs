using UnityEngine.Assertions;
using UnityEngine;

public class ProjectileController : MonoBehaviour
{
    private ProjectileComponent m_projectile = null;
    // Start is called before the first frame update
    void Start()
    {
        m_projectile = GetComponent<ProjectileComponent>();
        Assert.IsNotNull(m_projectile, "Houston, we've got a problem! Rigidbody is not attached!");
    }

    // Update is called once per frame
    void Update()
    {
        HandleUserInput();
    }

    private void HandleUserInput()
    {
        if(Input.GetKeyUp(KeyCode.Space))
        {
            m_projectile.OnLaunchProjectile();
        }

        if(Input.GetKey(KeyCode.UpArrow))
        {
            m_projectile.OnMoveBackward(0.01f);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            m_projectile.OnMoveForward(0.01f);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            m_projectile.OnMoveLeft(0.01f);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            m_projectile.OnMoveRight(0.01f);
        }
    }
}
