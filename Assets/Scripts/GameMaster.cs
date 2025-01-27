using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMaster : MonoBehaviour
{
    public void PlayGame(){
        SceneManager.LoadScene("SampleScene");
    }
}
