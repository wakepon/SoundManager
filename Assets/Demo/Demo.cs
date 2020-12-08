using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Demo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //OPTIONAL:
        //Replace reading method
        //Set "readOnAwake = false" in the inspector of SoundManger
        /*
        SoundManager.Instance.ReadFunction = () =>
        {
            //your read process here
            //...
            Debug.Log("Read process ends.");
        };
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
}