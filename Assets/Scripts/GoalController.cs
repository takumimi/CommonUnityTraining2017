using System.Collections;
using UnityEngine;

public class GoalController : MonoBehaviour 
{
	//UIControllerを参照する
	public UIController UIController;

	//Trigger との接触時に呼ばれる　Callback
	private void OnTriggerEnter (Collider hit)
	{

	    //接触対象はPlayer タグかどうか
		if (hit.CompareTag ("Player"))
		{
			//Rigidbody を停止させる
			hit.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;

			//ゲームクリアを表示する
			UIController.ShowGameClearLabel();
		}
	}
}
