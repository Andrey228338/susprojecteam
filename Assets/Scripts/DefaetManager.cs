using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;

public class DefaetManager : MonoBehaviour
{
    [SerializeField] public GameObject killer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnCollisionEnter(Collision killer)
    {
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
    }
}
