
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class NextScene : MonoBehaviour
{
    // Start is called before the first frame update
	public void OnMouseDown(string screen)
	{
		SceneManager.LoadScene(screen);
	}
}
