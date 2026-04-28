using UnityEngine;
using System.Collections;

public class SplashController : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(GoToMenu());
    }

    IEnumerator GoToMenu()
    {
        yield return new WaitForSeconds(2f);
        GameManager.Instance.GoToMenu();
    }
}