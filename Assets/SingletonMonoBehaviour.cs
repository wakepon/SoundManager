using UnityEngine;

public abstract class SingletonMonoBehaviour<T> : MonoBehaviour where T : SingletonMonoBehaviour<T>
{
	private static volatile T instance;
	public static T Instance {
		get {
            if ( instance == null ) {
                instance = ( T )FindObjectOfType( typeof( T ) );
                if ( instance == null ) {
                    Debug.LogError ( typeof( T ) + " does not exist" );
                }
            }
			return instance;
		}
	}

    //@memo
    //継承先でAwakeを定義しちゃ駄目
    //代わりにdoAwakeを作る。
	private void Awake()
	{
		if( this != Instance )
		{
			Destroy( this.gameObject );
			Debug.Log( typeof( T ) + " has already attached to \"" + Instance.gameObject.name + "\"" );
			return;
		}

		doAwake();
	}

	protected abstract void doAwake();
}

