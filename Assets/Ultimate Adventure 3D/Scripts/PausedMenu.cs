using UnityEngine;
using UnityEngine.Events;

public class PausedMenu : MonoBehaviour
{
    [SerializeField] private UnityEvent pausedMenu;
    [SerializeField] private UnityEvent resume;

    private bool isPaused;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            switch (isPaused)
            {
                case true:
                    resume.Invoke();
                    isPaused = false;
                    Cursor.visible = false;
                    Cursor.lockState = CursorLockMode.Locked;
                    break;

                case false:
                    pausedMenu.Invoke();
                    isPaused = true;
                    Cursor.visible = true;
                    Cursor.lockState = CursorLockMode.None;
                    break;
            }
        }
    }

    public void resumeGame()
    {
        resume.Invoke();
        isPaused = false;
        Cursor.visible = false;
    }
}
