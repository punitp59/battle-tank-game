using System.Collections;
using UnityEngine;

public class MonoSingletonGeneric<T> : MonoBehaviour where T: MonoSingletonGeneric<T> {
	public static T Instance {get {return instance;}}
	private void Awake() {
		if (Instance == null){
			Instance = (T)this;
		}
		else{
			Destroy(this);
		}
	}
}

public class PlayerTank : MonoSingletonGeneric<PlayerTank> {

}
public class EnemyTank : MonoSingletonGeneric<EnemyTank> {
	
}
