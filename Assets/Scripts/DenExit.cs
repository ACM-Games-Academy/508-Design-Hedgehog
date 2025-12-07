using UnityEngine;

public class DenExit : MonoBehaviour
{
    
    
private void OnCollisionEnter(UnityEngine.Collision collision)
{
    if (collision.gameObject.CompareTag("Player"))
    {
        Debug.Log("loading Dusk scene.");
        GameManager.Instance.StartCoroutine(GameManager.Instance.FadeToBlackThenLoadThenFade(2));
    }   
}

}