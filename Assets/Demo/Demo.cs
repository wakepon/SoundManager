using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Demo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Replace reading method
        //Disable "readOnAwake"@SoundManger.cs
        /*
        SoundManager.Instance.ReadFunction = CustomRead;
        SoundManager.Instance.Read();
        */

        //Play BGM
        var bgm_handle = SoundManager.Instance.PlayBgm( "bgmTest" );
        
        //Set BGM volume
        SoundManager.Instance.Volume.bgm = 0.5f;
        
        //FadeOut
        bgm_handle.FadeOut(()=>print("FadeOut has finished."));
        
        //Play SE
        var se_handle = SoundManager.Instance.PlaySe( "seTest" );

        //OnComplete
        se_handle.OnComplete( () => Debug.Log( "SE has finished." ) );
        
        //Easy version
        this.PlaySe("seTest");
        this.PlaySe("seTest", 3.0f);
    }

    private void CustomRead()
    {
        //your process here...
        //--
        Debug.Log("CustomRead ends.");
    }
}
